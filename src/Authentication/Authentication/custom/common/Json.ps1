# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2

function Json_ConvertJsonToHashtable {
    param(
        [Parameter(Mandatory = $true, Position = 1)]
        [string]$Path
    )
    $Hashtable = @{}
    try {
        $FileProvider = [Microsoft.Graph.PowerShell.Authentication.Common.ProtectedFileProvider]::CreateFileProvider($Path, [Microsoft.Graph.PowerShell.Authentication.Common.FileProtection]::SharedRead)
        if ($PSEdition -eq "Core") {
            $Hashtable = $FileProvider.CreateReader().ReadToEnd() | ConvertFrom-Json -AsHashtable
        }
        else {
            $DeserializationError = $null
            $Hashtable = [Microsoft.Graph.PowerShell.Authentication.Helpers.StringUtil]::ConvertFromJson($FileProvider.CreateReader().ReadToEnd(), $true, 4, [ref] $DeserializationError)
            if ($null -ne $DeserializationError) { throw $DeserializationError }
        }
    }
    finally {
        $FileProvider.Dispose()
    }
    return $Hashtable
}