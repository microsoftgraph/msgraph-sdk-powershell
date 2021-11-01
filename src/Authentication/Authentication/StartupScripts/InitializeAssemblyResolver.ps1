# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

try {
    if ($PSEdition -eq 'Core') {
        [Microsoft.Graph.PowerShell.Authentication.Utilities.DependencyAssemblyResolver]::Initialize()
    }
    else {
        [Microsoft.Graph.PowerShell.Authentication.Utilities.DependencyAssemblyResolver]::Initialize($true)
    }
}
catch {
    Write-Warning $_
}