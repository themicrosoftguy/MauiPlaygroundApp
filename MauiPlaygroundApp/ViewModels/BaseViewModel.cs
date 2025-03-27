﻿using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiPlaygroundApp.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
        private bool isBusy = false;

        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        private string title = string.Empty;

        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
    }
}
