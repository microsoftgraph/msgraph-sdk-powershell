$BetaProfileRegex = "^(Select-MgProfile)\s+(?:-Name)?(\s+)?([beta{'}])"
$V1ProfileRegex = "^(Select-MgProfile)\s+(?:-Name)?(\s+)?('v1\.0'|v1\.0)"
function Read-MgScriptDirectory {
    param (
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [ValidateNotNullorEmpty()]
        [string] $DirectoryPath,
        [string] $GraphProfile,
        [string] $UpdatedFilePath
    )

    process {
        $SupportedFileTypes = ".ps1", ".psm1"
        Get-ChildItem $DirectoryPath -Recurse -File | ForEach-Object {
            if ($_.Extension -in $SupportedFileTypes) {
                Invoke-MgScriptAnalyzer -FilePath $_.FullName -GraphProfile $GraphProfile -UpdatedFilePath $UpdatedFilePath
                
            }
            else {
                Write-Warning "Skipping unsupported file type: $($_.FullName)"
            }
        }
    }
}

function Invoke-MgScriptAnalyzer {
    param (
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [ValidateNotNullorEmpty()]
        [string] $FilePath,
        [string] $GraphProfile,
        [string] $UpdatedFilePath
    )

    # TODO: Analyze script content for breaking change.
    # TODO: Store changes in an object.
    # TODO: Write object as output.
    # TODO: Settle on object members.

    # Proposed Output
    # Order | Location (file name:line:tab) | Type (Cmdlet|CmdletParameter|ModuleName) | ApiVersion | Original | New

    [System.Collections.ArrayList]$LineContent = @()
    [System.Collections.ArrayList]$LineNumbers = @()
    $LineUpdate = @{}
    [Hashtable]$Original = @{}
    [Hashtable]$ProposedChanges = @{}
    $Result = @()

        $SupportedFileTypes = ".ps1", ".psm1"
        if ($SupportedFileTypes -notContains [System.IO.Path]::GetExtension($FilePath)) {
            throw "Unsupported file type: $FilePath"
        }
        $WriteToFile = $false
        $FileName = [System.IO.Path]::GetFileName($FilePath)
        $UpdatedFile = ""
        if (-not ([string]::IsNullOrEmpty($UpdatedFilePath))) {
            $WriteToFile = $true
            $UpdatedFile = Join-Path $UpdatedFilePath "Migration-$FileName"
            if (-not (Test-Path $UpdatedFilePath)) { throw "Path does not exist: $UpdatedFilePath" }
        }
        $ScriptContent = Get-Content $FilePath     
        $i = 0
        foreach ($_ in $ScriptContent) {
            $_ = $_.ToString().TrimStart()
            $indexOfItem = $LineContent.Add($_)
            
            if ($_ -match $BetaProfileRegex) {
                if(-not $_.StartsWith("#")){
                    $indexOfLineItem = $LineNumbers.Add($i)
                }
                
            }
            
            $i++
        }
        if ($GraphProfile -ieq "beta") {
            for ($g = 0; $g -lt $LineContent.Count; $g++) {
                if ($LineContent[$g].Contains("-Mg")) {
                    $Original.Add($g + 1, $LineContent[$g])
                    $ProposedChanges.Add($g + 1, $LineContent[$g].ToString().Replace("-Mg", "-MgBeta"))
                }
            }
        }
        else {
            $Lines = $LineNumbers.Count
    
            for ($j = 0; $j -lt $Lines; $j++) {
             
                for ($k = $LineNumbers[$j]; $k -lt $LineContent.Count; $k++) {
                    if ($LineContent[$k] -match $V1ProfileRegex) {
                
                
                        if (-not $LineUpdate.ContainsKey($LineNumbers[$j])) {
                            $LineUpdate.Add($LineNumbers[$j], $k)
                        }
                    }
                }
            }
            $LineUpdate.Keys | ForEach-Object {
                $LineNumber = $_
                for ($m = $lineNumber + 1; $m -lt $LineUpdate[$LineNumber]; $m++) {
                    if ($LineContent[$m].Contains("-Mg")) {
                        $Original.Add($m + 1, $LineContent[$m])
                        $ProposedChanges.Add($m + 1, $LineContent[$m].ToString().Replace("-Mg", "-MgBeta"))
                    }
                
                }
            }
            if ($Lines -gt $LineUpdate.Count) {
                for ($n = $LineNumbers[$Lines - 1] + 1; $n -lt $LineContent.Count; $n++) {
                    if ($LineContent[$n].Contains("-Mg")) {
                        $Original.Add($n + 1, $LineContent[$n])
                        $ProposedChanges.Add($n + 1, $LineContent[$n].ToString().Replace("-Mg", "-MgBeta"))
                    }
                }
            }
    
        }

        $p = 1
        foreach ($item in $Original.GetEnumerator() | Sort Name) {
            $LineNumber = $item.Key
            $OriginalValue = $Original[$LineNumber].ToString()
            $ProposedValue = $ProposedChanges[$LineNumber].ToString()
            $Result += [pscustomobject]@{"Order" = $p;"Location" = $FileName+":"+$LineNumber; "Type"="Cmdlet"; "ApiVersion" = "Beta"; "Original" = $OriginalValue; "New" = $ProposedValue }
            if ($WriteToFile) {
                foreach ($Content in $ScriptContent) {

                    if ($Content -eq $OriginalValue) {
                        $ScriptContent = $ScriptContent | ForEach-Object { $_ -replace [regex]::Escape($OriginalValue), $ProposedValue }   
                    }
                    if ($Content.StartsWith("Select-MgProfile")) {
                        $ScriptContent = $ScriptContent -replace $Content, $null
                    }
                     
                }
                $ScriptContent > $UpdatedFile
            }
            $p++
        }
        if ($Result.Count -gt 0) {
            Write-Host -ForegroundColor Green "--------- Your script(s) contains commands that need to conform to the naming convention as per the 'New' column on the table below ---------"
            Write-Output $Result | Format-Table
        }
        if($WriteToFile){
            Write-Host -ForegroundColor Blue "Your updated script is on this path: $UpdatedFile" 
        }
        $Result = @()

}

function New-MgMigrationPlan {
    [CmdletBinding(DefaultParameterSetName = 'FileOrDirectory')]
    param (
        [Parameter(ParameterSetName = 'Directory', Mandatory = $true)]
        [ValidateNotNullorEmpty()]
        [string] $DirectoryPath,
        [Parameter(ParameterSetName = 'File', Mandatory = $true)]
        [ValidateNotNullorEmpty()]
        [string] $FilePath,
        [Parameter(ParameterSetName = 'FileOrDirectory', Mandatory = $true, ValueFromPipeline = $true, Position = 0)]
        [PSCustomObject] $InputObject,
        [string] $GraphProfile,
        [string] $UpdatedFilePath
    )

    process {
        switch ($PSCmdlet.ParameterSetName) {
            'File' {
                if (-not (Test-Path $FilePath)) { throw "Path does not exist: $FilePath" }
                Invoke-MgScriptAnalyzer -FilePath $FilePath -GraphProfile $GraphProfile -UpdatedFilePath $UpdatedFilePath
            }
            'Directory' {
                if (-not (Test-Path $DirectoryPath)) { throw "Path does not exist: $DirectoryPath" }
                Read-MgScriptDirectory -DirectoryPath $DirectoryPath -GraphProfile $GraphProfile -UpdatedFilePath $UpdatedFilePath
            }
            'FileOrDirectory' {
                foreach ($input in $InputObject) {
                    if (-not (Test-Path $input)) { throw "Path does not exist: $input" }
                    if ([System.IO.Path]::HasExtension($input)) {
                        # Process as file.
                        Invoke-MgScriptAnalyzer -FilePath $input -GraphProfile $GraphProfile -UpdatedFilePath $UpdatedFilePath
                    }
                    else {
                        # Process as directory.
                        Read-MgScriptDirectory -DirectoryPath $input -GraphProfile $GraphProfile -UpdatedFilePath $UpdatedFilePath
                    }
                }
            }
        }
    }
}

# TODO: Remove test when done.
#New-MgMigrationPlan -FilePath "C:\Dev\M\msgraph-sdk-powershell\samples\6-Sites.ps1"
#New-MgMigrationPlan -FilePath "C:\Projects\msgraph-sdk-powershell\samples\6-Sites.ps1" -GraphProfile Beta
#New-MgMigrationPlan -FilePath "C:\Projects\msgraph-sdk-powershell\samples\5-Teams.ps1"
#New-MgMigrationPlan -FilePath "C:\Projects\msgraph-sdk-powershell\samples\5-Teams.ps1" -UpdatedFilePath C:\PlayGround
# Test cases:
# 1. Cmdlet with no changes.
# 2. Cmdlet with changes.
# 3. Cmdlet with changes and deprecated parameter.
# 4. Cmdlet with changes and deprecated parameter and new parameter.
# 5. Cmdlet with changes and deprecated parameter and new parameter and new cmdlet.
# 6. Cmdlet with changes and deprecated parameter and new parameter and new cmdlet and new module.
# 7. Empty script file.
# 8. Script file without Microsoft Graph cmdlets.
# 9. Script file with v2.x cmdlets.