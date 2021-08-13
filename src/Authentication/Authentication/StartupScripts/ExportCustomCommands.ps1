# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

# Load custom commands
$customScriptCommandDirItem = Get-Item $PSScriptRoot -ErrorAction Ignore
if ( $customScriptCommandDirItem ) {
    $customScriptCommandDir = join-path $customScriptCommandDirItem.FullName ../custom

    Get-ChildItem $customScriptCommandDir -Filter *.ps1 -ErrorAction Stop | ForEach-Object {
        . $_.FullName
    }
}

# Export custom script commands without removing the
# binary cmdlets. Custom script commands are functions,
# the cmdlets are.. cmdlets. We must explicitly specify
# both functions and cmdlets at export; if only one of
# these classes is specified, nothing of the other
# class will be exported.
Export-ModuleMember -Function * -Cmdlet *

