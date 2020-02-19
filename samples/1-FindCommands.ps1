
# Modules Current Available
Find-module Microsoft.Graph* | Select-Object Name

# Commands Available for licenses 
Get-Command -Module Microsoft.Graph* *license*

# Commands Available for Outlook tasks 
Get-Command -Module Microsoft.Graph* *OutlookTask*

# Commands Available for Teams  
Get-Command -Module Microsoft.Graph* *Team*