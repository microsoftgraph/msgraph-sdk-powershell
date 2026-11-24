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

Wrapper migration audit: all 17 shared cmdlet groups are accounted for in
`wrapper/DirectoryObjects_directiveMigrationMap.json`. Neither compatible profile
contains PKI routes; v1.0 has none in its legacy source either, while the ledger
records the exact legacy beta methods, paths, and operation IDs. No speculative
suppression overrides are needed. `DirectoryObjectsDirectiveMigrationTests`
pins the evidence and preserves the live directoryObjects neighbors.

Profile-local readmes and `src/readme.graph.md` are intentionally excluded.
There are no shared parameter/schema directives here; those classes remain
deferred. Keep every original AutoRest directive active until that pipeline is
retired.

``` yaml
directive:
# Remove duplicate cmdlets.
# Wrapper audit group 1: beta certificate-authority DELETE is absent in compatible specs.
  - where:
      verb: Remove
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority$
    remove: true
# Wrapper audit group 2: beta configuration PATCH is absent in compatible specs.
  - where:
      verb: Update
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration$
    remove: true
# Wrapper audit group 3: beta PKI PATCH is absent in compatible specs.
  - where:
      verb: Update
      subject: ^DirectoryPublicKeyInfrastructure$
    remove: true
# Wrapper audit group 4: exact duplicate of group 1; retained and audited separately.
  - where:
      verb: Remove
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority$
    remove: true
# Wrapper audit group 5: beta certificate-authority POST is absent in compatible specs.
  - where:
      verb: New
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority$
    remove: true
# Wrapper audit group 6: literal Mg-prefixed subject matches no legacy subject.
  - where:
      verb: New
      subject: ^MgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration$
    remove: true
# Wrapper audit group 7: beta qualified upload action is absent in compatible specs.
  - where:
      verb: Invoke
      subject: ^UploadDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration$
    remove: true
# Wrapper audit group 8: beta configuration count GET is absent in compatible specs.
  - where:
      verb: Get
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCount$
    remove: true
# Wrapper audit group 9: literal MgBeta-prefixed subject matches no legacy subject.
  - where:
      verb: Get
      subject: ^MgBetaDirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthorityCount$
    remove: true
# Wrapper audit group 10: beta certificate-authority collection/item GETs are absent.
  - where:
      verb: Get
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority$
    remove: true
# Wrapper audit group 11: beta configuration collection/item GETs are absent.
  - where:
      verb: Get
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration$
    remove: true
# Wrapper audit group 12: beta PKI GET is absent in compatible specs.
  - where:
      verb: Get
      subject: ^DirectoryPublicKeyInfrastructure$
    remove: true
# Wrapper audit group 13: beta certificate-authority count GET is absent.
  - where:
      verb: Get
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthorityCount$
    remove: true
# Wrapper audit group 14: beta configuration POST is absent in compatible specs.
  - where:
      verb: New
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration$
    remove: true
# Wrapper audit group 15: beta PKI DELETE is absent in compatible specs.
  - where:
      verb: Remove
      subject: ^DirectoryPublicKeyInfrastructure$
    remove: true
# Wrapper audit group 16: beta configuration DELETE is absent in compatible specs.
  - where:
      verb: Remove
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration$
    remove: true
# Wrapper audit group 17: beta certificate-authority PATCH is absent.
  - where:
      verb: Update
      subject: ^DirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority$
    remove: true
    
```
