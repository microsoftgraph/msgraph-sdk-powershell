# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

if ($TestMode -eq 'live' -or $TestMode -eq 'record') {
    Connect-MgGraph -ClientId $env:testApp_clientId -TenantId $env:testApp_tenantId -CertificateThumbprint $env:testApp_certThumbprint
}
else {
    # Use dummy access token to run Pester tests.
    # Provide the dummy access token to $env:testApp_dummyAccessToken in your environment variable.
    Connect-MgGraph -AccessToken (ConvertTo-SecureString -String $env:testApp_dummyAccessToken -AsPlainText)
}
