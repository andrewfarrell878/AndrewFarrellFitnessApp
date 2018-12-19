using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExcerisesAppAndrewFarrell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Timer : ContentPage
    {
        public Timer()
        {
            InitializeComponent();
          

        }
       
        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TimerRefresh());

        }

    }
}