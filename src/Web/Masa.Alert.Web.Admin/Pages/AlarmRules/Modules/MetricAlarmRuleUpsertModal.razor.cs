﻿// Copyright (c) MASA Stack All rights reserved.
// Licensed under the Apache License. See LICENSE.txt in the project root for license information.

namespace Masa.Alert.Web.Admin.Pages.AlarmRules.Modules;

public partial class MetricAlarmRuleUpsertModal : AdminCompontentBase
{
    [Parameter]
    public EventCallback OnOk { get; set; }

    [Inject]
    public ITscClient TscClient { get; set; } = default!;

    private MForm? _form;
    private AlarmRuleUpsertViewModel _model = new();
    private bool _visible;
    private Guid _entityId;
    private bool _cronVisible;
    private string _tempCron = string.Empty;
    private string _nextRunTimeStr = string.Empty;
    private List<string> _items = new();
    private AlarmPreviewChartModal? _previewChart;
    private List<string> _names = new();

    protected override string? PageName { get; set; } = "AlarmRule";

    AlarmRuleService AlarmRuleService => AlertCaller.AlarmRuleService;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await LoadData();
        }
        await base.OnAfterRenderAsync(firstRender);
    }

    private async Task LoadData()
    {
        _names = (await TscClient.MetricService.GetNamesAsync(null)).ToList();
        await InvokeAsync(() =>
        {
            StateHasChanged();
        });
    }

    public async Task OpenModalAsync(AlarmRuleListViewModel? listModel = null)
    {
        _entityId = listModel?.Id ?? default;
        _model = listModel?.Adapt<AlarmRuleUpsertViewModel>() ?? new();
        _model.AlarmRuleType = AlarmRuleTypes.Metric;

        if (_entityId != default)
        {
            await GetFormDataAsync();
        }
        FillData();
        await InvokeAsync(() =>
        {
            _visible = true;
            StateHasChanged();
        });
    }

    private async Task GetFormDataAsync()
    {
        var dto = await AlarmRuleService.GetAsync(_entityId) ?? new();
        _model = dto.Adapt<AlarmRuleUpsertViewModel>();

        foreach (var item in _model.MetricMonitorItems)
        {
            if (string.IsNullOrEmpty(item.Name)) continue;
            await HandleMetricNameChange(item.Name, item);

            if (string.IsNullOrEmpty(item.Tag)) continue;
            HandleMetricTagChange(item.Tag, item);
        }
    }

    private void FillData()
    {
        if (!_model.LogMonitorItems.Any())
        {
            _model.LogMonitorItems.Add(new LogMonitorItemViewModel());
        }
        if (!_model.MetricMonitorItems.Any())
        {
            _model.MetricMonitorItems.Add(new MetricMonitorItemViewModel());
        }
        if (!_model.Items.Any())
        {
            _model.Items.Add(new AlarmRuleItemViewModel());
        }
    }

    private void HandleCancel()
    {
        _visible = false;
        ResetForm();
    }

    private void ResetForm()
    {
        _model = new();
        _form?.ResetValidation();
    }

    private void HandleVisibleChanged(bool val)
    {
        if (!val) HandleCancel();
    }

    private async Task SetCronExpression()
    {
        if (CronExpression.IsValidExpression(_tempCron))
        {
            _model.CheckFrequency.CronExpression = _tempCron;
            GetNextRunTime();
            _cronVisible = false;
        }
        else
        {
            await PopupService.ToastErrorAsync(T("CronExpressionInvalid"));
        }
    }

    private void GetNextRunTime(int showCount = 5)
    {
        if (!CronExpression.IsValidExpression(_model.CheckFrequency.CronExpression))
        {
            _nextRunTimeStr = T("CronExpressionNotHasNextRunTime");
            return;
        }

        var sb = new StringBuilder();

        var startTime = DateTimeOffset.Now;

        var cronExpression = new CronExpression(_model.CheckFrequency.CronExpression);

        var timezone = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(p => p.BaseUtcOffset == TimezoneOffset);

        if (timezone != null)
            cronExpression.TimeZone = timezone;

        for (int i = 0; i < showCount; i++)
        {
            var nextExcuteTime = cronExpression.GetNextValidTimeAfter(startTime);

            if (nextExcuteTime.HasValue)
            {
                startTime = nextExcuteTime.Value;
                sb.AppendLine(string.Format("<p>{0}</p>", startTime.ToOffset(TimezoneOffset).ToString("yyyy-MM-dd HH:mm:ss")));
            }
        }

        if (sb.Length == 0)
        {
            _nextRunTimeStr = T("CronExpressionNotHasNextRunTime");
        }
        else
        {
            _nextRunTimeStr = sb.ToString();
        }
    }

    private void OpenCronModal()
    {
        _cronVisible = true;
        _tempCron = _model.CheckFrequency.CronExpression;
    }

    private void HandleMetricMonitorItemsAdd()
    {
        _model.MetricMonitorItems.Add(new MetricMonitorItemViewModel());
    }

    private void HandleMetricMonitorItemsRemove(MetricMonitorItemViewModel item)
    {
        _model.MetricMonitorItems.Remove(item);
    }

    private async Task HandleMetricNameChange(string newVal, MetricMonitorItemViewModel item)
    {
        var query = new LableValuesRequest
        {
            Match = newVal,
            Start = DateTime.Now.AddDays(-1),
            End = DateTime.Now,
        };
        var labelValues = (await TscClient.MetricService.GetLabelValuesAsync(query));
        item.LabelValues = labelValues;
        item.TagItems = labelValues.Select(x => x.Key).ToList();
    }

    private void HandleMetricTagChange(string newVal, MetricMonitorItemViewModel item)
    {
        item.ValueItems = item.LabelValues.FirstOrDefault(x => x.Key == newVal).Value;
    }

    private async Task HandleOk()
    {
        Check.NotNull(_form, "form not found");

        if (!_form.Validate())
        {
            return;
        }

        Loading = true;

        var inputDto = _model.Adapt<AlarmRuleUpsertDto>();

        if (_entityId == default)
        {
            await AlarmRuleService.CreateAsync(inputDto);
        }
        else
        {
            await AlarmRuleService.UpdateAsync(_entityId, inputDto);
        }

        Loading = false;
        _visible = false;

        ResetForm();

        await SuccessMessageAsync(T("OperationSuccessfulMessage"));

        if (OnOk.HasDelegate)
        {
            await OnOk.InvokeAsync();
        }
    }
}
