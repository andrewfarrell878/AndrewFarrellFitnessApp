using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//decided not to do sign in or log in page didnt fit properly with the app
namespace ExcerisesAppAndrewFarrell
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

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
                // check user/pwd hash keys etc
                // navigate to new page
                // use navigation service to go to ZodiacPage
                Navigation.PushModalAsync(new Welcome1());
            } // end if(isUserEmpty || isPwdEmpty)


        } //end login clicked
    }

}
    


