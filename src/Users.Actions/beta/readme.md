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
