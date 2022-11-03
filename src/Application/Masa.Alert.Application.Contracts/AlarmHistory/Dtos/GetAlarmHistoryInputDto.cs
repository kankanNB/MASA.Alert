﻿// Copyright (c) MASA Stack All rights reserved.
// Licensed under the Apache License. See LICENSE.txt in the project root for license information.

namespace Masa.Alert.Application.Contracts.AlarmHistory.Dtos;

public class GetAlarmHistoryInputDto : PaginatedOptionsDto
{
    public string Filter { get; set; } = default!;

    public AlarmHistorySearchTypes SearchType { get; set; } = AlarmHistorySearchTypes.Alarming;

    public AlarmHistorySearchTimeTypes TimeType { get; set; } = AlarmHistorySearchTimeTypes.FirstAlarmTime;

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public AlertSeverity AlertSeverity { get; set; }

    public AlarmHistoryStatuses Status { get; set; }

    public GetAlarmHistoryInputDto()
    {
    }

    public GetAlarmHistoryInputDto(int pageSize) : base("", 1, pageSize)
    {
    }

    public enum AlarmHistorySearchTypes
    {
        Alarming = 1,
        Processed,
        NoNotice
    }

    public enum AlarmHistorySearchTimeTypes
    {
        FirstAlarmTime = 1,
        LastAlarmTime,
    }
}
