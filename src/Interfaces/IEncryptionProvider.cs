/**
 * HVH.Common - Common code that is shared between the projects
 * Copyright (c) Dorian Stoll 2017
 * Licensed under the terms of the MIT License
 */

using System;

namespace HVH.Common.Interfaces
{
    /// <summary>
    /// Provides an interface for encoding data
    /// </summary>
    public interface IEncryptionProvider
    {
        Byte[] Encrypt(Byte[] data);
        Byte[] Decrypt(Byte[] data);
        void ChangeKey(Byte[] newKey);
    }
}