using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BluePillApp.CustomRenderers;
using BluePillApp.Droid.AndroidCustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(CustomSearchBarRenderer))]
namespace BluePillApp.Droid.AndroidCustomRenderers
{
    [Obsolete]
    public class CustomSearchBarRenderer : SearchBarRenderer
    {
        #region Properties

        private Android.Graphics.Color BorderColor = Android.Graphics.Color.Transparent;

        private int BorderWidth = 1;

        #endregion

        #region Constructor

        public CustomSearchBarRenderer() : base() { }

        public CustomSearchBarRenderer(Context context) : base(context) { }

        public CustomSearchBarRenderer(IntPtr a, JniHandleOwnership b) : base() { }

        #endregion

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                LinearLayout linearLayout = this.Control.GetChildAt(0) as LinearLayout;
                linearLayout = linearLayout.GetChildAt(2) as LinearLayout;
                linearLayout = linearLayout.GetChildAt(1) as LinearLayout;

                linearLayout.Background = null; //removes underline

                AutoCompleteTextView textView = linearLayout.GetChildAt(0) as AutoCompleteTextView; //modify for text appearance customization
            }

            var searchView = base.Control as SearchView;
            int searchIconId = Context.Resources.GetIdentifier("android:id/search_mag_icon", null, null);
            ImageView searchViewIcon = (ImageView)searchView.FindViewById<ImageView>(searchIconId);
            //searchViewIcon.SetImageDrawable(null);
        }

        
    }
}