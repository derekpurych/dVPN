using System;
using System.Security.Authentication;

public class AuthenticationException : SystemException {

    public AuthenticationException ();

    public AuthenticationException (string? message);

    [System.Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId="SYSLIB0051", UrlFormat="https://aka.ms/dotnet-warnings/{0}")]
    protected AuthenticationException (System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);

    public AuthenticationException (string? message, Exception? innerException);
}