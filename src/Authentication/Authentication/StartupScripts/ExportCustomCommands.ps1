# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

# Export custom script cmdlets.
$CustomScriptPath = Join-Path $PSScriptRoot "../custom"
if (Test-Path $CustomScriptPath) {
    Get-ChildItem -Path $CustomScriptPath -Filter '*.ps1' -File -ErrorAction Stop | ForEach-Object { . $_.FullName }

    # Export nothing to clear implicit exports.
    Export-ModuleMember

    # Export script cmdlets.
    Export-ModuleMember -Function (Get-ScriptCmdlet -ScriptFolder $CustomScriptPath) -Alias (Get-ScriptCmdlet -ScriptFolder $CustomScriptPath -AsAlias)
}
