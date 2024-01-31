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
      subject: ^(UserOnlineMeetingVirtualAppointmentReminderSm)$
    remove: true
```
