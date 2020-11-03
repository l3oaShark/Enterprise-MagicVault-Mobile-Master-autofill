﻿using Bit.App.Models;
using Bit.App.Models.Api;
using System;
using System.Collections.Generic;

namespace Bit.App.Abstractions
{
    public interface ICryptoService
    {
        SymmetricCryptoKey Key { get; set; }
        SymmetricCryptoKey EncKey { get; }
        byte[] PrivateKey { get; }
        IDictionary<string, SymmetricCryptoKey> OrgKeys { get; }
        void SetEncKey(CipherString encKeyEnc);
        void SetPrivateKey(CipherString privateKeyEnc);
        void SetOrgKeys(ProfileResponse profile);
        void SetOrgKeys(Dictionary<string, string> orgKeysEncDict);
        SymmetricCryptoKey GetOrgKey(string orgId);
        void ClearKeys();
        string Decrypt(CipherString encyptedValue, SymmetricCryptoKey key = null);
        byte[] DecryptToBytes(CipherString encyptedValue, SymmetricCryptoKey key = null);
        byte[] DecryptToBytes(byte[] encyptedValue, SymmetricCryptoKey key = null);
        byte[] RsaDecryptToBytes(CipherString encyptedValue, byte[] privateKey);
        CipherString Encrypt(string plaintextValue, SymmetricCryptoKey key = null);
        byte[] EncryptToBytes(byte[] plainBytes, SymmetricCryptoKey key = null);
        SymmetricCryptoKey MakeKeyFromPassword(string password, string salt);
        string MakeKeyFromPasswordBase64(string password, string salt);
        byte[] HashPassword(SymmetricCryptoKey key, string password);
        string HashPasswordBase64(SymmetricCryptoKey key, string password);
        CipherString MakeEncKey(SymmetricCryptoKey key);
    }
}