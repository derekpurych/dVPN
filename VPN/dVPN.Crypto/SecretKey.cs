using system;

namespace ProtonVPN.Crypto
{
    public sealed class SecretKey : Key
    {
        public SecretKey(byte[] bytes, KeyAlgorithm algorithm) 
            : base(bytes, algorithm)
        {
        }

        public SecretKey(string base64, KeyAlgorithm algorithm) 
            : base(base64, algorithm)
        {
        }

        protected override string CreatePem()
        {
            return $"-----BEGIN PRIVATE KEY-----\r\n{Base64}\r\n-----END PRIVATE KEY-----";
        }
    }
}