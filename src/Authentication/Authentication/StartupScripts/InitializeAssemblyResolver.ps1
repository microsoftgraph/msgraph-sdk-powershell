try {
    if ($PSEdition -eq 'Core') {
        [Microsoft.Graph.PowerShell.Authentication.Utilities.DependencyAssemblyResolver]::Initialize()
    }
    else {
        [Microsoft.Graph.PowerShell.Authentication.Utilities.DependencyAssemblyResolver]::Initialize($true)
    }
}
catch {
    Write-Warning $_
}