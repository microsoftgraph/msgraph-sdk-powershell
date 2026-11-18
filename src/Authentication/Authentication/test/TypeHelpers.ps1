function Get-MgAssemblyType {
    param(
        [Parameter(Mandatory)][string] $AssemblyName,
        [Parameter(Mandatory)][string] $TypeName
    )

    $assembly = [AppDomain]::CurrentDomain.GetAssemblies() |
        Where-Object { $_.GetName().Name -eq $AssemblyName } |
        Select-Object -First 1

    if ($null -eq $assembly) {
        throw "Assembly '$AssemblyName' is not loaded."
    }

    return $assembly.GetType($TypeName, $true)
}
