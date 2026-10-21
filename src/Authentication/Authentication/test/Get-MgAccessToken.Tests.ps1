# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
[Diagnostics.CodeAnalysis.SuppressMessageAttribute('PSAvoidUsingConvertToSecureStringWithPlainText', '', Justification='Just an example for testing purposes.')]
param()
BeforeAll {
	$ModuleName = "Microsoft.Graph.Authentication"
	$ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
	Import-Module $ModulePath -Force
	# Test JWT access token. Holds dummy values with an "exp" claim far in the future.
	$DummyToken = "eyJhbGciOiJIUzI1NiJ9.eyJSb2xlIjoiVGVzdCIsIklzc3VlciI6Iklzc3VlciIsIlVzZXJuYW1lIjoiVGVzdCIsImV4cCI6MTkxMTIzMDM1NiwiaWF0IjoxNjc4NDg4ODE2fQ.yjRvogDyxlQrrQV3EaEsZJKhpYuNzaCyrh5Ip9WvdjU"

	function ConvertFrom-SecureStringToPlainText {
		param([Parameter(Mandatory)][System.Security.SecureString]$SecureString)
		$bstr = [System.Runtime.InteropServices.Marshal]::SecureStringToBSTR($SecureString)
		try {
			return [System.Runtime.InteropServices.Marshal]::PtrToStringBSTR($bstr)
		} finally {
			[System.Runtime.InteropServices.Marshal]::ZeroFreeBSTR($bstr)
		}
	}
}

Describe 'Get-MgAccessToken' {
	AfterEach {
		Disconnect-MgGraph -ErrorAction SilentlyContinue
	}

	It 'Should throw when no auth context exists for the session' {
		{ Get-MgAccessToken } | Should -Throw
	}

	It 'Should return the access token as a SecureString by default' {
		Connect-MgGraph -AccessToken (ConvertTo-SecureString -AsPlainText -String $DummyToken)
		$Token = Get-MgAccessToken
		$Token | Should -BeOfType [System.Security.SecureString]
		(ConvertFrom-SecureStringToPlainText -SecureString $Token) | Should -Be $DummyToken
	}

	It 'Should return an MgAccessTokenInfo object when -AsObject is specified' {
		Connect-MgGraph -AccessToken (ConvertTo-SecureString -AsPlainText -String $DummyToken)
		$TokenInfo = Get-MgAccessToken -AsObject
		$TokenInfo | Should -Not -BeNullOrEmpty
		$TokenInfo.Token | Should -BeOfType [System.Security.SecureString]
		(ConvertFrom-SecureStringToPlainText -SecureString $TokenInfo.Token) | Should -Be $DummyToken
		$TokenInfo.ExpiresOn | Should -BeOfType [System.DateTimeOffset]
		$TokenInfo.ExpiresOn | Should -BeGreaterThan ([System.DateTimeOffset]::UtcNow)
	}

	It 'Should throw when -Scopes is specified and Connect-MgGraph was called with -AccessToken' {
		Connect-MgGraph -AccessToken (ConvertTo-SecureString -AsPlainText -String $DummyToken)
		{ Get-MgAccessToken -Scopes 'User.Read' } | Should -Throw
	}

	It 'Should throw when -ForceRefresh is specified and Connect-MgGraph was called with -AccessToken' {
		Connect-MgGraph -AccessToken (ConvertTo-SecureString -AsPlainText -String $DummyToken)
		{ Get-MgAccessToken -ForceRefresh } | Should -Throw
	}

	It 'Should return a cached token on a second call without -ForceRefresh' {
		Connect-MgGraph -AccessToken (ConvertTo-SecureString -AsPlainText -String $DummyToken)
		$FirstToken = Get-MgAccessToken
		$SecondToken = Get-MgAccessToken
		(ConvertFrom-SecureStringToPlainText -SecureString $FirstToken) | Should -Be (ConvertFrom-SecureStringToPlainText -SecureString $SecondToken)
	}
}

AfterAll {
	Disconnect-MgGraph -ErrorAction SilentlyContinue
}
