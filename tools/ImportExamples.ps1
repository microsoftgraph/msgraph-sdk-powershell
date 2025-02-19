# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    $ModulesToGenerate = @(),
    $Available = @(),
    [string] $FolderForExamplesToBeReviewed = (Join-Path $PSScriptRoot "..\examplesreport"),
    [string] $ExamplesToBeReviewed = "ExamplesToBeReviewed.csv",
    [string] $CommandMetadataPath = (Join-Path $PSScriptRoot "..\src\Authentication\Authentication\custom\common\MgCommandMetadata.json")
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
    try {
        if ($GenerationMode -eq "auto") {
            #Test path first
            if (Test-Path $CommandMetadataPath) {
                $CommandMetadataContent = Get-Content $CommandMetadataPath | ConvertFrom-Json
                $CommandMetadataContent | ForEach-Object {
                    $GraphCommand = $_.Command
                    $GraphModule = $_.Module
                    $UriPath = $_.Uri
                    $ExternalDocsUrl = $_.ApiReferenceLink
                    $ApiVersion = $_.ApiVersion
                    $ProfilePathMapping = "v1.0\examples"
                    if ($ApiVersion -eq "beta") {
                        $ProfilePathMapping = "beta\examples"
                        $GraphModule = $GraphModule.Replace("Beta.", "")
                    }
                    $ModulePath = Join-Path $PSScriptRoot "..\src\$GraphModule\$ProfilePathMapping"

                    $ExampleFile = "$ModulePath\$GraphCommand.md"
                    Write-Host $ExampleFile
                    Test-Commands -Command $GraphCommand -CommandPath $ExampleFile
                    if ($null -ne $ExternalDocsUrl) { 
                        if (-not (Test-Path $ExampleFile)) {
                            New-Item -Path $ExampleFile -ItemType File -Force
                        }
                        $IntuneUrl = $ExternalDocsUrl.Replace("intune-onboarding-", "")
                        $IntuneUrl = $IntuneUrl.Replace("intune-mam-", "")
                        $IsValid = IsValidEndPoint -GraphEndpoint $IntuneUrl
                        if ($IsValid) {
                            $ExternalDocsUrl = $IntuneUrl
                        }
                        Start-WebScrapping -GraphProfile $ApiVersion -ExternalDocUrl $ExternalDocsUrl -Command $GraphCommand -GraphProfilePath $ModulePath -UriPath $UriPath -Module $GraphModule
                    }
                    else {
                        if (Test-Path $ExampleFile) {
                            #Check file content and retain correct examples
                            $Content = Get-Content -Path $ExampleFile
                            Clear-Content $ExampleFile -Force
                            if ($Content | Select-String -pattern $GraphCommand) {
                                Retain-ExistingCorrectExamples -Content $Content -File $ExampleFile -CommandPattern $GraphCommand
                            }   
                        }
                    }
            
                }
            }
            else {
                Write-Host "The path to the command metadata file is invalid. Please ensure that the path is correct"
            }
        }
        else {
          
            $ProfilePathMapping = "v1.0\examples"
            if ($ProfilePath -eq "beta") {
                $ProfilePathMapping = "beta\examples"
            }
            $ModulePath = Join-Path $PSScriptRoot "..\src\$GraphModule\$ProfilePathMapping"
            Start-WebScrapping -GraphProfile $ProfilePath -ExternalDocUrl $ManualExternalDocsUrl -Command $GraphCommand -GraphProfilePath $ModulePath -Module $GraphModule   
        }
    }
    catch {
        Write-Host "`nError Message: " $_.Exception.Message
        Write-Host "`nError in Line: " $_.InvocationInfo.Line
        Write-Host "`nError in Line Number: "$_.InvocationInfo.ScriptLineNumber
        Write-Host "`nError Item Name: "$_.Exception.ItemName
    }
}
function Test-Commands {
    param(
        [ValidateNotNullOrEmpty()]
        [string] $Command = "Get-MgUser",
        [string] $CommandPath = ""
    )
    
    try {
        #Extract URI path
        $Cmdlet = Find-MgGraphCommand -Command $Command
        #Remove the file for the non-existent command
        if ($null -eq $Cmdlet) {
            Remove-FilesForNonExistentCommands -Command $Command -CommandPath $CommandPath
            return
        }
    }
    catch {

        #Remove the file for the non-existent command
        Remove-FilesForNonExistentCommands -Command $Command -CommandPath $CommandPath
        Write-Host "`nError Message: " $_.Exception.Message
        Write-Host "`nError in Line: " $_.InvocationInfo.Line
        Write-Host "`nError in Line Number: "$_.InvocationInfo.ScriptLineNumber
        Write-Host "`nError Item Name: "$_.Exception.ItemName
    }
    
}

function Remove-FilesForNonExistentCommands {
    param(
        [ValidateNotNullOrEmpty()]
        [string] $Command = "Get-MgUser",
        [string] $CommandPath = ""
    )
    if (Test-Path $CommandPath) {
        Remove-Item -Path $CommandPath -Force
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
    $ExternalDocUrlPaths = $ExternalDocUrl.Split("://")[1].Split("/")
    $LastExternalDocUrlPathSegmentWithQueryParam = $ExternalDocUrlPaths[$ExternalDocUrlPaths.Length - 1]
    $LastExternalDocUrlPathSegmentWithoutQueryParam = $LastExternalDocUrlPathSegmentWithQueryParam.Split("?")[0]

    $GraphDocsUrl = "https://raw.githubusercontent.com/microsoftgraph/microsoft-graph-docs-contrib/main/api-reference/$GraphProfile/api/$LastExternalDocUrlPathSegmentWithoutQueryParam.md"
    $UrlPaths = $GraphDocsUrl.Split("://")[1].Split("/")
    $LastPathSegment = $UrlPaths[$UrlPaths.Length - 1]
    $HeaderList = New-Object -TypeName 'System.Collections.ArrayList';
    $ExampleLinks = New-Object -TypeName 'System.Collections.ArrayList';
    $Snippets = New-Object -TypeName 'System.Collections.ArrayList';
    try {
        ($readStream, $HttpWebResponse, $IsSuccess) = FetchStream -GraphDocsUrl $GraphDocsUrl
        if ($IsSuccess) {
            while (-not $readStream.EndOfStream) {
                $Line = $readStream.ReadLine()
                if ($Line -match "^### Example") {
                    $H = $HeaderList.Add($Line)
                }
                if ($Line -match "/includes/snippets/powershell/") {
                    $Line = $Line.Replace("[!INCLUDE [sample-code](..", "")
                    $SnippetPath = $Line.Replace(")", "").Replace("]", "")
                    $SnippetUrl = $GraphDocsUrl.Replace("/api/$LastPathSegment", $SnippetPath)
                    $E = $ExampleLinks.Add($SnippetUrl)
                }
            }
            $HttpWebResponse.Close() 
            $readStream.Close()

            foreach ($Link in $ExampleLinks) {
                $ConstructedSnippet = "";
                ($Rs, $HttpResponse) = FetchStream -GraphDocsUrl $Link
                while (-not $Rs.EndOfStream) {
                    $Snippet = $Rs.ReadLine()
                
                    #Write-Host $desc
                    $Snippet = $Snippet.Replace("---", "")
                    $Snippet = $Snippet.Replace('description: "Automatically generated file. DO NOT MODIFY"', "")
                    $ConstructedSnippet += $Snippet + "`n"
                    
                }
                $S = $Snippets.Add($ConstructedSnippet)
            }
            if ($HeaderList.Count -ne $Snippets.Count) {
                $HeaderList.Clear()
                for ($d = 0; $d -lt $Snippets.Count; $d++) {
                    $sum = $d + 1
                    $H = $HeaderList.Add("### Example " + $sum + ": Code snippet".Trim())
                }
            }

            $ExampleFile = "$GraphProfilePath/$Command.md"
            $url = $ExternalDocUrl
            if ($GraphProfile -eq "beta") {
                $url = $url.Replace("graph-rest-1.0", "graph-rest-beta")
            }
            $DescriptionCommand = $Command  
            $Description = "This example shows how to use the $DescriptionCommand Cmdlet."
    
            Update-ExampleFile -GraphProfile $GraphProfile -HeaderList $HeaderList -ExampleList $Snippets -ExampleFile $ExampleFile -Description $Description -Command $Command -ExternalDocUrl $url -UriPath $UriPath -Module $Module
        }
    }
    catch {
        Write-Host "`nError Message: " $_.Exception.Message
        Write-Host "`nError in Line: " $_.InvocationInfo.Line
        Write-Host "`nError in Line Number: "$_.InvocationInfo.ScriptLineNumber
        Write-Host "`nError Item Name: "$_.Exception.ItemName
        Write-Host "`nRaw docs url : "  $GraphDocsUrl
        Write-Host "`nExternal docs url : "  $ExternalDocUrl
    }
}

function IsValidEndPoint {
    param(
        [string] $GraphEndpoint
    )
    try {
        $HTTP_Request = [System.Net.WebRequest]::Create($GraphEndpoint)

        # We then get a response from the site.
        $HTTP_Response = $HTTP_Request.GetResponse()

        # We then get the HTTP code as an integer.
        $HTTP_Status = [int]$HTTP_Response.StatusCode

        If ($HTTP_Status -eq 200) {
            return $True
        }
        If ($HTTP_Response -ne $null) { $HTTP_Response.Close() }
        return $False
    }
    catch {
        return $False
    }
}
function FetchStream {
    param(
        [string]$GraphDocsUrl
    )
    try {
        $HttpWebRequest = [System.Net.WebRequest]::Create($GraphDocsUrl)
        $HttpWebResponse = $HttpWebRequest.GetResponse()
        $ReceiveStream = $HttpWebResponse.GetResponseStream()
        $Encode = [System.Text.Encoding]::GetEncoding("utf-8")
        $ReadStream = [System.IO.StreamReader]::new($ReceiveStream, $Encode)
        return ($ReadStream, $HttpWebResponse, $True)
    }
    catch {
        return ($null, $null, $False)
        Write-Host "`nError Message: " $_.Exception.Message
        Write-Host "`nError in Line: " $_.InvocationInfo.Line
        Write-Host "`nError in Line Number: "$_.InvocationInfo.ScriptLineNumber
        Write-Host "`nError Item Name: "$_.Exception.ItemName
    }
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
    $CommandPattern = $Command
    $Content = Get-Content -Path $ExampleFile
    $SearchText = "Example"
    $SearchTextForNewImports = "{{ Add description here }}"
    $ReplaceEverything = $False
    if ($HeaderList.Count -eq 0) {
        for ($d = 0; $d -lt $ExampleList.Count; $d++) {
            $sum = $d + 1
            $HL = $HeaderList.Add("### Example " + $sum + ": Code snippet".Trim())
        }
    }
    if ($HeaderList.Count -ne $ExampleList.Count) {
        $HeaderList.Clear()
        for ($d = 0; $d -lt $ExampleList.Count; $d++) {
            $sum = $d + 1
            $H = $HeaderList.Add("### Example " + $sum + ": Code snippet".Trim())
        }
    }
    $EmptyFile = Test-FileEmpty $ExampleFile
    if ($EmptyFile -or ($Content | Select-String -pattern $SearchTextForNewImports)) {
        $ReplaceEverything = $True
    }
    $HeadCount = $HeaderList.Count
    $ExampleCount = $ExampleList.Count
    $WrongExamplesCount = 0;
    $SkippedExample = -1
    $TotalText = ""
    $ContainsRightExamples = $False
    $SearchString = "### Example \d:"
    $Option = [System.Text.RegularExpressions.RegexOptions]::Multiline
    $DescriptionRegex = [regex]::new($SearchString, $Option)
    #===========================Importing new examples into files ============================================#  
    if ($ReplaceEverything -and $ExampleCount -gt 0 -and $HeadCount -eq $ExampleCount) {
        Clear-Content $ExampleFile -Force
        for ($d = 0; $d -lt $HeaderList.Count; $d++) { 
            $CodeValue = $ExampleList[$d].Trim()
            if ($CodeValue -match "\b$CommandPattern\b") {
                $TitleValue = $HeaderList[$d].Trim()
                $TitleDesc = $TitleValue
                if (-not($TitleValue.Contains("Code snippet"))) {
                    if ($TitleDesc -match $DescriptionRegex) {
                        $TitleDesc = $TitleDesc -replace $DescriptionRegex, ''
                    }
                    $DescriptionPrefix = "This example will"
                    $FirstDescriptionString = $TitleDesc.Split(" ")[1]
                    if ($FirstDescriptionString.EndsWith("s")) {
                        $DescriptionPrefix = "This example"
                    }
                    elseif ($FirstDescriptionString.EndsWith("ing")) {
                        $DescriptionPrefix = "This example shows"
                    }
                    elseif ($FirstDescriptionString.EndsWith("Example")) {
                        $DescriptionPrefix = "This example shows how to use"
                    }
                    
                    $Description = ""
                    if ($FirstDescriptionString -eq "Example") {
                        $Description = "This example shows how to use the $CommandPattern Cmdlet."
                    }
                    else {
                        $Description = $DescriptionPrefix + $TitleDesc.ToLower()
                    }
                }
                $TotalText = "$TitleValue`r`n`n$CodeValue`r`n$Description`r`n"
                Add-Content -Path $ExampleFile -Value $TotalText
                $ContainsRightExamples = $True
            }
            else {    
                $WrongExamplesCount++
                $SkippedExample++
               
            }
        }
    }
    #The code below updates existing examples
    #------------------------------------------------------------#
    $PatternToSearch = "Import-Module Microsoft.Graph.$Module"
    if ($GraphProfile -eq "beta") {
        $PatternToSearch = "Import-Module Microsoft.Graph.Beta.$Module"
    }
    if (($Content | Select-String -pattern $SearchText) -and ($Content | Select-String -pattern "This example shows")) {
        $ContainsPatternToSearch = $False
        foreach ($List in $ExampleList) {
            if ($List.Contains($PatternToSearch) -and $List.Contains($CommandPattern)) {
                $ContainsPatternToSearch = $True
            }
        }
        Write-Host $ContainsPatternToSearch
        if ($ContainsPatternToSearch) {
            Clear-Content $ExampleFile -Force    
            for ($d = 0; $d -lt $HeaderList.Count; $d++) { 
                #We should only add the correct examples from external docs link
                if ($ExampleList[$d] -match "\b$CommandPattern\b") {
                    $CodeValue = $ExampleList[$d].Trim()
                    $TitleValue = $HeaderList[$d].Trim()
                    $TitleDesc = $TitleValue
                    if (-not($TitleValue.Contains("Code snippet"))) {
                        if ($TitleDesc -match $DescriptionRegex) {
                            $TitleDesc = $TitleDesc -replace $DescriptionRegex, ''
                        }
                        $DescriptionPrefix = "This example will"
                        $FirstDescriptionString = $TitleDesc.Split(" ")[1]
                        if ($FirstDescriptionString.EndsWith("s")) {
                            $DescriptionPrefix = "This example"
                        }
                        elseif ($FirstDescriptionString.EndsWith("ing")) {
                            $DescriptionPrefix = "This example shows"
                        }
                        elseif ($FirstDescriptionString.EndsWith("Example")) {
                            $DescriptionPrefix = "This example shows how to use"
                        }
                        
                        $Description = ""
                        if ($FirstDescriptionString -eq "Example") {
                            $Description = "This example shows how to use the $CommandPattern Cmdlet."
                        }
                        else {
                            $Description = $DescriptionPrefix + $TitleDesc.ToLower()
                        }
                    }      
                    $TotalText = "$TitleValue`r`n`n$CodeValue`r`n$Description`r`n"
                    Add-Content -Path $ExampleFile -Value $TotalText
                }
                else {
                    $SkippedExample++
            
                }

            }


        }
        else {
            Clear-Content $ExampleFile -Force
            if ($Content | Select-String -pattern $CommandPattern) {
                Retain-ExistingCorrectExamples -Content $Content -File $ExampleFile -CommandPattern $CommandPattern
            }
        }
        
    }
    $CheckIfFileEmpty = Test-FileEmpty $ExampleFile
    if ($CheckIfFileEmpty) {
        if ($Content) {
            Retain-ExistingCorrectExamples -Content $Content -File $ExampleFile -CommandPattern $CommandPattern
        }
    }
    #----------------------------------------------------------------------------------------------#
    #The code below corrects the numbering of the example headers/title if there is a situation where
    #some examples are wrong(which are left out) and some are right
    #-----------------------------------------------------------------------------------------------#
    $AvailableCorrectExamples = 1
    if ($SkippedExample -gt -1) {
        $NewContent = Get-Content -Path $ExampleFile
        foreach ($C in $NewContent) {
            if ($C.Contains("Example")) {
                $SearchString = $c.Split(":") 
                $StringToReplace = $SearchString[0]           
                $ReplacementString = "### Example $AvailableCorrectExamples"
                (Get-Content -Path $ExampleFile) -replace $StringToReplace, $ReplacementString | Set-Content $ExampleFile
                $AvailableCorrectExamples++
            }
        }
        if (-not(Test-Path -PathType Container $FolderForExamplesToBeReviewed)) {
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
    if (($WrongExamplesCount -gt 0) -and -not($ContainsRightExamples)) {
        Clear-Content $ExampleFile -Force
        Add-Content -Path $ExampleFile -Value $TotalText
        #Log api path api version and equivalent external doc url giving wron examples
        #Create folder and file if it doesn't exist
        #The artifact below will be ignored on git.
        #You can download the artificat from the generator pipeline

        if (-not(Test-Path -PathType Container $FolderForExamplesToBeReviewed)) {
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
function Test-FileEmpty {

    Param ([Parameter(Mandatory = $true)][string]$File)
  
    if ((Test-Path -LiteralPath $File) -and !((Get-Content -LiteralPath $File -Raw) -match '\S')) { return $true } else { return $false }
  
}

function Retain-ExistingCorrectExamples {
    Param (
        [object]$Content,
        [string]$File,
        [string]$CommandPattern
    )  
    $End = 0
    $NoOfExamples = 0
    foreach ($C in $Content) {
        if ($C.StartsWith("### Example")) {
            $NoOfExamples++
        }
        $End++  
    }
    Get-ExistingCorrectExamples -Content $Content -File $File -CommandPattern $CommandPattern -start 0 -end $End -NoOfExamples $NoOfExamples
    $TitleCount = 1
    $RetainedContent = $null
    foreach ($Ex in $RetainedExamples) {
        $ContentBody = $Ex.Split("**##@**")[0]
        $ContentTitle = $Ex.Split("**##@**")[1]
        $ContentDescription = $Ex.Split("**##@**")[2]
        if ($ContentBody -match "\b$CommandPattern\b") {
            $Val = $ContentTitle.Split("### Example ")
            $ToBeReplaced = $Val[1].Substring(0, 1)
            $ModifiedTitle = $ContentTitle.Replace($ToBeReplaced, $TitleCount)
            $ContentBody = $ContentBody.Replace($ContentTitle, $ModifiedTitle)
            $RetainedContent += "$ContentBody$ContentDescription"
            $TitleCount++
        }
                    
    }
    Set-Content -Path $File -Value $RetainedContent
    #Remove the last two empty lines at the end of the file
    $Stream = [IO.File]::OpenWrite($ExampleFile)
    try {
        $Stream.SetLength($stream.Length - 2)
        $Stream.Close()
    }
    catch {

    }
    $Stream.Dispose()
    $RetainedExamples.Clear()
}
function Get-ExistingCorrectExamples {

    Param (
        [object]$Content,
        [string]$File,
        [string]$CommandPattern,
        [int]$Start,
        [int]$End,
        [int]$NoOfExamples
    )
    $Title = $null
    $ContentBlock = $null
 
    for ($i = $Start; $i -lt $End; $i++) {
        $Value = $Content[$i]
        $ContentBlock += "$Value`n" 
        if ($Content[$i].StartsWith("### Example")) {
            $Title = $Content[$i]
        }   
        if ($Content[$i].EndsWith("``")) {
            $Start = $i
            break;
        }
    }
    $RetainedDescription = $null
    for ($j = $Start + 1; $j -lt $end; $j++) {
       
        if ($Content[$j].StartsWith("### Example")) {
            break;
        }
        $DescVal = $Content[$j]
        $RetainedDescription += "$DescVal`n"
    }
    $RetainedExamples.Add("$ContentBlock**##@**$Title**##@**$RetainedDescription")
    if ($NoOfExamples -gt 1) {
        $NoOfExamples--
        for ($k = $Start; $k -lt $End; $k++) {
            if ($Content[$k].StartsWith("### Example")) {
                $Start = $k
                break;
            }
        }
      
        Get-ExistingCorrectExamples -Content $Content -File $File -CommandPattern $CommandPattern -start $Start -end $End -NoOfExamples $NoOfExamples
    }
   
}
$RetainedExamples = New-Object Collections.Generic.List[string]

if (!(Get-Module "powershell-yaml" -ListAvailable -ErrorAction SilentlyContinue)) {
    Install-Module "powershell-yaml" -AcceptLicense -Scope CurrentUser -Force
}

If (-not (Get-Module -ErrorAction Ignore -ListAvailable PowerHTML)) {
    Write-Verbose "Installing PowerHTML module for the current user..."
    Install-Module PowerHTML -ErrorAction Stop -Scope CurrentUser -Force
}
Import-Module -ErrorAction Stop PowerHTML

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

#3. Test for v1.0 updates from api reference
#Start-Generator -GenerationMode "manual" -ManualExternalDocsUrl "https://docs.microsoft.com/graph/api/serviceprincipal-post-approleassignedto?view=graph-rest-v1.0" -GraphCommand "New-MgServicePrincipalAppRoleAssignedTo" -GraphModule "Applications" -Profile "v1.0"

#4. Test for beta updates from api reference
#Start-Generator -GenerationMode "manual" -ManualExternalDocsUrl "https://docs.microsoft.com/graph/api/serviceprincipal-post-approleassignedto?view=graph-rest-beta" -GraphCommand "New-MgBetaServicePrincipalAppRoleAssignedTo" -GraphModule "Applications" -Profile "beta"
#Start-Generator -GenerationMode "manual" -ManualExternalDocsUrl "https://learn.microsoft.com/en-us/graph/api/synchronization-synchronization-list-templates?view=graph-rest-beta&tabs=powershell" -GraphCommand "Get-MgBetaServicePrincipalSynchronizationTemplate" -GraphModule "Applications" -Profile "beta"