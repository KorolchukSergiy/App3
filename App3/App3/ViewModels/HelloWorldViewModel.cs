﻿using App3.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App3.ViewModels
{

    class HelloWorldViewModel
    {
        public Command HelloWorldCommand { get; }
        public HelloWorldViewModel()
        {
            HelloWorldCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(ResumePage)}");
        }
    }
}
