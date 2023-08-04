Write-Host -ForegroundColor Green 'Packing Graph module...'
dotnet pack $PSScriptRoot --no-build /nologo
Write-Host -ForegroundColor Green '-------------Done-------------'