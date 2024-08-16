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

public sealed class SocketsHttpPlaintextStreamFilterContext

    public System.Net.Http.HttpRequestMessage InitialRequestMessage { get; }

    public Version NegotiatedHttpVersion { get; }

    public System.IO.Stream PlaintextStream { get; }