﻿// Copyright (c) MASA Stack All rights reserved.
// Licensed under the Apache License. See LICENSE.txt in the project root for license information.

namespace Masa.Mc.Service.Services;

public class AlarmRuleService : ServiceBase
{
    public AlarmRuleService(IServiceCollection services) : base("api/alarm-rule")
    {

    }

    public async Task<PaginatedListDto<AlarmRuleDto>> GetListAsync(IEventBus eventbus, [FromQuery] AlarmRuleTypes type, [FromQuery] AlarmRuleSearchTimeTypes timeType, [FromQuery] DateTime? startTime,
       [FromQuery] DateTime? endTime, [FromQuery] string projectIdentity, [FromQuery] string appIdentity, [FromQuery] string metricId, [FromQuery] string filter = "", [FromQuery] string sorting = "", [FromQuery] int page = 1, [FromQuery] int pagesize = 10)
    {
        var inputDto = new GetAlarmRuleInputDto(filter, type, timeType, startTime, endTime, projectIdentity, appIdentity, metricId, sorting, page, pagesize);
        var query = new GetAlarmRuleListQuery(inputDto);
        await eventbus.PublishAsync(query);
        return query.Result;
    }

    public async Task<AlarmRuleDto> GetAsync(IEventBus eventBus, Guid id)
    {
        var query = new GetAlarmRuleQuery(id);
        await eventBus.PublishAsync(query);
        return query.Result;
    }

    public async Task CreateAsync(IEventBus eventBus, [FromBody] AlarmRuleUpsertDto inputDto)
    {
        var command = new CreateAlarmRuleCommand(inputDto);
        await eventBus.PublishAsync(command);
    }

    public async Task UpdateAsync(IEventBus eventBus, Guid id, [FromBody] AlarmRuleUpsertDto inputDto)
    {
        var command = new UpdateAlarmRuleCommand(id, inputDto);
        await eventBus.PublishAsync(command);
    }

    public async Task DeleteAsync(IEventBus eventBus, Guid id)
    {
        var command = new DeleteAlarmRuleCommand(id);
        await eventBus.PublishAsync(command);
    }
}
