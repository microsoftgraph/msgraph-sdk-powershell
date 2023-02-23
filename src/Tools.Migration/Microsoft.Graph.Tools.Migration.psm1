[System.Collections.ArrayList]$LineContent = @()
[System.Collections.ArrayList]$LineNumbers = @()
$LineUpdate = @{}
$Original = @{}
$ProposedChanges = @{}
function Read-MgScriptDirectory {
    param (
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [ValidateNotNullorEmpty()]
        [string] $DirectoryPath
    )

    process {
        $supportedFileTypes = ".ps1", ".psm1"
        Get-ChildItem $DirectoryPath -Recurse -File | ForEach-Object {
            if ($_.Extension -in $supportedFileTypes) {
                Read-MgScript -FilePath $_.FullName -GraphProfile $GraphProfile
                
            }
            else {
                Write-Warning "Skipping unsupported file type: $($_.FullName)"
            }
        }
    }
}

function Read-MgScript {
    param (
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [ValidateNotNullorEmpty()]
        [string] $FilePath,
        [string] $GraphProfile
    )

    process {
        $supportedFileTypes = ".ps1", ".psm1"
        if ($supportedFileTypes -notContains [System.IO.Path]::GetExtension($FilePath)) {
            throw "Unsupported file type: $FilePath"
        }

        $scriptContent = Get-Content $FilePath
        #Write-Host "Read-MgScript: $FilePath :$($scriptContent.Length)"

        $Analysis = Invoke-MgScriptAnalyzer -ScriptContent $scriptContent -GraphProfile $GraphProfile
        $Result = @()
        foreach ($item in $Original.GetEnumerator() | Sort Name) {
            $LineNumber = $item.Key
            $OriginalValue = $Original[$LineNumber].ToString()
            $ProposedValue = $ProposedChanges[$LineNumber].ToString()
            $Result += [pscustomobject]@{"Location" = $FilePath; "Line number" = $LineNumber; "ApiVersion" = "Beta"; "Original" = $OriginalValue; "New" = $ProposedValue }
            
        }
        if($Result.Count -gt 0){
            Write-Host -ForegroundColor Green "--------- Your script(s) contains commands that need to conform to the naming convention as per the 'New' column on the table below ---------"
        }
        Write-Output $Result | Format-Table
    }
}

function Invoke-MgScriptAnalyzer {
    param (
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [ValidateNotNullorEmpty()]
        [PSCustomObject] $ScriptContent,
        [string] $GraphProfile
    )

    # TODO: Analyze script content for breaking change.
    # TODO: Store changes in an object.
    # TODO: Write object as output.
    # TODO: Settle on object members.

    # Proposed Output
    # Order | Location (file name:line:tab) | Type (Cmdlet|CmdletParameter|ModuleName) | ApiVersion | Original | New
 
    $i = 0
    foreach ($_ in $scriptContent) {
        $LineContent.Add($_)

        if ($_ -ieq "Select-MgProfile beta" -or $_ -ieq "Select-MgProfile 'beta'" -or $_ -ieq 'Select-MgProfile "beta"' -or $_ -ieq "Select-MgProfile -Name beta" -or $_ -ieq "Select-MgProfile -Name 'beta'" -or $_ -ieq 'Select-MgProfile -Name "beta"') {
            
            $LineNumbers.Add($i)
        }
    
        $i++
    }
    if ($GraphProfile -ieq "beta") {
        for ($g = 0; $g -lt $LineContent.Count; $g++) {
            if ($LineContent[$g].Contains("Mg")) {
                $Original.Add($g + 1, $LineContent[$g])
                $ProposedChanges.Add($g + 1, $LineContent[$g].ToString().Replace("Mg", "MgBeta"))
            }
        }
    }
    else {
        $Lines = $LineNumbers.Count

        for ($j = 0; $j -lt $Lines; $j++) {
         
            for ($k = $LineNumbers[$j]; $k -lt $LineContent.Count; $k++) {
                if ($LineContent[$k] -ieq "Select-MgProfile v1.0" -or $LineContent[$k] -ieq "Select-MgProfile 'v1.0'" -or $LineContent[$k] -ieq 'select-MgProfile "v1.0"' -or $LineContent[$k] -ieq "Select-MgProfile -Name v1.0" -or $LineContent[$k] -ieq "Select-MgProfile -Name 'v1.0'" -or $LineContent[$k] -ieq 'select-MgProfile -Name "v1.0"') {
            
            
                    if (-not $LineUpdate.ContainsKey($LineNumbers[$j])) {
                        $LineUpdate.Add($LineNumbers[$j], $k)
                    }
                }
            }
        }
        $LineUpdate.Keys | ForEach-Object {
            $LineNumber = $_
            for ($m = $lineNumber + 1; $m -lt $LineUpdate[$LineNumber]; $m++) {
                if ($LineContent[$m].Contains("Mg")) {
                    $Original.Add($m + 1, $LineContent[$m])
                    $ProposedChanges.Add($m + 1, $LineContent[$m].ToString().Replace("Mg", "MgBeta"))
                }
            
            }
        }
        if ($Lines -gt $LineUpdate.Count) {
            for ($n = $LineNumbers[$Lines - 1] + 1; $n -lt $LineContent.Count; $n++) {
                if ($LineContent[$n].Contains("Mg")) {
                    $Original.Add($n + 1, $LineContent[$n])
                    $ProposedChanges.Add($n + 1, $LineContent[$n].ToString().Replace("Mg", "MgBeta"))
                }
            }
        }

    }
    

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
        [string] $GraphProfile
    )

    process {
        switch ($PSCmdlet.ParameterSetName) {
            'File' {
                if (-not (Test-Path $FilePath)) { throw "Path does not exist: $FilePath" }
                Read-MgScript -FilePath $FilePath -GraphProfile $GraphProfile
            }
            'Directory' {
                if (-not (Test-Path $DirectoryPath)) { throw "Path does not exist: $DirectoryPath" }
                Read-MgScriptDirectory -DirectoryPath $DirectoryPath -GraphProfile $GraphProfile
            }
            'FileOrDirectory' {
                foreach ($input in $InputObject) {
                    if (-not (Test-Path $input)) { throw "Path does not exist: $input" }
                    if ([System.IO.Path]::HasExtension($input)) {
                        # Process as file.
                        Read-MgScript -FilePath $input -GraphProfile $GraphProfile
                    }
                    else {
                        # Process as directory.
                        Read-MgScriptDirectory -DirectoryPath $input -GraphProfile $GraphProfile
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