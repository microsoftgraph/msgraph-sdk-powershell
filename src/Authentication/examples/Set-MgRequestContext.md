### Example 1: Set Http client timeout in seconds
```powershell
PS C:\> Set-MgRequestContext -ClientTimeout 5
ClientTimeout     RetryDelay                      MaxRetry                 RetriesTimeLimit
-------------     ----------                      --------                 ----------------
00:00:05                   3                             2                         00:00:00
```
Sets Http client timeout in seconds.

### Example 2: Set the maximum time in seconds allowed for request retries
```powershell
PS C:\> Set-MgRequestContext -RetriesTimeLimit 2
ClientTimeout     RetryDelay                      MaxRetry                 RetriesTimeLimit
-------------     ----------                      --------                 ----------------
00:00:05                   3                             2                         00:00:02
```
Sets the maximum time in seconds allowed for request retries.

### Example 3: Set the maximum number of retries for a request
```powershell
PS C:\> Set-MgRequestContext -MaxRetry 2
ClientTimeout     RetryDelay                      MaxRetry                 RetriesTimeLimit
-------------     ----------                      --------                 ----------------
00:00:05                   3                             2                         00:00:02
```
Sets the maximum number of retries for a request.

### Example 4: Set the waiting time in seconds before retrying a request
```powershell
PS C:\> Set-MgRequestContext -RetryDelay 3
ClientTimeout     RetryDelay                      MaxRetry                 RetriesTimeLimit
-------------     ----------                      --------                 ----------------
00:00:05                   3                             2                         00:00:02
```
Sets the waiting time in seconds before retrying a request.