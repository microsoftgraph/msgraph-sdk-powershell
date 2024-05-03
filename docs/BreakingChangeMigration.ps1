# Define the path to the CSV file and the script file
$csvPath = "docs\PowerShellBreakingChanges-V1.0.csv" #"docs\PowerShellBreakingChanges-Beta.csv"
$scriptPath = "<Path to your script>"
$newScriptPath = "<Path to save the updated script>"
 
# Import the CSV file
$cmdletMappings = Import-Csv -Path $csvPath
 
# Read the script file contents
$scriptContent = Get-Content -Path $scriptPath -Raw
 
# Replace old cmdlets with new cmdlets
foreach ($mapping in $cmdletMappings) {
    $oldCmdlet = $mapping.OldCmdlet
    $newCmdlet = $mapping.NewCmdlet
    $scriptContent = $scriptContent -replace $oldCmdlet, $newCmdlet
}
 
# Save the updated script content to a new file
$scriptContent | Set-Content -Path $newScriptPath
 
Write-Host "Script updated and saved to $newScriptPath"