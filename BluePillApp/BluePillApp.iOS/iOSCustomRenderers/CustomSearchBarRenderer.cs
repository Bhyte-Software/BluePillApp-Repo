﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BluePillApp.CustomRenderers;
using BluePillApp.iOS.iOSCustomRenderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(CustomSearchBarRenderer))]
namespace BluePillApp.iOS.iOSCustomRenderers
{
    public class CustomSearchBarRenderer : SearchBarRenderer
    {
        #region Properties

        private UIColor BorderColor = UIColor.Black;
        private int BorderWidth = 1;

        #endregion

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.SearchBar> e)
        {
            base.OnElementChanged(e);

            var newElement = ((CustomSearchBar)e.NewElement);

            BorderColor = newElement.BorderColor.ToUIColor();

            if (newElement.BorderWidth != 0)
            {
                BorderWidth = newElement.BorderWidth;
            }

            var searchbar = (UISearchBar)Control;

            if (e.NewElement != null)
            {
                //Foundation.NSString _searchField = new Foundation.NSString("searchField");
                //var textFieldInsideSearchBar = (UITextField)searchbar.ValueForKey(_searchField);
                //textFieldInsideSearchBar.BackgroundColor = UIColor.FromRGB(0, 0, 12);
                //textFieldInsideSearchBar.TextColor = UIColor.White;
                // searchbar.Layer.BackgroundColor = UIColor.Blue.CGColor;
                //searchbar.TintColor = UIColor.White;
                //searchbar.BarTintColor = UIColor.White;
                searchbar.Layer.CornerRadius = 0;
                searchbar.Layer.BorderWidth = BorderWidth;
                searchbar.Layer.BorderColor = BorderColor.CGColor;

                searchbar.ShowsCancelButton = true;
            }
        }
    }
}