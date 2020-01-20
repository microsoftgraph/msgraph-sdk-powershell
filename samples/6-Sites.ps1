# Microsoft Graph Sites PowerShell Snippets

# Get root site 
Get-MgSite -siteId root | Select-Object id, DisplayName

# Search for sites
Get-MgSite -search "marketing" | Select-Object DisplayName, Description, WebUrl

# Get Id for marketing site
$Sites = Get-MgSite -search "marketing" | Select-Object id

# Get Site Pages
Get-MgSitePage -SiteId $Sites[0].Id

# Get Site Lists
Get-MgSiteList -SiteId $Sites[0].Id | Select-Object id, DisplayName

# Get Document Libraries
Get-MgSiteDrive -SiteId $Sites[0].Id

