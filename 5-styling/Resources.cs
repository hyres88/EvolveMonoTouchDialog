using System;
using MonoTouch.UIKit;

namespace styling
{
	public static class Resources
	{

		public static UIImage KickstarterIcon = UIImage.FromBundle("images/icons/kickstarter.png");
		public static UIImage ActivityIcon = UIImage.FromBundle("images/icons/activity.png");
		public static UIImage ProfileIcon = UIImage.FromBundle("images/icons/profile.png");

		public static UIImage NavBarBackground = UIImage.FromBundle("images/navbar.png");
		public static UIImage ProjectBackground = UIImage.FromBundle("images/projectbackground.png");

		public static UIImage ProgressImageGrey = UIImage.FromBundle("images/progress-background.png").CreateResizableImage(new UIEdgeInsets(0,4,0,4));
		public static UIImage ProgressImageGreen = UIImage.FromBundle("images/progress-foreground.png").CreateResizableImage(new UIEdgeInsets(0,4,0,4));

		public static UIImage KickstarterLogo = UIImage.FromBundle("images/logo.png");

	}

	public static class Colors
	{
		public static UIColor ProjectBackgroundGrey = "e5e8e3".ToUIColor();
	}
}
