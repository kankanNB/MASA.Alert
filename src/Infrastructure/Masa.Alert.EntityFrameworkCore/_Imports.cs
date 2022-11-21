﻿global using System.Reflection;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.ChangeTracking;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.Extensions.Logging;
global using Masa.Contrib.Isolation.UoW.EFCore;
global using Masa.BuildingBlocks.Data.UoW;
global using Masa.Contrib.Ddd.Domain.Repository.EFCore;
global using System.Text.Json;
global using Masa.Alert.Domain.AlarmRules;
global using Masa.Alert.Domain.Shared.Consts;
global using Masa.Alert.Infrastructure.EntityFrameworkCore.EntityFrameworkCore.ValueConverters;
global using System.Threading.Channels;
global using System.Collections.Concurrent;
global using Masa.Alert.Domain.AlarmRules.Aggregates;
global using Masa.Alert.Domain.AlarmRules.Repositories;
global using Masa.Alert.Domain.AlarmHistories.Aggregates;
global using Masa.Alert.Domain.AlarmHistories.Repositories;
global using Masa.Alert.Application.Contracts.QueryContext;
global using Masa.Alert.Application.Contracts.QueryModels;