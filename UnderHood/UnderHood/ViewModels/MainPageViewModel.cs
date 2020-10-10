using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using UnderHood.Models;
using UnderHood.Services.BlueTooth;
using UnderHood.ViewModels.Base;
using UnderHood.Views;
using Xamarin.Forms;

namespace UnderHood.ViewModels
{
    class MainPageViewModel : ViewModelBase
    {
        IBluetoothService bluetoothService = DependencyService.Get<IBluetoothService>();

        public ICommand SectionButtonCommand
        {
            get
            {
                return new Command((e) =>
                {
                    var item = (e as SectionButton);
                    LoadSection(item.ButtonName);
                    // delete logic on item
                });
            }
        }

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

        private IList<View> detailViewChildren = new List<View>(); 
        public IList<View> DetailViewChildren
        {
            get { return detailViewChildren; }
            set
            {
                detailViewChildren = value;
                this.OnPropertyChanged(nameof(DetailViewChildren));
            }
        }

        private ObservableCollection<SectionButton> sections = new ObservableCollection<SectionButton>();
        public ObservableCollection<SectionButton> Sections
        {
            get { return sections; }
            set
            {
                sections = value;
                this.OnPropertyChanged(nameof(Sections));
            }
        }

        //public ObservableCollection<string> Sections = new ObservableCollection<string>();

        public MainPageViewModel()
        {
            PageTitle = "Main Page";

            Sections.Add(new SectionButton() { ButtonName = "Bluetooth" });
        }

        void LoadSection(string sectionName)
        {
            //TODO TinyIoC/Other VM loader
            IList<View> children = new List<View>();
            children.Add(new BluetoothView());
            DetailViewChildren = children;  
        }
     }
}
