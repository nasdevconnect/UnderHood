using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Bluetooth;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using UnderHood.Services.BlueTooth;

[assembly: Dependency(typeof(UnderHood.Droid.Services.Bluetooth.BluetoothService))]
namespace UnderHood.Droid.Services.Bluetooth
{
    class BluetoothService : UnderHood.Services.BlueTooth.IBluetoothService
    {
        string[] IBluetoothService.NearByDevices()
        {
            throw new NotImplementedException();
        }
    }
}