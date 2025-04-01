#Load MgCommandMetadata.json file
$CommandMetadataFile = (Join-Path $PSScriptRoot "../src\Authentication/Authentication/custom/common/MgCommandMetadata.json")
#Convert JSON to HashTable
$CommandMetadata = Get-Content $CommandMetadataFile | ConvertFrom-Json -AsHashTable

#Check if Connect-MgGraph is in the list of commands
$ConnectCommand = $CommandMetadata | Where-Object { $_.Name -eq "Connect-MgGraph" }
if ($null -eq $ConnectCommand) {
    #Add Connect-MgGraph to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Connect-MgGraph"
        Method = "POST"
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "System.Object"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/connect-mggraph?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalConnectMgGraphOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalConnectMgGraphOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Connect-MgGraph command added to the list of commands in MgCommandMetadata.json"
}

#Check if Add-MgEnvironment is in the list of commands
$AddEnvironmentCommand = $CommandMetadata | Where-Object { $_.Name -eq "Add-MgEnvironment" }
if ($null -eq $AddEnvironmentCommand) {
    #Add Add-MgEnvironment to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Add-MgEnvironment"
        Method = $null
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "Microsoft.Graph.PowerShell.Authentication.Models.GraphEnvironment"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/add-mgenvironment?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalAddEnvironmentOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalAddEnvironmentOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Add-MgEnvironment command added to the list of commands in MgCommandMetadata.json"
}
#Check if Get-MgEnvironment is in the list of commands
$GetEnvironmentCommand = $CommandMetadata | Where-Object { $_.Name -eq "Get-MgEnvironment" }
if ($null -eq $GetEnvironmentCommand) {
    #Add Get-MgEnvironment to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Get-MgEnvironment"
        Method = $null
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "Microsoft.Graph.PowerShell.Authentication.Models.GraphEnvironment"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/get-mgenvironment?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalGetEnvironmentOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalGetEnvironmentOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Get-MgEnvironment command added to the list of commands in MgCommandMetadata.json"
}
#Check if Remove-MgEnvironment is in the list of commands
$RemoveEnvironmentCommand = $CommandMetadata | Where-Object { $_.Name -eq "Remove-MgEnvironment" }
if ($null -eq $RemoveEnvironmentCommand) {
    #Add Remove-MgEnvironment to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Remove-MgEnvironment"
        Method = $null
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "System.Object"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/remove-mgenvironment?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalRemoveEnvironmentOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalRemoveEnvironmentOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Remove-MgEnvironment command added to the list of commands in MgCommandMetadata.json"
}
#Check if Set-MgEnvironment is in the list of commands
$SetEnvironmentCommand = $CommandMetadata | Where-Object { $_.Name -eq "Set-MgEnvironment" }
if ($null -eq $SetEnvironmentCommand) {
    #Add Set-MgEnvironment to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Set-MgEnvironment"
        Method = $null
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "System.Object"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/set-mgenvironment?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalSetEnvironmentOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalSetEnvironmentOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Set-MgEnvironment command added to the list of commands in MgCommandMetadata.json"
}
#Check if Disconnect-MgGraph is in the list of commands
$DisconnectCommand = $CommandMetadata | Where-Object { $_.Name -eq "Disconnect-MgGraph" }
if ($null -eq $DisconnectCommand) {
    #Add Disconnect-MgGraph to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Disconnect-MgGraph"
        Method = $null
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "Microsoft.Graph.PowerShell.Authentication.IAuthContext"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/disconnect-mggraph?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalDisconnectOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalDisconnectOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Disconnect-MgGraph command added to the list of commands in MgCommandMetadata.json"
}
#Check if Find-MgGraphCommand is in the list of commands
$FindCommand = $CommandMetadata | Where-Object { $_.Name -eq "Find-MgGraphCommand" }
if ($null -eq $FindCommand) {
    #Add Find-MgGraphCommand to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Find-MgGraphCommand"
        Method = $null
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "Microsoft.Graph.PowerShell.Authentication.Models.IGraphCommand"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/find-mggraphcommand?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalFindOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalFindOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Find-MgGraphCommand command added to the list of commands in MgCommandMetadata.json"
}
# Check if Find-MgGraphPermission is in the list of commands
$FindPermissionCommand = $CommandMetadata | Where-Object { $_.Name -eq "Find-MgGraphPermission" }
if ($null -eq $FindPermissionCommand) {
    #Add Find-MgGraphPermission to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Find-MgGraphPermission"
        Method = $null
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "System.Array"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/find-mggraphpermission?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalFindPermissionOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalFindPermissionOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Find-MgGraphPermission command added to the list of commands in MgCommandMetadata.json"
}
#Check if Get-MgContext is in the list of commands
$GetContextCommand = $CommandMetadata | Where-Object { $_.Name -eq "Get-MgContext" }
if ($null -eq $GetContextCommand) {
    #Add Get-MgContext to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Get-MgContext"
        Method = $null
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "Microsoft.Graph.PowerShell.Authentication.IAuthContext"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/get-mgcontext?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalGetContextOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalGetContextOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Get-MgContext command added to the list of commands in MgCommandMetadata.json"
}
#Check if Get-MgGraphOption is in the list of commands
$GetGraphOptionCommand = $CommandMetadata | Where-Object { $_.Name -eq "Get-MgGraphOption" }
if ($null -eq $GetGraphOptionCommand) {
    #Add Get-MgGraphOption to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Get-MgGraphOption"
        Method = $null
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "Microsoft.Graph.PowerShell.Authentication.IGraphOption"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/get-mggraphoption?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalGetGraphOptionOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalGetGraphOptionOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Get-MgGraphOption command added to the list of commands in MgCommandMetadata.json"
}
#Check if Get-MgRequestContext is in the list of commands
$GetRequestContextCommand = $CommandMetadata | Where-Object { $_.Name -eq "Get-MgRequestContext" }
if ($null -eq $GetRequestContextCommand) {
    #Add Get-MgRequestContext to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Get-MgRequestContext"
        Method = $null
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "Microsoft.Graph.PowerShell.Authentication.Core.Interfaces.IRequestContext"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/get-mgrequestcontext?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalGetRequestContextOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalGetRequestContextOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Get-MgRequestContext command added to the list of commands in MgCommandMetadata.json"
}
#Check if Invoke-MgGraphRequest is in the list of commands
$InvokeRequestCommand = $CommandMetadata | Where-Object { $_.Name -eq "Invoke-MgGraphRequest" }
if ($null -eq $InvokeRequestCommand) {
    #Add Invoke-MgGraphRequest to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Invoke-MgGraphRequest"
        Method = $null
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "System.Object"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/invoke-mggraphrequest?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalInvokeRequestOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalInvokeRequestOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Invoke-MgGraphRequest command added to the list of commands in MgCommandMetadata.json"
}
#Check if Set-MgGraphOption is in the list of commands
$SetGraphOptionCommand = $CommandMetadata | Where-Object { $_.Name -eq "Set-MgGraphOption" }
if ($null -eq $SetGraphOptionCommand) {
    #Add Set-MgGraphOption to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Set-MgGraphOption"
        Method = $null
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "System.Object"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/set-mggraphoption?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalSetGraphOptionOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalSetGraphOptionOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Set-MgGraphOption command added to the list of commands in MgCommandMetadata.json"
}
#Check if Set-MgRequestContext is in the list of commands
$SetRequestContextCommand = $CommandMetadata | Where-Object { $_.Name -eq "Set-MgRequestContext" }
if ($null -eq $SetRequestContextCommand) {
    #Add Set-MgRequestContext to the list of commands
    $CommandMetadata += [pscustomobject]@{
        Command = "Set-MgRequestContext"
        Method = $null
        Module = "Authentication"
        CommandAlias = $null
        Permissions = @()
        ApiVersion = $null
        OutputType = "Microsoft.Graph.PowerShell.Authentication.Core.Interfaces.IRequestContext"
        Variants = @()
        ApiReferenceLink = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/set-mgrequestcontext?view=graph-powershell-1.0"
        Uri = $null
    }
   # Update the file
    $FinalSetRequestContextOutPut = $CommandMetadata | ConvertTo-Json -Depth 10
    
    $FinalSetRequestContextOutPut | Set-Content -Path $CommandMetadataFile -Force
    Write-Host "Set-MgRequestContext command added to the list of commands in MgCommandMetadata.json"
}

