# Pin to a maintained Ubuntu 22.04 PowerShell base tag instead of the floating :latest.
# The PowerShell team rebuilds these date-stamped rolling tags with patched OS layers, so a
# scheduled rebuild (see .azure-pipelines/docker-image-refresh.yml) picks up Ubuntu/USN and
# PowerShell CVE fixes and produces a fresh digest, clearing the S360
# "Replace Vulnerable Registry Reference" findings. Override at build time with
# --build-arg PS_BASE_TAG=<tag> (e.g. 7.4-ubuntu-22.04 or lts-ubuntu-22.04).
ARG PS_BASE_TAG=lts-ubuntu-22.04
FROM mcr.microsoft.com/powershell:${PS_BASE_TAG}

ARG VERSION=latest

RUN pwsh -c "if ('${VERSION}' -eq 'latest') { Install-Module Microsoft.Graph -Scope CurrentUser -AllowClobber -Force} else { Install-Module Microsoft.Graph -Scope CurrentUser -AllowClobber -Force -RequiredVersion ${VERSION} }"
RUN pwsh -c "if ('${VERSION}' -eq 'latest') { Install-Module Microsoft.Graph.Beta -Scope CurrentUser -AllowClobber -Force} else { Install-Module Microsoft.Graph.Beta -Scope CurrentUser -AllowClobber -Force -RequiredVersion ${VERSION} }"
RUN pwsh -c "if (!(Test-Path -Path \$PROFILE)) { New-Item -ItemType File -Path \$PROFILE -Force } echo 'Import-Module Microsoft.Graph.Authentication' >> \$PROFILE"

LABEL description="# Welcome to Microsoft Graph PowerShell \
To start learning about the module checkout the [getting started documentation](https://docs.microsoft.com/en-us/powershell/microsoftgraph/get-started)"
