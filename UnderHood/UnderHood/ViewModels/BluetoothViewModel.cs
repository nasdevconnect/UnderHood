using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using UnderHood.Services.BlueTooth;
using UnderHood.ViewModels.Base;
using Xamarin.Forms;

namespace UnderHood.ViewModels
{
    class BluetoothViewModel : ViewModelBase
    {
        IBluetoothService bluetoothService = DependencyService.Get<IBluetoothService>();
        public ICommand GetNearByDevicesCommand { get; }

        private string pageTitle;
        public string PageTitle
        {
            get { return pageTitle; }
            set
            {
                pageTitle = value;
                this.OnPropertyChanged(nameof(PageTitle));
            }
        }

        private string[] nearByDevices;
        public string[] NearByDevices
        {
            get { return nearByDevices; }
            set
            {
                nearByDevices = value;
                this.OnPropertyChanged(nameof(NearByDevices));
            }
        }

        public BluetoothViewModel()
        {
            GetNearByDevicesCommand = new Command(GetNearByDevices);

            PageTitle = "BlueTooth Tools";
        }

        void GetNearByDevices()
        {
            NearByDevices = bluetoothService.NearByDevices();
        }
     }
}
