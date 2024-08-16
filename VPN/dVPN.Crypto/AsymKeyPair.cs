/* standard crypto for ssl */

using System;
using System.Collections;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace dVPN.crypto

    public class AssymetricKeyPair
    {
        public PublicKey PublicKey {get;}
        public SecretKey SkecretKey {get;}

        public AssymetricKeyPair(PublicKey publicKey, SecretKey secretKey)
            {
                if (PublicKey is null)
                {
                    throw new ArugmentNullException(nameof(publicKey)),
                }
                if (PrivateKey is null)
                {
                    throw new ArgumentNullException(nameof(secretKey)),
                }
                if (publicKey.Algorithm != secretKey.algotrithm)
                {
                    throw new ArgumentException()
                }
                
                PublicKey = publicKey;
                secretKey = secretKey;

            }
    }