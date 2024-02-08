<!-- region Generated -->
# Microsoft.Graph.Beta.Users.Actions
This directory contains the PowerShell module for the UsersActions service.

---
## Status
[![Microsoft.Graph.Beta.Users.Actions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Users.Actions.svg?style=flat-square&label=Microsoft.Graph.Beta.Users.Actions "Microsoft.Graph.Beta.Users.Actions")](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Users.Actions/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Beta.Users.Actions`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../Users.Actions.md
title: $(service-name)
subject-prefix: 'Beta'
namespace: Microsoft.Graph.Beta.PowerShell
directive:
  - where:
      verb: Send
      subject: ^(UserOnlineMeetingVirtualAppointmentReminderSm|UserOnlineMeetingVirtualAppointmentSm)$
      variant: ^Send1$|^SendExpanded1$|^SendViaIdentity1$|^SendViaIdentityExpanded1$
    remove: true
```
