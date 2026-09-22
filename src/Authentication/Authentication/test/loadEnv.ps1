# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------
$envFile = 'env.json'
if ($TestMode -eq 'live') {
    $envFile = 'localEnv.json'
}

if (Test-Path -Path (Join-Path $PSScriptRoot $envFile)) {
    $envFilePath = Join-Path $PSScriptRoot $envFile
} else {
    $envFilePath = Join-Path $PSScriptRoot '..\$envFile'
}
# Microsoft.Graph.Authentication.Core is loaded into a private AssemblyLoadContext on PowerShell 7+, so its types cannot be
# referenced with type literals like [Microsoft.Graph.PowerShell.Authentication.GraphSession]. Resolve them from the
# already-loaded assembly instead.
function Get-MgCoreType {
    param([Parameter(Mandatory)][string]$TypeName)
    $asm = [AppDomain]::CurrentDomain.GetAssemblies() | Where-Object { $_.GetName().Name -eq 'Microsoft.Graph.Authentication.Core' } | Select-Object -First 1
    if ($null -eq $asm) { throw 'Microsoft.Graph.Authentication.Core is not loaded. Import the module first.' }
    return $asm.GetType($TypeName, $true)
}

function Get-MgGraphSessionInstance {
    return (Get-MgCoreType 'Microsoft.Graph.PowerShell.Authentication.GraphSession').GetProperty('Instance').GetValue($null)
}

$env = @{}
if (Test-Path -Path $envFilePath) {
    # Load dummy auth configuration. This is used to run Pester tests.
    $env = Get-Content (Join-Path $PSScriptRoot $envFile) | ConvertFrom-Json -AsHashTable
    $authContext = [Activator]::CreateInstance((Get-MgCoreType 'Microsoft.Graph.PowerShell.Authentication.AuthContext'))
    $authContext.ClientId = $env.ClientId
    $authContext.TenantId = $env.TenantId
    $authContext.AuthType = [Enum]::Parse((Get-MgCoreType 'Microsoft.Graph.PowerShell.Authentication.AuthenticationType'), 'UserProvidedAccessToken')
    $authContext.TokenCredentialType = [Enum]::Parse((Get-MgCoreType 'Microsoft.Graph.PowerShell.Authentication.TokenCredentialType'), 'UserProvidedAccessToken')
    (Get-MgGraphSessionInstance).AuthContext = $authContext
}