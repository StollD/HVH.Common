/**
 * HVH.Common - Common code that is shared between the projects
 * Copyright (c) Dorian Stoll 2017
 * Licensed under the terms of the MIT License
 */

using System;
using System.Security.Cryptography;
using HVH.Common.Interfaces;

namespace HVH.Common.Encryption
{
    /// <summary>
    /// IEncryptionProvider shim for no encryption
    /// </summary>
    public class NoneEncryptionProvider  : IEncryptionProvider
    {
        public Byte[] Encrypt(Byte[] data)
        {
            return data;
        }

        public Byte[] Decrypt(Byte[] data)
        {
            return data;
        }

        public void ChangeKey(Byte[] newKey)
        {
            // ignored
        }
    }
}