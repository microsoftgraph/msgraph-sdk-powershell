# Microsoft Graph Sites PowerShell Snippets
Select-MgProfile -Name 'beta'
# Get root site 
Get-MgSite -siteId root | Select-Object id, DisplayName

# Search for sites
Get-MgSite -search "marketing" | Select-Object DisplayName, Description, WebUrl

# Get Id for marketing site
$Sites = Get-MgSite -search "marketing" | Select-Object id
Select-MgProfile -Name 'v1.0'
# Get Site Pages
Get-MgSitePage -SiteId $Sites[0].Id

# Get Site Lists
Get-MgSiteList -SiteId $Sites[0].Id | Select-Object id, DisplayName
#Select-MgProfile -Name  'beta'
# Get Document Libraries
Get-MgSiteDrive -SiteId $Sites[0].Id
