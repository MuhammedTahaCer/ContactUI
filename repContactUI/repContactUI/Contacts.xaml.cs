
using System;
using System.Collections.Generic;
using ContactsMessageUI.ViewModels;
using Xamarin.Forms;

namespace repContactUI
{
    public partial class Contacts : ContentPage
    {
        public Contacts()
        {
            InitializeComponent();
            BindingContext = new ContactsViewModel();
        }   

    }
}