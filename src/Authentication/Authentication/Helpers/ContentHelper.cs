// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Globalization;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;

using Microsoft.Graph.PowerShell.Authentication.Models;
using Microsoft.Win32;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal static class ContentHelper
    {
        #region Constants

        // default codepage encoding for web content.  See RFC 2616.
        private const string DefaultCodePage = "ISO-8859-1";

        #endregion Constants

        #region Fields
        internal static RestReturnType CheckReturnType(this HttpResponseMessage response)
        {
            if (response == null) throw new ArgumentNullException(nameof(response));

            var rt = RestReturnType.Detect;
            var contentType = response.GetContentType();
            if (string.IsNullOrEmpty(contentType) || IsJson(contentType))
                rt = RestReturnType.Json;
            else if (IsXml(contentType))
                rt = RestReturnType.Xml;
            else if (IsImage(contentType))
                rt = RestReturnType.Image;
            else if (IsOctetStream(contentType))
                rt = RestReturnType.OctetStream;
            return rt;
        }

        private static bool IsImage(string contentType)
        {
            contentType = GetContentTypeSignature(contentType);
            return CheckIsImage(contentType);
        }
        /// <summary>
        ///     Check that the current content-type is a valid image
        /// </summary>
        /// <param name="contentType"></param>
        /// <returns></returns>
        private static bool CheckIsImage(string contentType)
        {
            var isImage = false;
            if (string.IsNullOrEmpty(contentType))
                return false;
            switch (contentType.ToLower(CultureInfo.InvariantCulture))
            {
                case "image/apng":
                case "image/avif":
                case "image/gif":
                case "image/jpeg":
                case "image/png":
                    isImage = true;
                    break;
            }
            return isImage;
        }

        private static bool IsOctetStream(string contentType)
        {
            contentType = GetContentTypeSignature(contentType);
            return CheckIsOctetStream(contentType);
        }

        private static bool CheckIsOctetStream(string contentType)
        {
            var isOctetStream = false;
            if (string.IsNullOrEmpty(contentType))
                return false;
            switch (contentType.ToLower(CultureInfo.InvariantCulture))
            {
                case "application/octet-stream":
                    isOctetStream = true;
                    break;
            }
            return isOctetStream;
        }

        // used to split contentType arguments
        private static readonly char[] ContentTypeParamSeparator = { ';' };

        #endregion Fields

        #region Internal Methods

        internal static string GetContentType(this HttpResponseMessage response)
        {
            if (response == null)
            {
                throw new ArgumentNullException(nameof(response));
            }
            // ContentType may not exist in response header.  Return null if not.
            return response.Content.Headers.ContentType?.MediaType;
        }

        internal static Encoding GetDefaultEncoding()
        {
            return GetEncodingOrDefault(null);
        }

        internal static Encoding GetEncodingOrDefault(string characterSet)
        {
            // get the name of the codepage to use for response content
            var codepage = string.IsNullOrEmpty(characterSet) ? DefaultCodePage : characterSet;
            Encoding encoding;
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
            switch (contentType.ToLower(CultureInfo.InvariantCulture))
            {
                case "text/json":
                case "application/x-javascript":
                case "text/x-javascript":
                case "application/javascript":
                case "text/javascript":
                    isJson = true;
                    break;
            }
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
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && !isText)
            {
                // Media types registered with Windows as having a perceived type of text, are text
                using (var contentTypeKey = Registry.ClassesRoot.OpenSubKey(@"MIME\Database\Content Type\" + contentType))
                {
                    if (contentTypeKey?.GetValue("Extension") is string extension)
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
            return isText;
        }

        private static bool CheckIsXml(string contentType)
        {
            if (string.IsNullOrEmpty(contentType))
                return false;

            // RFC 3023: Media types with the suffix "+xml" are XML
            switch (contentType.ToLower(CultureInfo.InvariantCulture))
            {
                case "application/xml":
                case "application/xml-external-parsed-entity":
                case "application/xml-dtd":
                case var x when x.EndsWith("+xml"):
                    return true;
                default:
                    return false;
            }
        }

        private static string GetContentTypeSignature(string contentType)
        {
            if (string.IsNullOrEmpty(contentType))
                return null;

            var sig = contentType.Split(ContentTypeParamSeparator, 2)[0].ToUpperInvariant();
            return sig;
        }

        #endregion Private Helper Methods
    }
}