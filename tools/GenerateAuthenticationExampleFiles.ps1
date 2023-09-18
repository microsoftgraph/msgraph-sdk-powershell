[CmdletBinding()]
Param(
  [string] $DocsLocation = (Join-Path $PSScriptRoot "../src/Authentication/docs/"),
  [string] $ExamplesLocation = (Join-Path $PSScriptRoot "../src/Authentication/examples/")
)
function Start-Generator {
    foreach ($File in Get-ChildItem $DocsLocation) {
        $ExampleFile = (Join-Path $ExamplesLocation $File.Name)
        if (-not(Test-Path $ExampleFile)) {
            New-Item -ItemType File -Force -Path $ExampleFile
        }
    }
}

Start-Generator