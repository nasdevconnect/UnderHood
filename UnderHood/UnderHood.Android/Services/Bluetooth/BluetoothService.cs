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
using UnderHood.Droid.Services.Activity;

[assembly: Dependency(typeof(UnderHood.Droid.Services.Bluetooth.BluetoothService))]
namespace UnderHood.Droid.Services.Bluetooth
{
    public class BluetoothService : IBluetoothService
    {
        IActivityService activityService = DependencyService.Get<IActivityService>();

        const int REQUEST_CONNECT_DEVICE_SECURE = 1;
        const int REQUEST_CONNECT_DEVICE_INSECURE = 2;
        const int REQUEST_ENABLE_BT = 3;

        BluetoothAdapter bluetoothAdapter = BluetoothAdapter.DefaultAdapter;
        string[] IBluetoothService.NearByDevices()
        {
            var devices = new string[0];
            if (bluetoothAdapter == null)
            {
                //Bluetooth is not available
            }

            if (!bluetoothAdapter.IsEnabled)
            {
                var enableIntent = new Intent(BluetoothAdapter.ActionRequestEnable);
                activityService.StartActivity(enableIntent);
            }

            return devices;
        }
    }
}