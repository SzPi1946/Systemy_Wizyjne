using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;

namespace Projekt_SW
{
    class Korekta
    {
        const float rad = (float)(Math.PI / 180.0f);
        const float lumR = 0.3086f;
        const float lumG = 0.6094f;
        const float lumB = 0.0820f;
        public enum MatrixOrder
        {
            MatrixOrderPrepend = 0,
            MatrixOrderAppend = 1
        };
        private float[][] m_pColorMatrix = new float[5][];
        public Korekta()
        {
            Reset();
        }

        public Korekta(float[][] pColorMatrix)
        {
            m_pColorMatrix = pColorMatrix;
        }

        public void Reset()
        {
            m_pColorMatrix[0] = new float[] { 1, 0, 0, 0, 0 };
            m_pColorMatrix[1] = new float[] { 0, 1, 0, 0, 0 };
            m_pColorMatrix[2] = new float[] { 0, 0, 1, 0, 0 };
            m_pColorMatrix[3] = new float[] { 0, 0, 0, 1, 0 };
            m_pColorMatrix[4] = new float[] { 0, 0, 0, 0, 1 };
        }

        private void Multiply(Korekta pColorMatrix, MatrixOrder order)
        {
            float[][] a;
            float[][] b;
	        if (order == MatrixOrder.MatrixOrderAppend)
	        {
		        a = pColorMatrix.m_pColorMatrix;
		        b = m_pColorMatrix;
	        }
	        else
	        {
		        a = m_pColorMatrix;
		        b = pColorMatrix.m_pColorMatrix;
	        }
            float[][] temp = new float[5][];
            for (int y = 0; y < 5 ; y++)
            {
                temp[y] = new float[4];
                for (int x = 0; x < 4; x++)
		        {
			        float t = 0;
			        for (int i = 0; i < 5; i++) t += b[y][i] * a[i][x];
                    temp[y][x] = t;
                }
            }
            string csTemp = "";
	        for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    m_pColorMatrix[y][x] = temp[y][x];
                    csTemp += m_pColorMatrix[y][x] + ", ";
                }
                csTemp += m_pColorMatrix[y][4] + "\n";
            }
        }
        private void Scale(float scaleRed, float scaleGreen,float scaleBlue, float scaleOpacity, MatrixOrder order)
        {
            Korekta m = new Korekta();
            m.m_pColorMatrix[0][0] = scaleRed;
            m.m_pColorMatrix[1][1] = scaleGreen;
            m.m_pColorMatrix[2][2] = scaleBlue;
            m.m_pColorMatrix[3][3] = scaleOpacity;
            Multiply(m, order);
        }
        private void Translate(float offsetRed, float offsetGreen,float offsetBlue, float offsetOpacity, MatrixOrder order)
        {
            Korekta m = new Korekta();
            m.m_pColorMatrix[4][0] = offsetRed;
            m.m_pColorMatrix[4][1] = offsetGreen;
            m.m_pColorMatrix[4][2] = offsetBlue;
            m.m_pColorMatrix[4][3] = offsetOpacity;
	        Multiply(m, order);
        }
        public void ScaleColors(float scale, MatrixOrder order)
        {
            Scale(scale, scale, scale, 1.0f, order);
        }
        public void TranslateColors(float offset, MatrixOrder order)
        {
            Translate(offset, offset, offset, 1.0f, order);
        }
        public void SetSaturation(float saturation, MatrixOrder order)
        {
            float satCompl = 1.0f - saturation;
            float satComplR = lumR * satCompl;
            float satComplG = lumG * satCompl;
            float satComplB = lumB * satCompl;
            Korekta m = new Korekta(new float[5][]
            {
                new float[] {satComplR + saturation,    satComplR,  satComplR,  0.0f, 0.0f},
                new float[] {satComplG, satComplG + saturation, satComplG,  0.0f, 0.0f},
                new float[] {satComplB, satComplB,  satComplB + saturation, 0.0f, 0.0f},
                new float[] {0.0f,  0.0f,   0.0f,   1.0f,   0.0f},
                new float[] {0.0f,  0.0f,   0.0f,   0.0f,   1.0f}
            }
            );
            Multiply(m, order);
        }
        public Bitmap Adjust(Bitmap pBitmap, float fGamma)
        {
            ColorMatrix matrix = new ColorMatrix(m_pColorMatrix);
            ImageAttributes imageAttr = new ImageAttributes();
            imageAttr.SetColorMatrix(matrix);
            imageAttr.SetGamma(fGamma);
            Rectangle destRect = new Rectangle(0, 0, pBitmap.Width, pBitmap.Height);
            Bitmap pAdjustedBitmap = new Bitmap(pBitmap.Width, pBitmap.Height);
            Graphics pGraphics = Graphics.FromImage(pAdjustedBitmap);
            pGraphics.DrawImage(pBitmap, destRect, 0, 0, pBitmap.Width, pBitmap.Height, GraphicsUnit.Pixel, imageAttr);
            pGraphics.Dispose();
            return pAdjustedBitmap;
        }
    }
}
