using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Graph.PowerShell.Authentication.Extensions;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Authentication.Interfaces;
using Microsoft.Graph.PowerShell.Authentication.Models;
using Microsoft.Graph.PowerShell.Authentication.Properties;
using Microsoft.PowerShell.Commands;

using Newtonsoft.Json;

using static Microsoft.Graph.PowerShell.Authentication.Helpers.AsyncHelpers;

using DriveNotFoundException = System.Management.Automation.DriveNotFoundException;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    [Cmdlet(VerbsLifecycle.Invoke, "MgGraphRequest", DefaultParameterSetName = Constants.UserParameterSet)]
    [Alias("Invoke-GraphRequest")]
    public class InvokeMgGraphRequest : PSCmdlet
    {
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private readonly InvokeGraphRequestUserAgent _graphRequestUserAgent;
        private IGraphEnvironment _originalEnvironment;
        private string _originalFilePath;

        public InvokeMgGraphRequest()
        {
            _graphRequestUserAgent = new InvokeGraphRequestUserAgent(this);
            Authentication = GraphRequestAuthenticationType.Default;
        }

        /// <summary>
        ///     Http Method
        /// </summary>
        [Parameter(ParameterSetName = Constants.UserParameterSet,
            Position = 1,
            HelpMessage = "Http Method")]
        public GraphRequestMethod Method { get; set; } = GraphRequestMethod.GET;

        /// <summary>
        ///     Uri to call using the Graph HttpClient can be segments such as /beta/me
        ///     or fully qualified url such as https://graph.microsoft.com/beta/me
        /// </summary>
        [Parameter(ParameterSetName = Constants.UserParameterSet,
            Position = 2,
            Mandatory = true,
            HelpMessage =
                "Uri to call can be segments such as /beta/me or fully qualified https://graph.microsoft.com/beta/me")]
        public Uri Uri { get; set; }

        /// <summary>
        ///     Optional Http Body
        /// </summary>
        [Parameter(ParameterSetName = Constants.UserParameterSet,
            Position = 3,
            HelpMessage = "Request Body. Required when Method is Post or Patch",
            ValueFromPipeline = true)]
        public object Body { get; set; }

        /// <summary>
        ///     Optional Custom Headers
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 4,
            HelpMessage = "Optional Custom Headers")]
        public IDictionary Headers { get; set; }

        /// <summary>
        ///     Relative or absolute path where the response body will be saved.
        ///     Not allowed when InferOutputFileName is specified.
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 5,
            HelpMessage = "Output file where the response body will be saved")]
        public string OutputFilePath { get; set; }

        /// <summary>
        ///     Infer Download FileName from ContentDisposition Header.
        ///     Not allowed when OutputFilePath is specified.
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 6,
            HelpMessage = "Infer output filename")]
        public SwitchParameter InferOutputFileName { get; set; }

        /// <summary>
        ///     Gets or sets the InputFilePath property to send in the request
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 7,
            HelpMessage = "Input file to send in the request")]
        public virtual string InputFilePath { get; set; }

        /// <summary>
        ///     Indicates that the cmdlet returns the results, in addition to writing them to a file.
        ///     only valid when the OutFile parameter is also used.
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 8,
            HelpMessage =
                "Indicates that the cmdlet returns the results, in addition to writing them to a file. Only valid when the OutFile parameter is also used. ")]
        public SwitchParameter PassThru { get; set; }

        /// <summary>
        ///     OAuth or Bearer Token to use instead of already acquired token
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 9,
            HelpMessage = "OAuth or Bearer Token to use instead of already acquired token")]
        public SecureString Token { get; set; }

        /// <summary>
        ///     Add headers to Request Header collection without validation
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 10,
            HelpMessage = "Add headers to Request Header collection without validation")]
        public SwitchParameter SkipHeaderValidation { get; set; }

        /// <summary>
        ///     Custom Content Type
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 11,
            HelpMessage = "Custom Content Type")]
        public virtual string ContentType { get; set; }

        /// <summary>
        ///     Graph Authentication Type
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 12,
            HelpMessage = "Graph Authentication Type")]
        public GraphRequestAuthenticationType Authentication { get; set; }

        /// <summary>
        ///     Specifies a web request session. Enter the variable name, including the dollar sign ($).
        ///     You can't use the SessionVariable and WebSession parameters in the same command.
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 13,
            HelpMessage = "Specifies a web request session. Enter the variable name, including the dollar sign ($)." +
                          "You can't use the SessionVariable and GraphRequestSession parameters in the same command.")]
        [Alias("SV")]
        public string SessionVariable { get; set; }

        /// <summary>
        ///     Response Headers Variable
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 14,
            HelpMessage = "Response Headers Variable")]
        [Alias("RHV")]
        public string ResponseHeadersVariable { get; set; }

        /// <summary>
        ///     Response Status Code Variable
        /// </summary>
        [Parameter(Position = 15, ParameterSetName = Constants.UserParameterSet,
            Mandatory = false,
            HelpMessage = "Response Status Code Variable")]
        public string StatusCodeVariable { get; set; }

        /// <summary>
        ///     Gets or sets whether to skip checking HTTP status for error codes.
        /// </summary>
        [Parameter(Position = 16, ParameterSetName = Constants.UserParameterSet, Mandatory = false,
            HelpMessage = "Skip Checking Http Errors")]
        public virtual SwitchParameter SkipHttpErrorCheck { get; set; }

        /// <summary>
        ///     Gets or sets the Session property.
        /// </summary>
        [Parameter(Mandatory = false,
            Position = 17,
            ParameterSetName = Constants.UserParameterSet,
            HelpMessage = "Custom Graph Request Session")]
        public GraphRequestSession GraphRequestSession { get; set; }

        /// <summary>
        ///     Custom User Specified User Agent
        /// </summary>
        [Parameter(Mandatory = false,
            Position = 18,
            ParameterSetName = Constants.UserParameterSet,
            HelpMessage = "Custom User Specified User Agent")]
        public string UserAgent { get; set; }

        /// <summary>
        ///     Return full Graph Http Response without interpreting
        /// </summary>
        [Parameter(Mandatory = false,
            Position = 19,
            ParameterSetName = Constants.UserParameterSet,
            HelpMessage = "Return full Graph Http Response without interpreting. " +
                          "Specifying -RequestClone stores the original request in a variable")]
        public SwitchParameter Raw { get; set; }

        /// <summary>
        ///     Cloned Copy of Original Http Request
        /// </summary>
        [Parameter(Position = 20, ParameterSetName = Constants.UserParameterSet,
            Mandatory = false,
            HelpMessage = "A clone of the original request will be stored here")]
        [Alias("ORC")]
        public string OriginalRequestClone { get; set; }

        /// <summary>
        ///     Return full JSON Form, without converting to HashTable
        /// </summary>
        [Parameter(Mandatory = false,
            Position = 21,
            ParameterSetName = Constants.UserParameterSet,
            HelpMessage = "Return full Json Response")]
        public SwitchParameter Json { get; set; }

        /// <summary>
        ///     Wait for .NET debugger to attach
        /// </summary>
        [Parameter(Mandatory = false,
            DontShow = true,
            HelpMessage = "Wait for .NET debugger to attach")]
        public SwitchParameter Break { get; set; }

        internal string QualifiedOutFile => QualifyFilePath(OutputFilePath);

        internal bool ShouldSaveToOutFile => !string.IsNullOrEmpty(OutputFilePath);

        /// <summary>
        ///     Only write to pipeline if outfile is not specified, inference is not specified but PassThru is set.
        /// </summary>
        internal bool ShouldWriteToPipeline => !ShouldSaveToOutFile && !InferOutputFileName || PassThru;

        internal bool ShouldCheckHttpStatus => !SkipHttpErrorCheck;

        /// <summary>
        ///     Only Set Default Content Type (application/json) for POST, PUT and PATCH requests, where its not specified via `-ContentType`.
        /// </summary>
        private bool ShouldSetDefaultContentType => Method == GraphRequestMethod.POST || Method == GraphRequestMethod.PUT || Method == GraphRequestMethod.PATCH;

        private static async Task<ErrorRecord> GenerateHttpErrorRecordAsync(
            HttpMessageFormatter httpResponseMessageFormatter,
            HttpRequestMessage httpRequestMessage)
        {
            using (NoSynchronizationContext)
            {
                // Load into buffer to avoid stream already consumed issues.
                await httpResponseMessageFormatter.LoadIntoBufferAsync();
                var currentResponse = httpResponseMessageFormatter.HttpResponseMessage;
                var errorMessage =
                    Resources.ResponseStatusCodeFailure.FormatCurrentCulture(currentResponse.StatusCode,
                        currentResponse.ReasonPhrase);
                var httpException = new HttpResponseException(errorMessage, currentResponse);
                var errorRecord = new ErrorRecord(httpException, Errors.InvokeGraphHttpResponseException,
                    ErrorCategory.InvalidOperation, httpRequestMessage);
                var detailMsg = await httpResponseMessageFormatter.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(detailMsg))
                {
                    errorRecord.ErrorDetails = new ErrorDetails(detailMsg);
                }

                return errorRecord;
            }
        }

        /// <summary>
        ///     When -Verbose is specified, print out response status
        /// </summary>
        /// <param name="requestMessageFormatter"></param>
        private async Task ReportRequestStatusAsync(HttpMessageFormatter requestMessageFormatter)
        {
            using (NoSynchronizationContext)
            {
                await requestMessageFormatter.LoadIntoBufferAsync();
                var requestMessage = requestMessageFormatter.HttpRequestMessage;
                var requestContentLength = requestMessage.Content?.Headers.ContentLength.Value ?? 0;
                var reqVerboseMsg = Resources.InvokeGraphRequestVerboseMessage.FormatCurrentCulture(
                    requestMessage.Method,
                    requestMessage.RequestUri,
                    requestContentLength);
                // If Verbose is specified, will print out Uri and Content Length
                WriteVerbose(reqVerboseMsg);
                var requestString = await requestMessageFormatter.ReadAsStringAsync();
                // If Debug is Specified, will print out the Http Request as a string
                WriteDebug(requestString);
            }
        }

        /// <summary>
        ///     When -Verbose is specified, print out response status
        /// </summary>
        /// <param name="responseMessageFormatter"></param>
        private async Task ReportResponseStatusASync(HttpMessageFormatter responseMessageFormatter)
        {
            using (NoSynchronizationContext)
            {
                await responseMessageFormatter.LoadIntoBufferAsync();
                var contentType = responseMessageFormatter.HttpResponseMessage.GetContentType();
                var respVerboseMsg = Resources.InvokeGraphResponseVerboseMessage.FormatCurrentCulture(
                    responseMessageFormatter.HttpResponseMessage.Content.Headers.ContentLength,
                    contentType);
                // If Verbose is specified, will print out Uri and Content Length
                WriteVerbose(respVerboseMsg);
                var responseString = await responseMessageFormatter.ReadAsStringAsync();
                // If Debug is Specified, will print out the Http Response as a string
                WriteDebug(responseString);
            }
        }

        /// <summary>
        ///     Compose a request, setting Uri and Headers.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="uri"></param>
        /// <returns></returns>
        private HttpRequestMessage GetRequest(HttpClient httpClient, Uri uri)
        {
            var requestUri = PrepareUri(httpClient, uri);
            var httpMethod = GetHttpMethod(Method);
            // create the base WebRequest object
            var request = new HttpRequestMessage(httpMethod, requestUri);

            // pull in session data
            if (GraphRequestSession.Headers.Count > 0)
            {
                GraphRequestSession.ContentHeaders.Clear();
                foreach (var entry in GraphRequestSession.Headers)
                {
                    if (HttpKnownHeaderNames.ContentHeaders.Contains(entry.Key))
                    {
                        GraphRequestSession.ContentHeaders.Add(entry.Key, entry.Value);
                    }
                    else
                    {
                        if (SkipHeaderValidation)
                        {
                            request.Headers.TryAddWithoutValidation(entry.Key, entry.Value);
                        }
                        else
                        {
                            request.Headers.Add(entry.Key, entry.Value);
                        }
                    }
                }
            }

            // Set 'Transfer-Encoding: chunked' if 'Transfer-Encoding' is specified
            if (GraphRequestSession.Headers.ContainsKey(HttpKnownHeaderNames.TransferEncoding))
            {
                request.Headers.TransferEncodingChunked = true;
            }

            // Set 'User-Agent' if WebSession.Headers doesn't already contain it
            if (GraphRequestSession.Headers.TryGetValue(HttpKnownHeaderNames.UserAgent, out var userAgent))
            {
                GraphRequestSession.UserAgent = userAgent;
            }
            else
            {
                if (SkipHeaderValidation)
                {
                    request.Headers.TryAddWithoutValidation(HttpKnownHeaderNames.UserAgent,
                        GraphRequestSession.UserAgent);
                }
                else
                {
                    request.Headers.Add(HttpKnownHeaderNames.UserAgent, GraphRequestSession.UserAgent);
                }
            }

            return request;
        }

        /// <summary>
        ///     Compose Request Uri
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="uri"></param>
        /// <returns></returns>
        private Uri PrepareUri(HttpClient httpClient, Uri uri)
        {
            // before creating the web request,
            // preprocess Body if content is a dictionary and method is GET (set as query)
            if (Method == GraphRequestMethod.GET &&
                LanguagePrimitives.TryConvertTo(Body, out IDictionary bodyAsDictionary))
            {
                UriBuilder uriBuilder;
                // For AbsoluteUri such as /beta/groups$count=true, Get the scheme and host from httpClient
                // Then use them to compose a new Url with the URL fragment. 
                if (!uri.IsAbsoluteUri)
                {
                    uriBuilder = new UriBuilder
                    {
                        Scheme = httpClient.BaseAddress.Scheme,
                        Host = httpClient.BaseAddress.Host
                    };
                    var newAbsoluteUri = new Uri(uriBuilder.Uri, uri);
                    uriBuilder = new UriBuilder(newAbsoluteUri);
                }
                else
                {
                    uriBuilder = new UriBuilder(uri);
                }

                var bodyQueryParameters = bodyAsDictionary?.FormatDictionary();
                if (uriBuilder.Query != null && uriBuilder.Query.Length > 1 &&
                    !string.IsNullOrWhiteSpace(bodyQueryParameters))
                {
                    uriBuilder.Query = uriBuilder.Query.Substring(1) + "&" + bodyQueryParameters;
                }
                else if (!string.IsNullOrWhiteSpace(bodyQueryParameters))
                {
                    uriBuilder.Query = bodyQueryParameters;
                }

                uri = uriBuilder.Uri;
                // set body to null to prevent later FillRequestStream
                Body = null;
            }

            return uri;
        }

        /// <summary>
        ///     Process Http Response
        /// </summary>
        /// <param name="response"></param>
        internal async Task ProcessResponse(HttpResponseMessage response)
        {
            if (response == null) throw new ArgumentNullException(nameof(response));

            var baseResponseStream = response.GetResponseStream();

            if (ShouldWriteToPipeline)
            {
                //When -Raw is Specified, print out the actual HttpResponse.
                if (Raw)
                {
                    // if -ORC "originalRequestClone" is specified, clone and store.
                    if (!string.IsNullOrEmpty(OriginalRequestClone))
                    {
                        var vi = SessionState.PSVariable;
                        var originalRequest = await response.CloneHttpRequestWithContent();
                        vi.Set(OriginalRequestClone, originalRequest);
                    }
                    WriteObject(response);
                }
                else
                {
                    using (var responseStream = new BufferingStreamReader(baseResponseStream))
                    {
                        // determine the response type
                        var returnType = response.CheckReturnType();
                        // Try to get the response encoding from the ContentType header.
                        Encoding encoding = null;
                        var charSet = response.Content.Headers.ContentType?.CharSet;
                        if (!string.IsNullOrEmpty(charSet))
                        {
                            charSet.TryGetEncoding(out encoding);
                        }

                        if (string.IsNullOrEmpty(charSet) && returnType == RestReturnType.Json)
                        {
                            encoding = Encoding.UTF8;
                        }

                        Exception ex = null;

                        var str = responseStream.DecodeStream(ref encoding);

                        string encodingVerboseName;
                        try
                        {
                            encodingVerboseName = string.IsNullOrEmpty(encoding.HeaderName)
                                ? encoding.EncodingName
                                : encoding.HeaderName;
                        }
                        catch (NotSupportedException)
                        {
                            encodingVerboseName = encoding.EncodingName;
                        }

                        // NOTE: Tests use this verbose output to verify the encoding.
                        WriteVerbose(Resources.ContentEncodingVerboseMessage.FormatCurrentCulture(encodingVerboseName));
                        //If -Json is specified, return the Json string without converting to HashTable
                        if (Json)
                        {
                            WriteObject(str);
                        }
                        else
                        {
                            WriteObject(str.TryConvertToJson(out var obj, ref ex) ? obj : str);
                        }
                    }
                }
            }

            if (ShouldSaveToOutFile)
            {
                baseResponseStream.SaveStreamToFile(QualifiedOutFile, this, _cancellationTokenSource.Token);
            }

            if (InferOutputFileName.IsPresent)
            {
                if (response.Content.Headers.ContentDisposition != null)
                {
                    if (!string.IsNullOrWhiteSpace(response.Content.Headers.ContentDisposition.FileName))
                    {
                        var fileName = response.Content.Headers.ContentDisposition.FileNameStar;
                        var fullFileName = QualifyFilePath(fileName);
                        WriteVerbose(
                            Resources.InferredFileNameVerboseMessage.FormatCurrentCulture(fileName, fullFileName));
                        baseResponseStream.SaveStreamToFile(fullFileName, this, _cancellationTokenSource.Token);
                    }
                }
                else
                {
                    WriteVerbose(Resources.InferredFileNameErrorMessage);
                }
            }

            if (!string.IsNullOrEmpty(StatusCodeVariable))
            {
                var vi = SessionState.PSVariable;
                vi.Set(StatusCodeVariable, (int)response.StatusCode);
            }

            if (!string.IsNullOrEmpty(ResponseHeadersVariable))
            {
                var vi = SessionState.PSVariable;
                vi.Set(ResponseHeadersVariable, response.GetHttpResponseHeaders());
            }
        }


        /// <summary>
        ///     Gets a Custom AuthProvider or configured default provided depending on Auth Scheme specified.
        /// </summary>
        /// <returns></returns>
        private IAuthenticationProvider GetAuthProvider()
        {
            if (Authentication == GraphRequestAuthenticationType.UserProvidedToken)
            {
                return new InvokeGraphRequestAuthProvider(GraphRequestSession);
            }

            // Ensure that AuthContext is present in DefaultAuth mode, otherwise demand for Connect-Graph to be called.
            if (Authentication == GraphRequestAuthenticationType.Default && GraphSession.Instance.AuthContext != null)
            {
                return AuthenticationHelpers.GetAuthProvider(GraphSession.Instance.AuthContext);
            }

            var error = new ArgumentNullException(
                Resources.MissingAuthenticationContext.FormatCurrentCulture(nameof(GraphSession.Instance.AuthContext)),
                nameof(GraphSession.Instance.AuthContext));
            throw error;
        }

        /// <summary>
        ///     Gets a Graph HttpClient with a custom or default auth provider.
        /// </summary>
        /// <returns></returns>
        private HttpClient GetHttpClient()
        {
            var provider = GetAuthProvider();
            var client = HttpHelpers.GetGraphHttpClient(provider);
            return client;
        }

        /// <summary>
        ///     Executes the HTTP Request and returns a response
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<HttpResponseMessage> GetResponseAsync(HttpClient client, HttpRequestMessage request)
        {
            using (NoSynchronizationContext)
            {
                if (client == null)
                {
                    throw new ArgumentNullException(nameof(client));
                }

                if (request == null)
                {
                    throw new ArgumentNullException(nameof(request));
                }

                var cancellationToken = _cancellationTokenSource.Token;
                var response = await client.SendAsync(request, cancellationToken);
                return response;
            }
        }

        /// <summary>
        ///     Set the request content.
        ///     Convert Dictionaries to Json
        ///     Passing a dictionary to the body object should be translated to Json.
        ///     Almost everything on Microsoft Graph works converts dictionaries and arrays to JSON.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        private long SetRequestContent(HttpRequestMessage request, IDictionary content)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            // Covert all dictionaries to Json
            var body = JsonConvert.SerializeObject(content);
            return SetRequestContent(request, body);
        }

        /// <summary>
        ///     Set the request content
        /// </summary>
        /// <param name="request"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        private long SetRequestContent(HttpRequestMessage request, string content)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (content == null)
            {
                return 0;
            }

            Encoding encoding = null;
            // When contentType is set, coerce to correct encoding. 
            if (!string.IsNullOrWhiteSpace(ContentType))
            {
                // If Content-Type contains the encoding format (as CharSet), use this encoding format
                // to encode the Body of the GraphRequest sent to the server. Default Encoding format
                // would be used if Charset is not supplied in the Content-Type property.
                try
                {
                    var mediaTypeHeaderValue = MediaTypeHeaderValue.Parse(ContentType);
                    if (!string.IsNullOrEmpty(mediaTypeHeaderValue.CharSet))
                    {
                        encoding = Encoding.GetEncoding(mediaTypeHeaderValue.CharSet);
                    }
                }
                catch (FormatException ex)
                {
                    if (!SkipHeaderValidation)
                    {
                        var outerEx = new ValidationMetadataException(Resources.ContentTypeExceptionErrorMessage, ex);
                        var er = new ErrorRecord(outerEx, Errors.InvokeGraphContentTypeException,
                            ErrorCategory.InvalidArgument, ContentType);
                        ThrowTerminatingError(er);
                    }
                }
                catch (ArgumentException ex)
                {
                    if (!SkipHeaderValidation)
                    {
                        var outerEx = new ValidationMetadataException(Resources.ContentTypeExceptionErrorMessage, ex);
                        var er = new ErrorRecord(outerEx, Errors.InvokeGraphContentTypeException,
                            ErrorCategory.InvalidArgument, ContentType);
                        ThrowTerminatingError(er);
                    }
                }
            }

            var bytes = content.EncodeToBytes(encoding);
            var byteArrayContent = new ByteArrayContent(bytes);
            request.Content = byteArrayContent;

            return byteArrayContent.Headers.ContentLength.Value;
        }

        /// <summary>
        ///     Hydrate the request with the requisite data.
        ///     for Body handle Dictionaries, Streams and Byte Arrays, coerce
        ///     into a string if none of the above types.
        /// </summary>
        /// <param name="request"></param>
        private void FillRequestStream(HttpRequestMessage request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (ContentType != null)
            {
                GraphRequestSession.ContentHeaders[HttpKnownHeaderNames.ContentType] = ContentType;
            }
            else if (ShouldSetDefaultContentType)
            {
                GraphRequestSession.ContentHeaders.TryGetValue(HttpKnownHeaderNames.ContentType, out var contentType);
                if (string.IsNullOrWhiteSpace(contentType))
                {
                    // Assume application/json if not set by user
                    GraphRequestSession.ContentHeaders[HttpKnownHeaderNames.ContentType] =
                        CoreConstants.MimeTypeNames.Application.Json;
                }
            }

            // coerce body into a usable form
            if (Body != null)
            {
                var content = Body;
                // make sure we're using the base object of the body, not the PSObject wrapper
                if (Body is PSObject psBody)
                {
                    content = psBody.BaseObject;
                }

                // Passing a dictionary to the body object should be translated to Json.
                // Almost everything on Microsoft Graph works converts dictionaries and arrays to JSON.
                if (content is IDictionary dictionary && request.Method != HttpMethod.Get)
                {
                    SetRequestContent(request, dictionary);
                }
                else if (content is Stream stream)
                {
                    SetRequestContent(request, stream);
                }
                else if (content is byte[] bytes)
                {
                    SetRequestContent(request, bytes);
                }
                else
                {
                    // Assume its a string
                    SetRequestContent(request,
                        (string)LanguagePrimitives.ConvertTo(content, typeof(string), CultureInfo.InvariantCulture));
                }
            }
            else if (InputFilePath != null) // copy InputFilePath data
            {
                try
                {
                    // open the input file
                    SetRequestContent(request,
                        new FileStream(InputFilePath, FileMode.Open, FileAccess.Read, FileShare.Read));
                }
                catch (UnauthorizedAccessException)
                {
                    var msg = Resources.AccessDenied.FormatCurrentCulture(_originalFilePath);
                    throw new UnauthorizedAccessException(msg);
                }
            }

            // Add the content headers
            // Only Set Content Headers when its not a GET Request
            if (request.Content == null && Method != GraphRequestMethod.GET)
            {
                request.Content = new StringContent(string.Empty);
                request.Content.Headers.Clear();
            }

            foreach (var entry in GraphRequestSession.ContentHeaders.Where(header =>
                !string.IsNullOrWhiteSpace(header.Value)))
            {
                if (SkipHeaderValidation)
                {
                    request.Content?.Headers.TryAddWithoutValidation(entry.Key, entry.Value);
                }
                else
                {
                    try
                    {
                        request.Content?.Headers.Add(entry.Key, entry.Value);
                    }
                    catch (FormatException ex)
                    {
                        var outerEx =
                            new ValidationMetadataException(Resources.ContentTypeExceptionErrorMessage, ex);
                        var er = new ErrorRecord(outerEx, Errors.InvokeGraphContentTypeException,
                            ErrorCategory.InvalidArgument, ContentType);
                        ThrowTerminatingError(er);
                    }
                }
            }
        }

        /// <summary>
        ///     Sets the body of the to be a byte array
        /// </summary>
        /// <param name="request"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        private static long SetRequestContent(HttpRequestMessage request, byte[] content)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            if (content == null)
                return 0;

            var byteArrayContent = new ByteArrayContent(content);
            request.Content = byteArrayContent;

            return byteArrayContent.Headers.ContentLength.Value;
        }

        /// <summary>
        ///     Sets the body of the request to be a Stream
        /// </summary>
        /// <param name="request"></param>
        /// <param name="contentStream"></param>
        /// <returns></returns>
        private static long SetRequestContent(HttpRequestMessage request, Stream contentStream)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            if (contentStream == null)
                throw new ArgumentNullException(nameof(contentStream));

            var streamContent = new StreamContent(contentStream);
            request.Content = streamContent;

            return streamContent.Headers.ContentLength.Value;
        }

        /// <summary>
        ///     Maps from HttpVerb to System.Net.Http.HttpMethod
        /// </summary>
        /// <returns>System.Net.Http.HttpMethod</returns>
        private static HttpMethod GetHttpMethod(GraphRequestMethod graphRequestMethod)
        {
            return new HttpMethod(graphRequestMethod.ToString().ToUpperInvariant());
        }

        /// <summary>
        ///     Prepare GraphRequestSession to be used downstream.
        /// </summary>
        internal virtual void PrepareSession()
        {
            // Swap current GraphSession environment with a temporary environment for this request.
            // This only occurs when a customer has provided an absolute url and an access token.
            if (MyInvocation.BoundParameters.ContainsKey(nameof(Uri))
                && MyInvocation.BoundParameters.ContainsKey(nameof(Token))
                && Uri.IsAbsoluteUri)
            {
                _originalEnvironment = GraphSession.Instance.Environment;
                GraphSession.Instance.Environment = new GraphEnvironment
                {
                    Name = "MSGraphInvokeGraphRequest",
                    GraphEndpoint = Uri.GetBaseUrl()
                    // No need to set AAD endpoint since a token is provided.
                };
            }

            // Create a new GraphRequestSession object to work with if one is not supplied
            GraphRequestSession = GraphRequestSession ?? new GraphRequestSession();
            if (SessionVariable != null)
            {
                // save the session back to the PS environment if requested
                var vi = SessionState.PSVariable;
                vi.Set(SessionVariable, GraphRequestSession);
            }

            if (Authentication == GraphRequestAuthenticationType.UserProvidedToken && Token != null)
            {
                GraphRequestSession.Token = Token;
                GraphRequestSession.AuthenticationType = Authentication;
            }

            //
            // Handle Custom User Agents
            //
            GraphRequestSession.UserAgent = UserAgent ?? _graphRequestUserAgent.UserAgent;

            // Store the other supplied headers
            if (Headers != null)
            {
                foreach (string key in Headers.Keys)
                {
                    var value = Headers[key];

                    // null is not valid value for header.
                    // We silently ignore header if value is null.
                    if (!(value is null))
                    {
                        // add the header value (or overwrite it if already present)
                        GraphRequestSession.Headers[key] = value.ToString();
                    }
                }
            }
        }

        /// <summary>
        ///     Validate the Request Uri must have the same Host as GraphHttpClient BaseAddress.
        /// </summary>
        /// <param name="httpClient"></param>
        private void ValidateRequestUri(HttpClient httpClient)
        {
            if (Uri == null)
            {
                var error = GetValidationError(
                    Resources.InvokeGraphRequestMissingUriErrorMessage,
                    Errors.InvokeGraphRequestInvalidHost,
                    nameof(Uri));
                ThrowTerminatingError(error);
            }

            if (string.IsNullOrWhiteSpace(Uri.ToString()))
            {
                var error = GetValidationError(
                    Resources.InvokeGraphRequestInvalidUriErrorMessage,
                    Errors.InvokeGraphRequestInvalidHost,
                    nameof(Uri));
                ThrowTerminatingError(error);
            }
        }

        /// <summary>
        ///     Validate Passed In Parameters
        /// </summary>
        private void ValidateParameters()
        {
            if (GraphRequestSession != null && SessionVariable != null)
            {
                var error = GetValidationError(
                    Resources.GraphRequestSessionConflict,
                    Errors.InvokeGraphRequestSessionConflictException);
                ThrowTerminatingError(error);
            }

            // When PATCH or POST is specified, ensure a body is present
            if ((Method == GraphRequestMethod.PATCH || Method == GraphRequestMethod.POST) && Body == null &&
                string.IsNullOrWhiteSpace(InputFilePath))
            {
                var error = GetValidationError(
                    Resources.BodyMissingWhenMethodIsSpecified,
                    Errors.InvokeGraphRequestBodyMissingWhenMethodIsSpecified,
                    nameof(Body), Method);
                ThrowTerminatingError(error);
            }

            if (PassThru && OutputFilePath == null)
            {
                var error = GetValidationError(
                    Resources.PassThruWithOutputFilePathMissing,
                    Errors.InvokeGraphRequestOutFileMissingException,
                    nameof(PassThru), nameof(OutputFilePath));
                ThrowTerminatingError(error);
            }

            if (Authentication == GraphRequestAuthenticationType.Default && Token != null)
            {
                var error = GetValidationError(
                    Resources.AuthenticationTokenConflict,
                    Errors.InvokeGraphRequestAuthenticationTokenConflictException,
                    Authentication, nameof(Token));
                ThrowTerminatingError(error);
            }

            if (Authentication == GraphRequestAuthenticationType.Default && GraphSession.Instance.AuthContext == null)
            {
                var error = GetValidationError(
                    Resources.NotConnectedToGraphException,
                    Errors.InvokeGraphRequestAuthenticationTokenConflictException,
                    Authentication, nameof(Token));
                ThrowTerminatingError(error);
            }

            // Token shouldn't be null when UserProvidedToken is specified
            if (Authentication == GraphRequestAuthenticationType.UserProvidedToken && Token == null)
            {
                var error = GetValidationError(
                    Resources.AuthenticationCredentialNotSupplied,
                    Errors.InvokeGraphRequestAuthenticationTokenConflictException,
                    Authentication, nameof(Token));
                ThrowTerminatingError(error);
            }

            // Only Body or InputFilePath can be specified at a time
            if (Body != null && !string.IsNullOrWhiteSpace(InputFilePath))
            {
                var error = GetValidationError(
                    Resources.BodyConflict,
                    Errors.InvokeGraphRequestBodyConflictException,
                    nameof(Body), nameof(InputFilePath));
                ThrowTerminatingError(error);
            }

            if (InferOutputFileName.IsPresent && !string.IsNullOrWhiteSpace(OutputFilePath))
            {
                var error = GetValidationError(
                    Resources.InferFileNameOutFilePathConflict,
                    Errors.InvokeGraphRequestBodyConflictException,
                    nameof(InferOutputFileName), nameof(OutputFilePath));
                ThrowTerminatingError(error);
            }

            // Ensure InputFilePath is an Existing Item
            if (InputFilePath != null)
            {
                ErrorRecord errorRecord = null;

                try
                {
                    var providerPaths = GetResolvedProviderPathFromPSPath(InputFilePath, out var provider);

                    if (!provider.Name.Equals(FileSystemProvider.ProviderName, StringComparison.OrdinalIgnoreCase))
                    {
                        errorRecord = GetValidationError(
                            Resources.NotFileSystemPath,
                            Errors.InvokeGraphRequestFileNotFilesystemPathException,
                            InputFilePath);
                    }
                    else
                    {
                        if (providerPaths.Count > 1)
                        {
                            errorRecord = GetValidationError(
                                Resources.MultiplePathsResolved,
                                Errors.InvokeGraphRequestInputFileMultiplePathsResolvedException, InputFilePath);
                        }
                        else if (providerPaths.Count == 0)
                        {
                            errorRecord = GetValidationError(
                                Resources.NoPathResolved,
                                Errors.InvokeGraphRequestInputFileNoPathResolvedException, InputFilePath);
                        }
                        else
                        {
                            if (Directory.Exists(providerPaths[0]))
                            {
                                errorRecord = GetValidationError(
                                    Resources.DirectoryPathSpecified,
                                    Errors.InvokeGraphRequestInputFileNotFilePathException, InputFilePath);
                            }

                            _originalFilePath = InputFilePath;
                            InputFilePath = providerPaths[0];
                        }
                    }
                }
                catch (ItemNotFoundException pathNotFound)
                {
                    errorRecord = new ErrorRecord(pathNotFound.ErrorRecord, pathNotFound);
                }
                catch (ProviderNotFoundException providerNotFound)
                {
                    errorRecord = new ErrorRecord(providerNotFound.ErrorRecord, providerNotFound);
                }
                catch (DriveNotFoundException driveNotFound)
                {
                    errorRecord = new ErrorRecord(driveNotFound.ErrorRecord, driveNotFound);
                }

                if (errorRecord != null)
                    ThrowTerminatingError(errorRecord);
            }
        }

        /// <summary>
        ///     Composes a validation error
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="errorId"></param>
        /// <returns></returns>
        private ErrorRecord GetValidationError(string msg, string errorId)
        {
            var ex = new ValidationMetadataException(msg);
            var error = new ErrorRecord(ex, errorId, ErrorCategory.InvalidArgument, this);
            return error;
        }

        /// <summary>
        ///     Composes a validation error
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="errorId"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private ErrorRecord GetValidationError(string msg, string errorId, params object[] args)
        {
            msg = msg.FormatCurrentCulture(args);
            var ex = new ValidationMetadataException(msg);
            var error = new ErrorRecord(ex, errorId, ErrorCategory.InvalidArgument, this);
            return error;
        }

        /// <summary>
        ///     Generate a fully qualified file path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string QualifyFilePath(string path)
        {
            var resolvedFilePath = PathUtils.ResolveFilePath(path, this, true);
            return resolvedFilePath;
        }

        /// <summary>
        ///     Resets GraphSession environment back to its original state.
        /// </summary>
        private void ResetGraphSessionEnvironment()
        {
            GraphSession.Instance.Environment = _originalEnvironment;
        }

        #region CmdLet LifeCycle

        protected override void BeginProcessing()
        {
            if (Break)
            {
                this.Break();
            }

            ValidateParameters();
            base.BeginProcessing();
        }

        private async Task ProcessRecordAsync()
        {
            using (NoSynchronizationContext)
            {
                try
                {
                    PrepareSession();
                    using (var client = GetHttpClient())
                    {
                        ValidateRequestUri(client);
                        using (var httpRequestMessage = GetRequest(client, Uri))
                        {
                            using (var httpRequestMessageFormatter = new HttpMessageFormatter(httpRequestMessage))
                            {
                                FillRequestStream(httpRequestMessage);
                                try
                                {
                                    await ReportRequestStatusAsync(httpRequestMessageFormatter);
                                    var httpResponseMessage = await GetResponseAsync(client, httpRequestMessage);
                                    using (var httpResponseMessageFormatter = new HttpMessageFormatter(httpResponseMessage))
                                    {
                                        await ReportResponseStatusASync(httpResponseMessageFormatter);
                                        var isSuccess = httpResponseMessage.IsSuccessStatusCode;
                                        if (ShouldCheckHttpStatus && !isSuccess)
                                        {
                                            var httpErrorRecord = await GenerateHttpErrorRecordAsync(httpResponseMessageFormatter, httpRequestMessage);
                                            ThrowTerminatingError(httpErrorRecord);
                                        }

                                        await ProcessResponse(httpResponseMessage);
                                    }
                                }
                                catch (HttpRequestException ex)
                                {
                                    var er = new ErrorRecord(ex, Errors.InvokeGraphHttpResponseException,
                                        ErrorCategory.InvalidOperation,
                                        httpRequestMessage);
                                    if (ex.InnerException != null)
                                    {
                                        er.ErrorDetails = new ErrorDetails(ex.InnerException.Message);
                                    }

                                    ThrowTerminatingError(er);
                                }
                            }
                        }
                    }
                }
                catch (HttpRequestException httpRequestException)
                {
                    var errorRecord = new ErrorRecord(httpRequestException, ErrorCategory.ConnectionError.ToString(),
                        ErrorCategory.InvalidResult, null);
                    httpRequestException.Data.Add(ErrorCategory.ConnectionError.ToString(), errorRecord);
                    throw;
                }
                catch (Exception exception)
                {
                    var errorRecord = new ErrorRecord(exception, ErrorCategory.NotSpecified.ToString(),
                        ErrorCategory.InvalidOperation, null);
                    exception.Data.Add(ErrorCategory.NotSpecified.ToString(), errorRecord);
                    throw;
                }
            }
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                using (var asyncCommandRuntime = new CustomAsyncCommandRuntime(this, _cancellationTokenSource.Token))
                {
                    asyncCommandRuntime.Wait(ProcessRecordAsync(), _cancellationTokenSource.Token);
                }
            }
            catch (AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach (var innerException in aggregateException.Flatten().InnerExceptions)
                {
                    var errorRecords = innerException.Data;
                    if (errorRecords.Count < 1)
                    {
                        foreach (DictionaryEntry dictionaryEntry in errorRecords)
                        {
                            WriteError((ErrorRecord)dictionaryEntry.Value);
                        }
                    }
                    else
                    {
                        WriteError(new ErrorRecord(innerException, string.Empty, ErrorCategory.NotSpecified, null));
                    }
                }
            }
            catch (Exception exception) when (exception as PipelineStoppedException == null ||
                                              (exception as PipelineStoppedException).InnerException != null)
            {
                // Write exception out to error channel.
                WriteError(new ErrorRecord(exception, string.Empty, ErrorCategory.NotSpecified, null));
            }
        }

        protected override void EndProcessing()
        {
            ResetGraphSessionEnvironment();
            base.EndProcessing();
        }

        protected override void StopProcessing()
        {
            ResetGraphSessionEnvironment();
            _cancellationTokenSource.Cancel();
            base.StopProcessing();
        }

        #endregion
    }
}