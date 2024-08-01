FROM mcr.microsoft.com/powershell

ARG VERSION=latest

RUN pwsh -c "if ('${VERSION}' -eq 'latest') { Install-Module Microsoft.Graph -Scope CurrentUser -AllowClobber -Force} else { Install-Module Microsoft.Graph -Scope CurrentUser -AllowClobber -Force -RequiredVersion ${VERSION} }"
RUN pwsh -c "if (!(Test-Path -Path \$PROFILE)) { New-Item -ItemType File -Path \$PROFILE -Force } echo 'Import-Module Microsoft.Graph.Authentication' >> \$PROFILE"

LABEL description="# Welcome to Microsoft Graph PowrShell \
To start learning about the module checkout the [getting started documentation](https://docs.microsoft.com/en-us/powershell/microsoftgraph/get-started)"