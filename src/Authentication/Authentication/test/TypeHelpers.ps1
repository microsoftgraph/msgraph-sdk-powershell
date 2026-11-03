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

function Set-MgTestDataStore {
    $coreType = Get-MgAssemblyType -AssemblyName 'Microsoft.Graph.Authentication.Core' -TypeName 'Microsoft.Graph.PowerShell.Authentication.GraphSession'
    if ($null -eq ('Microsoft.Graph.Authentication.Test.Mocks.MockDataStore' -as [type])) {
        $references = @((Get-ChildItem (Join-Path $PSHOME 'ref') -Filter '*.dll').FullName) + @($coreType.Assembly.Location)
        # The net6.0 Core contract uses the host's newer shared framework at runtime.
        Add-Type -Path (Join-Path $PSScriptRoot '..\..\Authentication.Test\Mocks\MockDataStore.cs') -ReferencedAssemblies $references -CompilerOptions '/nowarn:1701'
    }
    $coreType.GetProperty('Instance').GetValue($null).DataStore = [Microsoft.Graph.Authentication.Test.Mocks.MockDataStore]::new()
}
