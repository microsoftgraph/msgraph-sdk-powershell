using System;
using System.Diagnostics;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal static class ContentHelper
    {
        #region Constants

        // default codepage encoding for web content.  See RFC 2616.
        private const string _defaultCodePage = "ISO-8859-1";

        #endregion Constants

        #region Fields

        // used to split contentType arguments
        private static readonly char[] s_contentTypeParamSeparator = {';'};

        #endregion Fields

        #region Internal Methods

        internal static string GetContentType(HttpResponseMessage response)
        {
            // ContentType may not exist in response header.  Return null if not.
            return response.Content.Headers.ContentType?.MediaType;
        }

        internal static Encoding GetDefaultEncoding()
        {
            return GetEncodingOrDefault(null);
        }

        internal static Encoding GetEncoding(HttpResponseMessage response)
        {
            // ContentType may not exist in response header.
            var charSet = response.Content.Headers.ContentType?.CharSet;
            return GetEncodingOrDefault(charSet);
        }

        internal static Encoding GetEncodingOrDefault(string characterSet)
        {
            // get the name of the codepage to use for response content
            var codepage = string.IsNullOrEmpty(characterSet) ? _defaultCodePage : characterSet;
            Encoding encoding = null;

            try
            {
                encoding = Encoding.GetEncoding(codepage);
            }
            catch (ArgumentException)
            {
                // 0, default code page
                encoding = Encoding.GetEncoding(0);
            }

            return encoding;
        }

        internal static StringBuilder GetRawContentHeader(HttpResponseMessage response)
        {
            var raw = new StringBuilder();

            var protocol = WebResponseHelper.GetProtocol(response);
            if (!string.IsNullOrEmpty(protocol))
            {
                var statusCode = WebResponseHelper.GetStatusCode(response);
                var statusDescription = WebResponseHelper.GetStatusDescription(response);
                raw.AppendFormat("{0} {1} {2}", protocol, statusCode, statusDescription);
                raw.AppendLine();
            }

            HttpHeaders[] headerCollections =
            {
                response.Headers,
                response.Content == null ? null : response.Content.Headers
            };

            foreach (var headerCollection in headerCollections)
            {
                if (headerCollection == null)
                {
                    continue;
                }

                foreach (var header in headerCollection)
                {
                    // Headers may have multiple entries with different values
                    foreach (var headerValue in header.Value)
                    {
                        raw.Append(header.Key);
                        raw.Append(": ");
                        raw.Append(headerValue);
                        raw.AppendLine();
                    }
                }
            }

            raw.AppendLine();
            return raw;
        }

        internal static bool IsJson(string contentType)
        {
            contentType = GetContentTypeSignature(contentType);
            return CheckIsJson(contentType);
        }

        internal static bool IsText(string contentType)
        {
            contentType = GetContentTypeSignature(contentType);
            return CheckIsText(contentType);
        }

        internal static bool IsXml(string contentType)
        {
            contentType = GetContentTypeSignature(contentType);
            return CheckIsXml(contentType);
        }

        #endregion Internal Methods

        #region Private Helper Methods

        private static bool CheckIsJson(string contentType)
        {
            if (string.IsNullOrEmpty(contentType))
                return false;

            // the correct type for JSON content, as specified in RFC 4627
            var isJson = contentType.Equals("application/json", StringComparison.OrdinalIgnoreCase);

            // add in these other "javascript" related types that
            // sometimes get sent down as the mime type for JSON content
            isJson |= contentType.Equals("text/json", StringComparison.OrdinalIgnoreCase)
                      || contentType.Equals("application/x-javascript", StringComparison.OrdinalIgnoreCase)
                      || contentType.Equals("text/x-javascript", StringComparison.OrdinalIgnoreCase)
                      || contentType.Equals("application/javascript", StringComparison.OrdinalIgnoreCase)
                      || contentType.Equals("text/javascript", StringComparison.OrdinalIgnoreCase);

            return isJson;
        }

        private static bool CheckIsText(string contentType)
        {
            if (string.IsNullOrEmpty(contentType))
                return false;

            // any text, xml or json types are text
            var isText = contentType.StartsWith("text/", StringComparison.OrdinalIgnoreCase)
                         || CheckIsXml(contentType)
                         || CheckIsJson(contentType);

            // Further content type analysis is available on Windows
            if (Platform.IsWindows && !isText)
            {
                // Media types registered with Windows as having a perceived type of text, are text
                using (var contentTypeKey =
                    Registry.ClassesRoot.OpenSubKey(@"MIME\Database\Content Type\" + contentType))
                {
                    if (contentTypeKey != null)
                    {
                        var extension = contentTypeKey.GetValue("Extension") as string;
                        if (extension != null)
                        {
                            using (var extensionKey = Registry.ClassesRoot.OpenSubKey(extension))
                            {
                                if (extensionKey != null)
                                {
                                    var perceivedType = extensionKey.GetValue("PerceivedType") as string;
                                    isText = perceivedType == "text";
                                }
                            }
                        }
                    }
                }
            }

            return isText;
        }

        private static bool CheckIsXml(string contentType)
        {
            if (string.IsNullOrEmpty(contentType))
                return false;

            // RFC 3023: Media types with the suffix "+xml" are XML
            var isXml = contentType.Equals("application/xml", StringComparison.OrdinalIgnoreCase)
                        || contentType.Equals("application/xml-external-parsed-entity",
                            StringComparison.OrdinalIgnoreCase)
                        || contentType.Equals("application/xml-dtd", StringComparison.OrdinalIgnoreCase);

            isXml |= contentType.EndsWith("+xml", StringComparison.OrdinalIgnoreCase);
            return isXml;
        }

        private static string GetContentTypeSignature(string contentType)
        {
            if (string.IsNullOrEmpty(contentType))
                return null;

            var sig = contentType.Split(s_contentTypeParamSeparator, 2)[0].ToUpperInvariant();
            return sig;
        }

        #endregion Private Helper Methods
    }

    internal static
        class StringUtil
    {
        // Typical padding is at most a screen's width, any more than that and we won't bother caching.
        private const int IndentCacheMax = 120;

        private const int DashCacheMax = 120;

        private static readonly string[] IndentCache = new string[IndentCacheMax];

        private static readonly string[] DashCache = new string[DashCacheMax];

        internal static
            string
            Format(string formatSpec, object o)
        {
            return string.Format(CultureInfo.CurrentCulture, formatSpec, o);
        }

        internal static
            string
            Format(string formatSpec, object o1, object o2)
        {
            return string.Format(CultureInfo.CurrentCulture, formatSpec, o1, o2);
        }

        internal static
            string
            Format(string formatSpec, params object[] o)
        {
            return string.Format(CultureInfo.CurrentCulture, formatSpec, o);
        }

        internal static
            string
            TruncateToBufferCellWidth(PSHostRawUserInterface rawUI, string toTruncate, int maxWidthInBufferCells)
        {
            Debug.Assert(rawUI != null, "need a reference");
            Debug.Assert(maxWidthInBufferCells >= 0, "maxWidthInBufferCells must be positive");

            string result;
            var i = Math.Min(toTruncate.Length, maxWidthInBufferCells);

            do
            {
                result = toTruncate.Substring(0, i);
                var cellCount = rawUI.LengthInBufferCells(result);
                if (cellCount <= maxWidthInBufferCells)
                {
                    // the segment from start..i fits

                    break;
                }

                // The segment does not fit, back off a tad until it does
                // We need to back off 1 by 1 because there could theoretically
                // be characters taking more 2 buffer cells
                --i;
            } while (true);

            return result;
        }

        internal static string Padding(int countOfSpaces)
        {
            if (countOfSpaces >= IndentCacheMax)
                return new string(' ', countOfSpaces);

            var result = IndentCache[countOfSpaces];

            if (result == null)
            {
                Interlocked.CompareExchange(ref IndentCache[countOfSpaces], new string(' ', countOfSpaces), null);
                result = IndentCache[countOfSpaces];
            }

            return result;
        }

        internal static string DashPadding(int count)
        {
            if (count >= DashCacheMax)
                return new string('-', count);

            var result = DashCache[count];

            if (result == null)
            {
                Interlocked.CompareExchange(ref DashCache[count], new string('-', count), null);
                result = DashCache[count];
            }

            return result;
        }
    }
}