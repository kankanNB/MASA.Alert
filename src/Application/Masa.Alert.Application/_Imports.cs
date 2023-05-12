﻿// Copyright (c) MASA Stack All rights reserved.
// Licensed under the Apache License. See LICENSE.txt in the project root for license information.

global using System.Collections.Concurrent;
global using System.Linq.Expressions;
global using System.Net.Http;
global using System.Text;
global using System.Text.Json;
global using FluentValidation;
global using Mapster;
global using Masa.Alert.Application.AlarmHistories.Commands;
global using Masa.Alert.Application.Contracts.AlarmHistories.Dtos;
global using Masa.Alert.Application.Contracts.AlarmRules.Dtos;
global using Masa.Alert.Application.Contracts.AlarmRules.Validator;
global using Masa.Alert.Application.Contracts.QueryContext;
global using Masa.Alert.Application.Contracts.QueryModels;
global using Masa.Alert.Application.Contracts.WebHooks.Dtos;
global using Masa.Alert.Contracts.Admin.Consts;
global using Masa.Alert.Domain.AlarmHistories.Aggregates;
global using Masa.Alert.Domain.AlarmHistories.Events;
global using Masa.Alert.Domain.AlarmHistories.Repositories;
global using Masa.Alert.Domain.AlarmRules;
global using Masa.Alert.Domain.AlarmRules.Aggregates;
global using Masa.Alert.Domain.AlarmRules.Events;
global using Masa.Alert.Domain.AlarmRules.Repositories;
global using Masa.Alert.Domain.AlarmRules.Services;
global using Masa.Alert.Domain.NotificationService;
global using Masa.Alert.Domain.Shared.AlarmHistory;
global using Masa.Alert.Domain.Shared.AlarmRules;
global using Masa.Alert.Domain.WebHooks.Aggregates;
global using Masa.Alert.Domain.WebHooks.Events;
global using Masa.Alert.Domain.WebHooks.Repositories;
global using Masa.Alert.Infrastructure.Ddd.Application.Contracts.Dtos;
global using Masa.BuildingBlocks.Authentication.Identity;
global using Masa.BuildingBlocks.Data;
global using Masa.BuildingBlocks.Ddd.Domain.Events;
global using Masa.BuildingBlocks.Ddd.Domain.SeedWork;
global using Masa.BuildingBlocks.Globalization.I18n;
global using Masa.BuildingBlocks.ReadWriteSplitting.Cqrs.Commands;
global using Masa.BuildingBlocks.ReadWriteSplitting.Cqrs.Queries;
global using Masa.BuildingBlocks.RulesEngine;
global using Masa.BuildingBlocks.StackSdks.Auth;
global using Masa.BuildingBlocks.StackSdks.Config;
global using Masa.BuildingBlocks.StackSdks.Scheduler;
global using Masa.BuildingBlocks.StackSdks.Scheduler.Enum;
global using Masa.BuildingBlocks.StackSdks.Scheduler.Model;
global using Masa.BuildingBlocks.StackSdks.Scheduler.Request;
global using Masa.BuildingBlocks.StackSdks.Tsc;
global using Masa.BuildingBlocks.StackSdks.Tsc.Contracts.Model.Aggregate;
global using Masa.BuildingBlocks.StackSdks.Tsc.Model;
global using Masa.Contrib.Dispatcher.Events;
global using Masa.Contrib.StackSdks.Config;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Logging;
global using Masa.Alert.Infrastructure.Constants;
global using Masa.Alert.Application.AlarmRules.Commands;
global using Masa.BuildingBlocks.Dispatcher.Events;
global using Masa.BuildingBlocks.Caching;
global using Masa.Alert.Domain.Shared.Consts;
