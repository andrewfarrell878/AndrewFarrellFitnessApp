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
    public partial class excerises : ContentPage
    {
        public excerises()
        {
            InitializeComponent();
            SetupImagesOnPage();
            SetupImagesOnPage1();
            SetupImagesOnPage2();
            SetupImagesOnPage3();
            SetupImagesOnPage4();

        }

        private void SetupImagesOnPage()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */
   string strFilename1 = "ExcerisesAppAndrewFarrell.Images.bicep-curl.jpg";

            imageMain1.Source =
                
                ImageSource.FromResource(strFilename1, assembly);

    }        

    private void SetupImagesOnPage1()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */
         string strFilename = "ExcerisesAppAndrewFarrell.Images.Excerises.png";

            imageMain.Source =
                ImageSource.FromResource(strFilename, assembly);

      

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            // go to PageTwo.xaml
            // create new instance of PageTwo and put it on the stack
            Navigation.PushAsync(new BiceptCurl());
        }


        private void SetupImagesOnPage2()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */
            string strFilename = "ExcerisesAppAndrewFarrell.Images.Barbelpush.jpg";

            imageMain2.Source =
                ImageSource.FromResource(strFilename, assembly);



        }

        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            // go to PageTwo.xaml
            // create new instance of PageTwo and put it on the stack
            Navigation.PushAsync(new barbellbenchpress());
        }


        private void SetupImagesOnPage3()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */
            string strFilename = "ExcerisesAppAndrewFarrell.Images.Crunch.jpg";

            imageMain3.Source =
                ImageSource.FromResource(strFilename, assembly);



        }

        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            // go to PageTwo.xaml
            // create new instance of PageTwo and put it on the stack
            Navigation.PushAsync(new Crunch());
        }

        private void SetupImagesOnPage4()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */
            string strFilename = "ExcerisesAppAndrewFarrell.Images.barbell-squat1.jpg";

            imageMain4.Source =
                ImageSource.FromResource(strFilename, assembly);



        }

        private void TapGestureRecognizer_Tapped3(object sender, EventArgs e)
        {
            // go to PageTwo.xaml
            // create new instance of PageTwo and put it on the stack
            Navigation.PushAsync(new BarbellSquat());
        }
    }
}