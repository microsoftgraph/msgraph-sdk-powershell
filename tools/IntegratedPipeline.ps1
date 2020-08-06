Param(
  [string] $RepositoryName = "PSGallery",
  [string] $RepositoryApiKey,
  [string] $ArtifactsLocation = (Join-Path $PSScriptRoot "..\artifacts\"),
  [switch] $Build,
  [switch] $Pack,
  [switch] $Publish,
  [switch] $EnableSigning,
  [switch] $BuildWhenEqual
)

$GenerateAuthenticationModule = Join-Path $PSScriptRoot ".\GenerateAuthenticationModule.ps1" -Resolve
$GenerateModules = Join-Path $PSScriptRoot ".\GenerateModules.ps1" -Resolve
$GenerateRollUpModules = Join-Path $PSScriptRoot ".\GenerateRollUpModule.ps1" -Resolve

& $GenerateAuthenticationModule -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey -ArtifactsLocation $ArtifactsLocation -Build $Build -Pack $Pack -Publish $Publish -EnableSigning $EnableSigning -BuildWhenEqual $BuildWhenEqual

& $GenerateModules -RepositoryName $RepositoryName  -RepositoryApiKey $RepositoryApiKey -UpdateAutoRest $true -Build:$Build -Pack :Pack -Publish:$Publish -EnableSigning $EnableSigning

& $GenerateRollUpModules -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey -Pack $Pack -Publish $Publish

