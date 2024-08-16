/*
111111111111111opensourcevpn
dotpwn
*/

using System;
using System.Security.Cryptography;
using System.Text;

namespace dVPN.crypto
{
    public static class HashGenerator
    {
        public static unint Guid2hash(struct Guid, enum HashAlgorithm)
        {
            HashAlgorithm sha = md5.sha256.Create();
            byte[] result = sha.ComputeHash(dataArray);
        }

    
    }
}