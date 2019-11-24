using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using BluePillApp.CustomRenderers;
using BluePillApp.iOS.iOSCustomRenderers;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryRenderer))]
namespace BluePillApp.iOS.iOSCustomRenderers
{
    [DesignTimeVisible(true)]
    [Obsolete]
    public class RoundedEntryRenderer : EditorRenderer
    {
        NSObject _keyboardShowObserver;
        NSObject _keyboardHideObserver;
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var view = (RoundedEntry)Element;

                //Control.LeftView = new UIView(new CGRect(0f, 0f, 9f, 20f));
                //Control.LeftViewMode = UITextFieldViewMode.Always;

                Control.KeyboardAppearance = UIKeyboardAppearance.Dark;
                Control.ReturnKeyType = UIReturnKeyType.Done;

                Control.Layer.CornerRadius = Convert.ToSingle(view.CornerRadius);
                Control.Layer.BorderColor = view.BorderColor.ToCGColor();
                Control.Layer.BorderWidth = view.BorderWidth;
                Control.ClipsToBounds = true;

                RegisterForKeyboardNotifications();
            }

            if (e.OldElement != null)
            {
                UnregisterForKeyboardNotifications();
            }

            if (Control != null)
            {
                Control.ScrollEnabled = false;
            }

            //Sets maximum number of lines *Not too sure about this one*
            CGSize size = Control.Text.StringSize(Control.Font, Control.Frame.Size, UILineBreakMode.WordWrap);
            int numLines = (int)(size.Height / Control.Font.LineHeight);
            if (numLines >= 5)
            {
                Control.ScrollEnabled = true;
            }

            void RegisterForKeyboardNotifications()
            {
                if (_keyboardShowObserver == null)
                    _keyboardShowObserver = UIKeyboard.Notifications.ObserveWillShow(OnKeyboardShow);
                if (_keyboardHideObserver == null)
                    _keyboardHideObserver = UIKeyboard.Notifications.ObserveWillHide(OnKeyboardHide);
            }

            void OnKeyboardShow(object sender, UIKeyboardEventArgs args)
            {

                NSValue result = (NSValue)args.Notification.UserInfo.ObjectForKey(new NSString(UIKeyboard.FrameEndUserInfoKey));
                CGSize keyboardSize = result.RectangleFValue.Size;
                if (Element != null)
                {
                    Element.Margin = new Thickness(0, 0, 0, keyboardSize.Height); //push the entry up to keyboard height when keyboard is activated

                }
            }

            void OnKeyboardHide(object sender, UIKeyboardEventArgs args)
            {
                if (Element != null)
                {
                    Element.Margin = new Thickness(0); //set the margins to zero when keyboard is dismissed
                }

            }

            void UnregisterForKeyboardNotifications()
            {
                if (_keyboardShowObserver != null)
                {
                    _keyboardShowObserver.Dispose();
                    _keyboardShowObserver = null;
                }

                if (_keyboardHideObserver != null)
                {
                    _keyboardHideObserver.Dispose();
                    _keyboardHideObserver = null;
                }
            }
        }
    }
}