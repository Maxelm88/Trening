﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZamarinKurs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmbeddedImage : ContentPage
    {
        public EmbeddedImage()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource("ZamarinKurs.Images.background.jpg");
        }
    }
}