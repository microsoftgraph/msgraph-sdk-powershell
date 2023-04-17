# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    $ModulesToGenerate = @(),
    $HandWrittenCommands = @(),
    [hashtable]$V1CommandList= @{},
    [hashtable]$BetaCommandList= @{},
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
    [string] $HandWrittenDocPath = (Join-Path $PSScriptRoot "..\examplesreport\HandWrittenExamplesByContentDeveloper.csv"),
    [string] $ExamplesToBeReviewed = (Join-Path $PSScriptRoot "..\examplesreport\ExamplesToBeReviewed.csv"),
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
        "v1.0" = "examples\v1.0"
        #"beta" = "examples\v1.0-beta"
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
        Get-ExternalDocsUrl -ManualExternalDocsUrl $ManualExternalDocsUrl -GenerationMode $GenerationMode -GraphProfilePath $ModulePath -Command $GraphCommand -GraphProfile $ProfilePath -Module -$Module
            
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
    $ModuleManifestFile = (Join-Path $PSScriptRoot "..\src\$Module\$Module\Microsoft.Graph.$Module.psd1")
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
                        $UriPath = $BetaCommandList[$Command]
                    }else{
                        $UriPath = $V1CommandList[$Command]
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
        [string] $GraphProfilePath = (Join-Path $PSScriptRoot "..\src\Users\Users\examples\v1.0")
    )
    if(-not($HandWrittenCommands -contains $Command)){
    if ($GenerationMode -eq "manual") {

        if (-not([string]::IsNullOrEmpty($ManualExternalDocsUrl))) {
    
            Start-WebScrapping -GraphProfile $GraphProfile -ExternalDocUrl $ManualExternalDocsUrl -Command $Command -GraphProfilePath $GraphProfilePath -UriPath $UriPath
        }

    }
    else {
        if ($UriPath) {
            if ($openApiContent.openapi && $openApiContent.info.version) {
                foreach ($path in $openApiContent.paths) {
                    $MethodName = $Method | Out-String
               
                    $externalDocUrl = $path[$UriPath].get.externalDocs.url
                    if ([string]::IsNullOrEmpty($externalDocUrl)) {
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
                            $externalDocUrl = $path[$RebuiltPath].get.externalDocs.url
                        }
                    }
                    if ($MethodName -eq "POST") {
                        $externalDocUrl = $path[$UriPath].post.externalDocs.url 
                    }
                
                    if ($MethodName -eq "PATCH") {
                        $externalDocUrl = $path[$UriPath].patch.externalDocs.url 
                    }
                
                    if ($MethodName -eq "DELETE") {
                        $externalDocUrl = $path[$UriPath].delete.externalDocs.url 
                    }

                    if ($MethodName -eq "PUT") {
                        $externalDocUrl = $path[$UriPath].put.externalDocs.url 
                    }
                    if (-not([string]::IsNullOrEmpty($externalDocUrl))) {
                        Start-WebScrapping -GraphProfile $GraphProfile -ExternalDocUrl $externalDocUrl -Command $Command -GraphProfilePath $GraphProfilePath -UriPath $UriPath
                    }
            
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
            $L = $ExampleList.Add($result)
        }
    }
    foreach ($header in $headers) {
        $checkPowershell = $header.OuterHtml
        
        if ($checkPowershell.Contains('Example')) {
            $result = $header.InnerHtml
            $A = $HeaderList.Add($result)
        }
        
    }
  
    Update-ExampleFile -GraphProfile $GraphProfile -HeaderList $HeaderList -ExampleList $ExampleList -ExampleFile $ExampleFile -Description $Description -Command $Command -ExternalDocUrl $ExternalDocUrl -UriPath $UriPath
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
    if (($Content | Select-String -pattern $SearchText) -or ($Content | Select-String -pattern $SearchTextForNewImports)) {
        $ReplaceEverything = $True
    }

    $headCount = $HeaderList.Count
    $exampleCount = $ExampleList.Count
    $wrongExamplesCount = 0;   
    if ($ReplaceEverything -and $exampleCount -gt 0 -and $headCount -eq $exampleCount) {
        Clear-Content $ExampleFile -Force
        for ($d = 0; $d -lt $headerList.Count; $d++) { 
            $codeValue = $exampleList[$d].Trim()
            if($codeValue.Contains($Command)){
            $titleValue = "### " + $headerList[$d].Trim()
            $code = "``````powershell`r$codeValue`r`n``````"
	
            $totalText = "$titleValue`r`n`n$code`r`n$description`r`n"
            Add-Content -Path $ExampleFile -Value $totalText
            }else{    
                $wrongExamplesCount++
            }
        }
    }
    if($wrongExamplesCount -gt 0){
        Write-Host "Logging this as an anormally Command " $Command "External Docs" $ExternalDocUrl
        $DefaultBoilerPlate = "### Example 1: {{ Add title here }}`r`n``````powershell`r`n PS C:\> {{ Add code here }}`r`n`n{{ Add output here }}`r`n```````n`n{{ Add description here }}`r`n`n### Example 2: {{ Add title here }}`r`n``````powershell`r`n PS C:\> {{ Add code here }}`r`n`n{{ Add output here }}`r`n```````n`n{{ Add description here }}`r`n`n"

        Add-Content -Path $ExampleFile -Value $DefaultBoilerPlate.Trim()
        #Log api path api version and equivalent external doc url giving wron examples

        #Create file if it doesn't exist
        if (-not (Test-Path $ExamplesToBeReviewed)) {
            "Command, ExternalDocsUrl, ApiVersion, OpenApiPath" | Out-File -FilePath  $ExamplesToBeReviewed -Encoding ASCII
        }

        $File = Get-Content $ExamplesToBeReviewed
        $containsWord = $File | % { $_ -match "$Command, $ExternalDocUrl, $GraphProfile, $UriPath" }
        if ($containsWord -contains $true) {
            #Skip adding to csv
        }
        else {
            "$Command, $ExternalDocUrl, $GraphProfile, $UriPath" | Out-File -FilePath $ExamplesToBeReviewed -Append -Encoding ASCII
        }
    }
    # git config --global user.email "timwamalwa@gmail.com"
    # git config --global user.name "Timothy Wamalwa"
    # git add $ExampleFile
    # git commit -m "Examples update on  $ExampleFile-$GraphProfile"   
}
Import-Csv $HandWrittenDocPath | 
ForEach-Object{
    $HandWrittenCommands += $_.CmdletName
}
$JsonContent = Get-Content -Path $MetaDataJsonFile
$DeserializedContent = $JsonContent | ConvertFrom-Json
foreach($Data in $DeserializedContent)
{
    if($Data.ApiVersion -eq "beta")
    {
        
        if((-not($Data.Variants[0].Contains("List")))){
            $Beta = $BetaCommandList.Add($Data.Command, $Data.Uri)        
        }   
    }

    if($Data.ApiVersion -eq "v1.0")
    {
        
        if((-not($Data.Variants[0].Contains("List")))){
            $V1 = $V1CommandList.Add($Data.Command, $Data.Uri)        
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
#Ensure that you pass all correct parameters as oer the already existing example

#Start-Generator -GenerationMode "manual" -ManualExternalDocsUrl "https://docs.microsoft.com/graph/api/serviceprincipal-post-approleassignedto?view=graph-rest-1.0&tabs=http" -GraphCommand "New-MgServicePrincipalAppRoleAssignedTo" -GraphModule "Applications" -Profile "v1.0"
Write-Host -ForegroundColor Green "-------------Done-------------"
