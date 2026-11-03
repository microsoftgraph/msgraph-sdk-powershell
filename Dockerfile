# The PowerShell team no longer publishes mcr.microsoft.com/powershell images (frozen since
# 2025-01-30; see https://github.com/PowerShell/Announcements/issues/75), so rebuilding on them
# cannot pick up Ubuntu/USN or PowerShell fixes. Use the .NET SDK image instead: it ships the
# current LTS PowerShell and is rebuilt by the .NET team with patched OS layers, so the scheduled
# rebuild (.azure-pipelines/docker-image-refresh.yml) produces a patched digest.
# Override at build time with --build-arg BASE_IMAGE=<image>.
ARG BASE_IMAGE=mcr.microsoft.com/dotnet/sdk:10.0-noble
FROM ${BASE_IMAGE}

ARG VERSION=latest

RUN pwsh -c "if ('${VERSION}' -eq 'latest') { Install-Module Microsoft.Graph -Scope CurrentUser -AllowClobber -Force} else { Install-Module Microsoft.Graph -Scope CurrentUser -AllowClobber -Force -RequiredVersion ${VERSION} }"
RUN pwsh -c "if ('${VERSION}' -eq 'latest') { Install-Module Microsoft.Graph.Beta -Scope CurrentUser -AllowClobber -Force} else { Install-Module Microsoft.Graph.Beta -Scope CurrentUser -AllowClobber -Force -RequiredVersion ${VERSION} }"
RUN pwsh -c "if (!(Test-Path -Path \$PROFILE)) { New-Item -ItemType File -Path \$PROFILE -Force } echo 'Import-Module Microsoft.Graph.Authentication' >> \$PROFILE"

LABEL description="# Welcome to Microsoft Graph PowerShell \
To start learning about the module checkout the [getting started documentation](https://docs.microsoft.com/en-us/powershell/microsoftgraph/get-started)"

# The .NET SDK image defaults to /bin/bash; keep PowerShell as the default command.
CMD ["pwsh"]
