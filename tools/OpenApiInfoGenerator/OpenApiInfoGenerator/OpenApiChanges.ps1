# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $v1_OpenAPIErrorFilePath = (Join-Path $PSScriptRoot "..\..\..\docs\OpenApiInfo\v1.0\"),
    [string] $beta_OpenAPIErrorFilePath = (Join-Path $PSScriptRoot "..\..\..\docs\OpenApiInfo\beta\"),
    [string] $OpenAPIErrorFileName = "openAPIErrors"
)

function Start-Validation {
    Write-Host "Validating OpenAPI errors..."
    $V1_OpenAPIErrorFile = Join-Path $v1_OpenAPIErrorFilePath "$OpenAPIErrorFileName.csv"
    $Beta_OpenAPIErrorFile = Join-Path $beta_OpenAPIErrorFilePath "$OpenAPIErrorFileName.csv"
    
    $GraphMapping = @{
        "v1.0" = $V1_OpenAPIErrorFile
        #"beta" = $Beta_OpenAPIErrorFile. Commenting out this to do checks for v1.0 only
    }
    $GraphMapping.Keys | ForEach-Object {
        $GraphProfile = $_
        $ErrorFile = $GraphMapping[$GraphProfile]
        if (Test-Path $ErrorFile) {
            #Check if the file is empty
            $ErrorFileContent = Get-Content -Path $ErrorFile -Raw
            if ([string]::IsNullOrEmpty($ErrorFileContent)) {
                Write-Host "No unnecessary errors found in $GraphProfile OpenAPI file."
            }
            else {
                #Throw error to stop the pipeline run
                Throw "Unnecessary errors found in $GraphProfile OpenAPI file."

            }
        }
        else {
            Write-Host "No errors found in $GraphProfile OpenAPI file."
        }
    }

}
Start-Validation