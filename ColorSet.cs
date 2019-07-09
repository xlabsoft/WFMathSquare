using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFMathSquare
{
    class ColorSet
    {
        private static readonly Color GREEN_BAY_PACKERS_GOLD = Color.FromArgb(240, 184, 1); //#F0B801;
        private static readonly Color GREEN_BAY_PACKERS_GREEN = Color.FromArgb(14, 56, 46); //#0E382E;

        public Color NONE;
        public Color INACTIVE;
        public Color NEGATIVE;
        public Color POSITIVE;

        public ColorSet()
        {
            NONE = Color.LightGray;
            INACTIVE = Color.Coral;
            NEGATIVE = Color.Red;
            POSITIVE = Color.Aqua;
        }

        public ColorSet(int presetNumber)
        {
            if (presetNumber == 1) setPreset1();
            else setPreset2();
        }

        //enum NewColor
        //{
        //    NONE, // GRAY
        //    INACTIVE_NEGATIVE, //= Color.Red,
        //    INACTIVE_POSITIVE, //BLUE
        //    NEGATIVE, //CORAL
        //    POSITIVE  //AQUA
        //}
        //private Color getColor(NewColor colNum)
        //{
        //    switch (colNum)
        //    {
        //        case (NewColor.NONE): { return Color.White; }
        //        default: { return Color.White; }
        //    }
        //    return Color.White;
        //}

        public void setPreset1 ()
        {
            // D6D5B7 R 214 G 213 B 183
            // D1BA74 R 209 G 186 B 116
            // E6CEAC R 230 G 206 B 172
            // ECAD9E R 236 G 173 B 158
            // F4606C R 244 G 96  B 108
            NONE = Color.FromArgb(214, 213, 183);
            INACTIVE = Color.FromArgb(236, 173, 158);
            NEGATIVE = Color.FromArgb(244, 96, 108);
            POSITIVE = Color.FromArgb(209, 186, 116);
        }

        public void setPreset2 ()
        {
            // 19CAAD R 25  G 202 B 173
            // 8CC7B5 R 140 G 199 B 181
            // A0EEE1 R 160 G 238 B 225
            // BEE7E9 R 190 G 231 B 233
            // BEEDC7 R 190 G 237 B 199
            NONE = Color.FromArgb(160, 238, 225);
            INACTIVE = Color.FromArgb(190, 231, 233);
            NEGATIVE = Color.FromArgb(140, 199, 181);
            POSITIVE = Color.FromArgb(190, 237, 199);
        }
    }
}
