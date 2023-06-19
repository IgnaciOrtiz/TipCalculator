﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipCalculator.Model;
using TipCalculator.ViewModel;
using Xamarin.Forms;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            this.BindingContext = 
                new MainPageViewModel();
        }
    }
}
