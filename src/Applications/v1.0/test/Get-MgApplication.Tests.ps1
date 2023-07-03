# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "Get-MgApplication" {
    BeforeAll {
        $GetMgApplication = Get-Command Get-MgApplication
    }

    It "Should support minimum set of parameter sets" {
        $GetMgApplication.ParameterSets.Name | Should -BeIn @("List", "Get", "GetViaIdentity")
        $GetMgApplication.Visibility | Should -Be "Public"
        $GetMgApplication.CommandType | Should -Be "Function"
    }

    It "Should return a list of applications by default" {
        $GetMgApplication.OutputType | Should -Be "Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApplication"
        $GetMgApplication.DefaultParameterSet | Should -Be "List"
    }

    It 'Should have List parameterSet' {
        $ListParameterSet = $GetMgApplication.ParameterSets | Where-Object Name -eq "List"
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
        $GetParameterSet = $GetMgApplication.ParameterSets | Where-Object Name -eq "Get"
        $GetParameterSet.Parameters.Name | Should -Contain ApplicationId
        $GetParameterSet.Parameters.Name | Should -Contain Property
        $GetParameterSet.Parameters.Name | Should -Contain ExpandProperty
    }

    It 'Should have GetViaIdentity parameterSet' {
        $GetViaIdentityParameterSet = $GetMgApplication.ParameterSets | Where-Object Name -eq "GetViaIdentity"
        $GetViaIdentityParameterSet.Parameters.Name | Should -Contain InputObject
        $GetViaIdentityParameterSet.Parameters.Name | Should -Contain Property
        $GetViaIdentityParameterSet.Parameters.Name | Should -Contain ExpandProperty
    }
}
