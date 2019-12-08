using System;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using CoreGraphics;
using CustomNavigation;
using CustomNavigation.Views;
using CustomNavigation.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CustomNavigation.iOS.Renderers;

[assembly: ExportRenderer(typeof(CustomNavigationPage), typeof(CustomNavigationRenderer))]
namespace CustomNavigation.iOS.Renderers
{
    public class CustomNavigationRenderer : NavigationRenderer
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
                OverrideUserInterfaceStyle = UIUserInterfaceStyle.Light;

            UINavigationBar.Appearance.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
            UINavigationBar.Appearance.ShadowImage = new UIImage();
            UINavigationBar.Appearance.BackgroundColor = UIColor.Clear;
            UINavigationBar.Appearance.TintColor = UIColor.White;
            UINavigationBar.Appearance.BarTintColor = UIColor.Clear;
            UINavigationBar.Appearance.Translucent = true;
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
                OverrideUserInterfaceStyle = UIUserInterfaceStyle.Light;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }

            base.Dispose(disposing);
        }

        protected override Task<bool> OnPushAsync(Page page, bool animated)
        {
            var retVal = base.OnPushAsync(page, animated);

            SetBackButtonOnPage(page);

            return retVal;
        }

        protected override Task<bool> OnPopViewAsync(Page page, bool animated)
        {
            var retVal = base.OnPopViewAsync(page, animated);
            var stack = page.Navigation.NavigationStack;
            var returnPage = stack[stack.Count - 2];

            if (returnPage != null)
            {
                SetBackButtonOnPage(returnPage);
            }

            return retVal;
        }


        void SetBackButtonOnPage(Page page)
        {
            // Below is what I added for common usage.
            if (page.GetType() == typeof(MainPage))
            {
                SetDefaultBackButton();
            }
            else
            {
                SetImageTitleBackButton("backbutton", "", 0);
            }
        }

        void SetImageTitleBackButton(string imageBundleName, string buttonTitle, int horizontalOffset)
        {
            var backButtonImage = new UIBarButtonItem(
                    UIImage.FromBundle(imageBundleName),
                    UIBarButtonItemStyle.Plain,
                    (sender, args) =>
                    {
                        this.TopViewController.NavigationController.PopViewController(true);
                    });
            backButtonImage.TintColor = UIColor.Black;
            this.TopViewController.NavigationItem.LeftBarButtonItem = backButtonImage;
        }

        void SetDefaultBackButton()
        {
            this.TopViewController.NavigationItem.LeftBarButtonItems = null;
        }
    }
}
