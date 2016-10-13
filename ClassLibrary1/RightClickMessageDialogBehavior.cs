﻿using Microsoft.Xaml.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RestaurantManager.Extensions
{
    public class RightClickMessageDialogBehavior : DependencyObject, IBehavior
    {
        public DependencyObject AssociatedObject { get; private set; }
        public string Message { get; set; }
        public string Title { get; set; }

        public void Attach(DependencyObject associatedObject)
        {
            if (associatedObject is Page)
            {
                this.AssociatedObject = associatedObject;
                (this.AssociatedObject as Page).RightTapped += MainPage_RightTapped;
            }
        }

        public void Detach()
        {
            if (this.AssociatedObject != null && this.AssociatedObject is Page)
            {
                (this.AssociatedObject as Page).RightTapped -= MainPage_RightTapped;
                this.AssociatedObject = null;
            }
        }

        private async void MainPage_RightTapped(object sender, RoutedEventArgs e)
        {
            await new MessageDialog(Message, Title).ShowAsync();
        }
    }


}
