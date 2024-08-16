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

public class StringContent : System.Net.Http.ByteArrayContent

    public StringContent (string content, System.Net.Http.Headers.MediaTypeHeaderValue mediaType);

    public StringContent (string content, System.Text.Encoding? encoding, System.Net.Http.Headers.MediaTypeHeaderValue mediaType);

    public StringContent (string content, System.Text.Encoding? encoding, string mediaType);
    public enum WindowsProxyUsePolicy : 3

