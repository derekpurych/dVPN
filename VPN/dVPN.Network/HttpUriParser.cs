using System;
using System.Collections;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace dVPN.HttpStyleUriParser
public class HttpStyleUriParser : UriParser

    protected virtual string GetComponents (Uri uri, UriComponents components, UriFormat format);
    protected virtual void InitializeAndValidate (Uri uri, out UriFormatException? parsingError);
    public virtual bool Equals (object? obj);
    public virtual int GetHashCode ();

    protected object MemberwiseClone ();

