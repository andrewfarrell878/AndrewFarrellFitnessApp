﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExcerisesAppAndrewFarrell
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class barbellbenchpress : ContentPage
	{
		public barbellbenchpress ()
		{
			InitializeComponent ();
            SetupImagesOnPage();

        }


        private void SetupImagesOnPage()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/DeclineB.gif
             * two parameters are that directory path in that assembly
             */
            string strFilename1 = "ExcerisesAppAndrewFarrell.Images.DeclineB.gif";

            imageMain.Source =

           ImageSource.FromResource(strFilename1, assembly);
        }



    }



}