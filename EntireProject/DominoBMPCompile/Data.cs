using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DominoBMPCompile
{
    class Data
    {
        //declare for use - Destroy when done to free memory
        private FileStream fStream = null;
        private StreamReader sReader = null;
        private StreamWriter sWriter = null;

        //Set for use
        private Image currentImageData;
        private List<String> textRenderStrings = new List<string>();
        private List<Image> allImageObjects;

        //Set defaults for use and starting App
        private String tempFile = @"c:\BitmapMaker\Data\dataTemp.txt";
        private string defaultData = "Default;28;-194;Arial Black;110;-10;ImagesSaved/;Default Comments...";
        public static string imagesFolder = @"c:\BitmapMaker\Images";
        private string dataFolder = @"c:\BitmapMaker\Data";
        private string data_path = @"c:\BitmapMaker\Data\SavedDomino.txt";


        /// <summary>
        /// Constructor initializes defaukt data by method of setAllImageObjects.
        /// </summary>
        public Data()
        {
            createFolders();
            setAllImageObjects();
        }

        private void createFolders()
        {
            Directory.CreateDirectory(imagesFolder);
            Directory.CreateDirectory(dataFolder);

        }

        /// <summary>
        /// All data will be returned
        /// </summary>
        /// <returns>
        /// Data from the data store is returned
        /// </returns>
        public List<Image> getAllImageObjects()
        {
            return allImageObjects;
        }

        /// <summary>
        /// Loads objects from the data store to allImageObjects
        /// </summary>
        /// <remarks>
        /// Loads data available as a master or creates default data and a file for storage.
        /// </remarks>
        private void setAllImageObjects()
        {
            try
            {
                allImageObjects = new List<Image>();
                if (File.Exists(data_path))
                {
                    using (fStream = new FileStream(data_path, FileMode.Open))
                    {
                        using (sReader = new StreamReader(fStream))
                        {
                            string currentLine = string.Empty;
                            while ((currentLine = sReader.ReadLine()) != null)
                            {
                                String[] imageObjectString = currentLine.Split(';');
                                allImageObjects.Add(new Image(imageObjectString[0], float.Parse(imageObjectString[1]), float.Parse(imageObjectString[2]),
                                                    imageObjectString[3], Convert.ToInt16(imageObjectString[4]), Convert.ToInt16(imageObjectString[5]),
                                                    imageObjectString[6], imageObjectString[7]));
                            }
                        }
                    }
                }
                else
                {
                    using (fStream = new FileStream(data_path, FileMode.OpenOrCreate))
                    {
                        using (sWriter = new StreamWriter(fStream))
                        {
                            sWriter.WriteLine(defaultData);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR! " + e.Message);
            }

        }

        /// <summary>
        /// Used to get Image object based on the text used for the image.
        /// </summary>
        /// <param name="textEntered">Searches for a match to the string supplied</param>
        /// <returns>Returns Image object match or default data if not found.</returns>
        public Image GetcurrentImageData(string textEntered)
        {
            //set default if not found
            currentImageData = new Image("NOT FOUND", 0, 0, "NONE", 0, 0, "NO PATH FOUND ERROR!",
                                                                "There was an error returning your data!");
            int count = 0;
            bool found = false;
            while (found == false)
            {
                if (String.Compare(textEntered, allImageObjects[count].textToRender) == 0)
                {
                    currentImageData = allImageObjects[count];
                    found = true;
                }
                count++;
            }
            return currentImageData;
        }

        /// <summary>
        /// Inserts the new image into the data store.
        /// </summary>
        /// <param name="newImage">Image object supplied to enter as new.</param>
        public void insertNewImage(Image newImage)
        {
            try
            {
                using (fStream = new FileStream(data_path, FileMode.Append))
                {
                    using (sWriter = new StreamWriter(fStream))
                    {
                        sWriter.WriteLine(newImage.textToRender + ";" + newImage.xPosition.ToString() + ";" + newImage.yPosition.ToString() + ";" + newImage.fontName + ";"
                                       + newImage.fontSize.ToString() + ";" + newImage.angleOfText.ToString() + ";" + newImage.saveLocation + ";" + newImage.comments);
                    }
                }
                //Update List
                allImageObjects.Add(newImage);
            }
            catch (Exception e)
            {
                string message = e.Message;
                MessageBox.Show("ERROR! " + e.Message);
            }
        }

        /// <summary>
        /// Updates a current image object with new data then calls updateDataStore
        /// </summary>
        /// <param name="image">Image to update - the text is used as the parameter to locate existing image.</param>
        public void updateImage(Image image)
        {
            string newText = string.Empty;
            string currentLine = string.Empty;

            try
            {
                //replace object
                int count = 0;
                bool found = false;
                while (found == false)
                {
                    if (String.Compare(image.textToRender, allImageObjects[count].textToRender) == 0)
                    {
                        allImageObjects.RemoveAt(count);
                        allImageObjects.Add(image);
                        found = true;
                    }
                    count++;
                }

                //update data with new
                updateDataStore();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR! " + e.Message);
            }
        }

        /// <summary>
        /// Deletes an image
        /// </summary>
        /// <param name="image">
        /// Image object to delete
        /// </param>
        public void deleteImage(Image image)
        {
            {

                string newText = string.Empty;
                string currentLine = string.Empty;

                try
                {
                    int count = 0;
                    bool found = false;
                    while (found == false)
                    {
                        if (String.Compare(image.textToRender, allImageObjects[count].textToRender) == 0)
                        {
                            //remove specific image
                            allImageObjects.RemoveAt(count);
                            File.Delete(image.saveLocation + image.textToRender + ".bmp");
                            updateDataStore();
                            found = true;
                        }
                        count++;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR! " + e.Message);
                }
            }

        }

        /// <summary>
        /// Creates a backup copy of the data store then overwrites with the new data in AllImageObjects
        /// </summary>
        private void updateDataStore()
        {
            try
            {
                //create a backup
                File.Copy(data_path, tempFile, true);

                //Overwrite existing file
                using (fStream = new FileStream(data_path, FileMode.Truncate))
                {
                    using (sWriter = new StreamWriter(fStream))
                    {
                        int inc = 0;
                        while (inc < allImageObjects.Count)
                        {
                            sWriter.WriteLine(allImageObjects[inc].textToRender + ";" + allImageObjects[inc].xPosition.ToString() + ";" + allImageObjects[inc].yPosition.ToString() + ";" + allImageObjects[inc].fontName + ";"
                                               + allImageObjects[inc].fontSize.ToString() + ";" + allImageObjects[inc].angleOfText.ToString() + ";" + allImageObjects[inc].saveLocation + ";" + allImageObjects[inc].comments);
                            inc++;
                        }

                    }
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("ERROR! " + e.Message);
            }
        }
    }
}
