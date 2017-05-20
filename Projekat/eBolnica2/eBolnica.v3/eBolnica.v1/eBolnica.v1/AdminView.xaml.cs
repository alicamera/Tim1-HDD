﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace eBolnica.v1
{
    public sealed partial class AdminView : UserControl
    {
        public AdminView()
        {
            this.InitializeComponent();
            AdminFrame.Navigate(typeof(Registracija));

        }



        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            // AdminFrame.Navigate(typeof(PageMain1));
        }
        private void Login_Clicked(object sender, RoutedEventArgs e)
        {
            //  AdminFrame.Navigate(typeof(PageMainLogin1));
        }

        private void Button_Click_Pane(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.SplitView.IsPaneOpen = !this.SplitView.IsPaneOpen; //pane open or close
        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!this.SplitView.IsPaneOpen)
            {
                this.SplitView.IsPaneOpen = true;
            }
            else
            {
                this.SplitView.IsPaneOpen = false;
            }
        }

    }
}
