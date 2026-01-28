        Write-Host "SkipOpenAPIDocsDownload: ${{ parameters.SkipOpenAPIDocsDownload }}"
        if ('${{ parameters.SkipOpenAPIDocsDownload }}' -eq 'True') {
          $ModuleNames = "Skipped"
          Write-Warning "Skipped OpenAPI Docs Download."
        } else  {
          $diff = git diff --name-only
          $ModulesWithChanges = @{}
          $diff | %{
            if ($_ -match 'openApiDocs\/(v1.0|beta)\/(.*)\.yml') {
              $version = if ($matches[1] -eq 'v1.0') { 'v1.0' } else { 'beta' }
              $moduleName = "$($matches[2])_$version"
              if (!$ModulesWithChanges.ContainsKey($moduleName)) {
                $ModulesWithChanges.Add($moduleName, $matches[1])
              }
            }
          }
          $ModuleNames = $ModulesWithChanges.Keys
          Write-Host "Modules with changes: $ModuleNames"
        }
        Write-Host "##vso[task.setvariable variable=ModulesWithChanges;isOutput=true]$ModuleNames"