using System;

using UIKit;

namespace ikeep2
{
	public partial class ViewController : UIViewController
	{
		partial void DoSignIn(UIButton sender)
		{
			UIView.BeginAnimations("platformAnimation");
			UIView.SetAnimationDuration(0.5);
			platformTop.Constant = -1 + SignInHeight.Constant * 2 + BlueLineHeight.Constant * 3 + 2;
			View.LayoutIfNeeded();
			UIView.CommitAnimations();

			//throw new NotImplementedException();
		}

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

