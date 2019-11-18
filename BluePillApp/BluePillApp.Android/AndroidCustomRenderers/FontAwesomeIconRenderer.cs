using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BluePillApp.CustomRenderers;
using BluePillApp.Droid.AndroidCustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FontAwesomeIcon), typeof(FontAwesomeIconRenderer))]
namespace BluePillApp.Droid.AndroidCustomRenderers
{
    [Obsolete]
    public class FontAwesomeIconRenderer : LabelRenderer
    {
        private readonly Context _context;

        public FontAwesomeIconRenderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Typeface = Typeface.CreateFromAsset(_context.Assets, FontAwesomeIcon.Typeface + ".ttf");
            }
        }
    }
}