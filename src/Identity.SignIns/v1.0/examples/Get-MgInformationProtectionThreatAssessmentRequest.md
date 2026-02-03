### Example 1: Get the properties of a mail assessment request

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgInformationProtectionThreatAssessmentRequest -ThreatAssessmentRequestId $threatAssessmentRequestId

```
This example will get the properties of a mail assessment request

### Example 2: Get the properties of an email file assessment request

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgInformationProtectionThreatAssessmentRequest -ThreatAssessmentRequestId $threatAssessmentRequestId

```
This example will get the properties of an email file assessment request

### Example 3: Get the properties of a file assessment request

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgInformationProtectionThreatAssessmentRequest -ThreatAssessmentRequestId $threatAssessmentRequestId

```
This example will get the properties of a file assessment request

### Example 4: Get the properties of an url assessment request

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgInformationProtectionThreatAssessmentRequest -ThreatAssessmentRequestId $threatAssessmentRequestId

```
This example will get the properties of an url assessment request

### Example 5: Expand threat assessment results for a request

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgInformationProtectionThreatAssessmentRequest -ThreatAssessmentRequestId $threatAssessmentRequestId -ExpandProperty "results" 

```
This example will expand threat assessment results for a request

