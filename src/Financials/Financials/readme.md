<!-- region Generated -->
# Microsoft.Graph.Financials
This directory contains the PowerShell module for the Financials service.

---
## Status
[![Microsoft.Graph.Financials](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Financials.svg?style=flat-square&label=Microsoft.Graph.Financials "Microsoft.Graph.Financials")](https://www.powershellgallery.com/packages/Microsoft.Graph.Financials/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Financials`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../readme.graph.md
  - $(this-folder)/../../../profiles/$(title)/readme.md
title: $(service-name)
subject-prefix: ''

```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Modify generated .dictionary.cs model classes in Financials module.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%5Capi%5CModels%5CMicrosoftGraph\w*\d*.dictionary.cs/gm))
      {
        return $;
      } else {
        // Rename additionalProperties indexer name in Financials module from Item to EntityItem to avoid property name conflict. salesOrderLine has a property named item.
        // See https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers
        let indexerRegex = /(^\s*)(public\s*global::System.Object this\[global::System.String index\]\s*{\W.*}$)/gm
        $ = $.replace(indexerRegex, '$1[System.Runtime.CompilerServices.IndexerName("EntityItem")]\n$1$2');
        return $;
      }
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
