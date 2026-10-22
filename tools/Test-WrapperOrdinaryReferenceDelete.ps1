<#
.SYNOPSIS
Checks an ordinary typed Users sponsors reference DELETE with the real PowerShell binder.

.DESCRIPTION
FixtureAssembly contains the generated single root DELETE command and dependencies.
All accepted invocations use WhatIf; no Graph session or network request is needed.
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string]$FixtureAssembly,
    [string]$CommandName = 'Remove-MgUserSponsorByRef'
)

$ErrorActionPreference = 'Stop'
$module = Import-Module (Resolve-Path $FixtureAssembly).Path -PassThru -ErrorAction Stop

function Assert-OrdinaryReferenceDelete([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
}

function Assert-OrdinaryReferenceDeleteRejected([scriptblock]$Invocation, [string]$ErrorId) {
    $failure = $null
    try { $null = & $Invocation }
    catch { $failure = $_ }
    Assert-OrdinaryReferenceDelete ($null -ne $failure -and $failure.FullyQualifiedErrorId -like "$ErrorId,*") `
        "Expected $ErrorId from the real binder, got: $failure"
}

try {
    $command = Get-Command $CommandName -Module $module.Name
    Assert-OrdinaryReferenceDelete ($command.ParameterSets.Count -eq 1) 'An ordinary reference DELETE must have exactly one parameter set.'
    $set = $command.ParameterSets[0]
    Assert-OrdinaryReferenceDelete (($set.Parameters | Where-Object Name -eq 'Id').IsMandatory) 'Id must bind the required @id query.'
    Assert-OrdinaryReferenceDelete (($set.Parameters | Where-Object Name -eq 'UserId').IsMandatory) 'The user path identifier must remain mandatory.'
    foreach ($name in 'IfMatch', 'Headers', 'AccessToken', 'WhatIf', 'Confirm') {
        Assert-OrdinaryReferenceDelete ($command.Parameters.ContainsKey($name)) "Missing ordinary parameter: $name"
    }
    foreach ($name in 'MemberReferenceUri', 'DirectoryObjectId', 'Route') {
        Assert-OrdinaryReferenceDelete (-not $command.Parameters.ContainsKey($name)) "An ordinary DELETE must not acquire $name."
    }
    $workers = @(Get-Command -Module $module.Name | Where-Object Name -like '*_Route*')
    Assert-OrdinaryReferenceDelete ($workers.Count -eq 0) 'An ordinary reference DELETE must not emit route workers.'
    $routes = @($command.ImplementingType.GetCustomAttributes($true) | Where-Object { $_.GetType().Name -eq 'GraphRouteAttribute' })
    Assert-OrdinaryReferenceDelete ($routes.Count -eq 1 -and $routes[0].Method -eq 'DELETE' `
        -and $routes[0].Path -ceq '/users/{user-id}/sponsors/$ref' -and [string]::IsNullOrEmpty($routes[0].ParameterSetName)) `
        'The single ordinary source route must remain unchanged and must not acquire route parameter-set metadata.'

    $reference = 'https://graph.microsoft.com/v1.0/directoryObjects/sponsor-id'
    & $command -UserId user-id -Id $reference -IfMatch '"etag"' -Headers @{ 'x-test-header' = 'ordinary' } `
        -AccessToken 'unused-whatif' -WhatIf
    & $command -UserId user-id -Id $reference -WhatIf
    Assert-OrdinaryReferenceDeleteRejected { & $command -UserId user-id -WhatIf } 'MissingMandatoryParameter'
    Assert-OrdinaryReferenceDeleteRejected { & $command -Id $reference -WhatIf } 'MissingMandatoryParameter'
    foreach ($invalid in 'MemberReferenceUri', 'DirectoryObjectId', 'Route') {
        $parameters = @{ UserId = 'user-id'; Id = $reference; WhatIf = $true; $invalid = 'not-supported' }
        Assert-OrdinaryReferenceDeleteRejected { & $command @parameters } 'NamedParameterNotFound'
    }
    Write-Host 'PASS: ordinary typed sponsors DELETE: required public Id, unchanged route, headers and WhatIf; no dispatcher, route workers or foreign parameters.'
}
finally {
    Remove-Module $module -ErrorAction SilentlyContinue
}
