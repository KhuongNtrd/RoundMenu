using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace RM
{
    // @interface XXXRoundMenuButton : UIControl
    [BaseType(typeof(UIControl))]
    [Protocol]
    interface XXXRoundMenuButton
    {
        // @property (assign, nonatomic) CGSize centerButtonSize;
        [Export("centerButtonSize", ArgumentSemantic.Assign)]
        CGSize CenterButtonSize { get; set; }

        // @property (assign, nonatomic) XXXIconType centerIconType;
        [Export("centerIconType", ArgumentSemantic.Assign)]
        XXXIconType CenterIconType { get; set; }

        // @property (nonatomic, strong) UIImage * centerIcon;
        [Export("centerIcon", ArgumentSemantic.Strong)]
        UIImage CenterIcon { get; set; }

        // @property (assign, nonatomic) BOOL jumpOutButtonOnebyOne;
        [Export("jumpOutButtonOnebyOne")]
        bool JumpOutButtonOnebyOne { get; set; }

        // @property (nonatomic, strong) UIColor * mainColor;
        [Export("mainColor", ArgumentSemantic.Strong)]
        UIColor MainColor { get; set; }

        // -(void)loadButtonWithIcons:(NSArray<UIImage *> *)icons startDegree:(float)degree layoutDegree:(float)layoutDegree;
        [Export("loadButtonWithIcons:startDegree:layoutDegree:")]
        void LoadButtonWithIcons(UIImage[] icons, float degree, float layoutDegree);

        // @property (nonatomic, strong) void (^buttonClickBlock)(NSInteger);
        [Export("buttonClickBlock", ArgumentSemantic.Strong)]
        Action<nint> ButtonClickBlock { get; set; }

        // @property (nonatomic, strong) void (^drawCenterButtonIconBlock)(CGRect, UIControlState);
        [Export("drawCenterButtonIconBlock", ArgumentSemantic.Strong)]
        Action<CGRect, UIControlState> DrawCenterButtonIconBlock { get; set; }

        // @property (assign, nonatomic) BOOL isOpened;
        [Export("isOpened")]
        bool IsOpened { get; set; }

        // @property (assign, nonatomic) CGSize offsetAfterOpened;
        [Export("offsetAfterOpened", ArgumentSemantic.Assign)]
        CGSize OffsetAfterOpened { get; set; }

        // @property (assign, nonatomic) CGFloat raduisForIcons;
        [Export("raduisForIcons")]
        nfloat RaduisForIcons { get; set; }
    }

}
