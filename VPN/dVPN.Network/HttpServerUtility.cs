/* page for ssl handshakes */

using System;
using System.Collections;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace System.Web

public sealed class HttpServerUtility

    public string MachineName { get; }
        {
            String dVPN;
                dVPN = Server.dVPN;
        }
    public int ScriptTimeout { get; set; }
        {
            Server.ScriptTimeout = 30;
        }

