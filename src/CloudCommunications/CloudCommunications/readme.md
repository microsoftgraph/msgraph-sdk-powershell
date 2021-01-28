<!-- region Generated -->
# Microsoft.Graph.CloudCommunications
This directory contains the PowerShell module for the CloudCommunications service.

---
## Status
[![Microsoft.Graph.CloudCommunications](https://img.shields.io/powershellgallery/v/Microsoft.Graph.CloudCommunications.svg?style=flat-square&label=Microsoft.Graph.CloudCommunications "Microsoft.Graph.CloudCommunications")](https://www.powershellgallery.com/packages/Microsoft.Graph.CloudCommunications/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.CloudCommunications`, see [how-to.md](how-to.md).
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
# Remove invalid paths.
  - remove-path-by-operation: ^communications(.cloudCommunications_.*CloudCommunications|_(List|Create|Update|Delete)CallRecords|.callRecords.sessions_.*Segments|(_List|_Update)Calls)$
# Rename cmdlets
  - where:
      verb: Invoke
      subject: ^Mute(CommunicationCallParticipant)$
      variant: ^Mute1$|^MuteExpanded1$|^MuteViaIdentity1$|^MuteViaIdentityExpanded1$
    set:
      subject: MuteAll$1
  - where:
      verb: New
      subject: ^(CommunicationOnlineMeeting)$
      variant: ^Create$|^CreateExpanded$|^Create2$|^CreateExpanded2$
    set:
      verb: Invoke
      subject: CreateOrGet$1
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
