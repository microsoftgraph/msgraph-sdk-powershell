BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    # Set test mode to playback.
    $TestMode = 'playback'
    $TestRecordingFile = Join-Path $PSScriptRoot 'New-MgIdentityConditionalAccessNamedLocation.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName

    Select-MgProfile 'beta'
}

Describe 'New-MgIdentityConditionalAccessNamedLocation' {
    BeforeAll {
        $Mock.PushDescription('New-MgIdentityConditionalAccessNamedLocation')
    }

    Context 'Create' {
        It 'Should create an ipNamedLocation' {
            $Mock.PushScenario('ShouldCreateAnIpNamedLocation')
            $params = @{
                "@odata.type" = "#microsoft.graph.ipNamedLocation"
                DisplayName = "Untrusted IP named location"
                IsTrusted = $false
                IpRanges = @(
                    @{
                        "@odata.type" = "#microsoft.graph.iPv4CidrRange"
                        CidrAddress = "12.34.221.11/22"
                    }
                    @{
                        "@odata.type" = "#microsoft.graph.iPv6CidrRange"
                        CidrAddress = "2001:0:9d38:90d6:0:0:0:0/63"
                    }
                )
            }

            # Redirect debug stream to variable.
            $IpNamedLocation = New-MgIdentityConditionalAccessNamedLocation -BodyParameter $params -Debug -Confirm:$false 5>&1

            $IpNamedLocation.DisplayName | Should -Be $params.DisplayName
            $IpNamedLocation.AdditionalProperties.ipRanges | Should -HaveCount 2
            $HttpRequestLog = $IpNamedLocation | Where-Object { $_ -Like "*HTTP REQUEST*" }
            $HttpRequestLog.Message | Should -BeLikeExactly '*"isTrusted": false*'
            $HttpRequestLog.Message | Should -BeLikeExactly '*"ipRanges":*'
        }

        It 'Should create a countryNamedLocation' {
            $Mock.PushScenario('ShouldCreateACountryNamedLocation')
            $params = @{
                "@odata.type" = "#microsoft.graph.countryNamedLocation"
                DisplayName = "Named location with unknown countries and regions"
                CountriesAndRegions = @(
                    "US"
                    "GB"
                )
                IncludeUnknownCountriesAndRegions = $true
            }

            # Redirect debug stream to variable.
            $CountryNamedLocation = New-MgIdentityConditionalAccessNamedLocation -BodyParameter $params -Debug -Confirm:$false 5>&1

            $CountryNamedLocation.DisplayName | Should -Be $params.DisplayName
            $CountryNamedLocation.AdditionalProperties.countriesAndRegions | Should -HaveCount 2
            $HttpRequestLog = $CountryNamedLocation | Where-Object { $_ -Like "*HTTP REQUEST*" }
            $HttpRequestLog.Message | Should -BeLikeExactly '*"includeUnknownCountriesAndRegions": true*'
            $HttpRequestLog.Message | Should -BeLikeExactly '*"countriesAndRegions":*'
        }
    }
}
