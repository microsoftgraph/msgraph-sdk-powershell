Param(
  [string] $DocsLocation = (Join-Path $PSScriptRoot "../docs/"),
  [string] $ExamplesLocation = (Join-Path $PSScriptRoot "../examples/"),
  [string] $SynopisLocation = (Join-Path $PSScriptRoot "../synopsis/"),
  [string] $DescriptionLocation = (Join-Path $PSScriptRoot "../descriptions/")
)
function Start-Generator {
    foreach ($File in Get-ChildItem $DocsLocation) {
        $ExampleFile = (Join-Path $ExamplesLocation $File.Name)
        if (-not(Test-Path $ExampleFile)) {
            New-Item -ItemType File -Force -Path $ExampleFile
        }
        $SynopsisFile = (Join-Path $SynopisLocation $File.Name)
        if (-not(Test-Path $SynopsisFile)) {
            New-Item -ItemType File -Force -Path $SynopsisFile
        }
        $DescriptionFile = (Join-Path $DescriptionLocation $File.Name)
        if (-not(Test-Path $DescriptionFile)) {
            New-Item -ItemType File -Force -Path $DescriptionFile
        }
    }
}

Start-Generator