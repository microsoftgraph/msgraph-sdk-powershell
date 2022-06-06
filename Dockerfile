FROM mcr.microsoft.com/powershell

RUN pwsh -c "Install-Module Microsoft.Graph -Scope CurrentUser -AllowClobber -Force "

LABEL description="# Welcome to Microsoft Graph PowrShell \
To start learning about the module checkout the [getting started documentation](https://docs.microsoft.com/en-us/powershell/microsoftgraph/get-started)"