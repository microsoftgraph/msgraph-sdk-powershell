Write-Host -ForegroundColor Green 'Packing Graph module...'
dotnet pack $PSScriptRoot --no-build /nologo
if ($LASTEXITCODE -ne 0) { throw "Packing Graph module failed (exit $LASTEXITCODE)." }
Write-Host -ForegroundColor Green '-------------Done-------------'