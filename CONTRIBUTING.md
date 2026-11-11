# Contributing

When contributing to this repository, please first open an an issue describing the update you wish to make, and read over our guidelines.

There are a few different recommended paths to get contributions into the released version of this SDK.

## Filing Issues

The best way to get started with a contribution is to start a dialog with us. Sometimes features will be under development or out of scope for this SDK and it's best to check before starting work on contribution, especially for large work items.

## Adding Scenario-Based Cmdlets

- Clone the repo - <https://github.com/microsoftgraph/msgraph-sdk-powershell.git>.
- Identify the module(s) that you want add the custom cmdlets to. E.g. [Groups](https://github.com/microsoftgraph/msgraph-sdk-powershell/tree/dev/src/Groups/Groups).
- Navigate to the module’s custom folder. E.g. [Groups/custom](https://github.com/microsoftgraph/msgraph-sdk-powershell/tree/dev/src/Groups/Groups/custom). In here, you will find a readme.md that has basic instructions on how to add custom cmdlets. A full guide can be found [here](https://github.com/Azure/autorest/blob/master/docs/powershell/customization.md#creating-a-new-cmdlet).
- In the custom directory, add your custom cmdlet naming the file as `{Verb}Mg{Subject}_{Variant}.(cs|ps)`. This file will contain the implementation of your custom cmdlet. You can refer to [NewMgGroupMember_Create.cs](https://github.com/microsoftgraph/msgraph-sdk-powershell/blob/dev/src/Groups/v1.0/custom/NewMgGroupMember_Create.cs) as an example.
- Once done, bump up the module version number in the module’s root [readme.md](https://github.com/microsoftgraph/msgraph-sdk-powershell/blob/dev/src/Groups/Groups/readme.md#versioning) then run `.\msgraph-sdk-powershell\tools\GenerateModules.ps1 -Build` to create, build and export the cmdlets to `..\exports` folder.

## Modifying Existing Cmdlets

When it comes to modifying existing cmdlets, we recommend you use [AutoREST directive](https://github.com/Azure/autorest.powershell/blob/master/docs/directives.md#cmdlet-hiding-exportation-suppression).

- Identify cmdlets you want to modify, and the modules they reside in.
- In the module’s `readme.md`, add your directive in the AutoREST configuration sections to modify the lower-level cmdlets.

## SDK generation

See our [SDK generation steps wiki](https://github.com/microsoftgraph/msgraph-sdk-powershell/wiki/Generation-Process) for more information.

Build tooling is installed with `npm install --no-package-lock` at the repository root.
Keep the root `@microsoft/rush` version aligned with `autorest.powershell/rush.json` so Rush
uses the local installation rather than bootstrapping an unconstrained dependency tree.
The root manifest temporarily overrides Rush's `@typespec/ts-http-runtime` to `0.3.9`
to avoid the ESM-only proxy dependency introduced in `0.3.10` while CI remains on Node 18.
This is a compatibility workaround, not a change to the supported Node requirements of those dependencies.

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