using System;
using CoreGraphics;
using UIKit;
using RM;

namespace RoundMenu
{
    public partial class ViewController : UIViewController
    {
        XXXRoundMenuButton button;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            button = new XXXRoundMenuButton();

            button.CenterButtonSize = new CGSize(44, 44);
            button.CenterIconType = XXXIconType.UserDraw;
            button.TintColor = UIColor.White;
            button.JumpOutButtonOnebyOne = true;
            button.DrawCenterButtonIconBlock = (rect, state) => { 
            
                if(state == UIControlState.Normal){
                    var rectanglePath = UIBezierPath.FromRect(new CGRect((rect.Size.Width - 15) / 2, rect.Size.Height / 2 - 5, 15, 1));
                    UIColor.White.SetFill();
                    rectanglePath.Fill();

                    var rectangle2Path = UIBezierPath.FromRect(new CGRect((rect.Size.Width - 15) / 2, rect.Size.Height / 2, 15, 1));
                    UIColor.White.SetFill();
                    rectangle2Path.Fill();

                    var rectangle3Path = UIBezierPath.FromRect(new CGRect((rect.Size.Width - 15) / 2, rect.Size.Height / 2 + 5, 15, 1));
                    UIColor.White.SetFill();
                    rectangle3Path.Fill();
                }
            
            };


            button.LoadButtonWithIcons(new UIImage[] {
                UIImage.FromBundle("IconCan"),
                UIImage.FromBundle("IconPos"),
                UIImage.FromBundle("IconImg"),
                UIImage.FromBundle("IconCan"),
                UIImage.FromBundle("IconPos"),
                UIImage.FromBundle("IconImg"),
                UIImage.FromBundle("IconCan"),
                UIImage.FromBundle("IconPos"),
                UIImage.FromBundle("IconImg")
            }, 0, (float)Math.PI * 2 * 7 / 8);

            button.ButtonClickBlock = (i) => { 
            
            };

            button.Frame = new CGRect(View.Frame.Size.Width / 2 - 100, View.Frame.Size.Height / 2 - 100, 200, 200);
            //button.Center = new CGPoint(View.Frame.Width / 2, View.Frame.Height / 2);

            View.AddSubview(button);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
