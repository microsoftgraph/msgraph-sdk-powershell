# Installing the Module

# Installing the Graph PowerShell module for the Beta API with no previous versions installed
Install-module Microsoft.Graph

# Uninstalling the old preview version, before installing the new

# Remove the main meta module
Uninstall-Module Microsoft.Graph

# Remove all the dependent modules
Get-InstalledModule Microsoft.Graph.* | %{ if($_.Name -ne "Microsoft.Graph.Authentication"){ Uninstall-Module $_.Name } }

# Update the authentication module from 0.1.5 to 0.2.0
Install-Module Microsoft.Graph.Authentication -Repository PSGallery -force

# Or uninstall the authentication module
Uninstall-Module Microsoft.Graph.Authentication

