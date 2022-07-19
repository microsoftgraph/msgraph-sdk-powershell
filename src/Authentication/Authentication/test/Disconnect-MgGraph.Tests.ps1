# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

BeforeAll {
    $ModuleName = "Microsoft.Graph.Authentication"
    $ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
    Import-Module $ModulePath -Force
}
Describe 'Disconnect-MgGraph ErrorAction Handling' {
    It 'Should throw error by default' {
        { Disconnect-MgGraph } | Should -Throw -ExpectedMessage "No application to sign out from."
    }

    It 'Should not throw error when ErrorAction is SilentlyContinue' {
        { Disconnect-MgGraph -ErrorAction SilentlyContinue } | Should -Not -Throw
    }
}
