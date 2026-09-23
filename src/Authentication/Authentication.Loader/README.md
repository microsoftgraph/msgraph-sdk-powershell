# Microsoft.Graph.Authentication.Loader

A tiny, dependency-free assembly that gives the `Microsoft.Graph.Authentication` PowerShell module its own
`AssemblyLoadContext` on PowerShell 7+.

## Why it exists

`Microsoft.Graph.Authentication` depends on a number of assemblies that other PowerShell modules also ship
(`Microsoft.Identity.Client`, `Azure.Identity`, `Azure.Core`, `Microsoft.Kiota.*`, `System.Text.Json`, ...). Historically
those assemblies were loaded into the *default* load context. Whichever module was imported first "won", and the second
module frequently failed with `FileLoadException` / `MissingMethodException` because a different version of the same
assembly was already loaded.

The loader fixes this by loading `Microsoft.Graph.Authentication.Core` (the engine) and all of its third-party
dependencies into a **private** `AssemblyLoadContext`. Other modules never see them, and the module never sees theirs.

## What lives where

```
Microsoft.Graph.Authentication/            (module root – default load context)
├── Microsoft.Graph.Authentication.psd1    manifest (no NestedModules / RequiredAssemblies!)
├── Microsoft.Graph.Authentication.psm1    root module – bootstraps the loader, then imports the dll
├── Microsoft.Graph.Authentication.dll     cmdlets only; may NOT reference isolated assemblies
├── Newtonsoft.Json.dll                    shared with the generated service modules, stays in Default
└── Dependencies/
	├── *.dll                              netstandard2.0 dependencies (Azure.Identity, MSAL, Kiota, ...)
	├── Core/                              PowerShell 7+ only – loaded into the private context
	│   ├── Microsoft.Graph.Authentication.Loader.dll   ← this project
	│   ├── Microsoft.Graph.Authentication.Core.dll
	│   └── *.dll                          net6.0-specific dependencies
	└── Desktop/                           Windows PowerShell 5.1 only (net472 builds, no load contexts)
```

## How it works

1. **`Microsoft.Graph.Authentication.psm1`** runs first (it is the `RootModule`). On PowerShell 7+ it does
   `Assembly.LoadFrom("Dependencies/Core/Microsoft.Graph.Authentication.Loader.dll")` and calls
   `GraphLoadContextInitializer.Initialize(dependencyFolder, coreDependencyFolder)`.
2. **`GraphLoadContextInitializer`** creates a single `GraphAssemblyLoadContext` and subscribes to
   `AssemblyLoadContext.Default.Resolving`. Whenever the default context fails to find
   `Microsoft.Graph.Authentication.Core`, the handler returns the copy loaded in the private context.
3. The psm1 then `Import-Module`s `Microsoft.Graph.Authentication.dll`. That assembly is loaded into the default
   context by PowerShell, but its reference to `Microsoft.Graph.Authentication.Core` is satisfied by step 2 and
   therefore resolves into the private context.
4. **`GraphAssemblyLoadContext.Load`** is called for every assembly `Core` (or anything else in the context) needs:
   - assemblies in `s_sharedAssemblyNames` (e.g. `Newtonsoft.Json`, `System.Management.Automation`) and every
	 **Trusted Platform Assembly** (the shared framework, e.g. `System.Memory`, `System.Text.Json`) return `null`,
	 which defers to the default context so type identity is preserved across the boundary;
   - everything else is probed in `Dependencies/Core` first, then `Dependencies`, and loaded privately.
5. **`GraphAssemblyLoadContext.LoadUnmanagedDll`** resolves native libraries (e.g. `msalruntime`) from the
   `runtimes/<rid>/native` folders next to the managed dependencies.
6. On `Remove-Module`, `ModuleInitializer.OnRemove` calls `GraphLoadContextInitializer.Shutdown()` which
   unsubscribes the `Resolving` handler. The context itself is non-collectible; assemblies stay loaded for the
   lifetime of the process, as is normal for PowerShell binary modules.

### Why the framework assemblies must be deferred

`Dependencies/` contains netstandard2.0 facades such as `System.Memory.dll`. If the private context loaded those,
`ReadOnlyMemory<byte>` inside the context would be a *different type* from the one in the runtime. Overrides of
framework methods (e.g. `UnsafeTokenCacheOptions.RefreshCacheAsync`) would then fail with
`TypeLoadException: ... does not have an implementation`. Checking `AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")`
makes sure anything shipped by the runtime is always taken from the runtime.

## Rules for the rest of the module

- **No `NestedModules` / `RequiredAssemblies` in the manifest.** PowerShell processes those *before* the `RootModule`,
  which would load the cmdlet dll (and try to bind `Core`) before the loader is initialised. `build-module.ps1` fails
  the build if either is present.
- **`Microsoft.Graph.Authentication.dll` must not reference isolated assemblies.** Types from `Azure.*`, `Microsoft.Identity.*`,
  `Microsoft.Graph.Core`, `Microsoft.Kiota.*`, `System.Text.Json`, ... must stay behind APIs in `Core`. The xUnit test
  `AssemblyIsolationTests` in `Authentication.Test` guards this.
- **Script cmdlets cannot use type literals for `Core` types.** `[Microsoft.Graph.PowerShell.Authentication.GraphSession]`
  is not resolvable from PowerShell because it lives in the private context. Use a type in the cmdlet assembly (e.g.
  `GraphCommandCache`) or match on type name / resolve reflectively via the loaded assembly.
- **This project must stay dependency-free** and target the lowest runtime the module supports on PowerShell 7 (`net6.0`).
  It is loaded into the default context, so any package it referenced would be back in the shared space.

## Windows PowerShell 5.1

.NET Framework has no `AssemblyLoadContext`. The loader is not used there; instead the psm1 pre-loads
`Dependencies/Desktop` and `Dependencies` with `Assembly.LoadFrom`, and `ModuleInitializer` keeps an
`AppDomain.AssemblyResolve` handler as a fallback. Conflicts with other modules remain possible on 5.1, exactly as before.

## Verifying isolation

```powershell
Import-Module ./artifacts/Microsoft.Graph.Authentication.psd1
Connect-MgGraph -AccessToken (ConvertTo-SecureString -AsPlainText -Force '<token>')
[AppDomain]::CurrentDomain.GetAssemblies() |
	Where-Object { $_.GetName().Name -match 'Identity|Azure|Kiota|Graph' } |
	ForEach-Object { '{0,-45} {1}' -f $_.GetName().Name, [System.Runtime.Loader.AssemblyLoadContext]::GetLoadContext($_).Name }
```

Everything except `Microsoft.Graph.Authentication` and `Microsoft.Graph.Authentication.Loader` should report
`Microsoft.Graph.Authentication` as its load context. `test/AssemblyIsolation.Tests.ps1` automates this, including a
scenario where a conflicting `Microsoft.Identity.Client` is pre-loaded before importing the module.
