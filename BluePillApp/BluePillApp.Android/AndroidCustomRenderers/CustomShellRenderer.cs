using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using BluePillApp.Droid.AndroidCustomRenderers;
using BluePillApp.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Support.Design.BottomNavigation;

[assembly: ExportRenderer(typeof(DropshadowShell), typeof(CustomShellRenderer))]
namespace BluePillApp.Droid.AndroidCustomRenderers
{
    public class CustomShellRenderer : ShellRenderer
    {
        public CustomShellRenderer(Context context) : base(context)
        {
        }

        protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
        {
            return new CustomBottomNavView();
        }
    }

    public class CustomBottomNavView : IShellBottomNavViewAppearanceTracker
    {
        public void Dispose()
        {

        }

        public void ResetAppearance(BottomNavigationView bottomView)
        {

        }

        public void SetAppearance(BottomNavigationView bottomView, ShellAppearance appearance)
        {
            bottomView.SetBackgroundColor(Android.Graphics.Color.White);
            bottomView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityUnlabeled;
        }
    }
}