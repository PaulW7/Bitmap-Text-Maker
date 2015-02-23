namespace DominoBMPCompile
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.textBoxTextToRender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.textBoxXPosition = new System.Windows.Forms.TextBox();
            this.textBoxYPosition = new System.Windows.Forms.TextBox();
            this.textBoxFontSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.increaseFontButton = new System.Windows.Forms.Button();
            this.decreaseFontButton = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.labelXPos = new System.Windows.Forms.Label();
            this.labelYPos = new System.Windows.Forms.Label();
            this.comboBoxFontType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelPosition = new System.Windows.Forms.Panel();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.angleDownButton = new System.Windows.Forms.Button();
            this.angleUpButton = new System.Windows.Forms.Button();
            this.CommentsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imageObjectsComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.radioButtonCoarse = new System.Windows.Forms.RadioButton();
            this.radioButtonFine = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordButtonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTextToRender
            // 
            this.textBoxTextToRender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextToRender.Location = new System.Drawing.Point(337, 81);
            this.textBoxTextToRender.Name = "textBoxTextToRender";
            this.textBoxTextToRender.Size = new System.Drawing.Size(166, 26);
            this.textBoxTextToRender.TabIndex = 0;
            this.textBoxTextToRender.TextChanged += new System.EventHandler(this.textBoxTextToRender_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter New:";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(533, 80);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(278, 28);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Visible = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
            this.pictureBoxPreview.ErrorImage = null;
            this.pictureBoxPreview.InitialImage = null;
            this.pictureBoxPreview.Location = new System.Drawing.Point(23, 118);
            this.pictureBoxPreview.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxPreview.MaximumSize = new System.Drawing.Size(788, 243);
            this.pictureBoxPreview.MinimumSize = new System.Drawing.Size(788, 243);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(788, 243);
            this.pictureBoxPreview.TabIndex = 3;
            this.pictureBoxPreview.TabStop = false;
            // 
            // saveImageButton
            // 
            this.saveImageButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveImageButton.Location = new System.Drawing.Point(823, 478);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(181, 35);
            this.saveImageButton.TabIndex = 4;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = false;
            this.saveImageButton.Visible = false;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // textBoxXPosition
            // 
            this.textBoxXPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXPosition.ForeColor = System.Drawing.Color.Magenta;
            this.textBoxXPosition.Location = new System.Drawing.Point(959, 309);
            this.textBoxXPosition.Name = "textBoxXPosition";
            this.textBoxXPosition.ReadOnly = true;
            this.textBoxXPosition.Size = new System.Drawing.Size(49, 26);
            this.textBoxXPosition.TabIndex = 7;
            this.textBoxXPosition.Text = "29";
            this.textBoxXPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxXPosition.Visible = false;
            // 
            // textBoxYPosition
            // 
            this.textBoxYPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYPosition.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBoxYPosition.Location = new System.Drawing.Point(959, 215);
            this.textBoxYPosition.Name = "textBoxYPosition";
            this.textBoxYPosition.ReadOnly = true;
            this.textBoxYPosition.Size = new System.Drawing.Size(49, 26);
            this.textBoxYPosition.TabIndex = 8;
            this.textBoxYPosition.Text = "-191";
            this.textBoxYPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxYPosition.Visible = false;
            // 
            // textBoxFontSize
            // 
            this.textBoxFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFontSize.Location = new System.Drawing.Point(857, 178);
            this.textBoxFontSize.Name = "textBoxFontSize";
            this.textBoxFontSize.ReadOnly = true;
            this.textBoxFontSize.Size = new System.Drawing.Size(48, 26);
            this.textBoxFontSize.TabIndex = 9;
            this.textBoxFontSize.Text = "107";
            this.textBoxFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(291, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bitmap Text Maker";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // increaseFontButton
            // 
            this.increaseFontButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.increaseFontButton.Image = ((System.Drawing.Image)(resources.GetObject("increaseFontButton.Image")));
            this.increaseFontButton.Location = new System.Drawing.Point(820, 178);
            this.increaseFontButton.Name = "increaseFontButton";
            this.increaseFontButton.Size = new System.Drawing.Size(37, 26);
            this.increaseFontButton.TabIndex = 11;
            this.increaseFontButton.UseVisualStyleBackColor = true;
            this.increaseFontButton.Click += new System.EventHandler(this.increaseFontButton_Click);
            // 
            // decreaseFontButton
            // 
            this.decreaseFontButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.decreaseFontButton.Image = ((System.Drawing.Image)(resources.GetObject("decreaseFontButton.Image")));
            this.decreaseFontButton.Location = new System.Drawing.Point(906, 178);
            this.decreaseFontButton.Name = "decreaseFontButton";
            this.decreaseFontButton.Size = new System.Drawing.Size(37, 26);
            this.decreaseFontButton.TabIndex = 12;
            this.decreaseFontButton.UseVisualStyleBackColor = true;
            this.decreaseFontButton.Click += new System.EventHandler(this.decreaseFontButton_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMoveUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonMoveUp.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveUp.Image")));
            this.buttonMoveUp.Location = new System.Drawing.Point(850, 230);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(34, 29);
            this.buttonMoveUp.TabIndex = 11;
            this.buttonMoveUp.UseVisualStyleBackColor = false;
            this.buttonMoveUp.Visible = false;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMoveDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonMoveDown.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveDown.Image")));
            this.buttonMoveDown.Location = new System.Drawing.Point(851, 289);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(34, 29);
            this.buttonMoveDown.TabIndex = 12;
            this.buttonMoveDown.UseVisualStyleBackColor = false;
            this.buttonMoveDown.Visible = false;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMoveLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonMoveLeft.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMoveLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveLeft.Image")));
            this.buttonMoveLeft.Location = new System.Drawing.Point(824, 257);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonMoveLeft.Size = new System.Drawing.Size(29, 34);
            this.buttonMoveLeft.TabIndex = 14;
            this.buttonMoveLeft.UseVisualStyleBackColor = false;
            this.buttonMoveLeft.Visible = false;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMoveRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonMoveRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveRight.Image")));
            this.buttonMoveRight.Location = new System.Drawing.Point(883, 256);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(29, 34);
            this.buttonMoveRight.TabIndex = 15;
            this.buttonMoveRight.UseVisualStyleBackColor = false;
            this.buttonMoveRight.Visible = false;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // labelXPos
            // 
            this.labelXPos.AutoSize = true;
            this.labelXPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXPos.ForeColor = System.Drawing.Color.Magenta;
            this.labelXPos.Location = new System.Drawing.Point(904, 313);
            this.labelXPos.Name = "labelXPos";
            this.labelXPos.Size = new System.Drawing.Size(58, 20);
            this.labelXPos.TabIndex = 15;
            this.labelXPos.Text = "X-POS";
            this.labelXPos.Visible = false;
            // 
            // labelYPos
            // 
            this.labelYPos.AutoSize = true;
            this.labelYPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYPos.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelYPos.Location = new System.Drawing.Point(900, 218);
            this.labelYPos.Name = "labelYPos";
            this.labelYPos.Size = new System.Drawing.Size(62, 20);
            this.labelYPos.TabIndex = 16;
            this.labelYPos.Text = "Y=POS";
            this.labelYPos.Visible = false;
            // 
            // comboBoxFontType
            // 
            this.comboBoxFontType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFontType.FormattingEnabled = true;
            this.comboBoxFontType.Items.AddRange(new object[] {
            "Aharoni Bold",
            "Andalus",
            "Angsana New",
            "Angsana New Bold",
            "Angsana New Bold Italic",
            "Angsana New Italic",
            "AngsanaUPC",
            "AngsanaUPC Bold",
            "AngsanaUPC Bold Italic",
            "AngsanaUPC Italic",
            "Arabic Transparent",
            "Arabic Transparent Bold",
            "Arial",
            "Arial Black",
            "Arial Bold",
            "Arial Bold Italic",
            "Arial Italic",
            "Browallia New",
            "Browallia New Bold",
            "Browallia New Bold Italic",
            "Browallia New Italic",
            "BrowalliaUPC",
            "BrowalliaUPC Bold",
            "BrowalliaUPC Bold Italic",
            "BrowalliaUPC Italic",
            "Comic Sans MS",
            "Comic Sans MS Bold",
            "Cordia New",
            "Cordia New Bold",
            "Cordia New Bold Italic",
            "Cordia New Italic",
            "CordiaUPC",
            "CordiaUPC Bold",
            "CordiaUPC Bold Italic",
            "CordiaUPC Italic",
            "Courier New",
            "Courier New Bold",
            "Courier New Bold Italic",
            "Courier New Italic",
            "David",
            "David Bold",
            "David Transparent",
            "DilleniaUPC",
            "DilleniaUPC Bold",
            "DilleniaUPC Bold Italic",
            "DilleniaUPC Italic",
            "Estrangelo Edessa",
            "EucrosiaUPC",
            "EucrosiaUPC Bold",
            "EucrosiaUPC Bold Italic",
            "EucrosiaUPC Italic",
            "Fixed Miriam Transparent",
            "Franklin Gothic Medium",
            "Franklin Gothic Medium Italic",
            "FrankRuehl",
            "FreesiaUPC",
            "FreesiaUPC Bold",
            "FreesiaUPC Bold Italic",
            "FreesiaUPC Italic",
            "Gautami",
            "Georgia",
            "Georgia Bold",
            "Georgia Bold Italic",
            "Georgia Italic",
            "Impact",
            "IrisUPC",
            "IrisUPC Bold",
            "IrisUPC Bold Italic",
            "IrisUPC Italic",
            "JasmineUPC",
            "JasmineUPC Bold",
            "JasmineUPC Bold Italic",
            "JasmineUPC Italic",
            "KodchiangUPC",
            "KodchiangUPC Bold",
            "KodchiangUPC Bold Italic",
            "KodchiangUPC Italic",
            "Latha",
            "Levenim MT",
            "Levenim MT Bold",
            "LilyUPC",
            "LilyUPC Bold",
            "LilyUPC Bold Italic",
            "LilyUPC Italic",
            "Lucida Console",
            "Lucida Sans Unicode",
            "Mangal",
            "Marlett",
            "Microsoft Sans Serif",
            "Miriam",
            "Miriam Fixed",
            "Miriam Transparent",
            "MV Boli",
            "Narkisim",
            "Palatino Linotype",
            "Palatino Linotype Bold",
            "Palatino Linotype Bold Italic",
            "Palatino Linotype Italic",
            "Raavi",
            "Rod",
            "Rod Transparent",
            "Shruti",
            "Simplified Arabic",
            "Simplified Arabic Bold",
            "Simplified Arabic Fixed",
            "Sylfaen",
            "Symbol",
            "Tahoma",
            "Tahoma Bold",
            "Times New Roman",
            "Times New Roman Bold",
            "Times New Roman Bold Italic",
            "Times New Roman Italic",
            "Traditional Arabic",
            "Traditional Arabic Bold",
            "Trebuchet MS",
            "Trebuchet MS Bold",
            "Trebuchet MS Bold Italic",
            "Trebuchet MS Italic",
            "Tunga",
            "Verdana",
            "Verdana Bold",
            "Verdana Bold Italic",
            "Verdana Italic",
            "Webdings",
            "Wingdings",
            "SimHei",
            "FangSong_GB2312",
            "DFKai-SB",
            "KaiTi_GB2312",
            "MS Gothic",
            "MS Mincho",
            "Gulim",
            "Mingliu",
            "Simsun",
            "Batang"});
            this.comboBoxFontType.Location = new System.Drawing.Point(818, 135);
            this.comboBoxFontType.Name = "comboBoxFontType";
            this.comboBoxFontType.Size = new System.Drawing.Size(190, 28);
            this.comboBoxFontType.TabIndex = 14;
            this.comboBoxFontType.Text = "Arial Black";
            this.comboBoxFontType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFontType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(814, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Font Type:";
            // 
            // panelPosition
            // 
            this.panelPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPosition.Location = new System.Drawing.Point(856, 263);
            this.panelPosition.Name = "panelPosition";
            this.panelPosition.Size = new System.Drawing.Size(25, 22);
            this.panelPosition.TabIndex = 19;
            this.panelPosition.Visible = false;
            // 
            // angleTextBox
            // 
            this.angleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angleTextBox.Location = new System.Drawing.Point(857, 363);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.ReadOnly = true;
            this.angleTextBox.Size = new System.Drawing.Size(55, 26);
            this.angleTextBox.TabIndex = 20;
            this.angleTextBox.Text = "-10";
            this.angleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.angleTextBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(822, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Angle:";
            this.label4.Visible = false;
            // 
            // angleDownButton
            // 
            this.angleDownButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.angleDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.angleDownButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.angleDownButton.Image = ((System.Drawing.Image)(resources.GetObject("angleDownButton.Image")));
            this.angleDownButton.Location = new System.Drawing.Point(913, 362);
            this.angleDownButton.Name = "angleDownButton";
            this.angleDownButton.Size = new System.Drawing.Size(34, 26);
            this.angleDownButton.TabIndex = 22;
            this.angleDownButton.UseVisualStyleBackColor = false;
            this.angleDownButton.Visible = false;
            this.angleDownButton.Click += new System.EventHandler(this.angleDownButton_Click);
            // 
            // angleUpButton
            // 
            this.angleUpButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.angleUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.angleUpButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.angleUpButton.Image = ((System.Drawing.Image)(resources.GetObject("angleUpButton.Image")));
            this.angleUpButton.Location = new System.Drawing.Point(823, 363);
            this.angleUpButton.Name = "angleUpButton";
            this.angleUpButton.Size = new System.Drawing.Size(34, 26);
            this.angleUpButton.TabIndex = 23;
            this.angleUpButton.UseVisualStyleBackColor = false;
            this.angleUpButton.Visible = false;
            this.angleUpButton.Click += new System.EventHandler(this.angleUpButton_Click_1);
            // 
            // CommentsTextBox
            // 
            this.CommentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsTextBox.Location = new System.Drawing.Point(21, 380);
            this.CommentsTextBox.MinimumSize = new System.Drawing.Size(4, 80);
            this.CommentsTextBox.Multiline = true;
            this.CommentsTextBox.Name = "CommentsTextBox";
            this.CommentsTextBox.Size = new System.Drawing.Size(790, 80);
            this.CommentsTextBox.TabIndex = 24;
            this.CommentsTextBox.TextChanged += new System.EventHandler(this.CommentsTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Comments:";
            // 
            // imageObjectsComboBox
            // 
            this.imageObjectsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageObjectsComboBox.FormattingEnabled = true;
            this.imageObjectsComboBox.Location = new System.Drawing.Point(23, 81);
            this.imageObjectsComboBox.Name = "imageObjectsComboBox";
            this.imageObjectsComboBox.Size = new System.Drawing.Size(197, 28);
            this.imageObjectsComboBox.TabIndex = 25;
            this.imageObjectsComboBox.Text = "Select Existing";
            this.imageObjectsComboBox.SelectionChangeCommitted += new System.EventHandler(this.imageObjectsComboBox_SelectionChangeCommitted);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Yellow;
            this.deleteButton.Location = new System.Drawing.Point(23, 478);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(207, 35);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "DELETE IMAGE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // radioButtonCoarse
            // 
            this.radioButtonCoarse.AutoSize = true;
            this.radioButtonCoarse.Checked = true;
            this.radioButtonCoarse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonCoarse.Location = new System.Drawing.Point(12, 26);
            this.radioButtonCoarse.Name = "radioButtonCoarse";
            this.radioButtonCoarse.Size = new System.Drawing.Size(70, 20);
            this.radioButtonCoarse.TabIndex = 27;
            this.radioButtonCoarse.TabStop = true;
            this.radioButtonCoarse.Text = "Coarse";
            this.radioButtonCoarse.UseVisualStyleBackColor = true;
            // 
            // radioButtonFine
            // 
            this.radioButtonFine.AutoSize = true;
            this.radioButtonFine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonFine.Location = new System.Drawing.Point(97, 26);
            this.radioButtonFine.Name = "radioButtonFine";
            this.radioButtonFine.Size = new System.Drawing.Size(52, 20);
            this.radioButtonFine.TabIndex = 28;
            this.radioButtonFine.TabStop = true;
            this.radioButtonFine.Text = "Fine";
            this.radioButtonFine.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCoarse);
            this.groupBox1.Controls.Add(this.radioButtonFine);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(826, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 53);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resolution";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Yellow;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(803, 32);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(205, 29);
            this.passwordTextBox.TabIndex = 30;
            this.passwordTextBox.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.Color.Yellow;
            this.passwordLabel.Location = new System.Drawing.Point(803, 16);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 13);
            this.passwordLabel.TabIndex = 31;
            this.passwordLabel.Text = "PASSWORD:";
            this.passwordLabel.Visible = false;
            // 
            // passwordButtonSubmit
            // 
            this.passwordButtonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordButtonSubmit.Location = new System.Drawing.Point(928, 68);
            this.passwordButtonSubmit.Name = "passwordButtonSubmit";
            this.passwordButtonSubmit.Size = new System.Drawing.Size(75, 26);
            this.passwordButtonSubmit.TabIndex = 32;
            this.passwordButtonSubmit.Text = "Submit";
            this.passwordButtonSubmit.UseVisualStyleBackColor = true;
            this.passwordButtonSubmit.Visible = false;
            this.passwordButtonSubmit.Click += new System.EventHandler(this.passwordButtonSubmit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1017, 522);
            this.Controls.Add(this.passwordButtonSubmit);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.imageObjectsComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CommentsTextBox);
            this.Controls.Add(this.panelPosition);
            this.Controls.Add(this.buttonMoveRight);
            this.Controls.Add(this.angleUpButton);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.angleDownButton);
            this.Controls.Add(this.buttonMoveLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.angleTextBox);
            this.Controls.Add(this.textBoxYPosition);
            this.Controls.Add(this.textBoxXPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelYPos);
            this.Controls.Add(this.comboBoxFontType);
            this.Controls.Add(this.labelXPos);
            this.Controls.Add(this.textBoxFontSize);
            this.Controls.Add(this.increaseFontButton);
            this.Controls.Add(this.decreaseFontButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTextToRender);
            this.Name = "mainForm";
            this.Text = "Domino BMP Compile";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTextToRender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.TextBox textBoxXPosition;
        private System.Windows.Forms.TextBox textBoxYPosition;
        private System.Windows.Forms.TextBox textBoxFontSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button increaseFontButton;
        private System.Windows.Forms.Button decreaseFontButton;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Label labelYPos;
        private System.Windows.Forms.Label labelXPos;
        private System.Windows.Forms.ComboBox comboBoxFontType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelPosition;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button angleDownButton;
        private System.Windows.Forms.Button angleUpButton;
        private System.Windows.Forms.TextBox CommentsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox imageObjectsComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.RadioButton radioButtonCoarse;
        private System.Windows.Forms.RadioButton radioButtonFine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button passwordButtonSubmit;
    }
}

