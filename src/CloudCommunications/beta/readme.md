<!-- region Generated -->
# Microsoft.Graph.Beta.CloudCommunications
This directory contains the PowerShell module for the CloudCommunications service.

---
## Status
[![Microsoft.Graph.Beta.CloudCommunications](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.CloudCommunications.svg?style=flat-square&label=Microsoft.Graph.Beta.CloudCommunications "Microsoft.Graph.Beta.CloudCommunications")](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.CloudCommunications/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Beta.CloudCommunications`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../CloudCommunications.md
title: $(service-name)
subject-prefix: 'Beta'
namespace: Microsoft.Graph.Beta.PowerShell
directive:
  - where:
      verb: Send
      subject: ^(CommunicationOnlineMeetingVirtualAppointmentReminderSm|CommunicationOnlineMeetingVirtualAppointmentSm)$
      variant: ^Send1$|^SendExpanded1$|^SendViaIdentity1$|^SendViaIdentityExpanded1$
    remove: true
```
