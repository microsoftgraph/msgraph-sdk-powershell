# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ModuleProjectPath,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $FullyQualifiedModuleName
)
$ErrorActionPreference = "Stop"
# Update module psm1 with Graph session profile name.
$ModulePsm1 = Join-Path $ModuleProjectPath "/$FullyQualifiedModuleName.psm1"
(Get-Content -Path $ModulePsm1) | ForEach-Object {
    if ($_ -match '\$instance = \[Microsoft.Graph.PowerShell.Module\]::Instance') {
        # Update main psm1 with Graph session profile name and module name.
        $_
        '  $instance.ProfileName = [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.SelectedProfile'
    }
    else {
        # Rename all Azure instances in psm1 to `Microsoft Graph`.
        $updatedLine = $_ -replace 'Azure', 'Microsoft Graph'
        # Replace all 'instance.Name' declarations with fully qualified module name.
        $updatedLine = $updatedLine -replace '\$\(\$instance.Name\)', "$FullyQualifiedModuleName"
        # Replace Write-Information with Write-Debug
        $updatedLine = $updatedLine -replace 'Write\-Information', 'Write-Debug'
        $updatedLine
    }
} | Set-Content $ModulePsm1

# Address AutoREST bug where it looks for exports in the wrong directory.
$InternalModulePsm1 = Join-Path $ModuleProjectPath "/internal/$FullyQualifiedModuleName.internal.psm1"
(Get-Content -Path $InternalModulePsm1) | ForEach-Object {
    $updatedLine = $_
    # Address AutoREST bug where it looks for exports in the wrong directory.
    if ($_ -match '\$exportsPath = \$PSScriptRoot') {
        $updatedLine = '  $exportsPath = Join-Path $PSScriptRoot "../exports"'
    }

    # Remove duplicate instance.Name declarations in internal.psm1
    # Main .psm1 already handles this.
    if ($_ -match '\$\(\$instance.Name\)') {
        $updatedLine = ""
    }
    $updatedLine
} | Set-Content $InternalModulePsm1