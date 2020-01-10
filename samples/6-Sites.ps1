# Microsoft Graph Sites PowerShell Snippets

# Get root site 
Get-Site -siteId root | Select-Object id, DisplayName

# Search for sites
Get-Site -search "marketing" | Select-Object DisplayName, Description, WebUrl

# Get Id for marketing site
$Sites = Get-Site -search "marketing" | Select-Object id

# Get Site Pages
Get-SitePage -SiteId $Sites[0].Id

# Get Site Lists
Get-SiteList -SiteId $Sites[0].Id | Select-Object id, DisplayName

# Get Document Libraries
Get-SiteDrive -SiteId $Sites[0].Id

