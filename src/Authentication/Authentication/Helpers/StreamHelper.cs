// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.IO;
using System.Management.Automation;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Graph.PowerShell.Authentication.Cmdlets;
using Microsoft.Graph.PowerShell.Authentication.Properties;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal static class StreamHelper
    {
        internal const int DefaultReadBuffer = 100000;

        internal const int ChunkSize = 10000;

        /// <summary>
        ///     Encode specified string to bytes using the provided encoding
        /// </summary>
        /// <param name="str"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        internal static byte[] EncodeToBytes(this string str, Encoding encoding)
        {
            if (encoding == null)
            {
                // just use the default encoding if one wasn't provided
                encoding = ContentHelper.GetDefaultEncoding();
            }

            return encoding.GetBytes(str);
        }

        internal static Stream GetResponseStream(this HttpResponseMessage response)
        {
            var responseStream = response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
            return responseStream;
        }

        internal static bool TryGetEncoding(this string characterSet, out Encoding encoding)
        {
            var result = false;
            try
            {
                encoding = Encoding.GetEncoding(characterSet);
                result = true;
            }
            catch (ArgumentException)
            {
                encoding = null;
            }

            return result;
        }

        internal static string DecodeStream(this BufferingStreamReader responseStream, ref Encoding encoding)
        {
            if (encoding == null)
            {
                // Use the default encoding if one wasn't provided
                encoding = ContentHelper.GetDefaultEncoding();
            }
            var content = responseStream.StreamToString(encoding);
            return content;
        }

        internal static string StreamToString(this Stream stream, Encoding encoding)
        {
            using (var reader = new StreamReader(stream, encoding))
            {
                return reader.ReadToEnd();
            }
        }

        internal static void SaveStreamToFile(this Stream baseResponseStream, string filePath,
            InvokeGraphRequest invokeGraphRequest, CancellationToken token)
        {
            // If the web cmdlet should resume, append the file instead of overwriting.
            const FileMode fileMode = FileMode.Create;
            using (var output = new FileStream(filePath, fileMode, FileAccess.Write, FileShare.Read))
            {
                baseResponseStream.WriteToStream(output, invokeGraphRequest, token);
            }
        }

        private static void WriteToStream(this Stream input, Stream output, PSCmdlet cmdlet,
            CancellationToken cancellationToken)
        {
            if (cmdlet == null)
            {
                throw new ArgumentNullException(nameof(cmdlet));
            }

            var copyTask = input.CopyToAsync(output);

            var record = new ProgressRecord(
                000000000,
                "WriteRequestProgressActivity",
                "WriteRequestProgressStatus");
            try
            {
                do
                {
                    record.StatusDescription =
                        Resources.WriteRequestProgressStatus.FormatCurrentCulture(output.Position);
                    cmdlet.WriteProgress(record);

                    Task.Delay(1000, cancellationToken).Wait(cancellationToken);
                } while (!copyTask.IsCompleted && !cancellationToken.IsCancellationRequested);

                if (copyTask.IsCompleted)
                {
                    record.StatusDescription = Resources.WriteRequestComplete.FormatCurrentCulture(output.Position);
                    cmdlet.WriteProgress(record);
                }
            }
            catch (OperationCanceledException)
            {
            }
        }
    }
}