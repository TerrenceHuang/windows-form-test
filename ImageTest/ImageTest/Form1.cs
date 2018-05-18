using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTest {

    public partial class Form1 : System.Windows.Forms.Form {

        ScanEffectHandler scanEffectHandler;

        public Form1() {

            InitializeComponent();
            // put in the pictureBox's reference
            scanEffectHandler = new ScanEffectHandler(TestPictureBox);
        }

        async void ModifyColorButton_Click(object sender, EventArgs e) {
            
            string imgSource = @"D:\github\TerrenceHuang\windows-form-test\ImageTest\ImageTest\sharedPicture.png";

            using (FileStream fs = new FileStream(imgSource, FileMode.Open, FileAccess.Read)) {

                Image image = new Bitmap(fs);
                // use this method to change the image and scan
                await scanEffectHandler.ChangePicture(image);
            }
        }
    }
}
