using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace BluePillApp.CustomRenderers
{
    [DesignTimeVisible(true)]
    public class RoundedEditor : Editor
    {
        //Border Colour Custom Property
        public static readonly BindableProperty BorderColorProperty =
       BindableProperty.Create(
           nameof(BorderColor),
           typeof(Color),
           typeof(RoundedEditor),
           Color.Gray);

        // Gets or sets BorderColor value
        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        //Background Colour Custom Property
        public static readonly BindableProperty BackColorProperty =
       BindableProperty.Create(
           nameof(BackColor),
           typeof(Color),
           typeof(RoundedEditor),
           Color.Gray);

        // Gets or sets custom/new Background Colour
        public Color BackColor
        {
            get { return (Color)GetValue(BackColorProperty); }
            set { SetValue(BackColorProperty, value); }
        }


        //BorderWidth/Thickness Custom Property
        [Obsolete]
        public static readonly BindableProperty BorderWidthProperty =
        BindableProperty.Create(
            nameof(BorderWidth),
            typeof(int),
            typeof(RoundedEditor),
            Device.OnPlatform<int>(1, 2, 2));

        // Gets or sets BorderWidth/Thickness value
        [Obsolete]
        public int BorderWidth
        {
            get { return (int)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }

        //CornerRadius Custom Property
        [Obsolete]
        public static readonly BindableProperty CornerRadiusProperty =
        BindableProperty.Create(
            nameof(CornerRadius),
            typeof(double),
            typeof(RoundedEditor),
            Device.OnPlatform<double>(0, 0, 0));

        // Gets or sets CornerRadius value
        [Obsolete]
        public double CornerRadius
        {
            get { return (double)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }


        public static readonly BindableProperty IsCurvedCornersEnabledProperty =
        BindableProperty.Create(
            nameof(IsCurvedCornersEnabled),
            typeof(bool),
            typeof(RoundedEditor),
            true);

        // Gets or sets IsCurvedCornersEnabled value
        public bool IsCurvedCornersEnabled
        {
            get { return (bool)GetValue(IsCurvedCornersEnabledProperty); }
            set { SetValue(IsCurvedCornersEnabledProperty, value); }
        }


        public RoundedEditor()
        {
            TextChanged += OnTextChanged;
        }

        ~RoundedEditor()
        {
            TextChanged -= OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            InvalidateMeasure();
        }
    }
}
