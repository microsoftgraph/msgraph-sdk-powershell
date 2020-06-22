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
            var result = new StringBuilder(ChunkSize);
            var decoder = encoding.GetDecoder();

            var useBufferSize = 64;
            if (useBufferSize < encoding.GetMaxCharCount(10))
            {
                useBufferSize = encoding.GetMaxCharCount(10);
            }

            var chars = new char[useBufferSize];
            var bytes = new byte[useBufferSize * 4];
            int bytesRead;
            do
            {
                // Read at most the number of bytes that will fit in the input buffer. The
                // return value is the actual number of bytes read, or zero if no bytes remain.
                bytesRead = stream.Read(bytes, 0, useBufferSize * 4);

                var completed = false;
                var byteIndex = 0;

                while (!completed)
                {
                    // If this is the last input data, flush the decoder's internal buffer and state.
                    var flush = bytesRead == 0;
                    decoder.Convert(bytes, byteIndex, bytesRead - byteIndex,
                        chars, 0, useBufferSize, flush,
                        out var bytesUsed, out var charsUsed, out completed);

                    // The conversion produced the number of characters indicated by charsUsed. Write that number
                    // of characters to our result buffer
                    result.Append(chars, 0, charsUsed);

                    // Increment byteIndex to the next block of bytes in the input buffer, if any, to convert.
                    byteIndex += bytesUsed;

                    // The behavior of decoder.Convert changed start .NET 3.1-preview2.
                    // The change was made in https://github.com/dotnet/coreclr/pull/27229
                    // The recommendation from .NET team is to not check for 'completed' if 'flush' is false.
                    // Break out of the loop if all bytes have been read.
                    if (!flush && bytesRead == byteIndex)
                    {
                        break;
                    }
                }
            } while (bytesRead != 0);

            return result.ToString();
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
                    record.StatusDescription = StringUtil.Format("WriteRequestProgressStatus", output.Position);
                    cmdlet.WriteProgress(record);

                    Task.Delay(1000).Wait(cancellationToken);
                } while (!copyTask.IsCompleted && !cancellationToken.IsCancellationRequested);

                if (copyTask.IsCompleted)
                {
                    record.StatusDescription = StringUtil.Format("WriteRequestComplete", output.Position);
                    cmdlet.WriteProgress(record);
                }
            }
            catch (OperationCanceledException)
            {
            }
        }
    }
}