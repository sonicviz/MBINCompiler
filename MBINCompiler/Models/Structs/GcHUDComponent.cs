﻿using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcHUDComponent : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;

        public int PosX;
        public int PosY;
        public int Width;
        public int Height;
        public int Align;

        public string[] AlignValues()
        {
            return new string[] { "Center", "TopLeft", "TopRight", "BottomLeft", "BottomRight" };
        }

        public int Unknown24;
    }
}
