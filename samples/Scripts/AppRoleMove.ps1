<#
.SYNOPSIS
    Migrates users and groups assigned the implicit "Default Access" role on a
    Microsoft Entra enterprise application to an explicit "User" app role, in a
    safe and auditable way.

.DESCRIPTION
    AppRoleMove.ps1 manages app role assignments for an enterprise application
    (service principal) in Microsoft Entra ID using the Microsoft Graph
    PowerShell SDK.

    Option 1 (Fix assignments): creates a "User" app role on the backing app
    registration if it does not already exist, assigns it to users/groups that
    are currently on Default Access, then removes Default Access only after the
    User role is successfully assigned. Generates CSV/JSON before/after reports.

    Option 2 (Report only): makes no changes; reports the current assignments.

    Use -DryRun with Option 1 to simulate changes without performing any
    Microsoft Graph write operations.

.PARAMETER TenantId
    Microsoft Entra tenant ID.

.PARAMETER ServicePrincipalId
    Object ID of the enterprise application (service principal), not the App ID.

.EXAMPLE
    .\AppRoleMove.ps1 -TenantId <TenantId> -ServicePrincipalId <SpId> -Option 1 -DryRun
    Previews the changes without modifying the tenant (recommended first step).

.EXAMPLE
    .\AppRoleMove.ps1 -TenantId <TenantId> -ServicePrincipalId <SpId> -Option 1
    Creates the User role, reassigns principals, and removes Default Access.

.EXAMPLE
    .\AppRoleMove.ps1 -TenantId <TenantId> -ServicePrincipalId <SpId> -Option 2
    Report only; makes no changes.

.NOTES
    Author : Jeevan Desarda (GitHub: @jeevansd)
    Module : Microsoft Graph PowerShell SDK (Microsoft.Graph)

    Required Microsoft Graph permissions (admin consent required):
      - Application.ReadWrite.All
      - AppRoleAssignment.ReadWrite.All
      - Directory.Read.All

    DISCLAIMER:
    This sample script is not an official Microsoft product and is provided
    "AS IS" without warranty of any kind. It is not supported under any
    Microsoft standard support program or service. Always run with -DryRun and
    review the generated reports before executing changes against a tenant.

.LINK
    https://learn.microsoft.com/powershell/microsoftgraph/
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)]
    [string] $TenantId,

    [Parameter(Mandatory = $true)]
    [string] $ServicePrincipalId,

    # Optional: allow non-interactive execution
    [ValidateSet("1","2")]
    [string] $Option,

    [string] $NewRoleDisplayName = "User",
    [string] $NewRoleValue = "User",
    [string] $NewRoleDescription = "User role for Users/Groups",

    # Propagation wait (role created on App must appear on SP)
    [int] $MaxAttempts = 60,
    [int] $DelaySeconds = 5,

    # Scope of principals to target
    [ValidateSet("Both","UsersOnly","GroupsOnly")]
    [string] $PrincipalScope = "Both",

    # If not provided, defaults to <scriptdir>\Reports
    [string] $ReportPath,

    [switch] $EnableTranscript,

    # customer-friendly dry run (no Graph writes)
    [switch] $DryRun
)

# ==============================
# Robust ScriptDir + ReportPath
# ==============================
$ScriptDir = if ($PSScriptRoot) {
    $PSScriptRoot
} elseif ($PSCommandPath) {
    Split-Path -Parent $PSCommandPath
} else {
    (Get-Location).Path
}

if ([string]::IsNullOrWhiteSpace($ReportPath)) {
    $ReportPath = Join-Path $ScriptDir "Reports"
}
elseif (-not [System.IO.Path]::IsPathRooted($ReportPath)) {
    $ReportPath = Join-Path $ScriptDir $ReportPath
}

# ==============================
# Constants / Helpers
# ==============================
$DefaultAccessRoleId = [Guid]"00000000-0000-0000-0000-000000000000"

function Write-Section([string]$text) {
    Write-Host ""
    Write-Host "=== $text ===" -ForegroundColor Cyan
}

function Ensure-Folder([string]$Path) {
    if ([string]::IsNullOrWhiteSpace($Path)) {
        throw "Ensure-Folder: Path is empty."
    }
    try {
        if (-not (Test-Path -LiteralPath $Path)) {
            New-Item -ItemType Directory -Path $Path -Force -ErrorAction Stop | Out-Null
        }
    }
    catch {
        throw "Ensure-Folder failed for '$Path' : $($_.Exception.Message)"
    }
}

function New-RunId {
    (Get-Date).ToString("yyyy-MM-dd_HH-mm-ss.fff")
}

function Select-OptionIfMissing {
    if ($script:Option) { return }

    Write-Section "Select an option"
    Write-Host "1. Create 'User' role if missing; move ONLY Default Access -> 'User' (then remove Default Access)"
    Write-Host "2. Report Only (no changes)"

    $script:Option = Read-Host "Enter option number (1 or 2)"
    if ($script:Option -notin @("1","2")) {
        throw "Invalid option. Choose 1 or 2."
    }
}

function Invoke-WithRetry {
    param(
        [Parameter(Mandatory)]
        [scriptblock] $Script,

        [int] $MaxRetries = 4,
        [int] $DelaySeconds = 2
    )

    for ($i = 1; $i -le $MaxRetries; $i++) {
        try {
            return & $Script
        }
        catch {
            $msg = $_.Exception.Message
            if ($i -ge $MaxRetries) {
                throw
            }
            Write-Warning "Transient Graph error. Retrying ($i/$MaxRetries). Error: $msg"
            Start-Sleep -Seconds $DelaySeconds
        }
    }
}

function Connect-Graph([string]$TenantId) {
    $scopes = @(
        "Directory.Read.All",
        "Application.ReadWrite.All",
        "AppRoleAssignment.ReadWrite.All"
    )

    Write-Section "Connect to Microsoft Graph"
    Connect-MgGraph -TenantId $TenantId -Scopes $scopes -NoWelcome | Out-Null

    $ctx = Get-MgContext
    Write-Host ("Connected to tenant : {0}" -f $ctx.TenantId)
    Write-Host ("Mode               : {0}" -f $(if($DryRun){"DryRun (preview only)"} else {"Execute"}))
}

function Get-AppAndSp([string]$SpId) {
    Write-Section "Load Service Principal + backing Application"

    $sp = Invoke-WithRetry {
        Get-MgServicePrincipal -ServicePrincipalId $SpId -Property Id,AppId,DisplayName,AppRoles -ErrorAction Stop
    }

    if (-not $sp) { throw "Service principal not found: $SpId" }

    $app = Invoke-WithRetry {
        Get-MgApplication -Filter "appId eq '$($sp.AppId)'" -Property Id,AppId,DisplayName,AppRoles -ErrorAction Stop
    }

    if (-not $app) { throw "Application object not found for appId: $($sp.AppId)" }

    Write-Host "Enterprise App (SP) : $($sp.DisplayName) [$($sp.Id)]"
    Write-Host "Backed by App (App) : $($app.DisplayName) [$($app.Id)]"
    return @{ sp = $sp; app = $app }
}

function Find-RoleOnApp($app, [string]$DisplayName, [string]$Value) {
    if (-not $app.AppRoles) { return $null }

    return ($app.AppRoles |
        Where-Object { $_.DisplayName -eq $DisplayName -or $_.Value -eq $Value } |
        Select-Object -First 1)
}

function Validate-RoleIsUserAssignable($role) {
    if (-not $role.IsEnabled) {
        throw "Existing role '$($role.DisplayName)' is disabled. Enable it or choose another role."
    }

    $allowed = @()
    if ($role.AllowedMemberTypes) { $allowed = @($role.AllowedMemberTypes) }

    # In Entra app roles, AllowedMemberTypes containing 'User' means the role is assignable to Users AND Groups.
    if ($allowed -notcontains "User") {
        throw "Role '$($role.DisplayName)' is not assignable to Users/Groups. AllowedMemberTypes must include 'User'. Current: $($allowed -join ', ')"
    }

    if ($allowed -contains "Application" -and $allowed -contains "User") {
        Write-Warning "Role '$($role.DisplayName)' is assignable to both Users/Groups and Applications (AllowedMemberTypes includes 'Application')."
    }
}

function Ensure-UserRole($app, [string]$DisplayName, [string]$Value, [string]$Description) {
    $existingRole = Find-RoleOnApp -app $app -DisplayName $DisplayName -Value $Value
    if ($existingRole) {
        Validate-RoleIsUserAssignable -role $existingRole
        $rid = [Guid]$existingRole.Id
        Write-Host "App role already exists: '$DisplayName' Id=$rid"
        return @{ RoleId = $rid; Created = $false }
    }

    $newRoleId = [Guid]::NewGuid()
    $newRole = @{
        allowedMemberTypes = @("User")
        description        = $Description
        displayName        = $DisplayName
        id                 = $newRoleId
        isEnabled          = $true
        value              = $Value
        origin             = "Application"
    }

    $updatedRoles = @()
    if ($app.AppRoles) { $updatedRoles += $app.AppRoles }
    $updatedRoles += $newRole

    if ($DryRun) {
        Write-Host "DryRun: Would create app role '$DisplayName' on Application $($app.Id)"
    } else {
        Invoke-WithRetry {
            Update-MgApplication -ApplicationId $app.Id -BodyParameter @{ appRoles = $updatedRoles } -ErrorAction Stop
        }
        Write-Host "Created app role '$DisplayName'"
    }

    return @{ RoleId = $newRoleId; Created = $true }
}

function Wait-RoleVisibleOnSp([string]$SpId, [Guid]$RoleId, [int]$Max, [int]$Delay) {
    Write-Section "Wait for role propagation to Service Principal"
    $attempt = 0
    do {
        $attempt++

        $spCheck = Invoke-WithRetry {
            Get-MgServicePrincipal -ServicePrincipalId $SpId -Property Id,AppRoles -ErrorAction Stop
        }

        $visible = $false
        if ($spCheck.AppRoles) { $visible = ($spCheck.AppRoles.Id -contains $RoleId) }

        if ($visible) {
            Write-Host "Role is visible on the Service Principal. Proceeding..."
            return
        }

        Write-Host "Waiting for role to appear (attempt $attempt/$Max)..."
        Start-Sleep -Seconds $Delay
    } until ($attempt -ge $Max)

    throw "Role Id $RoleId is not visible on the Service Principal after $Max attempts."
}

function Get-Assignments([string]$SpId) {
    Write-Section "Get current assignments"

    $a = Invoke-WithRetry {
        Get-MgServicePrincipalAppRoleAssignedTo -ServicePrincipalId $SpId -All -ErrorAction Stop
    }

    $count = 0
    if ($a) { $count = $a.Count }
    Write-Host "Found $count existing assignments on this Enterprise App."
    return $a
}

function Get-ScopeTypes {
    switch ($PrincipalScope) {
        "UsersOnly"  { return @("User") }
        "GroupsOnly" { return @("Group") }
        default      { return @("User","Group") }
    }
}

function Get-TargetPrincipalIds($assignments, [bool]$DefaultOnly, $validAppRoleIds) {
    $types = Get-ScopeTypes
    $q = $assignments | Where-Object { $_.PrincipalType -in $types }

    if ($DefaultOnly) {
        # Include Default Access, orphaned (null/empty AppRoleId), AND roles that no longer exist
        $q = $q | Where-Object { 
            $_.AppRoleId -eq $DefaultAccessRoleId -or
            [string]::IsNullOrWhiteSpace($_.AppRoleId) -or
            $_.AppRoleId -eq [Guid]::Empty -or
            ($validAppRoleIds -and $_.AppRoleId -notin $validAppRoleIds)
        }
    }

    return ($q | Select-Object -ExpandProperty PrincipalId -Unique)
}

function Get-OrphanedAssignments($assignments, $validAppRoleIds) {
    $types = Get-ScopeTypes
    return @($assignments | Where-Object { 
        $_.PrincipalType -in $types -and
        (
            [string]::IsNullOrWhiteSpace($_.AppRoleId) -or 
            $_.AppRoleId -eq [Guid]::Empty -or
            ($validAppRoleIds -and $_.AppRoleId -notin $validAppRoleIds)
        )
    })
}

function Get-ValidAppRoleIds($app) {
    # Get all valid app role IDs from the application, including Default Access
    $validIds = @($DefaultAccessRoleId)
    if ($app.AppRoles) {
        $validIds += @($app.AppRoles | Select-Object -ExpandProperty Id)
    }
    return $validIds
}

function Build-AlreadyHasRoleIndex($assignments, [Guid]$RoleId) {
    $index = @{}
    foreach ($a in ($assignments | Where-Object { $_.AppRoleId -eq $RoleId })) {
        $index[$a.PrincipalId] = $true
    }
    return $index
}

function Assign-RoleToPrincipals(
    [string]$SpId,
    [Guid]$RoleId,
    [Guid[]]$PrincipalIds,
    $alreadyIndex,
    [ref]$changeLog
) {
    Write-Section "Assign role to principals"
    $planned = 0; $skipped = 0; $failed = 0

    foreach ($principalid in $PrincipalIds) {
        if ($alreadyIndex.ContainsKey($principalid)) {
            $skipped++
            continue
        }

        try {
            if ($DryRun) {
                Write-Host "DryRun: Would assign 'User' role to principal $principalid"
                $planned++
                $alreadyIndex[$principalid] = $true
                $changeLog.Value += [pscustomobject]@{
                    action      = "AssignUserRole"
                    principalId = $principalid
                    status      = "Planned"
                    message     = ""
                }
                continue
            }

            Invoke-WithRetry {
                New-MgServicePrincipalAppRoleAssignedTo `
                    -ServicePrincipalId $SpId `
                    -BodyParameter @{
                        principalId = $principalid
                        resourceId  = $SpId
                        appRoleId   = $RoleId
                    } `
                    -ErrorAction Stop | Out-Null
            }

            $planned++
            $alreadyIndex[$principalid] = $true
            $changeLog.Value += [pscustomobject]@{
                action      = "AssignUserRole"
                principalId = $principalid
                status      = "Success"
                message     = ""
            }
        }
        catch {
            $failed++
            $msg = $_.Exception.Message
            $changeLog.Value += [pscustomobject]@{
                action      = "AssignUserRole"
                principalId = $principalid
                status      = "Failed"
                message     = $msg
            }
            Write-Warning "Failed to assign role to principalId=$principalid : $msg"
        }
    }

    return @{ Planned = $planned; Skipped = $skipped; Failed = $failed }
}

function Remove-InvalidAssignments(
    [string]$SpId,
    $assignmentsSnapshot,
    [Guid[]]$PrincipalIds,
    $alreadyIndex,
    $validAppRoleIds,
    [ref]$changeLog
) {
    Write-Section "Remove Invalid Assignments (Default Access and Orphaned)"
    $planned = 0; $skipped = 0; $failed = 0

    foreach ($principalid in $PrincipalIds) {
        # Remove invalid assignments only after the principal has or will have User role
        if (-not $alreadyIndex.ContainsKey($principalid)) { continue }

        # Find all invalid assignments: Default Access OR orphaned (role no longer exists)
        $invalidAssignments = $assignmentsSnapshot | Where-Object {
            $_.PrincipalId -eq $principalid -and
            $_.PrincipalType -in @("User","Group") -and
            (
                $_.AppRoleId -eq $DefaultAccessRoleId -or
                [string]::IsNullOrWhiteSpace($_.AppRoleId) -or
                $_.AppRoleId -eq [Guid]::Empty -or
                ($validAppRoleIds -and $_.AppRoleId -notin $validAppRoleIds)
            )
        }

        if (-not $invalidAssignments) {
            $skipped++
            continue
        }

        foreach ($assignment in @($invalidAssignments)) {
            $isDefaultAccess = ($assignment.AppRoleId -eq $DefaultAccessRoleId)
            $actionName = if ($isDefaultAccess) { "RemoveDefaultAccess" } else { "RemoveOrphanedAssignment" }
            $displayType = if ($isDefaultAccess) { "Default Access" } else { "Orphaned assignment (AppRoleId: $($assignment.AppRoleId))" }

            try {
                if ($DryRun) {
                    Write-Host "DryRun: Would remove $displayType from principal $principalid"
                    $planned++
                    $changeLog.Value += [pscustomobject]@{
                        action       = $actionName
                        principalId  = $principalid
                        assignmentId = $assignment.Id
                        appRoleId    = $assignment.AppRoleId
                        status       = "Planned"
                        message      = ""
                    }
                    continue
                }

                Invoke-WithRetry {
                    Remove-MgServicePrincipalAppRoleAssignedTo `
                        -ServicePrincipalId $SpId `
                        -AppRoleAssignmentId $assignment.Id `
                        -ErrorAction Stop | Out-Null
                }

                $planned++
                $changeLog.Value += [pscustomobject]@{
                    action       = $actionName
                    principalId  = $principalid
                    assignmentId = $assignment.Id
                    appRoleId    = $assignment.AppRoleId
                    status       = "Success"
                    message      = ""
                }
            }
            catch {
                $failed++
                $msg = $_.Exception.Message
                $changeLog.Value += [pscustomobject]@{
                    action       = $actionName
                    principalId  = $principalid
                    assignmentId = $assignment.Id
                    appRoleId    = $assignment.AppRoleId
                    status       = "Failed"
                    message      = $msg
                }
                Write-Warning "Failed to remove $displayType for principalId=$principalid assignmentId=$($assignment.Id): $msg"
            }
        }
    }

    return @{ Planned = $planned; Skipped = $skipped; Failed = $failed }
}

function Simulate-AssignmentsAfter(
    $assignmentsBefore,
    [Guid]$roleId,
    [Guid[]]$targetPrincipalIds,
    [bool]$removeInvalid,
    $validAppRoleIds
) {
    $after = New-Object System.Collections.Generic.List[object]
    $types = @("User","Group")
    $alreadyHasRole = @{}

    foreach ($a in ($assignmentsBefore | Where-Object { $_.AppRoleId -eq $roleId })) {
        $alreadyHasRole[$a.PrincipalId] = $true
    }

    foreach ($a in $assignmentsBefore) {
        $after.Add([pscustomobject]@{
            Id                   = $a.Id
            PrincipalId          = $a.PrincipalId
            PrincipalType        = $a.PrincipalType
            PrincipalDisplayName = $a.PrincipalDisplayName
            AppRoleId            = $a.AppRoleId
        })
    }

    foreach ($principalid in $targetPrincipalIds) {
        if (-not $alreadyHasRole.ContainsKey($principalid)) {
            $after.Add([pscustomobject]@{
                Id                   = "PLANNED-" + ([Guid]::NewGuid().ToString())
                PrincipalId          = $principalid
                PrincipalType        = ""
                PrincipalDisplayName = ""
                AppRoleId            = $roleId
            })
            $alreadyHasRole[$principalid] = $true
        }
    }

    if ($removeInvalid) {
        # Remove both Default Access AND orphaned assignments (role no longer exists)
        $after = $after | Where-Object {
            $dominated = $_.PrincipalId -in $targetPrincipalIds -and $_.PrincipalType -in $types
            $isDefaultAccess = $_.AppRoleId -eq $DefaultAccessRoleId
            $isOrphaned = $validAppRoleIds -and $_.AppRoleId -notin $validAppRoleIds
            
            -not ($dominated -and ($isDefaultAccess -or $isOrphaned))
        }
    }

    return $after
}

function Export-Reports(
    [string]$BasePath,
    [string]$RunId,
    $sp,
    $app,
    $assignmentsBefore,
    $assignmentsAfter,
    $summary,
    $changeLog
) {
    Write-Section "Export report"
    Ensure-Folder -Path $BasePath
    $prefix = Join-Path $BasePath "AppRoleMove_$RunId"

    $summary | ConvertTo-Json -Depth 10 | Set-Content -Path "$prefix.summary.json" -Encoding UTF8 -ErrorAction Stop

    $assignmentsBefore |
        Select-Object Id,PrincipalId,PrincipalType,PrincipalDisplayName,AppRoleId |
        Export-Csv -Path "$prefix.assignments.before.csv" -NoTypeInformation -Encoding UTF8 -ErrorAction Stop

    if ($assignmentsAfter) {
        $assignmentsAfter |
            Select-Object Id,PrincipalId,PrincipalType,PrincipalDisplayName,AppRoleId |
            Export-Csv -Path "$prefix.assignments.after.csv" -NoTypeInformation -Encoding UTF8 -ErrorAction Stop
    }

    Write-Host "Reports written:"
    Write-Host " $prefix.summary.json"
    Write-Host " $prefix.assignments.before.csv"
    if ($assignmentsAfter) { Write-Host " $prefix.assignments.after.csv" }
}

# ==============================
# Main
# ==============================
$runId = New-RunId
Ensure-Folder -Path $ReportPath

Write-Section "Start"
Write-Host ("Mode : {0}" -f $(if($DryRun){"DryRun (preview only)"} else {"Execute"}))

if ($EnableTranscript) {
    try {
        Start-Transcript -Path (Join-Path $ReportPath "AppRoleMove_$runId.transcript.txt") -ErrorAction Stop | Out-Null
    }
    catch {
        Write-Warning "Could not start transcript: $($_.Exception.Message)"
    }
}

try {
    Select-OptionIfMissing
    Connect-Graph -TenantId $TenantId

    $objs = Get-AppAndSp -SpId $ServicePrincipalId
    $sp   = $objs.sp
    $app  = $objs.app

    $assignmentsBefore = Get-Assignments -SpId $sp.Id

    if (-not $assignmentsBefore -or $assignmentsBefore.Count -eq 0) {
        Write-Section "No assignments detected"
        Write-Host "This Enterprise Application currently has no users or groups assigned."
        Write-Host "Nothing to process, and reports will not be generated."
        return
    }

    $reportOnly  = ($Option -eq "2")
    $defaultOnly = ($Option -eq "1")
    $moveDefault = ($Option -eq "1") # Option 1 removes Default Access

    # Determine RoleId
    $roleId = $null
    $roleCreated = $false
    if ($Option -eq "1") {
        Write-Section "Option 1"
        $r = Ensure-UserRole -app $app -DisplayName $NewRoleDisplayName -Value $NewRoleValue -Description $NewRoleDescription
        $roleId = [Guid]$r.RoleId
        $roleCreated = [bool]$r.Created
    }
    else {
        Write-Section "Option 2"
        $existingRole = Find-RoleOnApp -app $app -DisplayName $NewRoleDisplayName -Value $NewRoleValue
        if ($existingRole) {
            try {
                Validate-RoleIsUserAssignable -role $existingRole
                $roleId = [Guid]$existingRole.Id
            }
            catch {
                $roleId = $null
            }
        }
    }

    # Get valid app role IDs from the application (to detect orphaned assignments with deleted roles)
    $validAppRoleIds = Get-ValidAppRoleIds -app $app
    Write-Host "Valid app role IDs on application: $($validAppRoleIds.Count)"

    $countDefault = @($assignmentsBefore | Where-Object { $_.AppRoleId -eq $DefaultAccessRoleId }).Count
    $countNewRole = if ($roleId) {
        @($assignmentsBefore | Where-Object { $_.AppRoleId -eq $roleId }).Count
    } else { 0 }

    # Get orphaned assignments (null/empty AppRoleId OR role no longer exists on app)
    $orphanedAssignments = Get-OrphanedAssignments -assignments $assignmentsBefore -validAppRoleIds $validAppRoleIds
    $countOrphaned = $orphanedAssignments.Count
    $orphanedPrincipalIds = @($orphanedAssignments | Select-Object -ExpandProperty PrincipalId -Unique)

    $targetPrincipalIds = Get-TargetPrincipalIds -assignments $assignmentsBefore -DefaultOnly:$defaultOnly -validAppRoleIds $validAppRoleIds

    Write-Section "Summary"
    Write-Host ("Option selected                : {0}" -f $Option)
    Write-Host ("Users/Groups in scope          : {0}" -f $targetPrincipalIds.Count)
    Write-Host ("  - Default Access assignments : {0}" -f $countDefault)
    Write-Host ("  - Orphaned assignments       : {0}" -f $countOrphaned)
    Write-Host ("User role will be assigned     : {0}" -f $(if($reportOnly){"No"} else {"Yes"}))
    Write-Host ("Default Access will be removed : {0}" -f $(if($moveDefault -and -not $reportOnly){"Yes"} else {"No"}))

    if ($DryRun) {
        Write-Host ""
        Write-Host "DRY RUN: Preview only. No changes will be made." -ForegroundColor Yellow
    }

    $changeLog = @()
    $summary = [ordered]@{
        runId                      = $runId
        mode                       = $(if($DryRun){"DryRun"} else {"Execute"})
        option                     = $Option
        enterpriseApp              = $sp.DisplayName
        servicePrincipalId         = $sp.Id
        usersOrGroupsInScope       = $targetPrincipalIds.Count
        userRoleAssigned           = $(if($reportOnly){$false}else{$true})
        defaultAccessRemoved       = $(if($reportOnly){$false}else{$moveDefault})
        defaultAccessBefore        = $countDefault
        orphanedAssignmentsBefore  = $countOrphaned
        orphanedPrincipalIds       = $orphanedPrincipalIds
    }

    if ($reportOnly) {
        Write-Section "Report Only"
        Write-Host "No changes will be made."
        Export-Reports -BasePath $ReportPath -RunId $runId -sp $sp -app $app `
            -assignmentsBefore $assignmentsBefore -assignmentsAfter $null -summary $summary -changeLog $changeLog
        return
    }

    # Wait for propagation only in Execute; in DryRun skip wait because role is not actually created
    if ($roleCreated -and $DryRun) {
        Write-Section "Wait for role propagation to Service Principal"
        Write-Host "DryRun: skipping propagation wait (role not actually created)."
    }
    else {
        Wait-RoleVisibleOnSp -SpId $sp.Id -RoleId $roleId -Max $MaxAttempts -Delay $DelaySeconds
    }

    if (-not $targetPrincipalIds -or $targetPrincipalIds.Count -eq 0) {
        Write-Section "No target principals"
        Write-Host "No target principals found for this option/scope. Nothing to do."
        Export-Reports -BasePath $ReportPath -RunId $runId -sp $sp -app $app `
            -assignmentsBefore $assignmentsBefore -assignmentsAfter $null -summary $summary -changeLog $changeLog
        return
    }

    $alreadyIndex = Build-AlreadyHasRoleIndex -assignments $assignmentsBefore -RoleId $roleId

    $assignResult = Assign-RoleToPrincipals -SpId $sp.Id -RoleId $roleId `
        -PrincipalIds $targetPrincipalIds -alreadyIndex $alreadyIndex -changeLog ([ref]$changeLog)

    if ($moveDefault) {
        $removeResult = Remove-InvalidAssignments -SpId $sp.Id -assignmentsSnapshot $assignmentsBefore `
            -PrincipalIds $targetPrincipalIds -alreadyIndex $alreadyIndex -validAppRoleIds $validAppRoleIds -changeLog ([ref]$changeLog)
    }

    Write-Section "Result"
    Write-Host ("Users/Groups processed         : {0}" -f $targetPrincipalIds.Count)
    Write-Host ("User role assigned             : {0}" -f $(if($reportOnly){"No"} else {"Yes"}))
    Write-Host ("Invalid assignments removed    : {0}" -f $(if($moveDefault){"Yes"} else {"No"}))

    # AFTER snapshot: simulate in DryRun; fetch real in Execute
    if ($DryRun) {
        $assignmentsAfter = Simulate-AssignmentsAfter -assignmentsBefore $assignmentsBefore -roleId $roleId `
            -targetPrincipalIds $targetPrincipalIds -removeInvalid:$moveDefault -validAppRoleIds $validAppRoleIds
    }
    else {
        $assignmentsAfter = Get-Assignments -SpId $sp.Id
    }

    Export-Reports -BasePath $ReportPath -RunId $runId -sp $sp -app $app `
        -assignmentsBefore $assignmentsBefore -assignmentsAfter $assignmentsAfter -summary $summary -changeLog $changeLog
}
finally {
    if ($EnableTranscript) {
        try { Stop-Transcript | Out-Null } catch {}
    }
}