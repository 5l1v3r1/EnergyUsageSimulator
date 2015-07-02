using System.Drawing;
using System.Windows.Forms;

namespace EnergyUsageSimulator.Controls
{
    internal class VerticalSeperator : Label
    {
        public override bool AutoSize
        {
            get
            {
                return false;
            }
        }

        public override Size MaximumSize
        {
            get
            {
                return new Size(2, int.MaxValue);
            }
        }

        public override Size MinimumSize
        {
            get
            {
                return new Size(2, 1);
            }
        }

        public override string Text
        {
            get
            {
                return "";
            }
        }

        public VerticalSeperator()
        {
            this.AutoSize = false;
            this.Height = 2;
            this.BorderStyle = BorderStyle.Fixed3D;
        }
    }

    internal class HorizontalSeperator : Label
    {
        public override bool AutoSize
        {
            get
            {
                return false;
            }
        }

        public override Size MaximumSize
        {
            get
            {
                return new Size(int.MaxValue, 2);
            }
        }

        public override Size MinimumSize
        {
            get
            {
                return new Size(1, 2);
            }
        }

        public override string Text
        {
            get
            {
                return "";
            }
        }

        public HorizontalSeperator()
        {
            this.AutoSize = false;
            this.Height = 2;
            this.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}