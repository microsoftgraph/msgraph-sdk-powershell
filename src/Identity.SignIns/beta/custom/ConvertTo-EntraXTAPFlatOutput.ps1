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

<#
.Synopsis
    Internal helper: projects a CrossTenantAccessPolicy API response into the flat
    parameter-aligned output shape shared by the *-DefaultEntraXTAP and
    *-PartnerEntraXTAP cmdlets.

.Description
    Decodes the nested TargetConfiguration model back into the flat property names
    that match the new cmdlet input parameters:

    Default mode (IsPartner = $false): emits Id + flat properties.
    Partner mode (IsPartner = $true):  emits PartnerTenantId + flat properties.

    Output property mapping:
      M365CollaborationInbound.Users.accessType         → M365CollaborationInbound  ("Allowed"|"Blocked")
      M365CollaborationInbound.Users.targets[user]      → M365CollaborationInboundTargetUsers
      M365CollaborationOutbound.UsersAndGroups.accessType → M365CollaborationOutbound ("Allowed"|"Blocked")
      M365CollaborationOutbound.UsersAndGroups.targets[user]  → M365CollaborationOutboundTargetUsers
      M365CollaborationOutbound.UsersAndGroups.targets[group] → M365CollaborationOutboundTargetGroups
      AppServiceConnectInbound.Applications.accessType  → AppServiceConnectInbound  ("Allowed"|"Blocked")
      AppServiceConnectInbound.Applications.targets[application] → AppServiceConnectInboundTargetApplications
#>
function ConvertTo-EntraXTAPFlatOutput {
    param(
        [Parameter(Mandatory = $true)]
        $Result,

        [Parameter()]
        [switch]
        $IsPartner
    )

    # Helper: capitalise first letter of accessType for enum output ("allowed" → "Allowed")
    function Format-AccessType {
        param([string]$Value)
        if ([string]::IsNullOrEmpty($Value)) { return $null }
        return [System.Globalization.CultureInfo]::InvariantCulture.TextInfo.ToTitleCase($Value.ToLower())
    }

    # Helper: extract target IDs from a TargetConfiguration for a given targetType.
    function Get-TargetIds {
        param($Config, [string]$TargetType)
        if ($null -eq $Config -or $null -eq $Config.Targets) { return $null }
        $ids = @($Config.Targets | Where-Object { $_.TargetType -eq $TargetType } | ForEach-Object { $_.Target })
        if ($ids.Count -eq 0) { return $null }
        return $ids
    }

    # ------------------------------------------------------------------
    # M365CollaborationInbound  →  .Users  (user targets only)
    # ------------------------------------------------------------------
    $inboundConfig        = if ($null -ne $Result.M365CollaborationInbound) { $Result.M365CollaborationInbound.Users } else { $null }
    $inboundAccessType    = if ($null -ne $inboundConfig) { Format-AccessType $inboundConfig.AccessType } else { $null }
    $inboundUsers         = if ($null -ne $inboundConfig) { Get-TargetIds -Config $inboundConfig -TargetType 'user' } else { $null }

    # ------------------------------------------------------------------
    # M365CollaborationOutbound  →  .UsersAndGroups  (user + group)
    # ------------------------------------------------------------------
    $outboundConfig       = if ($null -ne $Result.M365CollaborationOutbound) { $Result.M365CollaborationOutbound.UsersAndGroups } else { $null }
    $outboundAccessType   = if ($null -ne $outboundConfig) { Format-AccessType $outboundConfig.AccessType } else { $null }
    $outboundUsers        = if ($null -ne $outboundConfig) { Get-TargetIds -Config $outboundConfig -TargetType 'user'  } else { $null }
    $outboundGroups       = if ($null -ne $outboundConfig) { Get-TargetIds -Config $outboundConfig -TargetType 'group' } else { $null }

    # ------------------------------------------------------------------
    # AppServiceConnectInbound  →  .Applications  (application targets)
    # ------------------------------------------------------------------
    $appConfig            = if ($null -ne $Result.AppServiceConnectInbound) { $Result.AppServiceConnectInbound.Applications } else { $null }
    $appAccessType        = if ($null -ne $appConfig) { Format-AccessType $appConfig.AccessType } else { $null }
    $appIds               = if ($null -ne $appConfig) { Get-TargetIds -Config $appConfig -TargetType 'application' } else { $null }

    # ------------------------------------------------------------------
    # Emit flat output — property names match cmdlet input parameters.
    # ------------------------------------------------------------------
    if ($IsPartner) {
        [PSCustomObject]@{
            PartnerTenantId                      = $Result.TenantId
            M365CollaborationInbound             = $inboundAccessType
            M365CollaborationInboundTargetUsers        = $inboundUsers
            M365CollaborationOutbound            = $outboundAccessType
            M365CollaborationOutboundTargetUsers       = $outboundUsers
            M365CollaborationOutboundTargetGroups      = $outboundGroups
            AppServiceConnectInbound             = $appAccessType
            AppServiceConnectInboundTargetApplications = $appIds
        }
    } else {
        [PSCustomObject]@{
            Id                                   = $Result.Id
            IsServiceDefault                     = $Result.IsServiceDefault
            M365CollaborationInbound             = $inboundAccessType
            M365CollaborationInboundTargetUsers        = $inboundUsers
            M365CollaborationOutbound            = $outboundAccessType
            M365CollaborationOutboundTargetUsers       = $outboundUsers
            M365CollaborationOutboundTargetGroups      = $outboundGroups
            AppServiceConnectInbound             = $appAccessType
            AppServiceConnectInboundTargetApplications = $appIds
        }
    }
}

<#
.Synopsis
    Internal helper: projects a M365CapabilityBase API response into the flat
    parameter-aligned output shape shared by the *-DefaultM365XTAPCapability and
    *-PartnerM365XTAPCapability cmdlets.

.Description
    Decodes the nested M365CapabilityInboundAccess model back into the flat
    property names that match the cmdlet input parameters:

      InboundAccess.IsAllowed        → IsAllowed
      InboundAccess.ResourceScopes
        .Included[ResourceType=user]  → IncludedUsers
        .Included[ResourceType=group] → IncludedGroups
        .Excluded[ResourceType=user]  → ExcludedUsers
        .Excluded[ResourceType=group] → ExcludedGroups

    Default mode (IsPartner = $false):
      Emits CapabilityId, LastModifiedDateTime, IsAllowed, Included/Excluded Users/Groups.

    Partner mode (IsPartner = $true):
      Prepends PartnerTenantId before CapabilityId.
#>
function ConvertTo-EntraXTAPM365CapabilityFlatOutput {
    param(
        [Parameter(Mandatory = $true)]
        $Result,

        [Parameter()]
        [switch]
        $IsPartner
    )

    # ------------------------------------------------------------------
    # Helper: extract resource IDs from a scope array for a given type.
    # ------------------------------------------------------------------
    function Get-ScopeIds {
        param($Scopes, [string]$ResourceType)
        if ($null -eq $Scopes) { return $null }
        $ids = @($Scopes | Where-Object { $_.ResourceType -eq $ResourceType } | ForEach-Object { $_.ResourceId })
        if ($ids.Count -eq 0) { return $null }
        return $ids
    }

    $inbound        = $Result.InboundAccess
    $isAllowed      = if ($null -ne $inbound) { $inbound.IsAllowed } else { $null }
    $includedUsers  = $null
    $includedGroups = $null
    $excludedUsers  = $null
    $excludedGroups = $null

    if ($null -ne $inbound -and $null -ne $inbound.ResourceScopes) {
        $includedUsers  = Get-ScopeIds -Scopes $inbound.ResourceScopes.Included -ResourceType 'user'
        $includedGroups = Get-ScopeIds -Scopes $inbound.ResourceScopes.Included -ResourceType 'group'
        $excludedUsers  = Get-ScopeIds -Scopes $inbound.ResourceScopes.Excluded -ResourceType 'user'
        $excludedGroups = Get-ScopeIds -Scopes $inbound.ResourceScopes.Excluded -ResourceType 'group'
    }

    if ($IsPartner) {
        [PSCustomObject]@{
            PartnerTenantId      = $Result.AdditionalProperties['tenantId']
            CapabilityId         = $Result.Name
            LastModifiedDateTime = $Result.LastModifiedDateTime
            IsAllowed            = $isAllowed
            IncludedUsers        = $includedUsers
            IncludedGroups       = $includedGroups
            ExcludedUsers        = $excludedUsers
            ExcludedGroups       = $excludedGroups
        }
    } else {
        [PSCustomObject]@{
            CapabilityId         = $Result.Name
            LastModifiedDateTime = $Result.LastModifiedDateTime
            IsAllowed            = $isAllowed
            IncludedUsers        = $includedUsers
            IncludedGroups       = $includedGroups
            ExcludedUsers        = $excludedUsers
            ExcludedGroups       = $excludedGroups
        }
    }
}

