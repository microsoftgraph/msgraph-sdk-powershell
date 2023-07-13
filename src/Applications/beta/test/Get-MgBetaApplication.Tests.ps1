# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "Get-MgBetaApplication" {
    BeforeAll {
        $GetMgBetaApplication = Get-Command Get-MgBetaApplication
    }

    It "Should support minimum set of parameter sets" {
        $GetMgBetaApplication.ParameterSets.Name | Should -BeIn @("List", "Get", "GetViaIdentity")
        $GetMgBetaApplication.Visibility | Should -Be "Public"
        $GetMgBetaApplication.CommandType | Should -Be "Function"
    }

    It "Should return a list of applications by default" {
        $GetMgBetaApplication.OutputType | Should -Be "Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphApplication"
        $GetMgBetaApplication.DefaultParameterSet | Should -Be "List"
    }

    It 'Should have List parameterSet' {
        $ListParameterSet = $GetMgBetaApplication.ParameterSets | Where-Object Name -eq "List"
        $ListParameterSet.Parameters.Name | Should -Contain All
        $ListParameterSet.Parameters.Name | Should -Contain PageSize
        $ListParameterSet.Parameters.Name | Should -Contain CountVariable
        $ListParameterSet.Parameters.Name | Should -Contain Filter
        $ListParameterSet.Parameters.Name | Should -Contain Top
        $ListParameterSet.Parameters.Name | Should -Contain Property
        $ListParameterSet.Parameters.Name | Should -Contain ExpandProperty
        $ListParameterSet.Parameters.Name | Should -Contain ConsistencyLevel
    }

    It 'Should have Get parameterSet' {
        $GetParameterSet = $GetMgBetaApplication.ParameterSets | Where-Object Name -eq "Get"
        $GetParameterSet.Parameters.Name | Should -Contain ApplicationId
        $GetParameterSet.Parameters.Name | Should -Contain Property
        $GetParameterSet.Parameters.Name | Should -Contain ExpandProperty
    }

    It 'Should have GetViaIdentity parameterSet' {
        $GetViaIdentityParameterSet = $GetMgBetaApplication.ParameterSets | Where-Object Name -eq "GetViaIdentity"
        $GetViaIdentityParameterSet.Parameters.Name | Should -Contain InputObject
        $GetViaIdentityParameterSet.Parameters.Name | Should -Contain Property
        $GetViaIdentityParameterSet.Parameters.Name | Should -Contain ExpandProperty
    }
}
