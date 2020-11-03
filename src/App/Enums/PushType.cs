﻿namespace Bit.App.Enums
{
    public enum PushType : short
    {
        SyncCipherUpdate = 0,
        SyncCipherCreate = 1,
        SyncLoginDelete = 2,
        SyncFolderDelete = 3,
        SyncCiphers = 4,

        SyncVault = 5,
        SyncOrgKeys = 6,
        SyncFolderCreate = 7,
        SyncFolderUpdate = 8,
        SyncCipherDelete = 9,
        SyncSettings = 10
    }
}
