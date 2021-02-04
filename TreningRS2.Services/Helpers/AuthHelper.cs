﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace TreningRS2.Services.Helpers
{
    public static class AuthHelper
    {
        public static string GenerateHash(string passwordSalt, string password)
        {
            byte[] source = Convert.FromBase64String(passwordSalt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] destination = new byte[source.Length + bytes.Length];

            Buffer.BlockCopy(source, 0, destination, 0, source.Length);
            Buffer.BlockCopy(bytes, 0, destination, source.Length, bytes.Length);

            return Convert.ToBase64String(HashAlgorithm.Create("MD5").ComputeHash(destination));/*SHA256*/
        }

        public static string GenerateSalt()
        {
            var buffer = new byte[16];
            new RNGCryptoServiceProvider().GetBytes(buffer);
            return Convert.ToBase64String(buffer);
        }
    }
}
