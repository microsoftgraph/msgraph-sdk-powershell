# Financials

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Financials v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
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
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
