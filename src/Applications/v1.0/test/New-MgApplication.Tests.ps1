# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "New-MgApplication" {
    BeforeAll {
        $NewMgApplication = Get-Command New-MgApplication
    }

    It "Should support minimum set of parameter sets" {
        $NewMgApplication.ParameterSets.Name | Should -BeIn @("Create", "CreateExpanded")
        $NewMgApplication.Visibility | Should -Be "Public"
        $NewMgApplication.CommandType | Should -Be "Function"
    }

    It "Should support CreateExpanded parameterSet by default" {
        $NewMgApplication.OutputType | Should -Be "Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApplication"
        $NewMgApplication.DefaultParameterSet | Should -Be "CreateExpanded"
    }

    It 'Should have CreateExpanded parameterSet' {
        $CreateExpandedParameterSet = $NewMgApplication.ParameterSets | Where-Object Name -eq "CreateExpanded"
        $CreateExpandedParameterSet.Parameters.Name | Should -Contain DisplayName
        $CreateExpandedParameterSet.Parameters.Name | Should -Contain Description
        $CreateExpandedParameterSet.Parameters.Name | Should -Contain AdditionalProperties
        $CreateExpandedParameterSet.Parameters.Name | Should -Not -Contain BodyParameter
    }

    It 'Should have Create parameterSet' {
        $CreateParameterSet = $NewMgApplication.ParameterSets | Where-Object Name -eq "Create"
        $CreateParameterSet.Parameters.Name | Should -Contain BodyParameter
        $CreateParameterSet.Parameters.Name | Should -Not -Contain DisplayName
        $CreateParameterSet.Parameters.Name | Should -Not -Contain AdditionalProperties
    }
}
