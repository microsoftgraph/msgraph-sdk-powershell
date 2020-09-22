# Installing the Module

# Installing the Graph PowerShell module with no previous versions installed
Install-module Microsoft.Graph

# If upgrading from our preview modules, run install-module with AllowClobber and Force parameter to avoid command name conflicts
Install-Module Microsoft.Graph -AllowClobber -Force

# Updating from an earlier version of MS Graph PowerShell installed from PS Gallery
Update-module Microsoft.Graph

# Uninstalling the old preview version, before installing the new

# Remove the main meta module
Uninstall-Module Microsoft.Graph

# Remove all the dependent modules
Get-InstalledModule Microsoft.Graph.* | %{ if($_.Name -ne "Microsoft.Graph.Authentication"){ Uninstall-Module $_.Name } }

# Update the authentication module from 0.1.5 to 0.2.0
Install-Module Microsoft.Graph.Authentication -Repository PSGallery -force

# Or uninstall the authentication module
Uninstall-Module Microsoft.Graph.Authentication

