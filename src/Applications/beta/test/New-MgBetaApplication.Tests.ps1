# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "New-MgBetaApplication" {
    BeforeAll {
        $NewMgBetaApplication = Get-Command New-MgBetaApplication
    }

    It "Should support minimum set of parameter sets" {
        $NewMgBetaApplication.ParameterSets.Name | Should -BeIn @("Create", "CreateExpanded")
        $NewMgBetaApplication.Visibility | Should -Be "Public"
        $NewMgBetaApplication.CommandType | Should -Be "Function"
    }

    It "Should support CreateExpanded parameterSet by default" {
        $NewMgBetaApplication.OutputType | Should -Be "Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphApplication"
        $NewMgBetaApplication.DefaultParameterSet | Should -Be "CreateExpanded"
    }

    It 'Should have CreateExpanded parameterSet' {
        $CreateExpandedParameterSet = $NewMgBetaApplication.ParameterSets | Where-Object Name -eq "CreateExpanded"
        $CreateExpandedParameterSet.Parameters.Name | Should -Contain DisplayName
        $CreateExpandedParameterSet.Parameters.Name | Should -Contain Description
        $CreateExpandedParameterSet.Parameters.Name | Should -Contain AdditionalProperties
        $CreateExpandedParameterSet.Parameters.Name | Should -Not -Contain BodyParameter
    }

    It 'Should have Create parameterSet' {
        $CreateParameterSet = $NewMgBetaApplication.ParameterSets | Where-Object Name -eq "Create"
        $CreateParameterSet.Parameters.Name | Should -Contain BodyParameter
        $CreateParameterSet.Parameters.Name | Should -Not -Contain DisplayName
        $CreateParameterSet.Parameters.Name | Should -Not -Contain AdditionalProperties
    }
}
