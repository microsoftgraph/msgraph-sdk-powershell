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
                $scriptContent = Read-MgScript -FilePath $_.FullName
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
        [string] $FilePath
    )

    process {
        $supportedFileTypes = ".ps1", ".psm1"
        if ($supportedFileTypes -notContains [System.IO.Path]::GetExtension($FilePath)) {
            throw "Unsupported file type: $FilePath"
        }

        $scriptContent = Get-Content $FilePath
        Write-Host "Read-MgScript: $FilePath :$($scriptContent.Length)"

        $analysis = Invoke-MgScriptAnalyzer -ScriptContent $scriptContent

        Write-Output $scriptContent
    }
}

function Invoke-MgScriptAnalyzer {
    param (
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [ValidateNotNullorEmpty()]
        [PSCustomObject] $ScriptContent
    )

    # TODO: Analyze script content for breaking change.
    # TODO: Store changes in an object.
    # TODO: Write object as output.
    # TODO: Settle on object members.

    # Proposed Output
    # Order | Location (file name:line:tab) | Type (Cmdlet|CmdletParameter|ModuleName) | ApiVersion | Original | New
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
        [PSCustomObject] $InputObject
    )

    process {
        switch ($PSCmdlet.ParameterSetName) {
            'File' {
                if (-not (Test-Path $FilePath)) { throw "Path does not exist: $FilePath" }
                Read-MgScript -FilePath $FilePath
            }
            'Directory' {
                if (-not (Test-Path $DirectoryPath)) { throw "Path does not exist: $DirectoryPath" }
                Read-MgScriptDirectory -DirectoryPath $DirectoryPath
            }
            'FileOrDirectory' {
                foreach ($input in $InputObject) {
                    if (-not (Test-Path $input)) { throw "Path does not exist: $input" }
                    if ([System.IO.Path]::HasExtension($input)) {
                        # Process as file.
                        Read-MgScript -FilePath $input
                    }
                    else {
                        # Process as directory.
                        Read-MgScriptDirectory -DirectoryPath $input
                    }
                }
            }
        }
    }
}

# TODO: Remove test when done.
# New-MgMigrationPlan -FilePath "C:\Dev\M\msgraph-sdk-powershell\samples\6-Sites.ps1"

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