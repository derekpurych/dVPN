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

public class StreamContent : System.Net.Http.HttpContent

    public StreamContent (System.IO.Stream content);