$OutputFolder = (Join-Path $PSScriptRoot "../src/Authentication/docs/")
$parameters = @{
    Module                = "Microsoft.Graph.Authentication"
    OutputFolder          = $OutputFolder
    AlphabeticParamsOrder = $true
    WithModulePage        = $true
    ExcludeDontShow       = $true
    Encoding              = [System.Text.Encoding]::UTF8
}

$updateparameters = @{
    Path                  = $OutputFolder
    RefreshModulePage     = $true
    AlphabeticParamsOrder = $true
    UpdateInputOutput     = $true
    ExcludeDontShow       = $true
    Encoding              = [System.Text.Encoding]::UTF8
}

Import-Module -Name "../src/Authentication/Authentication/artifacts/Microsoft.Graph.Authentication.psm1"
$ct = (Get-ChildItem $DocsLocation | Measure-Object ).Count
if ($ct -gt 0) {
    Update-MarkdownHelpModule @updateparameters
}
else {
    New-MarkdownHelp @parameters
}
