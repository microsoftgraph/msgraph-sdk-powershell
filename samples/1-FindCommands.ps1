
# Modules Current Available
Find-Module -Repository GraphPowerShell | Select-Object Name

# Commands Available for licenses 
Get-Command -Module Microsoft.Graph.Beta* *license*

# Commands Available for Outlook tasks 
Get-Command -Module Microsoft.Graph.Beta* *OutlookTask*

# Commands Available for Teams  
Get-Command -Module Microsoft.Graph.Beta* *Team*