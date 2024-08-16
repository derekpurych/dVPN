using System;
using System.Collections;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Net.ServerSentEvents;
using System.Web;
using System.Net.Http;

public class HttpClient : System.Net.Http.HttpMessageInvoker

    [System.Runtime.Versioning.UnsupportedOSPlatform("browser")]
    public sealed class SocketsHttpHandler : System.Net.Http.HttpMessageHandler

    [System.CLSCompliant(false)]
    public System.Diagnostics.DistributedContextPropagator? ActivityHeadersPropagator { get; set; }
    public bool AllowAutoRedirect { get; set; }
    public System.Net.DecompressionMethods AutomaticDecompression { get; set; }

    public Func<System.Net.Http.SocketsHttpConnectionContext,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<System.IO.Stream>>? 
        ConnectCallback { get; set; }

    public TimeSpan ConnectTimeout { get; set; }

    public System.Net.CookieContainer CookieContainer { get; set; }

    public System.Net.ICredentials? Credentials { get; set; }

    public System.Net.ICredentials? DefaultProxyCredentials { get; set; }

    public bool EnableMultipleHttp2Connections { get; set; }

    public TimeSpan Expect100ContinueTimeout { get; set; }

    public int InitialHttp2StreamWindowSize { get; set; }

    [System.Runtime.Versioning.UnsupportedOSPlatformGuard("browser")]
    public static bool IsSupported { get; }

    public TimeSpan KeepAlivePingDelay { get; set; }

    public System.Net.Http.HttpKeepAlivePingPolicy KeepAlivePingPolicy { get; set; }

    public TimeSpan KeepAlivePingTimeout { get; set; }

    public int MaxAutomaticRedirections { get; set; }

    public int MaxConnectionsPerServer { get; set; }

    public int MaxResponseDrainSize { get; set; }

    public int MaxResponseHeadersLength { get; set; }

    [System.CLSCompliant(false)]
    public System.Diagnostics.Metrics.IMeterFactory? MeterFactory { get; set; }

    public Func<System.Net.Http.SocketsHttpPlaintextStreamFilterContext,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<System.IO.Stream>>? 
        PlaintextStreamFilter { get; set; }

    public TimeSpan PooledConnectionIdleTimeout { get; set; }

    public TimeSpan PooledConnectionLifetime { get; set; }

    public bool PreAuthenticate { get; set; }

    public System.Collections.Generic.IDictionary<string,object?> Properties { get; }

    public System.Net.IWebProxy? Proxy { get; set; }

    public System.Net.Http.HeaderEncodingSelector<System.Net.Http.HttpRequestMessage>? RequestHeaderEncodingSelector { get; set; }

    public TimeSpan ResponseDrainTimeout { get; set; }

    public System.Net.Http.HeaderEncodingSelector<System.Net.Http.HttpRequestMessage>? ResponseHeaderEncodingSelector { get; set; }

    public System.Net.Security.SslClientAuthenticationOptions SslOptions { get; set; }

    public bool UseCookies { get; set; }

    public bool UseProxy { get; set; }