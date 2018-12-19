using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//decided not to do sign in or log in page didnt fit properly with the app
namespace ExcerisesAppAndrewFarrell
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignInPage : ContentPage
	{
		public SignInPage ()
		{
			InitializeComponent ();
		}

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            bool isUserEmpty, isPwdEmpty;
            isUserEmpty = String.IsNullOrEmpty(entUser.Text);
            isPwdEmpty = String.IsNullOrEmpty(entPassword.Text);

            if (isUserEmpty || isPwdEmpty)
            {
                // message to user not to be awkward
            }
            else
            {
               
                Navigation.PushAsync(new Welcome1());
            } // end if(isUserEmpty || isPwdEmpty)


        } //end login clicked
    }
}