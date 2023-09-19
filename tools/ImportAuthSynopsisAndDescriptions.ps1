[CmdletBinding()]
Param(
  [string] $DocsLocation = (Join-Path $PSScriptRoot "../src/Authentication/docs/"),
  [string] $SynopsisLocation = (Join-Path $PSScriptRoot "../src/Authentication/synopsis/"),
  [string] $DescriptionLocation = (Join-Path $PSScriptRoot "../src/Authentication/descriptions/")
  
)
$ImportMapping = @{
    "descriptions" = "## DESCRIPTION(?s).*## EXAMPLES"
    "synopsis" = "## SYNOPSIS(?s).*## SYNTAX"
}
function Start-Import {
    foreach ($File in Get-ChildItem $DocsLocation) {
        $ImportMapping.Keys | ForEach-Object {
            $ImportContent = $_
            $SearchBlock = $ImportMapping[$ImportContent]
            $LocationFile = (Join-Path $SynopsisLocation $File.Name)
            if($ImportContent -eq "descriptions") {
                $LocationFile = (Join-Path $DescriptionLocation $File.Name)
            }

    
        if (Test-Path $LocationFile) {
           $FileEmpty = Test-FileEmpty -File $LocationFile
           if(-not($FileEmpty)) {
              Write-Host $LocationFile
              $Content = Get-Content -Path $LocationFile
              $FinalOutput = "## SYNOPSIS`r`n$Content`r`n## SYNTAX"
              if($ImportContent -eq "descriptions") {
                $FinalOutput = "## DESCRIPTION`r`n$Content`r`n## EXAMPLES"
              }
              Import-Content -Content $Content -File $File -SearchBlock $SearchBlock -FinalOutput $FinalOutput
           }
        }
    }
    }
}


function Import-Content {
    Param (
        [object]$Content,
        [string]$File,
        [string]$SearchBlock,
        [string]$FinalOutput
    ) 

    $option = [System.Text.RegularExpressions.RegexOptions]::Multiline
    $Re = [regex]::new($SearchBlock, $option)
    if(Test-Path $File){
        $DestinationContent = Get-Content -Encoding UTF8 -Raw $File
     if($DestinationContent -match $Re){
        $Extracted = $Matches[0]
        $text = $DestinationContent.ToString()
        $text = $text.Replace($Extracted, $FinalOutput)
        }
          $text | Out-File $File -Encoding UTF8
     }
     $Stream = [IO.File]::OpenWrite($File)
     try
     {
         $Stream.SetLength($stream.Length - 2)
         $Stream.Close()
     }
     catch
     {
         
     }
     $Stream.Dispose()
    }

Function Test-FileEmpty {

    Param ([Parameter(Mandatory = $true)][string]$File)
  
    if ((Test-Path -LiteralPath $File) -and !((Get-Content -LiteralPath $file -Raw) -match '\S')) {return $true} else {return $false}
  
  }
Start-Import