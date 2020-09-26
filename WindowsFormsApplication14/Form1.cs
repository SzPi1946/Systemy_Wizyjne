using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Projekt_SW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private byte AdjustBrightness(int iIn, int iChange)
        {
            int iOut = iIn + iChange;
            if (iOut < 0) iOut = 0;
            if (iOut > 255) iOut = 255;
            return (byte)iOut;
        }

        private byte AdjustContrast(int iIn, double fContrast)
        {
            double pixel = iIn / 255.0;
            pixel -= 0.5;
            pixel *= fContrast;
            pixel += 0.5;
            pixel *= 255;
            if (pixel < 0) pixel = 0;
            if (pixel > 255) pixel = 255;
            return (byte)pixel;
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {

            TrackBarBrightness.Value = 0;
            TrackBarContrast.Value = 20;
            TrackBarSaturation.Value = 20;
            TrackBarGamma.Value = 20;
            pictureBox.Image = global::Projekt_SW.Properties.Resources.untitled;
        }


        private void TrackBar3_ValueChanged(object sender, EventArgs e)
        {
            Korekta Korekta = new Korekta();
            Korekta.ScaleColors(TrackBarContrast.Value * 0.05f, Korekta.MatrixOrder.MatrixOrderPrepend);
            Korekta.TranslateColors(TrackBarBrightness.Value * 0.05f, Korekta.MatrixOrder.MatrixOrderAppend);
            Korekta.SetSaturation(TrackBarSaturation.Value * 0.05f, Korekta.MatrixOrder.MatrixOrderAppend);

            Bitmap pSource = global::Projekt_SW.Properties.Resources.untitled;
            pictureBox.Image = Korekta.Adjust(pSource, TrackBarGamma.Value * 0.05f);
        }


        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
