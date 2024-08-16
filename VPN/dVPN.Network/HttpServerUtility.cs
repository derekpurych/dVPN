/* page for ssl handshakes */

using system

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

