$OutputFolder = (Join-Path $PSScriptRoot "../docs/")
# Install PlatyPS
if (!(Get-Module -Name PlatyPS -ListAvailable)) {
    Install-Module PlatyPS -Force
}
Import-Module PlatyPS -Force -Scope Global
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
Import-Module "../../../../../PlayGround/Migrations/Microsoft.Graph.Authentication.2.6.1/Microsoft.Graph.Authentication.psm1"
$ct = (Get-ChildItem $DocsLocation | Measure-Object ).Count
if ($ct -gt 0) {
    Update-MarkdownHelpModule @updateparameters
}
else {
    New-MarkdownHelp @parameters
}
