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

public abstract class HttpSessionStateBase : System.Collections.ICollection

    public virtual int CodePage { get; set; }
    
    public virtual System.Web.HttpSessionStateBase Contents { get; }

    public virtual System.Web.HttpCookieMode CookieMode { get; }

    public virtual int Count { get; }

    public virtual bool IsCookieless { get; }

    public virtual bool IsNewSession { get; }

    public virtual bool IsReadOnly { get; }

    public virtual bool IsSynchronized { get; }

    public virtual object this[int index] { get; set; }

    public virtual object this[string name] { get; set; }

    public virtual System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get; }

    public virtual int LCID { get; set; }

    public virtual System.Web.SessionState.SessionStateMode Mode { get; }

    public virtual string SessionID { get; }

    public virtual System.Web.HttpStaticObjectsCollectionBase StaticObjects { get; }

    public virtual object SyncRoot { get; }

    public virtual int Timeout { get; set; }