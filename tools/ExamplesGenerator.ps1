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
        #"v1.0" = "examples\v1.0"
        "beta" = "examples\v1.0-beta"
    }
    if ($GenerationMode -eq "auto") {
        $GraphMapping.Keys | ForEach-Object {
            $graphProfile = $_
            Get-FilesByProfile -GraphProfile $graphProfile -GraphProfilePath $GraphMapping[$graphProfile] -ModulesToGenerate $ModulesToGenerate 
        }
    }
    else {
          
        $ProfilePathMapping = "examples\v1.0"
        if ($ProfilePath -eq "beta") {
            $ProfilePathMapping = "examples\v1.0-beta"
        }
        $ModulePath = Join-Path $PSScriptRoot "..\src\$GraphModule\$GraphModule\$ProfilePathMapping"
        Get-ExternalDocsUrl -ManualExternalDocsUrl $ManualExternalDocsUrl -GenerationMode $GenerationMode -GraphProfilePath $ModulePath -Command $GraphCommand -GraphProfile $ProfilePath -Module $GraphModule
            
    }
}
function Get-FilesByProfile {
    Param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [ValidateNotNullOrEmpty()]
        [string] $GraphProfilePath = "examples\v1.0",
        [ValidateNotNullOrEmpty()]
        $ModulesToGenerate = @()
    )


    $ModulesToGenerate | ForEach-Object {
        $ModuleName = $_
        $ModulePath = Join-Path $PSScriptRoot "..\src\$ModuleName\$ModuleName\$GraphProfilePath"
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
        [string] $GraphProfilePath = (Join-Path $PSScriptRoot "..\src\Users\Users\examples\v1.0"),
        [ValidateNotNullOrEmpty()]
        [string] $Module = "Users",
        [Hashtable] $OpenApiContent 
    )
    
    try {
        if (Test-Path $GraphProfilePath) {

            foreach ($File in Get-ChildItem $GraphProfilePath) {
               
                #Extract command over here
                $Command = [System.IO.Path]::GetFileNameWithoutExtension($File)
                    #Extract URI path
                    $CommandValue = $null
                    if($GraphProfile -eq "beta"){
                        $CommandValue = $BetaCommandGetVariantList[$Command]
                        
                    }else{
                        $CommandValue = $V1CommandGetVariantList[$Command]
                    }
                        
                    if ($CommandValue) {
                        $CommandValueParams = $CommandValue.Split(",")
                         $ApiPath = $CommandValueParams[0]
                         $Method = $CommandValueParams[1]
                        Get-ExternalDocsUrl -GraphProfile $GraphProfile -Url -UriPath $ApiPath -Command $Command -OpenApiContent $OpenApiContent -GraphProfilePath $GraphProfilePath -Method $Method.Trim() -Module $Module
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
        [string] $GraphProfilePath = (Join-Path $PSScriptRoot "..\src\Users\Users\examples\v1.0")
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
                    $ExternalDocUrl = $null
                    switch($Method){
                        "GET" {
                            $ExternalDocUrl = $path[$UriPath].get.externalDocs.url
                            if ([string]::IsNullOrEmpty($ExternalDocUrl)) {
                                $GETApiPath = Extract-PathFromListVariant -GraphProfile $GraphProfile -Command $Command
                                if(-not([string]::IsNullOrEmpty($GETApiPath))){
                                    $ExternalDocUrl = $Path[$GETApiPath].get.externalDocs.url
                                }      
                            }
                        }
                        "POST" {
                            $ExternalDocUrl = $Path[$UriPath].post.externalDocs.url
                            if ([string]::IsNullOrEmpty($ExternalDocUrl)) {
                                $POSTApiPath = Extract-PathFromListVariant -GraphProfile $GraphProfile -Command $Command
                                if(-not([string]::IsNullOrEmpty($POSTApiPath))){
                                    $ExternalDocUrl = $Path[$POSTApiPath].post.externalDocs.url
                                }      
                            }  
                        }
                        "PATCH" {
                            $ExternalDocUrl = $Path[$UriPath].patch.externalDocs.url 
                            if ([string]::IsNullOrEmpty($ExternalDocUrl)) {
                                $PATCHApiPath = Extract-PathFromListVariant -GraphProfile $GraphProfile -Command $Command
                                if(-not([string]::IsNullOrEmpty($PATCHApiPath))){
                                    $ExternalDocUrl = $Path[$PATCHApiPath].patch.externalDocs.url
                                }      
                            }
                        }
                        "DELETE" {
                            $ExternalDocUrl = $Path[$UriPath].delete.externalDocs.url
                            if ([string]::IsNullOrEmpty($ExternalDocUrl)) {
                                $DELETEApiPath = Extract-PathFromListVariant -GraphProfile $GraphProfile -Command $Command
                                if(-not([string]::IsNullOrEmpty($DELETEApiPath))){
                                    $ExternalDocUrl = $Path[$DELETEApiPath].delete.externalDocs.url
                                }      
                            }
                        }
                        "PUT" {
                            $ExternalDocUrl = $Path[$UriPath].put.externalDocs.url
                            if ([string]::IsNullOrEmpty($ExternalDocUrl)) {
                                $PUTApiPath = Extract-PathFromListVariant -GraphProfile $GraphProfile -Command $Command
                                if(-not([string]::IsNullOrEmpty($PUTApiPath))){
                                    $ExternalDocUrl = $Path[$PUTApiPath].put.externalDocs.url
                                }      
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
function Extract-PathFromListVariant{
    param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0", 
        [string] $Command = "Get-MgUser"
    )
    $ListApiPath = $null
    $ListCommandValue = $null
    if($GraphProfile -eq "beta"){
        $ListCommandValue = $BetaCommandListVariantList[$Command]
    }else{
        $ListCommandValue = $V1CommandListVariantList[$Command]
    } 
    if(-not([string]::IsNullOrEmpty($ListCommandValue))){
        $ListCommandValueParams = $ListCommandValue.Split(",")
        $ListApiPath = $ListCommandValueParams[0]
    }
    return $ListApiPath
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
    $SkippedExample = -1
    $ContainsRightExamples = $False
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
            $ContainsRightExamples = $True
            }else{    
                $WrongExamplesCount++
                $SkippedExample++
               
            }
        }
    }
    #The code below updates existing examples
    #------------------------------------------------------------#
    $PatternToSearch = "Import-Module Microsoft.Graph.$Module"
    if(($Content | Select-String -pattern $SearchText) -and ($Content | Select-String -pattern "This example shows")){
        $ContainsPatternToSearch = $False
        foreach($List in $ExampleList){
           if($List.Contains($PatternToSearch)){
            $ContainsPatternToSearch = $True
           }
        }
        if($ContainsPatternToSearch){
            Clear-Content $ExampleFile -Force
           for ($d = 0; $d -lt $HeaderList.Count; $d++) { 
            if($ExampleList[$d].Contains($Command)){
            $CodeValue = $ExampleList[$d].Trim()
            $TitleValue = "### " + $HeaderList[$d].Trim()
            $Code = "``````powershell`r$CodeValue`r`n``````"
    
            $TotalText = "$TitleValue`r`n`n$Code`r`n$Description`r`n"
            Add-Content -Path $ExampleFile -Value $TotalText
            }else{
                $SkippedExample++ 
            }
        }

        }else{
            Clear-Content $ExampleFile -Force
            #Replace everything with boiler plate code
            $DefaultBoilerPlate = "### Example 1: {{ Add title here }}`r`n``````powershell`r`n PS C:\> {{ Add code here }}`r`n`n{{ Add output here }}`r`n```````n`n{{ Add description here }}`r`n`n### Example 2: {{ Add title here }}`r`n``````powershell`r`n PS C:\> {{ Add code here }}`r`n`n{{ Add output here }}`r`n```````n`n{{ Add description here }}`r`n`n"
            Add-Content -Path $ExampleFile -Value $DefaultBoilerPlate.Trim()
        }
        
    }
    #The code below corrects the numbering of the example headers/title if there is a situation where
    #some examples are wrong(which are left out) and some are right
    #-----------------------------------------------------------------------------------------------#
    $AvailableCorrectExamples = 1
    if($SkippedExample -gt -1){
        $NewContent = Get-Content -Path $ExampleFile
        foreach($C in $NewContent){
            if($C.Contains("Example")){
                $SearchString = $c.Split(":") 
                $StringToReplace =  $SearchString[0]           
                $ReplacementString = "### Example $AvailableCorrectExamples"
                (Get-Content -Path $ExampleFile) -replace $StringToReplace, $ReplacementString | Set-Content $ExampleFile
                $AvailableCorrectExamples++
            }
        }
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
    #-----------------------------------------------------------------------------------------------------------------------------------------------------------------#
    if(($WrongExamplesCount -gt 0) -and -not($ContainsRightExamples)){
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
            $BetaAPIPathAndMethod = $Data.Uri,$Data.Method -join ","
            $Beta = $BetaCommandGetVariantList.Add($Data.Command, $BetaAPIPathAndMethod)        
        }else{
            $Beta1 = $BetaCommandListVariantList.Add($Data.Command, $BetaAPIPathAndMethod) 
        }   
    }

    if($Data.ApiVersion -eq "v1.0")
    {
        $V1APIPathAndMethod = $Data.Uri,$Data.Method -join ","
        if((-not($Data.Variants[0].Contains("List")))){
            $V1 = $V1CommandGetVariantList.Add($Data.Command, $V1APIPathAndMethod)        
        }else{
            $V11 = $V1CommandListVariantList.Add($Data.Command, $V1APIPathAndMethod)
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