using System

using System.Web

public class HttpStyleUriParser : UriParser

    protected virtual string GetComponents (Uri uri, UriComponents components, UriFormat format);
    protected virtual void InitializeAndValidate (Uri uri, out UriFormatException? parsingError);
    public virtual bool Equals (object? obj);
    public virtual int GetHashCode ();

    protected object MemberwiseClone ();
