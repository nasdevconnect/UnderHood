using System;
using System.Collections.Generic;
using System.Text;

namespace UnderHood.Services.BlueTooth
{
    public interface IBluetoothService
    {
        string[] NearByDevices();
    }
}
