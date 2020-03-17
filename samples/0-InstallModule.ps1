# Installing the Module

# Installing the Graph PowerShell module for the Beta API with no previous versions installed
Install-module Microsoft.Graph

# Uninstalling the old preview version, before installing the new

# Remove the main meta module
Uninstall-Module Microsoft.Graph

# Remove all the dependent modules
Get-InstalledModule Microsoft.Graph.* | uninstall-module

# Update the authentication module from 0.1.4 to 0.1.5
Install-Module Microsoft.Graph.Authentication -Repository PSGallery -force

