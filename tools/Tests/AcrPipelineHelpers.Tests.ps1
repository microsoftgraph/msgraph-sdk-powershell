# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

BeforeAll {
    . (Join-Path $PSScriptRoot '..\AcrPipelineHelpers.ps1')
}

Describe 'Set-CiModulePrerelease' {
    It 'sets every module prerelease value to the build-specific suffix' {
        $metadataPath = Join-Path $TestDrive 'ModuleMetadata.json'
        @{
            versions = @{
                authentication = @{ version = '2.39.0'; prerelease = '' }
                beta = @{ version = '2.39.0'; prerelease = '' }
                'v1.0' = @{ version = '2.39.0'; prerelease = '' }
            }
        } | ConvertTo-Json -Depth 10 | Set-Content -Path $metadataPath

        Set-CiModulePrerelease -MetadataPath $metadataPath -BuildId '12345' | Should -Be 'ci.12345'

        $metadata = Get-Content -Path $metadataPath -Raw | ConvertFrom-Json
        $metadata.versions.authentication.prerelease | Should -Be 'ci.12345'
        $metadata.versions.beta.prerelease | Should -Be 'ci.12345'
        $metadata.versions.'v1.0'.prerelease | Should -Be 'ci.12345'
    }
}

Describe 'Test-AcrPublishPath' {
    It 'matches relevant source and generation inputs' -ForEach @(
        'src/Authentication/Authentication/Microsoft.Graph.Authentication.psd1'
        'SRC\AUTHENTICATION\Authentication.Core\Authentication.cs'
        'config/ModuleMetadata.json'
        'autorest.powershell/packages/autorest.powershell/package.json'
        'openApiDocs/v1.0/Users.yml'
    ) {
        Test-AcrPublishPath -Path $_ | Should -BeTrue
    }

    It 'does not match unrelated paths' -ForEach @(
        'docs/readme.md'
        'samples/1-Users.ps1'
        'src/Users/v1.0/readme.md'
        '.azure-pipelines/ci-build.yml'
    ) {
        Test-AcrPublishPath -Path $_ | Should -BeFalse
    }

    It 'returns true when any changed path is relevant' {
        Test-AcrPublishPath -Path @('docs/readme.md', 'config/ModulesMapping.jsonc') | Should -BeTrue
    }
}
