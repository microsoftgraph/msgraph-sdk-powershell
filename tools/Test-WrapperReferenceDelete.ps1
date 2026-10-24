<#
.SYNOPSIS
Checks the real PowerShell binder against compiled, typed reference-delete wrappers.

.DESCRIPTION
FixtureAssembly must contain the generated administrative-unit collection and item
reference-delete workers and dispatcher, alongside their dependencies. All valid
invocations use WhatIf, so no Graph session or HTTP request is required.

.EXAMPLE
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperReferenceDelete.ps1 -FixtureAssembly <fixture-dll>
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string]$FixtureAssembly
)

$ErrorActionPreference = 'Stop'
$FixtureAssembly = (Resolve-Path $FixtureAssembly).Path
$module = Import-Module $FixtureAssembly -PassThru -ErrorAction Stop

function Assert-ReferenceDelete([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
}

function Assert-ReferenceDeleteRejected([scriptblock]$Invocation, [string]$ErrorId) {
    $failure = $null
    try { $null = & $Invocation }
    catch { $failure = $_ }
    Assert-ReferenceDelete ($null -ne $failure -and $failure.FullyQualifiedErrorId -like "$ErrorId,*") `
        "Expected $ErrorId from the real binder, got: $failure"
}

try {
    $command = Get-Command Remove-MgAdministrativeUnitMemberByRef -Module $module.Name
    Assert-ReferenceDelete ($command.DefaultParameterSet -eq 'ItemInvoke') 'The item route must remain the default.'
    Assert-ReferenceDelete ($command.ParameterSets.Count -eq 2) 'Exactly collection and item parameter sets are required.'
    $collection = $command.ParameterSets | Where-Object Name -eq 'CollectionInvoke'
    $item = $command.ParameterSets | Where-Object Name -eq 'ItemInvoke'
    Assert-ReferenceDelete (($collection.Parameters | Where-Object Name -eq 'MemberReferenceUri').IsMandatory) `
        'The actual required @id query must be mandatory on the collection route.'
    Assert-ReferenceDelete (($item.Parameters | Where-Object Name -eq 'DirectoryObjectId').IsMandatory) `
        'The item route must require its directory-object id.'
    Assert-ReferenceDelete ('MemberReferenceUri' -notin $item.Parameters.Name) 'The item route must not accept the query.'
    Assert-ReferenceDelete ('DirectoryObjectId' -notin $collection.Parameters.Name) 'The collection route must not accept an item id.'
    Assert-ReferenceDelete (-not $command.Parameters.ContainsKey('Route')) 'Reference deletes must not acquire a route selector.'
    foreach ($set in $collection, $item) {
        Assert-ReferenceDelete ('IfMatch' -in $set.Parameters.Name -and 'Headers' -in $set.Parameters.Name `
            -and 'AccessToken' -in $set.Parameters.Name -and 'WhatIf' -in $set.Parameters.Name `
            -and 'Confirm' -in $set.Parameters.Name) 'Headers, authentication and ShouldProcess parameters must remain available.'
    }

    $reference = 'https://graph.microsoft.com/beta/directoryObjects/member-id'
    Remove-MgAdministrativeUnitMemberByRef -AdministrativeUnitId unit-id -MemberReferenceUri $reference `
        -IfMatch '"etag"' -Headers @{ 'x-test-header' = 'collection' } -AccessToken 'unused-whatif' -WhatIf
    Remove-MgAdministrativeUnitMemberByRef -AdministrativeUnitId unit-id -DirectoryObjectId member-id `
        -IfMatch '"etag"' -Headers @{ 'x-test-header' = 'item' } -AccessToken 'unused-whatif' -WhatIf
    Remove-MgAdministrativeUnitMemberByRef unit-id member-id -WhatIf

    Assert-ReferenceDeleteRejected {
        Remove-MgAdministrativeUnitMemberByRef -AdministrativeUnitId unit-id -DirectoryObjectId member-id `
            -MemberReferenceUri $reference -WhatIf
    } 'AmbiguousParameterSet'
    Assert-ReferenceDeleteRejected {
        Remove-MgAdministrativeUnitMemberByRef -AdministrativeUnitId unit-id -WhatIf
    } 'MissingMandatoryParameter'
    Assert-ReferenceDeleteRejected {
        Remove-MgAdministrativeUnitMemberByRef -AdministrativeUnitId unit-id -DirectoryObjectId member-id -Route Collection -WhatIf
    } 'NamedParameterNotFound'
    Assert-ReferenceDeleteRejected {
        Remove-MgAdministrativeUnitMemberByRef_Route0 -AdministrativeUnitId unit-id -MemberReferenceUri $reference `
            -DirectoryObjectId member-id -WhatIf
    } 'NamedParameterNotFound'
    Assert-ReferenceDeleteRejected {
        Remove-MgAdministrativeUnitMemberByRef_Route1 -AdministrativeUnitId unit-id -DirectoryObjectId member-id `
            -MemberReferenceUri $reference -WhatIf
    } 'NamedParameterNotFound'
    Write-Host 'PASS: actual typed reference-delete binder: collection/item exclusivity, required parameters, headers, ShouldProcess and five rejected combinations.'
}
finally {
    Remove-Module $module -ErrorAction SilentlyContinue
}
