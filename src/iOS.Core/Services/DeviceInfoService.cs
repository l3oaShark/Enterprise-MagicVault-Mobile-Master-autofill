﻿using Bit.App.Abstractions;
using UIKit;

namespace Bit.iOS.Core.Services
{
    public class DeviceInfoService : IDeviceInfoService
    {
        public string Model => UIDevice.CurrentDevice.Model;
        public int Version
        {
            get
            {
                int version;
                var versionParts = UIDevice.CurrentDevice.SystemVersion.Split('.');
                if(versionParts.Length > 0 && int.TryParse(versionParts[0], out version))
                {
                    return version;
                }

                // unable to determine version
                return -1;
            }
        }
        public float Scale => (float)UIScreen.MainScreen.Scale;
        public bool NfcEnabled => false;
        public bool HasCamera => true;
    }
}
