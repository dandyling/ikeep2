// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ikeep2
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint BlueLineHeight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint platformTop { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint sign { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SignInButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint SignInHeight { get; set; }

        [Action ("DoSignIn:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DoSignIn (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BlueLineHeight != null) {
                BlueLineHeight.Dispose ();
                BlueLineHeight = null;
            }

            if (platformTop != null) {
                platformTop.Dispose ();
                platformTop = null;
            }

            if (sign != null) {
                sign.Dispose ();
                sign = null;
            }

            if (SignInButton != null) {
                SignInButton.Dispose ();
                SignInButton = null;
            }

            if (SignInHeight != null) {
                SignInHeight.Dispose ();
                SignInHeight = null;
            }
        }
    }
}