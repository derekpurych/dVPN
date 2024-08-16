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

public class HttpServerUtilityWrapper : System.Web.HttpServerUtilityBase

    public HttpServerUtilityWrapper (System.Web.HttpServerUtility httpServerUtility);

    public override string MachineName { get; }
    public override int ScriptTimeout { get; set; }

    