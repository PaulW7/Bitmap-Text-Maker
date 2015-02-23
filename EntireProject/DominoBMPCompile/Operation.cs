using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using System.Resources;
namespace DominoBMPCompile
{
    class Operation
    {
        private Data data = new Data();
        private Image image;

        /// <summary>
        /// Returns list of image objects by text name
        /// </summary>
        public List<string> imageTextList
        {
            get
            {
                //set var for combobox datasource
                List<string> list = new List<string>();

                List<Image> images = data.getAllImageObjects();

                int index = 0;
                while (index < images.Count)
                {
                    list.Add(images[index].textToRender);
                    index++;
                }

                return list;
            }
        }

        public Bitmap getBitMapImage(Image myImage)
        {
            //X Position is set at a margin the "-70" will give a zero reference
            //The Y position is adjusted with o reference in the north border transpose to negetive to start at the south
            PointF location = new PointF(myImage.xPosition - 90, myImage.yPosition + 295);



            Bitmap myBitMap = new Bitmap(@"App_Ref\templateNEW.bmp");
            using (Graphics graphics = Graphics.FromImage(myBitMap))
            {
                //cHECK FOR CUSTOM FONT
                if (String.Compare(myImage.fontName, "Your Font") == 0)
                {
                    try
                    {
                        PrivateFontCollection myCollection = new PrivateFontCollection();
                        myCollection.AddFontFile(@"App_Ref\your_font.ttf");
                        using (Font font = new Font(myCollection.Families[0], myImage.fontSize,FontStyle.Bold | FontStyle.Italic))
                        {
                            graphics.RotateTransform(myImage.angleOfText);
                            graphics.DrawString(myImage.textToRender, font, Brushes.Black, location);

                        }
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.StackTrace);
                    }

                }
                else
                {
                    using (Font font = new Font(myImage.fontName, myImage.fontSize))
                    {
                        graphics.RotateTransform(myImage.angleOfText);
                        graphics.DrawString(myImage.textToRender, font, Brushes.Black, location);

                    }
                }
            }
            return myBitMap;
        }

        public void addNewImage(Image image)
        {
            data.insertNewImage(image);
        }

        public void updateExistingImage(Image image)
        {
            data.updateImage(image);
        }

        public Image getImage(String imageText)
        {
            return data.GetcurrentImageData(imageText);
        }

        public void removeImage(Image imageToRemove)
        {
            data.deleteImage(imageToRemove);
        }
    }
}
