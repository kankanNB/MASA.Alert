﻿// Copyright (c) MASA Stack All rights reserved.
// Licensed under the Apache License. See LICENSE.txt in the project root for license information.

namespace Masa.Alert.Application.AlarmRules.Commands;

public class CreateAlarmRuleCommandValidator : AbstractValidator<CreateAlarmRuleCommand>
{
    public CreateAlarmRuleCommandValidator() => RuleFor(cmd => cmd.AlarmRule).SetValidator(new AlarmRuleUpsertDtoValidator());
}