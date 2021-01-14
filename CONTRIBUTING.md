# Contributing

When contributing to this repository, please first open an an issue describing the update you wish to make, and read over our guidelines.

There are a few different recommended paths to get contributions into the released version of this SDK.

## Filing Issues
The best way to get started with a contribution is to start a dialog with us. Sometimes features will be under development or out of scope for this SDK and it's best to check before starting work on contribution, especially for large work items.

## Adding Scenario-Based Cmdlets
- Clone the repo - https://github.com/microsoftgraph/msgraph-sdk-powershell.git.
- Identify the module(s) that you want add the custom cmdlets to. E.g. [Groups](https://github.com/microsoftgraph/msgraph-sdk-powershell/tree/dev/src/Groups/Groups).
- Navigate to the module’s custom folder. E.g. [Groups/custom](https://github.com/microsoftgraph/msgraph-sdk-powershell/tree/dev/src/Groups/Groups/custom). In here, you will find a readme.md that has basic instructions on how to add custom cmdlets. A full guide can be found [here](https://github.com/Azure/autorest/blob/master/docs/powershell/customization.md#creating-a-new-cmdlet).
- In the custom directory, add your custom cmdlet naming the file as `{Verb}Mg{Subject}_{Variant}.(cs|ps)`. This file will contain the implementation of your custom cmdlet. You can refer to [NewMgGroupMember_Create.cs](https://github.com/microsoftgraph/msgraph-sdk-powershell/blob/dev/src/Groups/Groups/custom/NewMgGroupMember_Create.cs) as an example.
- Once done, bump up the module version number in the module’s root [readme.md](https://github.com/microsoftgraph/msgraph-sdk-powershell/blob/dev/src/Groups/Groups/readme.md#versioning) then run `.\msgraph-sdk-powershell\tools\GenerateModules.ps1 -Build` to create, build and export the cmdlets to `..\exports` folder.

## Modifying Existing Cmdlets
When it comes to modifying existing cmdlets, we recommend you use [AutoREST directive](https://github.com/Azure/autorest.powershell/blob/master/docs/directives.md#cmdlet-hiding-exportation-suppression).
- Identify cmdlets you want to modify, and the modules they reside in.
- In the module’s `readme.md`, add your directive in the AutoREST configuration sections to modify the lower-level cmdlets.
