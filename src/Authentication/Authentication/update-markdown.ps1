$OutputFolder = (Join-Path $PSScriptRoot "../docs/")
if (!(Get-Module -Name PlatyPS -ListAvailable)) {
    throw 'platyPS is required to build Authentication help. Save the module to a build-local directory and add it to PSModulePath.'
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
$ct = (Get-ChildItem $DocsLocation | Measure-Object ).Count
if ($ct -gt 0) {
    Update-MarkdownHelpModule @updateparameters
}
else {
    New-MarkdownHelp @parameters
}
