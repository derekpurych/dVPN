using System;
using System.Collections;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Net.ServerSentEvents

public delegate T SseItemParser<out T>(string eventType, ReadOnlySpan<byte> data);

public static class SseParser

        public const string EventTypeDefault;

        public static System.Net.ServerSentEvents.SseParser<string> Create (System.IO.Stream sseStream);


public sealed class SseParser<T>

    public string LastEventId { get; }

    public TimeSpan ReconnectionInterval { get; }

    public System.Collections.Generic.IEnumerable<System.Net.ServerSentEvents.SseItem<T>> Enumerate ();

    public System.Collections.Generic.IAsyncEnumerable<System.Net.ServerSentEvents.SseItem<T>> EnumerateAsync (System.Threading.CancellationToken cancellationTo);