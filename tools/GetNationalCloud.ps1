Param(
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $apiVersion,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $serverUrl
)

switch -regex ($serverUrl) {
    "https://graph.microsoft.us/*" {
        return "USGOV-$apiVersion"
    }
    "https://dod-graph.microsoft.us/*" {
        return "USGOV-DOD-$apiVersion"
    }
    "https://microsoftgraph.chinacloudapi.cn/*" {
        return "China-$apiVersion"
    }
    "https://graph.microsoft.de/*" {
        return "Germany-$apiVersion"
    }
    Default {
        return $apiVersion
    }
}