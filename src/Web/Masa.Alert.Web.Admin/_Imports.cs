﻿// Copyright (c) MASA Stack All rights reserved.
// Licensed under the Apache License. See LICENSE.txt in the project root for license information.

global using BlazorComponent;
global using BlazorComponent.I18n;
global using Masa.Blazor;
global using Masa.Alert.Web.Admin.Global;
global using Microsoft.AspNetCore.Components;
global using Microsoft.AspNetCore.Components.Forms;
global using Microsoft.AspNetCore.Components.Web;
global using Microsoft.AspNetCore.Http;
global using System.ComponentModel;
global using System.ComponentModel.DataAnnotations;
global using System.Net.Http.Json;
global using System.Reflection;
global using System.Text.Json;
global using Masa.Alert.Infrastructure.Ddd.Application.Contracts.Dtos;
global using Mapster;
global using Masa.Alert.Infrastructure.Common.Helper;
global using Masa.Alert.ApiGateways.Caller;
global using FluentValidation;
global using Masa.Alert.Infrastructure.Common.Extensions;
global using System.Text;
global using Microsoft.AspNetCore.SignalR.Client;
global using Masa.Alert.Contracts.Admin.Consts;
global using BlazorDownloadFile;
global using Microsoft.JSInterop;
global using Masa.Blazor.Components.Editor;
global using Microsoft.Extensions.DependencyInjection;
global using Masa.Utils.Data.Elasticsearch;
global using Masa.Contrib.SearchEngine.AutoComplete;
global using Masa.BuildingBlocks.SearchEngine.AutoComplete;
global using Masa.BuildingBlocks.SearchEngine.AutoComplete.Options;
global using Masa.Stack.Components;
global using Masa.Stack.Components.Models;
global using Masa.Stack.Components.TaskHandle;
global using System.Collections.Concurrent;
global using Masa.Alert.Web.Admin.ViewModel.AlarmRules;
global using Microsoft.AspNetCore.Components.Rendering;
global using BlazorComponent.Helpers;
global using Masa.Alert.Application.Contracts.AlarmRules;
global using Masa.Alert.Web.Admin.Pages.AlarmRules.Modules;
global using Masa.Alert.Domain.Shared.AlarmRules;
global using static Masa.Stack.Components.JsInitVariables;
global using Masa.Alert.Infrastructure.Common.Utils;
global using Masa.Alert.Application.Contracts.AlarmHistories.Dtos;
global using Masa.Alert.Application.Contracts.AlarmRules.Dtos;
global using Masa.Alert.Domain.Shared.AlarmHistory;
global using Masa.Alert.Web.Admin.ViewModel.AlarmHistory;
global using Masa.BuildingBlocks.StackSdks.Mc.Enum;
global using Masa.Contrib.StackSdks.Mc.Service;
global using System.Reflection.PortableExecutable;
global using Masa.Alert.Web.Admin.Components.Modules.Alarm;
global using Masa.Alert.Web.Admin.Pages.AlarmHistory.Modules;
global using System.Linq.Expressions;
global using Masa.Stack.Components.Layouts;
global using Masa.Alert.Application.Contracts.WebHooks.Dtos;
global using Masa.Alert.Web.Admin.ViewModel.WebHooks;
global using Masa.Alert.Web.Admin.Pages.WebHooks.Modules;
global using Masa.Alert.Domain.Shared.Enums;
global using Masa.Alert.ApiGateways.Caller.Services.AlarmRules;
global using Masa.BuildingBlocks.Ddd.Domain.Entities;
global using Masa.BuildingBlocks.Service.Caller;
global using Humanizer;
global using Masa.BuildingBlocks.StackSdks.Auth;
global using Masa.Contrib.StackSdks.Auth;
global using Masa.BuildingBlocks.StackSdks.Pm;
global using Masa.BuildingBlocks.StackSdks.Pm.Model;
global using Masa.BuildingBlocks.StackSdks.Tsc;
global using Masa.Alert.Contracts.Admin.Tsc;
global using Masa.BuildingBlocks.StackSdks.Tsc.Model;
global using Masa.Alert.ApiGateways.Caller.Services.AlarmHistories;
global using Masa.Alert.Web.Admin.Components.Modules.Alarm.Model;
global using Masa.BuildingBlocks.StackSdks.Mc;
global using Masa.Alert.ApiGateways.Caller.Services.WebHooks;
global using Masa.BuildingBlocks.StackSdks.Tsc.Contracts.Model;
global using Masa.BuildingBlocks.Ddd.Domain.SeedWork;
global using Masa.Alert.Web.Admin.Components;
global using Newtonsoft.Json.Linq;
global using System.Text.RegularExpressions;
global using Masa.Alert.Application.Contracts.QueryModels;
global using Masa.Contrib.StackSdks.Caller;
global using Microsoft.IdentityModel.Protocols.OpenIdConnect;
global using Masa.Stack.Components.Extensions;