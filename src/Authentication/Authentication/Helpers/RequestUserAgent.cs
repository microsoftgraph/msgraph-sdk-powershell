// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Globalization;
using System.Management.Automation;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal class RequestUserAgent
    {
        private readonly InvocationInfo _invocationInfo;
        private readonly Version _psHostVersion;
        private string _windowsUserAgent;

        internal RequestUserAgent(Version psHostVersion, InvocationInfo invocationInfo)
        {
            _invocationInfo = invocationInfo;
            _psHostVersion = psHostVersion;
        }
        /// <summary>
        /// Full UserAgent which Includes the Operating System, Current Culture
        /// and full app name including powershell version and invoked command. 
        /// </summary>
        internal string UserAgent
        {
            get
            {
                // format the user-agent string from the various component parts
                var userAgent = string.Format(CultureInfo.InvariantCulture,
                    "{0} ({1}; {2}; {3}) {4}",
                    Compatibility, PlatformName, OS, Culture, App);
                return userAgent;
            }
        }

        internal static string Compatibility => ("Mozilla/5.0");
        /// <summary>
        /// Indicates the App which includes the PowerShell version
        /// and the command name.
        /// </summary>
        internal string App
        {
            get
            {
                var app = string.Empty;
                if (_psHostVersion != null)
                    app = string.Format(CultureInfo.InvariantCulture, "PowerShell/{0} {1}", _psHostVersion, _invocationInfo?.MyCommand?.Name);
                return app;
            }
        }

        internal string PlatformName
        {
            get
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    // only generate the windows user agent once
                    if (_windowsUserAgent == null)
                    {
                        // find the version in the windows operating system description
                        var pattern = new Regex(@"\d+(\.\d+)+");
                        var versionText = pattern.Match(OS).Value;
                        var windowsPlatformVersion = new Version(versionText);
                        _windowsUserAgent = $"Windows NT {windowsPlatformVersion.Major}.{windowsPlatformVersion.Minor}";
                    }

                    return _windowsUserAgent;
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    return "Macintosh";
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    return "Linux";
                else
                {
                    // unknown/unsupported platform
                    Debug.Assert(false, "Unable to determine Operating System Platform");
                    return string.Empty;
                }
            }
        }

        internal static string OS => RuntimeInformation.OSDescription.Trim();

        internal static string Culture => (CultureInfo.CurrentCulture.Name);
    }
}