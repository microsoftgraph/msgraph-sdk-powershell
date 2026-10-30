# Contributing

When contributing to this repository, please first open an an issue describing the update you wish to make, and read over our guidelines.

There are a few different recommended paths to get contributions into the released version of this SDK.

## Filing Issues

The best way to get started with a contribution is to start a dialog with us. Sometimes features will be under development or out of scope for this SDK and it's best to check before starting work on contribution, especially for large work items.

## Adding or Modifying v3 Cmdlets

The v3 SDK uses Kiota clients and [WrapperGenerator](tools/WrapperGenerator/README.md).
It does not require the AutoRest submodule or its Node.js/Rush toolchain.

Identify the affected module and update its wrapper cmdlet configuration in
`src\<Module>\wrapper\<Module>_cmdletConfigurations.cs`, or the generator when a behavior
change is required. See the generator documentation for configuration matching and generated
cmdlet behavior. Regenerate rather than hand-editing generated clients or cmdlets.

Legacy per-module AutoRest directives, customizations, and `src\readme.graph.md` remain as
historical migration references. They are not the v3 generation entry point.

## SDK Generation

Use the .NET SDK and Kiota CLI described in the [wrapper tooling guide](tools/README.md).
For example, generate and build one module with:

```powershell
.\tools\Build-WrapperModule.ps1 -Module Mail -ApiVersion v1.0
```

Use `-ApiVersion beta` for beta modules and `-SkipKiota` to reuse a committed client.
The v3 release pipeline is `.azure-pipelines\wrapper-release.yml`; the legacy AutoRest
generation and release pipeline entry points have been retired from this branch.

## Debugging the Auth module

* In a terminal run `.\tools\GenerateAuthenticationModule.ps1 -Build -Pack`
* In Visual Studio open the `.\src\Authentication\Authentication.sln` solution
* Start the project in debug mode
* In the newly opened terminal run `pwd` to get the current working directory for the debug session
* Copy the `Microsoft.Graph.Authencation.<version-number>.nupkg` to the working directory for the debug session
* Rename the `.nupkg` file to `.zip`
* Unzip the files to the working directory
* In the working directory run `Import-Module .\Microsoft.Graph.Authentication.psm1`
* Run any cmdlet from the Authentication module to hit your breakpoints