$CommandMetadataPath = (Join-Path $PSScriptRoot "..\src\Authentication\Authentication\custom\common\MgCommandMetadata.json")

$CommandMetadata = Get-Content -Path $CommandMetadataPath | ConvertFrom-Json
$Counter = 0
$CommandMetadata | ForEach-Object {
    #If cmdlet method is a post or a patch add it to the counter
    if ($_.Method -eq "DELETE") {
        $Counter++
    }
}
Write-Host "Total number of cmdlets that are DELETE: $Counter"