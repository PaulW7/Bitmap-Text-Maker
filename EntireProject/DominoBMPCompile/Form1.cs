using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace DominoBMPCompile
{
    public partial class mainForm : Form
    {  
        //defaults for validating changes
        float defaultXPosition = 29;
        float defaultYPosition = -191;
        String defaultFontName = "Arial Black";
        int defaultFontSize = 107;
        int defaultAngleOfText = -10;


        //initial value for validation
        private bool controlsSet = true;

        //password
        string myPassword = "domino";
        bool passwordCorrect = false;

        //Shared Objects
        private Image myImage;
        private Operation operation = new Operation();
        
        //var to save image for use
        private Bitmap bitMapImage;

        private String saveLocation = string.Empty;
        private bool submitRequired = true;

        //default
        private int controlResolutionCoarse = 5;
        private int controlResolutionFine = 1;

        public mainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form loads and initializes combobox in display using populateComboBox
        /// </summary>
        private void mainForm_Load(object sender, EventArgs e)
        {
            populateComboBoxList();

        }

        /// <summary>
        /// populates UI combobox with current values
        /// </summary>
        private void populateComboBoxList()
        {
            try
            {
                //Get updated list
                imageObjectsComboBox.DataSource = operation.imageTextList;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR! " + e.Message);
            }
        }

        /// <summary>
        /// Sets controls to visible by calling makeControlsVisible
        /// </summary>
        private void textBoxTextToRender_TextChanged(object sender, EventArgs e)
        {
            makeControlsVisible();
            submitRequired = true;
            deleteButton.Visible = false;
        }

        /// <summary>
        /// Sets UI controls propertyto visible = true
        /// </summary>
        private void makeControlsVisible()
        {
            buttonMoveDown.Visible = true;
            buttonMoveLeft.Visible = true;
            buttonMoveRight.Visible = true;
            buttonMoveUp.Visible = true;
            panelPosition.Visible = true;
            labelXPos.Visible = true;
            labelYPos.Visible = true;
            textBoxXPosition.Visible = true;
            textBoxYPosition.Visible = true;
            angleTextBox.Visible = true;
            angleDownButton.Visible = true;
            angleUpButton.Visible = true;
            submitButton.Visible = true;
        }

        /// <summary>
        /// Clears error format on ui controls restoring them to normal
        /// </summary>
        private void ClearErrorsOnControls()
        {
            textBoxTextToRender.BackColor = Color.White;
            textBoxYPosition.BackColor = Color.White;
            textBoxXPosition.BackColor = Color.White;
            textBoxFontSize.BackColor = Color.White;
            controlsSet = true;
        }

        /// <summary>
        /// Sets flag for button press to true for save operation
        /// Creates a new image object using updateImage
        /// Calls render image to update UI display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            submitRequired = false;
            updateImage();

            //main method to display image
            renderImage();
        }

        /// <summary>
        /// Builds new image object from UI
        /// </summary>
        private void updateImage()
        {
            //Object of the main image to render - Constructor accepts all required attributes of the image
            myImage = new Image(textBoxTextToRender.Text, float.Parse(textBoxXPosition.Text), float.Parse(textBoxYPosition.Text),
                                        comboBoxFontType.SelectedItem.ToString(), Convert.ToInt16(textBoxFontSize.Text), Convert.ToInt16(angleTextBox.Text),
                                        Data.imagesFolder, CommentsTextBox.Text);
        }

        /// <summary>
        /// Main method to update image on UI for display.
        /// </summary>
        private void renderImage()
        {
                pictureBoxPreview.Image = operation.getBitMapImage(myImage);

                //set vars for saving
                bitMapImage = operation.getBitMapImage(myImage);

                //Show option to save
                saveImageButton.Visible = true;

                //update UI controls
                updateUIControls();
        }

        /// <summary>
        /// Updates all UI controls with current image data using myImage
        /// </summary>
        private void updateUIControls()
        {
            textBoxYPosition.Text = myImage.yPosition.ToString();
            textBoxXPosition.Text = myImage.xPosition.ToString();
            angleTextBox.Text = myImage.angleOfText.ToString();
            textBoxFontSize.Text = myImage.fontSize.ToString();
            CommentsTextBox.Text = myImage.comments;
            comboBoxFontType.SelectedIndex = comboBoxFontType.FindStringExact(myImage.fontName);
            textBoxTextToRender.Text = myImage.textToRender;
            Data.imagesFolder = myImage.saveLocation;

            string currentFileText = myImage.saveLocation + myImage.textToRender + ".bmp";
            if (File.Exists(currentFileText))
            {
                deleteButton.Visible = true;
            }
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            myImage.xPosition += currentResolution();
            renderImage();

        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            myImage.xPosition -= currentResolution();
            renderImage();
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            myImage.yPosition -= currentResolution();
            renderImage();
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            myImage.yPosition += currentResolution();
            renderImage();
        }

        private void processSaveImage()
        {
            try
            {
                bool saveOperationAborted = false;
                bool imageUpdated = false;
                string saveLocationText = myImage.saveLocation + myImage.textToRender + ".bmp";

                if (!submitRequired)
                {
                    submitRequired = true;

                    if (File.Exists(saveLocationText))
                    {

                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult dr = MessageBox.Show("The image already exists are you sure you would like to overwrite it?", "File Exists!", buttons);
                        if (dr == DialogResult.OK)
                        {
                            operation.updateExistingImage(myImage);
                            imageUpdated = true;

                        }
                        else
                        {
                            saveOperationAborted = true;
                        }
                    }
                    if (!saveOperationAborted)
                    {
                        bitMapImage.Save(saveLocationText);
                        if (!imageUpdated)
                        {
                            operation.addNewImage(myImage);
                        }

                        MessageBox.Show("The image has been saved as " + saveLocationText);

                        populateComboBoxList();
                    }
                }
                else
                {
                    MessageBox.Show("The new text was not written please click SUBMIT and try again");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex.Message);
            }
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            if (imageIsDefault())
            {
                processSaveImage();
            }
             //Image changed from default
            else
            {
                MessageBox.Show("Dfault settings have been changed. Submit the password to save.");
                passwordTextBox.UseSystemPasswordChar = true;
                passwordTextBox.Visible = true;
                passwordLabel.Visible = true;
                passwordButtonSubmit.Visible = true;
                passwordTextBox.Focus();
            }
        }

        private void angleDownButton_Click(object sender, EventArgs e)
        {
            myImage.angleOfText += currentResolution();
            renderImage();
        }

        private void angleUpButton_Click_1(object sender, EventArgs e)
        {
            myImage.angleOfText -= currentResolution();
            renderImage();
        }

        private void increaseFontButton_Click(object sender, EventArgs e)
        {
            myImage.fontSize += currentResolution();
            renderImage();
        }

        private void decreaseFontButton_Click(object sender, EventArgs e)
        {
            myImage.fontSize -= currentResolution();
            renderImage();
        }

        private void comboBoxFontType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                myImage.fontName = comboBoxFontType.SelectedItem.ToString();
                renderImage();
           
        }

        //verifies default settings
        private bool imageIsDefault()
        {
            //Enable here to force default saving settings with a password
            /*if(defaultXPosition == myImage.xPosition && defaultYPosition == myImage.yPosition && defaultFontName == myImage.fontName
                && defaultFontSize == myImage.fontSize && defaultAngleOfText == myImage.angleOfText)
            {
                return true;
            }
            else
            {
                return false;
            }*/

            return true;
            
        }

        //Checks for correct password entered
        private bool passwordSet()
        {

            if (!passwordCorrect)
            {


                if (string.Compare(passwordTextBox.Text,myPassword) == 0)
                {
                        passwordCorrect = true;
                        passwordTextBox.Visible = false;
                        passwordLabel.Visible = false;
                        passwordButtonSubmit.Visible = false;
                }
                else
                {
                    MessageBox.Show("Pasword Incorrect please try again.");
                    passwordTextBox.Visible = false;
                    passwordLabel.Visible = false;
                    passwordButtonSubmit.Visible = false;
                }
            }
            return passwordCorrect;
        }

        private void imageObjectsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            myImage = operation.getImage(imageObjectsComboBox.SelectedItem.ToString());
            updateUIControls();
            renderImage();
            submitRequired = false;
        }

        //Textbox will not save if user skips to another control this prevents dataloss from the comments
        private void CommentsTextBox_TextChanged(object sender, EventArgs e)
        {
            myImage.comments = CommentsTextBox.Text;
        }

        public int currentResolution()
        {
            if(radioButtonFine.Checked)
            {
                return controlResolutionFine;
            }
            else
            {
                return controlResolutionCoarse;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Last chance to cancel delete operation
            DialogResult result = MessageBox.Show("You are about to delete the file for " + myImage.textToRender
                + ".\nDo you wish to continue?", "Delete Image", MessageBoxButtons.OKCancel);
            //User pressed ok
            if (result == DialogResult.OK)
            {
                //remove specific image
                operation.removeImage(myImage);

                //Update UI combobox
                populateComboBoxList();

                //Clear delete button
                deleteButton.Visible = false;
            }
            else
            {
                //User cancelled operation
                MessageBox.Show("The image was not deleted!");
            }

        }

        private void passwordButtonSubmit_Click(object sender, EventArgs e)
        {
            if (passwordSet())
            {
                processSaveImage();
                passwordCorrect = false;
            }
        }


    }
}
