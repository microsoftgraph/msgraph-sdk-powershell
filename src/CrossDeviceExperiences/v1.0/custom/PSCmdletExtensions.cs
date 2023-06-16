// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell
{
    using Microsoft.Graph.PowerShell.Authentication;
    using Microsoft.Graph.PowerShell.Authentication.Common;
    using System;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Linq;
    using System.Management.Automation;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    internal static class PSCmdletExtensions
    {
        private static readonly char[] PathSeparators = new char[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar };
        
        // Converts a string to its unescaped form. The method also replaces '+' with spaces.
        internal static string UnescapeString(this PSCmdlet cmdlet, string value)
        {
            if (value == null)
                return null;

            try
            {
                var unescapedString = Uri.UnescapeDataString(value);
                return unescapedString.Replace('+', ' ');
            }
            catch (UriFormatException ex)
            {
                cmdlet.ThrowTerminatingError(new ErrorRecord(ex, string.Empty, ErrorCategory.InvalidArgument, value));
                return null;
            }
        }

        /// <summary>
        /// Gets a resolved or unresolved path from PSPath.
        /// </summary>
        /// <param name="cmdlet">The calling <see cref="PSCmdlet"/>.</param>
        /// <param name="filePath">The file path to get a provider path for.</param>
        /// <param name="isResolvedPath">Determines whether get a resolved or unresolved provider path.</param>
        /// <returns>The provider path from PSPath.</returns>
        internal static string GetProviderPath(this PSCmdlet cmdlet, string filePath, bool isResolvedPath)
        {
            string providerPath = null;
            ProviderInfo provider;
            try
            {
                var paths = new Collection<string>();
                if (isResolvedPath)
                {
                    paths = cmdlet.SessionState.Path.GetResolvedProviderPathFromPSPath(filePath, out provider);
                }
                else
                {
                    paths.Add(cmdlet.SessionState.Path.GetUnresolvedProviderPathFromPSPath(filePath, out provider, out _));
                }

                if (provider.Name != "FileSystem" || paths.Count == 0)
                {
                    cmdlet.ThrowTerminatingError(new ErrorRecord(new Exception($"Invalid path {filePath}."), string.Empty, ErrorCategory.InvalidArgument, filePath));
                }
                if (paths.Count > 1)
                {
                    cmdlet.ThrowTerminatingError(new ErrorRecord(new Exception("Multiple paths not allowed."), string.Empty, ErrorCategory.InvalidArgument, filePath));
                }
                providerPath = paths[0];
            }
            catch (Exception ex)
            {
                cmdlet.ThrowTerminatingError(new ErrorRecord(ex, string.Empty, ErrorCategory.InvalidArgument, filePath));
            }

            return providerPath;
        }

        /// <summary>
        /// Saves a stream to a file on disk.
        /// </summary>
        /// <param name="cmdlet">The calling <see cref="PSCmdlet"/>.</param>
        /// <param name="response">The HTTP response from the service.</param>
        /// <param name="inputStream">The stream to write to file.</param>
        /// <param name="filePath">The path to write the file to. This should include the file name and extension.</param>
        /// <param name="cancellationToken">A cancellation token that will be used to cancel the operation by the user.</param>
        internal static void WriteToFile(this PSCmdlet cmdlet, HttpResponseMessage response, Stream inputStream, string filePath, CancellationToken cancellationToken)
        {
            if (IsPathDirectory(filePath))
            {
                // Get file name from content disposition header if present; otherwise throw an exception for a file name to be provided.
                var fileName = GetFileName(response);
                filePath = Path.Combine(filePath, fileName);
            }
            if (File.Exists(filePath))
            {
                cmdlet.WriteWarning($"{filePath} already exists. The file will be overridden.");
                File.Delete(filePath);
            }
            using (var fileProvider = ProtectedFileProvider.CreateFileProvider(filePath, FileProtection.ExclusiveWrite, new DiskDataStore()))
            {
                string downloadUrl = response?.RequestMessage?.RequestUri.ToString();
                cmdlet.WriteToStream(inputStream, fileProvider.Stream, downloadUrl, cancellationToken);
            }
        }

        /// <summary>
        /// Writes an input stream to an output stream.
        /// </summary>
        /// <param name="cmdlet">The calling <see cref="PSCmdlet"/>.</param>
        /// <param name="inputStream">The stream to write to an output stream.</param>
        /// <param name="outputStream">The stream to write the input stream to.</param>
        /// <param name="cancellationToken">A cancellation token that will be used to cancel the operation by the user.</param>
        private static void WriteToStream(this PSCmdlet cmdlet, Stream inputStream, Stream outputStream, string downloadUrl, CancellationToken cancellationToken)
        {
            Task copyTask = inputStream.CopyToAsync(outputStream);
            ProgressRecord record = new ProgressRecord(
                activityId: 0,
                activity: $"Downloading {downloadUrl ?? "file"}",
                statusDescription: $"{outputStream.Position} of {outputStream.Length} bytes downloaded.");
            try
            {
                do
                {
                    cmdlet.WriteProgress(GetProgress(record, outputStream));

                    Task.Delay(1000, cancellationToken).Wait(cancellationToken);
                } while (!copyTask.IsCompleted && !cancellationToken.IsCancellationRequested);

                if (copyTask.IsCompleted)
                {
                    cmdlet.WriteProgress(GetProgress(record, outputStream));
                }
            }
            catch (OperationCanceledException)
            {
            }
        }

        private static bool IsPathDirectory(string path)
        {
            if (path == null) throw new ArgumentNullException("path");
            bool isDirectory = false;
            path = path.Trim();

            if (Directory.Exists(path))
                isDirectory = true;

            if (File.Exists(path))
                isDirectory = false;

            // If path has a trailing slash then it's a directory.
            if (PathSeparators.Contains(path.Last()))
                isDirectory = true;

            // If path has an extension then its a file.
            if (Path.HasExtension(path))
                isDirectory = false;

            return isDirectory;
        }

        private static string GetFileName(HttpResponseMessage responseMessage)
        {
            if (responseMessage.Content.Headers.ContentDisposition != null
                && !string.IsNullOrWhiteSpace(responseMessage.Content.Headers.ContentDisposition.FileName))
            {
                var fileName = responseMessage.Content.Headers.ContentDisposition.FileNameStar ?? responseMessage.Content.Headers.ContentDisposition.FileName;
                if (!string.IsNullOrWhiteSpace(fileName))
                    return SanitizeFileName(fileName);
            }
            throw new ArgumentException(ErrorConstants.Message.CannotInferFileName, "-OutFile");
        }

        /// <summary>
        /// When Inferring file names from content disposition header, ensure that only valid path characters are in the file name
        /// </summary>
        /// <param name="fileName"></param>
        private static string SanitizeFileName(string fileName)
        {
            var illegalCharacters = Path.GetInvalidFileNameChars().Concat(Path.GetInvalidPathChars()).ToArray();
            return string.Concat(fileName.Split(illegalCharacters));
        }

        /// <summary>
        /// Calculates and updates the progress record of the provided stream.
        /// </summary>
        /// <param name="currentProgressRecord">The <see cref="ProgressRecord"/> to update.</param>
        /// <param name="stream">The stream to calculate its progress.</param>
        /// <returns>An updated <see cref="ProgressRecord"/>.</returns>
        private static ProgressRecord GetProgress(ProgressRecord currentProgressRecord, Stream stream)
        {
            currentProgressRecord.StatusDescription = $"{stream.Position} of {stream.Length} bytes downloaded.";
            currentProgressRecord.PercentComplete = (int)Math.Round((double)(100 * stream.Position) / stream.Length);
            return currentProgressRecord;
        }
    }
}
