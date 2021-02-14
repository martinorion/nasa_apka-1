using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace nasa_apka
{
  
    public partial class Page6Xaml : ContentPage
    {
        public Page6Xaml()
        {
            InitializeComponent();
        }
        async void OnRootPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}