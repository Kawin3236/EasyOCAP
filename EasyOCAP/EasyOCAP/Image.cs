using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyOCAP
{
    public class Image
    {
        private String imgNull = "C:\\Test555\\picNull.png";
        private String imgKicker = "C:\\Test555\\picKicker.jpg";
        private String imgTray = "C:\\test555\\pic_check_tray.jpg";

       public String GetImgNull()
        {
            return this.imgNull;
        }
        public String GetImgKicker()
        {
            return this.imgKicker;
        }

        public void ShowImgCase(ComboBox errorCase, PictureBox picBox, Label label)
        {
            String img = "";
            if (errorCase.Text.Equals("Null"))
            {
                img = this.imgNull;
                label.Visible = false;
            }
            else if (errorCase.Text.Equals("Kicker"))
                img = this.imgKicker;
            else if (errorCase.Text.Equals("Can't Open Tray"))
            {
                img = this.imgTray;
                label.Visible = true;
            }
            Bitmap bitmap = new Bitmap(img, false);
            picBox.Image = bitmap;

            
        }

    }
}
