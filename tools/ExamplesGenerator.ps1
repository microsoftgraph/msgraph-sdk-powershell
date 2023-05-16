# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    $ModulesToGenerate = @(),
    $Available = @(),
    [hashtable]$V1CommandGetVariantList= @{},
    [hashtable]$BetaCommandGetVariantList= @{},
    [hashtable]$V1CommandListVariantList= @{},
    [hashtable]$BetaCommandListVariantList= @{},
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
    [string] $FolderForExamplesToBeReviewed = (Join-Path $PSScriptRoot "..\examplesreport"),
    [string] $ExamplesToBeReviewed = "ExamplesToBeReviewed.csv",
    $MetaDataJsonFile = (Join-Path $PSScriptRoot "../src/Authentication/Authentication/custom/common/MgCommandMetadata.json")
)
function Start-Generator {
    Param(
        $ModulesToGenerate = @(),
        [ValidateNotNullOrEmpty()]
        [string] $GenerationMode = "auto",
        [string] $GraphCommand = "Get-MgUser",
        [string] $GraphModule = "Users",
        [string] $ProfilePath = "v1.0",
        [string] $ManualExternalDocsUrl = "https://learn.microsoft.com/en-us/graph/api/user-get?view=graph-rest-1.0&tabs=powershell"
    )

    $GraphMapping = @{
        "v1.0" = "v1.0\examples"
        "beta" = "beta\examples"
    }
    if ($GenerationMode -eq "auto") {
        $GraphMapping.Keys | ForEach-Object {
            $graphProfile = $_
            Get-FilesByProfile -GraphProfile $graphProfile -GraphProfilePath $GraphMapping[$graphProfile] -ModulesToGenerate $ModulesToGenerate 
        }
    }
    else {
          
        $ProfilePathMapping = "v1.0\examples"
        if ($ProfilePath -eq "beta") {
            $ProfilePathMapping = "beta\examples"
        }
        $ModulePath = Join-Path $PSScriptRoot "..\src\$GraphModule\$ProfilePathMapping"
        Get-ExternalDocsUrl -ManualExternalDocsUrl $ManualExternalDocsUrl -GenerationMode $GenerationMode -GraphProfilePath $ModulePath -Command $GraphCommand -GraphProfile $ProfilePath -Module $GraphModule
            
    }
    git add .
    git commit -m "Importing updates from API reference" 
}
function Get-FilesByProfile {
    Param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [ValidateNotNullOrEmpty()]
        [string] $GraphProfilePath = "v1.0\examples",
        [ValidateNotNullOrEmpty()]
        $ModulesToGenerate = @()
    )


    $ModulesToGenerate | ForEach-Object {
        $ModuleName = $_
        $ModulePath = Join-Path $PSScriptRoot "..\src\$ModuleName\$GraphProfilePath"
        $OpenApiFile = Join-Path $PSScriptRoot "..\openApiDocs\v1.0\$ModuleName.yml"
        #test this path first before proceeding
        if (Test-Path $OpenApiFile) {
            $yamlContent = Get-Content -Path $OpenApiFile
            $OpenApiContent = ($yamlContent | ConvertFrom-Yaml)
            Get-Files -GraphProfile $GraphProfile -GraphProfilePath $modulePath -Module $ModuleName -OpenApiContent $OpenApiContent
        }
    }

}
function Get-Files {
    param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [ValidateNotNullOrEmpty()]
        [string] $GraphProfilePath = (Join-Path $PSScriptRoot "..\src\Users\v1.0\examples"),
        [ValidateNotNullOrEmpty()]
        [string] $Module = "Users",
        [Hashtable] $OpenApiContent 
    )
    
    $ModuleManifestFile = (Join-Path $PSScriptRoot "..\src\$Module\$GraphProfile\Microsoft.Graph.$Module.psd1")
    if($GraphProfile -eq "beta"){
        $ModuleManifestFile = (Join-Path $PSScriptRoot "..\src\$Module\$GraphProfile\Microsoft.Graph.Beta.$Module.psd1")  
    }
    $ModuleManifestFileContent = Get-Content -Path $ModuleManifestFile

    try {
        if (Test-Path $GraphProfilePath) {

            foreach ($File in Get-ChildItem $GraphProfilePath) {
               
                #Extract command over here
                $Command = [System.IO.Path]::GetFileNameWithoutExtension($File)
                #Check for cmdlet existence from the module manifest file
                if ($ModuleManifestFileContent | Select-String -pattern $Command) {
                
                    #Extract URI path
                    $UriPath = $null
                    if($GraphProfile -eq "beta"){
                        $UriPath = $BetaCommandGetVariantList[$Command]
                    }else{
                        $UriPath = $V1CommandGetVariantList[$Command]
                    }
                        
                    if ($UriPath) {
                        $Method = $UriPaths.Method
                        Get-ExternalDocsUrl -GraphProfile $GraphProfile -Url -UriPath $UriPath -Command $Command -OpenApiContent $OpenApiContent -GraphProfilePath $GraphProfilePath -Method $Method -Module $Module
                    }
                    
                }

            }
        }
    }
    catch {
        Write-Host "`nError Message: " $_.Exception.Message
        Write-Host "`nError in Line: " $_.InvocationInfo.Line
        Write-Host "`nError in Line Number: "$_.InvocationInfo.ScriptLineNumber
        Write-Host "`nError Item Name: "$_.Exception.ItemName
    }
    
}
function Get-ExternalDocsUrl {

    param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [string] $UriPath,
        [string] $Module = "Users",
        [string] $GenerationMode = "auto",
        [string] $ManualExternalDocsUrl,
        [ValidateNotNullOrEmpty()]
        [string] $Command = "Get-MgUser",
        [Hashtable] $OpenApiContent,
        [System.Object] $Method = "GET",
        [string] $GraphProfilePath = (Join-Path $PSScriptRoot "..\src\Users\v1.0\examples")
    )

    if ($GenerationMode -eq "manual") {

        if (-not([string]::IsNullOrEmpty($ManualExternalDocsUrl))) {
    
            Start-WebScrapping -GraphProfile $GraphProfile -ExternalDocUrl $ManualExternalDocsUrl -Command $Command -GraphProfilePath $GraphProfilePath -UriPath $UriPath -Module $Module
        }

    }
    else {
        if ($UriPath) {
    
            if ($OpenApiContent.openapi && $OpenApiContent.info.version) {
                foreach ($Path in $OpenApiContent.paths) {
                    $MethodName = $Method | Out-String
                    $ExternalDocUrl = $Path[$UriPath].values.externalDocs.url
                     
                    if ([string]::IsNullOrEmpty($ExternalDocUrl)) {
                        $PathSplit = $UriPath.Split("/")
                        $PathToAppend = $PathSplit[$PathSplit.Count - 1]
                        if ($PathToAppend.StartsWith("{") -or $PathToAppend.StartsWith("$")) {
                            #skip
                        }
                        else {
                            $PathRebuild = "/" + $PathSplit[0]
                            for ($i = 1; $i -lt $PathSplit.Count - 1; $i++) {
                                $PathRebuild += $PathSplit[$i] + "/" 
                            }
                            $RebuiltPath = $PathRebuild + "microsoft.graph." + $PathToAppend
                            $ExternalDocUrl = $path[$RebuiltPath].get.externalDocs.url
                            if ([string]::IsNullOrEmpty($ExternalDocUrl)) {
                                $UriPath2 = $null
                                if($GraphProfile -eq "beta"){
                                    $UriPath2 = $BetaCommandListVariantList[$Command]
                                }else{
                                    $UriPath2 = $V1CommandListVariantList[$Command]
                                } 
                                if(-not([string]::IsNullOrEmpty($UriPath2))){
                                    $ExternalDocUrl = $Path[$UriPath2].get.externalDocs.url
                                }
                                  
                            }
                        }
                    }
                    if ($MethodName -eq "POST") {
                        $ExternalDocUrl = $Path[$UriPath].post.externalDocs.url
                        if ([string]::IsNullOrEmpty($ExternalDocUrl)) {
                            $UriPath3 = $null
                            if($GraphProfile -eq "beta"){
                                $UriPath3 = $BetaCommandListVariantList[$Command]
                            }else{
                                $UriPath3 = $V1CommandListVariantList[$Command]
                            }
                            if(-not([string]::IsNullOrEmpty($UriPath3))){ 
                                $ExternalDocUrl = $Path[$UriPath3].post.externalDocs.url
                            }  
                        } 
                    }
                
                    if ($MethodName -eq "PATCH") {
                        $ExternalDocUrl = $Path[$UriPath].patch.externalDocs.url 
                        if ([string]::IsNullOrEmpty($ExternalDocUrl)) {
                            $UriPath4 = $null
                            if($GraphProfile -eq "beta"){
                                $UriPath4 = $BetaCommandListVariantList[$Command]
                            }else{
                                $UriPath4 = $V1CommandListVariantList[$Command]
                            } 
                            if(-not([string]::IsNullOrEmpty($UriPath4))){ 
                                $ExternalDocUrl = $Path[$UriPath4].post.externalDocs.url
                            }  
                        } 
                    }
                
                    if ($MethodName -eq "DELETE") {
                        $ExternalDocUrl = $Path[$UriPath].delete.externalDocs.url
                        if ([string]::IsNullOrEmpty($ExternalDocUrl)) {
                            $UriPath5 = $null
                            if($GraphProfile -eq "beta"){
                                $UriPath5 = $BetaCommandListVariantList[$Command]
                            }else{
                                $UriPath5 = $V1CommandListVariantList[$Command]
                            } 
                            if(-not([string]::IsNullOrEmpty($UriPath5))){ 
                                $ExternalDocUrl = $Path[$UriPath5].post.externalDocs.url
                            }  
                        } 
                    }
    
                    if ($MethodName -eq "PUT") {
                        $ExternalDocUrl = $Path[$UriPath].put.externalDocs.url
                        if ([string]::IsNullOrEmpty($ExternalDocUrl)) {
                            $UriPath6 = $null
                            if($GraphProfile -eq "beta"){
                                $UriPath6 = $BetaCommandListVariantList[$Command]
                            }else{
                                $UriPath6 = $V1CommandListVariantList[$Command]
                            } 
                            if(-not([string]::IsNullOrEmpty($UriPath6))){ 
                                $ExternalDocUrl = $Path[$UriPath6].post.externalDocs.url
                            }  
                        } 
                    }
                    if (-not([string]::IsNullOrEmpty($ExternalDocUrl))) {
                        Start-WebScrapping -GraphProfile $GraphProfile -ExternalDocUrl $ExternalDocUrl -Command $Command -GraphProfilePath $GraphProfilePath -UriPath $UriPath -Module $Module
                    }
                }
    
            }
        }
    }

}
function Start-WebScrapping {
    param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [ValidateNotNullOrEmpty()]
        [string] $ExternalDocUrl = "https://learn.microsoft.com/en-us/graph/api/user-get?view=graph-rest-1.0&tabs=powershell",
        [ValidateNotNullOrEmpty()]
        [string] $Command = "Get-MgUser",
        [string] $UriPath,
        [string] $Module = "Users",
        [string] $GraphProfilePath = (Join-Path $PSScriptRoot "..\src\Users\Users\examples\v1.0")
    )  
    $ExampleFile = "$GraphProfilePath/$Command.md"
    $url = $ExternalDocUrl
	
    $Description = "This example shows how to use the $Command Cmdlet.`r`n`r`To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference)."
    $WebResponse = Invoke-WebRequest -Uri $url
    $HeaderList = New-Object -TypeName 'System.Collections.ArrayList';
    $ExampleList = New-Object -TypeName 'System.Collections.ArrayList';
    $htmlDom = ConvertFrom-Html $WebResponse
    $nodes = $htmlDom.SelectNodes('//pre/code')
    $headers = $htmlDom.SelectNodes('//h3')
    foreach ($node in $nodes) {
        $checkPowershell = $node.OuterHtml
        
        if ($checkPowershell.Contains('lang-powershell')) {
            $result = $node.InnerHtml
            $result = $result.Replace('&quot;', '"')
            $EL = $ExampleList.Add($result)
        }
    }
    foreach ($header in $headers) {
        $checkPowershell = $header.OuterHtml
        
        if ($checkPowershell.Contains('Example')) {
            $result = $header.InnerHtml
            $HL = $HeaderList.Add($result)
        }
        
    }
  
    Update-ExampleFile -GraphProfile $GraphProfile -HeaderList $HeaderList -ExampleList $ExampleList -ExampleFile $ExampleFile -Description $Description -Command $Command -ExternalDocUrl $ExternalDocUrl -UriPath $UriPath -Module $Module
}

function Update-ExampleFile {
    param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [System.Collections.ArrayList] $HeaderList,
        [System.Collections.ArrayList] $ExampleList,
        [string] $ExampleFile,
        [string] $UriPath,
        [string] $Description,
        [string] $Module = "Users",
        [string] $Command = "Get-MgUser",
        [ValidateNotNullOrEmpty()]
        [string] $ExternalDocUrl = "https://learn.microsoft.com/en-us/graph/api/user-get?view=graph-rest-1.0&tabs=powershell"
    ) 
    
    $Content = Get-Content -Path $ExampleFile
    $SearchText = "Example"
    $SearchTextForNewImports = "{{ Add description here }}"
    $ReplaceEverything = $False
    if ($HeaderList.Count -eq 0) {
        for ($d = 0; $d -lt $ExampleList.Count; $d++) {
            $sum = $d + 1
            $HL = $HeaderList.Add("Example " + $sum + ": Code snippet".Trim())
        }
    }
    if ($HeaderList.Count -ne $ExampleList.Count) {
        $HeaderList.Clear()
        for ($d = 0; $d -lt $ExampleList.Count; $d++) {
            $sum = $d + 1
            $H = $HeaderList.Add("Example " + $sum + ": Code snippet".Trim())
        }
    }
    if (($Content | Select-String -pattern $SearchTextForNewImports)) {
        $ReplaceEverything = $True
    }


    $HeadCount = $HeaderList.Count
    $ExampleCount = $ExampleList.Count
    $WrongExamplesCount = 0;
    #===========================Importing new examples into files ============================================#  
    if ($ReplaceEverything -and $ExampleCount -gt 0 -and $HeadCount -eq $ExampleCount) {
        Clear-Content $ExampleFile -Force
        for ($d = 0; $d -lt $HeaderList.Count; $d++) { 
            $CodeValue = $ExampleList[$d].Trim()
            if($CodeValue.Contains($Command)){
            $TitleValue = "### " + $HeaderList[$d].Trim()
            $Code = "``````powershell`r$CodeValue`r`n``````"
	
            $TotalText = "$TitleValue`r`n`n$Code`r`n$Description`r`n"
            Add-Content -Path $ExampleFile -Value $TotalText
            }else{    
                $WrongExamplesCount++
               
            }
        }
    }
    $PatternToSearch = "Import-Module Microsoft.Graph.$Module"
    if($GraphProfile -eq "beta"){
        $PatternToSearch = "Import-Module Microsoft.Graph.Beta.$Module"  
    }
    if(($Content | Select-String -pattern $SearchText) -and ($Content | Select-String -pattern "This example shows")){
        $ContainsPatternToSearch = $False
        foreach($List in $ExampleList){
           if($List.Contains($PatternToSearch)){
            $ContainsPatternToSearch = $True
           }
        }
        if($ContainsPatternToSearch){
            Clear-Content $ExampleFile -Force
           #Replace everything
           for ($d = 0; $d -lt $HeaderList.Count; $d++) { 
            $CodeValue = $ExampleList[$d].Trim()
            $TitleValue = "### " + $HeaderList[$d].Trim()
            $Code = "``````powershell`r$CodeValue`r`n``````"
    
            $TotalText = "$TitleValue`r`n`n$Code`r`n$Description`r`n"
            Add-Content -Path $ExampleFile -Value $TotalText
        }

        }else{
            Clear-Content $ExampleFile -Force
            #Replace everything with boiler plate code
            $DefaultBoilerPlate = "### Example 1: {{ Add title here }}`r`n``````powershell`r`n PS C:\> {{ Add code here }}`r`n`n{{ Add output here }}`r`n```````n`n{{ Add description here }}`r`n`n### Example 2: {{ Add title here }}`r`n``````powershell`r`n PS C:\> {{ Add code here }}`r`n`n{{ Add output here }}`r`n```````n`n{{ Add description here }}`r`n`n"
            Add-Content -Path $ExampleFile -Value $DefaultBoilerPlate.Trim()
        }
        
    }
    if($WrongExamplesCount -gt 0){
        $DefaultBoilerPlate = "### Example 1: {{ Add title here }}`r`n``````powershell`r`n PS C:\> {{ Add code here }}`r`n`n{{ Add output here }}`r`n```````n`n{{ Add description here }}`r`n`n### Example 2: {{ Add title here }}`r`n``````powershell`r`n PS C:\> {{ Add code here }}`r`n`n{{ Add output here }}`r`n```````n`n{{ Add description here }}`r`n`n"
        Add-Content -Path $ExampleFile -Value $DefaultBoilerPlate.Trim()
        #Log api path api version and equivalent external doc url giving wron examples
        #Create folder and file if it doesn't exist
        #The artifact below will be ignored on git.
        #You can download the artificat from the generator pipeline

        if(-not(Test-Path -PathType Container $FolderForExamplesToBeReviewed)){
            New-Item -ItemType Directory -Force -Path $FolderForExamplesToBeReviewed
        }
        if (-not (Test-Path "$FolderForExamplesToBeReviewed\$ExamplesToBeReviewed")) {
            "Command, ExternalDocsUrl, ApiVersion" | Out-File -FilePath  "$FolderForExamplesToBeReviewed\$ExamplesToBeReviewed" -Encoding ASCII
        }

        $File = Get-Content "$FolderForExamplesToBeReviewed\$ExamplesToBeReviewed"
        $containsWord = $File | % { $_ -match "$Command, $ExternalDocUrl, $GraphProfile, $UriPath" }
        if (-not($containsWord -contains $true)) {
            "$Command, $ExternalDocUrl, $GraphProfile, $UriPath" | Out-File -FilePath "$FolderForExamplesToBeReviewed\$ExamplesToBeReviewed" -Append -Encoding ASCII
        }
    }
  
}       
$JsonContent = Get-Content -Path $MetaDataJsonFile
$DeserializedContent = $JsonContent | ConvertFrom-Json
foreach($Data in $DeserializedContent)
{
    if($Data.ApiVersion -eq "beta")
    {        
        if((-not($Data.Variants[0].Contains("List")))){
            $Beta = $BetaCommandGetVariantList.Add($Data.Command, $Data.Uri)        
        }else{
            $Beta1 = $BetaCommandListVariantList.Add($Data.Command, $Data.Uri) 
        }   
    }

    if($Data.ApiVersion -eq "v1.0")
    {
        
        if((-not($Data.Variants[0].Contains("List")))){
            $V1 = $V1CommandGetVariantList.Add($Data.Command, $Data.Uri)        
        }else{
            $V11 = $V1CommandListVariantList.Add($Data.Command, $Data.Uri)
        }   
    }
}
if (!(Get-Module "powershell-yaml" -ListAvailable -ErrorAction SilentlyContinue)) {
    Install-Module "powershell-yaml" -AcceptLicense -Scope CurrentUser -Force
}
if (-not (Test-Path $ModuleMappingConfigPath)) {
    Write-Error "Module mapping file not be found: $ModuleMappingConfigPath."
}
If (-not (Get-Module -ErrorAction Ignore -ListAvailable PowerHTML)) {
    Write-Verbose "Installing PowerHTML module for the current user..."
    Install-Module PowerHTML -ErrorAction Stop -Scope CurrentUser -Force
}
Import-Module -ErrorAction Stop PowerHTML

if ($ModulesToGenerate.Count -eq 0) {
    [HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
    $ModulesToGenerate = $ModuleMapping.Keys
}
Start-Generator -ModulesToGenerate $ModulesToGenerate -GenerationMode "auto"

#Comment the above and uncomment the below start command, if you manually want to manually pass ExternalDocs url.
#This is for scenarios where the correponding external docs url to the uri path gotten from Find-MgGraph command, is missing on the openapi.yml file for a particular module.
#Ensure that you pass all correct parameters as per the already existing example
#Start-Generator -GenerationMode "manual" -ManualExternalDocsUrl "https://docs.microsoft.com/graph/api/serviceprincipal-post-approleassignedto?view=graph-rest-1.0&tabs=http" -GraphCommand "New-MgServicePrincipalAppRoleAssignedTo" -GraphModule "Applications" -Profile "v1.0"

#The below tests are ran manually. Comment the above Start-Generator with Generation mode set to auto and uncomment the below test
#---------------------------------------------------------------------------------------------------------------------------------#
#1. Test for making corrections and updating auto imported examples. I.e Examples that were not handwritten
#Start-Generator -GenerationMode "manual" -ManualExternalDocsUrl "https://docs.microsoft.com/graph/api/directoryobject-getmembergroups?view=graph-rest-beta" -GraphCommand "Get-MgBetaApplicationMemberGroup" -GraphModule "Applications" -Profile "beta"

#2. Test for ensuring that a handwritten example is not tampered with
#Start-Generator -GenerationMode "manual" -ManualExternalDocsUrl "https://docs.microsoft.com/graph/api/user-get?view=graph-rest-1.0" -GraphCommand "Get-MgUser" -GraphModule "Users" -Profile "v1.0" 

#3. Test for updates from api reference
#Start-Generator -GenerationMode "manual" -ManualExternalDocsUrl "https://docs.microsoft.com/graph/api/serviceprincipal-post-approleassignedto?view=graph-rest-1.0" -GraphCommand "New-MgServicePrincipalAppRoleAssignedTo" -GraphModule "Applications" -Profile "v1.0"
Write-Host -ForegroundColor Green "-------------Done-------------"