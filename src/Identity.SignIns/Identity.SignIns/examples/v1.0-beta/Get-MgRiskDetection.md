### Example 1: Get all riskDetections
```powershell
Connect-MgGraph -Scopes "IdentityRiskEvent.Read.All"
Get-Mgriskdetection -All|Format-Table UserDisplayName,RiskType,RiskLevel,DetectedDateTime

UserDisplayName RiskType                      RiskLevel DetectedDateTime
--------------- --------                      --------- ----------------
Jason Mayer     anonymizedIPAddress           medium    4/19/2022 10:44:40 PM
Jason Mayer     generic                       medium    4/20/2022 1:16:29 PM
Jason Mayer     anonymizedIPAddress           high      4/21/2022 9:50:28 PM
Jason Mayer     unfamiliarFeatures            high      4/21/2022 10:07:33 PM
Jason Mayer     unlikelyTravel                medium    4/21/2022 10:42:04 PM
Jason Mayer     generic                       medium    4/23/2022 12:52:20 PM
Alice Su        unfamiliarFeatures            low       5/2/2022 12:01:44 AM
Alice Su        unlikelyTravel                low       5/2/2022 2:16:22 AM
```

This command returns a list of all users.

### Example 2: Get riskDetections by user displayname
```powershell
Connect-MgGraph -Scopes "IdentityRiskEvent.Read.All"
Get-Mgriskdetection -All|Format-Table UserDisplayName,RiskType,RiskLevel,DetectedDateTime

UserDisplayName RiskType                      RiskLevel DetectedDateTime
--------------- --------                      --------- ----------------
Jason Mayer     anonymizedIPAddress           medium    4/19/2022 10:44:40 PM
Jason Mayer     generic                       medium    4/20/2022 1:16:29 PM
Jason Mayer     anonymizedIPAddress           high      4/21/2022 9:50:28 PM
Jason Mayer     unfamiliarFeatures            high      4/21/2022 10:07:33 PM
Jason Mayer     unlikelyTravel                medium    4/21/2022 10:42:04 PM
Jason Mayer     generic                       medium    4/23/2022 12:52:20 PM
```

This command returns all risk detections for the specified user 

### Example 3: Get riskDetections by risk type
```powershell
Connect-MgGraph -Scopes "IdentityRiskEvent.Read.All"
Get-Mgriskdetection -Filter "RiskType eq 'anonymizedIPAddress'" |Format-Table UserDisplayName,RiskType,RiskLevel,DetectedDateTime

UserDisplayName RiskType            RiskLevel DetectedDateTime
--------------- --------            --------- ----------------
Jason Mayer     anonymizedIPAddress high      4/21/2022 9:50:28 PM
Jason Mayer     anonymizedIPAddress medium    4/19/2022 10:44:40 PM
Alex  Su        anonymizedIPAddress high      6/9/2022 4:31:19 AM
```

This command returns all risk detections for the anonymizedIPAddress risk detection

### Example 4: Get all riskDetections for a particular user with high risk
```powershell
Connect-MgGraph -Scopes "IdentityRiskEvent.Read.All"
Get-Mgriskdetection -Filter "userdisplayname eq 'Jason Mayer' and Risklevel eq 'high'" |Format-Table UserDisplayName,RiskType,RiskLevel,DetectedDateTime

UserDisplayName RiskType                      RiskLevel DetectedDateTime
--------------- --------                      --------- ----------------
Jason Mayer     anonymizedIPAddress           high      4/21/2022 9:50:28 PM
Jason Mayer     unfamiliarFeatures            high      4/21/2022 10:07:33 PM
```
This command returns all risk detections with high risks for the specified user 
