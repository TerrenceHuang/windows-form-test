using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTest {

    class ScanEffectHandler {
        
        
        PictureBox pictureBox;
        Label scanLine;
        bool locker;

        public ScanEffectHandler(PictureBox pictureBox) {
            
            this.pictureBox = pictureBox;
            locker = false;

            scanLine = new Label();
            scanLine.BackColor = Color.Red;
            scanLine.Width = pictureBox.Width;
            scanLine.Height = 5;
            scanLine.Visible = false;
            pictureBox.Controls.Add(scanLine);
        }

        public async Task<bool> ChangePicture(Image image) {

            if (locker) {

                return false;
            }else {

                locker = true;
                scanLine.Visible = true;
            }

            Bitmap origanBitmap = pictureBox.Image as Bitmap;
            Bitmap newBitmap = image as Bitmap;

            int pictureBoxHeight = pictureBox.Height;

            // change picture
            for (int y = 0; y < origanBitmap.Height; y++) {

                // change line of picture
                for (int x = 0; x < origanBitmap.Width; x++) {

                    origanBitmap.SetPixel(x, y, newBitmap.GetPixel(x, y));
                }

                // update the pictureBox and line
                if (y % 5 == 0) {

                    scanLine.Location = new Point(0, pictureBoxHeight * y / origanBitmap.Height);
                    pictureBox.Image = origanBitmap;
                    await Task.Delay(1);
                }
            }

            locker = false;
            scanLine.Visible = false;
            return true;
        }
    }
}
