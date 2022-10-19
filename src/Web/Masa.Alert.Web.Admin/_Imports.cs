﻿// Copyright (c) MASA Stack All rights reserved.
// Licensed under the Apache License. See LICENSE.txt in the project root for license information.

global using BlazorComponent;
global using BlazorComponent.I18n;
global using Masa.Blazor;
global using Masa.Alert.Web.Admin.Global;
global using Masa.Alert.Web.Admin.Global.Config;
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
global using Masa.Alert.Web.Admin.Data.Shared.Favorite;
global using Masa.Alert.Web.Admin.Data.Others.AccountSettings.Dto;
global using Masa.Alert.Web.Admin.Data.Base;
global using Microsoft.Extensions.DependencyInjection;
global using Masa.Utils.Data.Elasticsearch;
global using Masa.Contrib.SearchEngine.AutoComplete;
global using Masa.BuildingBlocks.SearchEngine.AutoComplete;
global using Masa.BuildingBlocks.SearchEngine.AutoComplete.Options;
global using Masa.Stack.Components;
global using Masa.Stack.Components.Models;
global using System.Collections.Concurrent;