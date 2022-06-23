FROM mcr.microsoft.com/powershell

ARG MODULE_VERSION=latest

RUN pwsh -c "if ('${MODULE_VERSION}' -eq 'latest') { Install-Module Microsoft.Graph -Scope CurrentUser -AllowClobber -Force} else { Install-Module Microsoft.Graph -Scope CurrentUser -AllowClobber -Force -Version ${MODULE_VERSION} }"

LABEL description="# Welcome to Microsoft Graph PowrShell \
To start learning about the module checkout the [getting started documentation](https://docs.microsoft.com/en-us/powershell/microsoftgraph/get-started)"