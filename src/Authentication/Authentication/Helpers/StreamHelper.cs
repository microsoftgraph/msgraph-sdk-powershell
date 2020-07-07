using System;
using System.IO;
using System.Management.Automation;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Graph.PowerShell.Authentication.Cmdlets;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal class StreamHelper
    {
        internal const int DefaultReadBuffer = 100000;

        internal const int ChunkSize = 10000;

        public static byte[] EncodeToBytes(string str, Encoding encoding)
        {
            if (encoding == null)
            {
                // just use the default encoding if one wasn't provided
                encoding = ContentHelper.GetDefaultEncoding();
            }

            return encoding.GetBytes(str);
        }

        internal static Stream GetResponseStream(HttpResponseMessage response)
        {
            var responseStream = response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
            return responseStream;
        }

        internal static bool TryGetEncoding(string characterSet, out Encoding encoding)
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

        internal static string DecodeStream(BufferingStreamReader responseStream, ref Encoding encoding)
        {
            var isDefaultEncoding = false;
            if (encoding == null)
            {
                // Use the default encoding if one wasn't provided
                encoding = ContentHelper.GetDefaultEncoding();
                isDefaultEncoding = true;
            }

            var content = StreamToString(responseStream, encoding);
            if (isDefaultEncoding)
            {
                do
                {
                    // check for a charset attribute on the meta element to override the default.

                    var localEncoding = Encoding.UTF8;
                    responseStream.Seek(0, SeekOrigin.Begin);
                    content = StreamToString(responseStream, localEncoding);
                    // report the encoding used.
                    encoding = localEncoding;
                } while (false);
            }

            return content;
        }

        private static string StreamToString(Stream stream, Encoding encoding)
        {
            using var reader = new StreamReader(stream, encoding);
            return reader.ReadToEnd();
        }

        public static void SaveStreamToFile(Stream baseResponseStream, string filePath,
            InvokeGraphRequest invokeGraphRequest, CancellationToken token)
        {
            // If the web cmdlet should resume, append the file instead of overwriting.
            const FileMode fileMode = FileMode.Create;
            using (var output = new FileStream(filePath, fileMode, FileAccess.Write, FileShare.Read))
            {
                WriteToStream(baseResponseStream, output, invokeGraphRequest, token);
            }
        }

        private static void WriteToStream(Stream input, Stream output, PSCmdlet cmdlet,
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
                    record.StatusDescription = StringUtil.FormatCurrentCulture("WriteRequestProgressStatus", output.Position);
                    cmdlet.WriteProgress(record);

                    Task.Delay(1000).Wait(cancellationToken);
                } while (!copyTask.IsCompleted && !cancellationToken.IsCancellationRequested);

                if (copyTask.IsCompleted)
                {
                    record.StatusDescription = StringUtil.FormatCurrentCulture("WriteRequestComplete", output.Position);
                    cmdlet.WriteProgress(record);
                }
            }
            catch (OperationCanceledException)
            {
            }
        }
    }
}