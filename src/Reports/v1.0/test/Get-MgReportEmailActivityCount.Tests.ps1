# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "Get-MgReportEmailActivityCount" {
    BeforeAll {
        $GetMgReportEmailActivityCount = Get-Command Get-MgReportEmailActivityCount
    }

    It "Should support minimum set of parameter sets" {
        $GetMgReportEmailActivityCount.ParameterSets.Name | Should -BeIn @("Get", "GetViaIdentity")
        $GetMgReportEmailActivityCount.Visibility | Should -Be "Public"
        $GetMgReportEmailActivityCount.CommandType | Should -Be "Function"
    }

    It "Should return a list of applications by default" {
        $GetMgReportEmailActivityCount.OutputType | Should -Be "System.Boolean"
        $GetMgReportEmailActivityCount.DefaultParameterSet | Should -Be "Get"
    }

    It 'Should have Get parameterSet' {
        $GetParameterSet = $GetMgReportEmailActivityCount.ParameterSets | Where-Object Name -eq "Get"
        $GetParameterSet.Parameters.Name | Should -Contain OutFile
        $GetParameterSet.Parameters.Name | Should -Contain Period
    }

    It '-Period parameter should have an argument completer' {
        $GetMgReportEmailActivityCount.Parameters.Period.Attributes.ScriptBlock | Should -be "'D7', 'D30', 'D90', 'D180'"
    }
}
