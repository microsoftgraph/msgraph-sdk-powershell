# DirectoryObjects

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for DirectoryObjects v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Remove duplicate cmdlets.
  - where:
      verb: Remove
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority$
    remove: true
  - where:
      verb: Update
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration$
    remove: true
  - where:
      verb: Update
      subject: ^DirectoryPublicKeyInfrastructure$
    remove: true
  - where:
      verb: Remove
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority$
    remove: true
  - where:
      verb: New
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority$
    remove: true
  - where:
      verb: New
      subject: ^MgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration$
    remove: true
  - where:
      verb: Invoke
      subject: ^UploadDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration$
    remove: true
  - where:
      verb: Get
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCount$
    remove: true
  - where:
      verb: Get
      subject: ^MgBetaDirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthorityCount$
    remove: true
  - where:
      verb: Get
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority$
    remove: true
  - where:
      verb: Get
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration$
    remove: true
  - where:
      verb: Get
      subject: ^DirectoryPublicKeyInfrastructure$
    remove: true
```
