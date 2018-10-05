using System;
using ObjCRuntime;

namespace RM
{
    [Flags]
    [Native]
    public enum XXXIconType : ulong
    {
        Plus = 0x0,
        UserDraw,
        CustomImage
    }
}
