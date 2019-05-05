namespace WindowTabs
{
    partial class FormEditMacro
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
            this.listBoxMacroActions = new System.Windows.Forms.ListBox();
            this.panelMacroActionEditor = new System.Windows.Forms.Panel();
            this.panelActionTypeKeyUp = new System.Windows.Forms.Panel();
            this.textBoxActionTypeKeyUpWhichKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelActionTypeKeyDown = new System.Windows.Forms.Panel();
            this.textBoxActionTypeKeyDownWhichKey = new System.Windows.Forms.TextBox();
            this.lblWhichKey = new System.Windows.Forms.Label();
            this.panelActionTypeMouseUp = new System.Windows.Forms.Panel();
            this.buttonActionTypeMouseUpSetImage = new System.Windows.Forms.Button();
            this.buttonActionTypeMouseUpSelectImage = new System.Windows.Forms.Button();
            this.pictureBoxActionTypeMouseUpWhichImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxActionTypeMouseUpYPos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxActionTypeMouseUpXPos = new System.Windows.Forms.TextBox();
            this.comboBoxActionTypeMouseUpWhichMouseButton = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelActionTypeTypeKey = new System.Windows.Forms.Panel();
            this.textBoxActionTypeTypeKeyWhichKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelActionTypeMouseDown = new System.Windows.Forms.Panel();
            this.buttonActionTypeMouseDownSetImage = new System.Windows.Forms.Button();
            this.buttonActionTypeMouseDownSelectImage = new System.Windows.Forms.Button();
            this.pictureBoxActionTypeMouseDownWhichImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxActionTypeMouseDownYPos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxActionTypeMouseDownXPos = new System.Windows.Forms.TextBox();
            this.comboBoxActionTypeMouseDownWhichMouseButton = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelActionTypeMouseClick = new System.Windows.Forms.Panel();
            this.buttonActionTypeMouseClickSetImage = new System.Windows.Forms.Button();
            this.buttonActionTypeMouseClickSelectImage = new System.Windows.Forms.Button();
            this.pictureBoxActionTypeMouseClickWhichImage = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxActionTypeMouseClickYPos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxActionTypeMouseClickXPos = new System.Windows.Forms.TextBox();
            this.comboBoxActionTypeMouseClickWhichMouseButton = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelActionTypePassKeys = new System.Windows.Forms.Panel();
            this.panelActionTypeWait = new System.Windows.Forms.Panel();
            this.textBoxActionTypeWaitTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelActionTypeRunMacro = new System.Windows.Forms.Panel();
            this.textBoxActionTypeRunMacroNameOfMacro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblActionType = new System.Windows.Forms.Label();
            this.comboBoxActionType = new System.Windows.Forms.ComboBox();
            this.textBoxHotKey = new System.Windows.Forms.TextBox();
            this.lblHotKey = new System.Windows.Forms.Label();
            this.textBoxMacroName = new System.Windows.Forms.TextBox();
            this.lblMacroName = new System.Windows.Forms.Label();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.textBoxProcessName = new System.Windows.Forms.TextBox();
            this.lblClassPath = new System.Windows.Forms.Label();
            this.textBoxClassPath = new System.Windows.Forms.TextBox();
            this.btnAddMacroAction = new System.Windows.Forms.Button();
            this.btnDeleteMacroAction = new System.Windows.Forms.Button();
            this.checkBoxDirectInput = new System.Windows.Forms.CheckBox();
            this.btnSaveMacroChanges = new System.Windows.Forms.Button();
            this.btnCancelMacroChanges = new System.Windows.Forms.Button();
            this.lblMacroHotkeyLevel = new System.Windows.Forms.Label();
            this.comboBoxInputLevel = new System.Windows.Forms.ComboBox();
            this.PnlTopBar = new System.Windows.Forms.Panel();
            this.panelMacroActionEditor.SuspendLayout();
            this.panelActionTypeKeyUp.SuspendLayout();
            this.panelActionTypeKeyDown.SuspendLayout();
            this.panelActionTypeMouseUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActionTypeMouseUpWhichImage)).BeginInit();
            this.panelActionTypeTypeKey.SuspendLayout();
            this.panelActionTypeMouseDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActionTypeMouseDownWhichImage)).BeginInit();
            this.panelActionTypeMouseClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActionTypeMouseClickWhichImage)).BeginInit();
            this.panelActionTypeWait.SuspendLayout();
            this.panelActionTypeRunMacro.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMacroActions
            // 
            this.listBoxMacroActions.AllowDrop = true;
            this.listBoxMacroActions.FormattingEnabled = true;
            this.listBoxMacroActions.Location = new System.Drawing.Point(22, 159);
            this.listBoxMacroActions.Name = "listBoxMacroActions";
            this.listBoxMacroActions.Size = new System.Drawing.Size(432, 251);
            this.listBoxMacroActions.TabIndex = 2;
            this.listBoxMacroActions.SelectedIndexChanged += new System.EventHandler(this.listBoxMacroActions_SelectedIndexChanged);
            this.listBoxMacroActions.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxMacroActions_DragDrop);
            this.listBoxMacroActions.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxMacroActions_DragOver);
            this.listBoxMacroActions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxMacroActions_MouseDown);
            // 
            // panelMacroActionEditor
            // 
            this.panelMacroActionEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMacroActionEditor.Controls.Add(this.panelActionTypeKeyUp);
            this.panelMacroActionEditor.Controls.Add(this.panelActionTypeKeyDown);
            this.panelMacroActionEditor.Controls.Add(this.panelActionTypeMouseUp);
            this.panelMacroActionEditor.Controls.Add(this.panelActionTypeTypeKey);
            this.panelMacroActionEditor.Controls.Add(this.panelActionTypeMouseDown);
            this.panelMacroActionEditor.Controls.Add(this.panelActionTypeMouseClick);
            this.panelMacroActionEditor.Controls.Add(this.panelActionTypePassKeys);
            this.panelMacroActionEditor.Controls.Add(this.panelActionTypeWait);
            this.panelMacroActionEditor.Controls.Add(this.panelActionTypeRunMacro);
            this.panelMacroActionEditor.Controls.Add(this.lblActionType);
            this.panelMacroActionEditor.Controls.Add(this.comboBoxActionType);
            this.panelMacroActionEditor.Location = new System.Drawing.Point(460, 159);
            this.panelMacroActionEditor.Name = "panelMacroActionEditor";
            this.panelMacroActionEditor.Size = new System.Drawing.Size(328, 279);
            this.panelMacroActionEditor.TabIndex = 3;
            // 
            // panelActionTypeKeyUp
            // 
            this.panelActionTypeKeyUp.Controls.Add(this.textBoxActionTypeKeyUpWhichKey);
            this.panelActionTypeKeyUp.Controls.Add(this.label1);
            this.panelActionTypeKeyUp.Enabled = false;
            this.panelActionTypeKeyUp.Location = new System.Drawing.Point(3, 30);
            this.panelActionTypeKeyUp.Name = "panelActionTypeKeyUp";
            this.panelActionTypeKeyUp.Size = new System.Drawing.Size(322, 218);
            this.panelActionTypeKeyUp.TabIndex = 20;
            this.panelActionTypeKeyUp.Tag = "1";
            this.panelActionTypeKeyUp.Visible = false;
            // 
            // textBoxActionTypeKeyUpWhichKey
            // 
            this.textBoxActionTypeKeyUpWhichKey.Location = new System.Drawing.Point(70, 10);
            this.textBoxActionTypeKeyUpWhichKey.Name = "textBoxActionTypeKeyUpWhichKey";
            this.textBoxActionTypeKeyUpWhichKey.ReadOnly = true;
            this.textBoxActionTypeKeyUpWhichKey.Size = new System.Drawing.Size(249, 20);
            this.textBoxActionTypeKeyUpWhichKey.TabIndex = 19;
            this.textBoxActionTypeKeyUpWhichKey.Tag = "1";
            this.textBoxActionTypeKeyUpWhichKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxActionTypeKeyUpWhichKey_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Which Key";
            // 
            // panelActionTypeKeyDown
            // 
            this.panelActionTypeKeyDown.Controls.Add(this.textBoxActionTypeKeyDownWhichKey);
            this.panelActionTypeKeyDown.Controls.Add(this.lblWhichKey);
            this.panelActionTypeKeyDown.Enabled = false;
            this.panelActionTypeKeyDown.Location = new System.Drawing.Point(3, 30);
            this.panelActionTypeKeyDown.Name = "panelActionTypeKeyDown";
            this.panelActionTypeKeyDown.Size = new System.Drawing.Size(322, 218);
            this.panelActionTypeKeyDown.TabIndex = 2;
            this.panelActionTypeKeyDown.Visible = false;
            // 
            // textBoxActionTypeKeyDownWhichKey
            // 
            this.textBoxActionTypeKeyDownWhichKey.Location = new System.Drawing.Point(70, 10);
            this.textBoxActionTypeKeyDownWhichKey.Name = "textBoxActionTypeKeyDownWhichKey";
            this.textBoxActionTypeKeyDownWhichKey.ReadOnly = true;
            this.textBoxActionTypeKeyDownWhichKey.Size = new System.Drawing.Size(249, 20);
            this.textBoxActionTypeKeyDownWhichKey.TabIndex = 19;
            this.textBoxActionTypeKeyDownWhichKey.Tag = "1";
            this.textBoxActionTypeKeyDownWhichKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxActionTypeKeyDownWhichKey_KeyDown);
            // 
            // lblWhichKey
            // 
            this.lblWhichKey.AutoSize = true;
            this.lblWhichKey.Location = new System.Drawing.Point(5, 13);
            this.lblWhichKey.Name = "lblWhichKey";
            this.lblWhichKey.Size = new System.Drawing.Size(59, 13);
            this.lblWhichKey.TabIndex = 1;
            this.lblWhichKey.Text = "Which Key";
            // 
            // panelActionTypeMouseUp
            // 
            this.panelActionTypeMouseUp.Controls.Add(this.buttonActionTypeMouseUpSetImage);
            this.panelActionTypeMouseUp.Controls.Add(this.buttonActionTypeMouseUpSelectImage);
            this.panelActionTypeMouseUp.Controls.Add(this.pictureBoxActionTypeMouseUpWhichImage);
            this.panelActionTypeMouseUp.Controls.Add(this.label6);
            this.panelActionTypeMouseUp.Controls.Add(this.textBoxActionTypeMouseUpYPos);
            this.panelActionTypeMouseUp.Controls.Add(this.label7);
            this.panelActionTypeMouseUp.Controls.Add(this.textBoxActionTypeMouseUpXPos);
            this.panelActionTypeMouseUp.Controls.Add(this.comboBoxActionTypeMouseUpWhichMouseButton);
            this.panelActionTypeMouseUp.Controls.Add(this.label8);
            this.panelActionTypeMouseUp.Enabled = false;
            this.panelActionTypeMouseUp.Location = new System.Drawing.Point(3, 30);
            this.panelActionTypeMouseUp.Name = "panelActionTypeMouseUp";
            this.panelActionTypeMouseUp.Size = new System.Drawing.Size(322, 218);
            this.panelActionTypeMouseUp.TabIndex = 29;
            this.panelActionTypeMouseUp.Visible = false;
            // 
            // buttonActionTypeMouseUpSetImage
            // 
            this.buttonActionTypeMouseUpSetImage.Location = new System.Drawing.Point(162, 93);
            this.buttonActionTypeMouseUpSetImage.Name = "buttonActionTypeMouseUpSetImage";
            this.buttonActionTypeMouseUpSetImage.Size = new System.Drawing.Size(155, 23);
            this.buttonActionTypeMouseUpSetImage.TabIndex = 28;
            this.buttonActionTypeMouseUpSetImage.Text = "Set Image";
            this.buttonActionTypeMouseUpSetImage.UseVisualStyleBackColor = true;
            // 
            // buttonActionTypeMouseUpSelectImage
            // 
            this.buttonActionTypeMouseUpSelectImage.Location = new System.Drawing.Point(162, 64);
            this.buttonActionTypeMouseUpSelectImage.Name = "buttonActionTypeMouseUpSelectImage";
            this.buttonActionTypeMouseUpSelectImage.Size = new System.Drawing.Size(155, 23);
            this.buttonActionTypeMouseUpSelectImage.TabIndex = 27;
            this.buttonActionTypeMouseUpSelectImage.Text = "Select Image";
            this.buttonActionTypeMouseUpSelectImage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxActionTypeMouseUpWhichImage
            // 
            this.pictureBoxActionTypeMouseUpWhichImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxActionTypeMouseUpWhichImage.Location = new System.Drawing.Point(8, 64);
            this.pictureBoxActionTypeMouseUpWhichImage.Name = "pictureBoxActionTypeMouseUpWhichImage";
            this.pictureBoxActionTypeMouseUpWhichImage.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxActionTypeMouseUpWhichImage.TabIndex = 26;
            this.pictureBoxActionTypeMouseUpWhichImage.TabStop = false;
            this.pictureBoxActionTypeMouseUpWhichImage.Tag = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "y pos";
            // 
            // textBoxActionTypeMouseUpYPos
            // 
            this.textBoxActionTypeMouseUpYPos.Location = new System.Drawing.Point(112, 38);
            this.textBoxActionTypeMouseUpYPos.Name = "textBoxActionTypeMouseUpYPos";
            this.textBoxActionTypeMouseUpYPos.Size = new System.Drawing.Size(37, 20);
            this.textBoxActionTypeMouseUpYPos.TabIndex = 24;
            this.textBoxActionTypeMouseUpYPos.Tag = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "x pos";
            // 
            // textBoxActionTypeMouseUpXPos
            // 
            this.textBoxActionTypeMouseUpXPos.Location = new System.Drawing.Point(37, 38);
            this.textBoxActionTypeMouseUpXPos.Name = "textBoxActionTypeMouseUpXPos";
            this.textBoxActionTypeMouseUpXPos.Size = new System.Drawing.Size(37, 20);
            this.textBoxActionTypeMouseUpXPos.TabIndex = 22;
            this.textBoxActionTypeMouseUpXPos.Tag = "2";
            // 
            // comboBoxActionTypeMouseUpWhichMouseButton
            // 
            this.comboBoxActionTypeMouseUpWhichMouseButton.FormattingEnabled = true;
            this.comboBoxActionTypeMouseUpWhichMouseButton.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Middle"});
            this.comboBoxActionTypeMouseUpWhichMouseButton.Location = new System.Drawing.Point(118, 10);
            this.comboBoxActionTypeMouseUpWhichMouseButton.Name = "comboBoxActionTypeMouseUpWhichMouseButton";
            this.comboBoxActionTypeMouseUpWhichMouseButton.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActionTypeMouseUpWhichMouseButton.TabIndex = 21;
            this.comboBoxActionTypeMouseUpWhichMouseButton.Tag = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Which Mouse Button";
            // 
            // panelActionTypeTypeKey
            // 
            this.panelActionTypeTypeKey.Controls.Add(this.textBoxActionTypeTypeKeyWhichKey);
            this.panelActionTypeTypeKey.Controls.Add(this.label2);
            this.panelActionTypeTypeKey.Enabled = false;
            this.panelActionTypeTypeKey.Location = new System.Drawing.Point(3, 30);
            this.panelActionTypeTypeKey.Name = "panelActionTypeTypeKey";
            this.panelActionTypeTypeKey.Size = new System.Drawing.Size(322, 218);
            this.panelActionTypeTypeKey.TabIndex = 21;
            this.panelActionTypeTypeKey.Visible = false;
            // 
            // textBoxActionTypeTypeKeyWhichKey
            // 
            this.textBoxActionTypeTypeKeyWhichKey.Location = new System.Drawing.Point(70, 10);
            this.textBoxActionTypeTypeKeyWhichKey.Name = "textBoxActionTypeTypeKeyWhichKey";
            this.textBoxActionTypeTypeKeyWhichKey.ReadOnly = true;
            this.textBoxActionTypeTypeKeyWhichKey.Size = new System.Drawing.Size(249, 20);
            this.textBoxActionTypeTypeKeyWhichKey.TabIndex = 19;
            this.textBoxActionTypeTypeKeyWhichKey.Tag = "1";
            this.textBoxActionTypeTypeKeyWhichKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxActionTypeTypeKeyWhichKey_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Which Key";
            // 
            // panelActionTypeMouseDown
            // 
            this.panelActionTypeMouseDown.Controls.Add(this.buttonActionTypeMouseDownSetImage);
            this.panelActionTypeMouseDown.Controls.Add(this.buttonActionTypeMouseDownSelectImage);
            this.panelActionTypeMouseDown.Controls.Add(this.pictureBoxActionTypeMouseDownWhichImage);
            this.panelActionTypeMouseDown.Controls.Add(this.label5);
            this.panelActionTypeMouseDown.Controls.Add(this.textBoxActionTypeMouseDownYPos);
            this.panelActionTypeMouseDown.Controls.Add(this.label4);
            this.panelActionTypeMouseDown.Controls.Add(this.textBoxActionTypeMouseDownXPos);
            this.panelActionTypeMouseDown.Controls.Add(this.comboBoxActionTypeMouseDownWhichMouseButton);
            this.panelActionTypeMouseDown.Controls.Add(this.label3);
            this.panelActionTypeMouseDown.Enabled = false;
            this.panelActionTypeMouseDown.Location = new System.Drawing.Point(3, 30);
            this.panelActionTypeMouseDown.Name = "panelActionTypeMouseDown";
            this.panelActionTypeMouseDown.Size = new System.Drawing.Size(322, 218);
            this.panelActionTypeMouseDown.TabIndex = 22;
            this.panelActionTypeMouseDown.Visible = false;
            // 
            // buttonActionTypeMouseDownSetImage
            // 
            this.buttonActionTypeMouseDownSetImage.Location = new System.Drawing.Point(162, 93);
            this.buttonActionTypeMouseDownSetImage.Name = "buttonActionTypeMouseDownSetImage";
            this.buttonActionTypeMouseDownSetImage.Size = new System.Drawing.Size(155, 23);
            this.buttonActionTypeMouseDownSetImage.TabIndex = 28;
            this.buttonActionTypeMouseDownSetImage.Text = "Set Image";
            this.buttonActionTypeMouseDownSetImage.UseVisualStyleBackColor = true;
            // 
            // buttonActionTypeMouseDownSelectImage
            // 
            this.buttonActionTypeMouseDownSelectImage.Location = new System.Drawing.Point(162, 64);
            this.buttonActionTypeMouseDownSelectImage.Name = "buttonActionTypeMouseDownSelectImage";
            this.buttonActionTypeMouseDownSelectImage.Size = new System.Drawing.Size(155, 23);
            this.buttonActionTypeMouseDownSelectImage.TabIndex = 27;
            this.buttonActionTypeMouseDownSelectImage.Text = "Select Image";
            this.buttonActionTypeMouseDownSelectImage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxActionTypeMouseDownWhichImage
            // 
            this.pictureBoxActionTypeMouseDownWhichImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxActionTypeMouseDownWhichImage.Location = new System.Drawing.Point(8, 64);
            this.pictureBoxActionTypeMouseDownWhichImage.Name = "pictureBoxActionTypeMouseDownWhichImage";
            this.pictureBoxActionTypeMouseDownWhichImage.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxActionTypeMouseDownWhichImage.TabIndex = 26;
            this.pictureBoxActionTypeMouseDownWhichImage.TabStop = false;
            this.pictureBoxActionTypeMouseDownWhichImage.Tag = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "y pos";
            // 
            // textBoxActionTypeMouseDownYPos
            // 
            this.textBoxActionTypeMouseDownYPos.Location = new System.Drawing.Point(112, 38);
            this.textBoxActionTypeMouseDownYPos.Name = "textBoxActionTypeMouseDownYPos";
            this.textBoxActionTypeMouseDownYPos.Size = new System.Drawing.Size(37, 20);
            this.textBoxActionTypeMouseDownYPos.TabIndex = 24;
            this.textBoxActionTypeMouseDownYPos.Tag = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "x pos";
            // 
            // textBoxActionTypeMouseDownXPos
            // 
            this.textBoxActionTypeMouseDownXPos.Location = new System.Drawing.Point(37, 38);
            this.textBoxActionTypeMouseDownXPos.Name = "textBoxActionTypeMouseDownXPos";
            this.textBoxActionTypeMouseDownXPos.Size = new System.Drawing.Size(37, 20);
            this.textBoxActionTypeMouseDownXPos.TabIndex = 22;
            this.textBoxActionTypeMouseDownXPos.Tag = "2";
            // 
            // comboBoxActionTypeMouseDownWhichMouseButton
            // 
            this.comboBoxActionTypeMouseDownWhichMouseButton.FormattingEnabled = true;
            this.comboBoxActionTypeMouseDownWhichMouseButton.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Middle"});
            this.comboBoxActionTypeMouseDownWhichMouseButton.Location = new System.Drawing.Point(118, 10);
            this.comboBoxActionTypeMouseDownWhichMouseButton.Name = "comboBoxActionTypeMouseDownWhichMouseButton";
            this.comboBoxActionTypeMouseDownWhichMouseButton.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActionTypeMouseDownWhichMouseButton.TabIndex = 21;
            this.comboBoxActionTypeMouseDownWhichMouseButton.Tag = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Which Mouse Button";
            // 
            // panelActionTypeMouseClick
            // 
            this.panelActionTypeMouseClick.Controls.Add(this.buttonActionTypeMouseClickSetImage);
            this.panelActionTypeMouseClick.Controls.Add(this.buttonActionTypeMouseClickSelectImage);
            this.panelActionTypeMouseClick.Controls.Add(this.pictureBoxActionTypeMouseClickWhichImage);
            this.panelActionTypeMouseClick.Controls.Add(this.label9);
            this.panelActionTypeMouseClick.Controls.Add(this.textBoxActionTypeMouseClickYPos);
            this.panelActionTypeMouseClick.Controls.Add(this.label10);
            this.panelActionTypeMouseClick.Controls.Add(this.textBoxActionTypeMouseClickXPos);
            this.panelActionTypeMouseClick.Controls.Add(this.comboBoxActionTypeMouseClickWhichMouseButton);
            this.panelActionTypeMouseClick.Controls.Add(this.label11);
            this.panelActionTypeMouseClick.Enabled = false;
            this.panelActionTypeMouseClick.Location = new System.Drawing.Point(3, 30);
            this.panelActionTypeMouseClick.Name = "panelActionTypeMouseClick";
            this.panelActionTypeMouseClick.Size = new System.Drawing.Size(322, 218);
            this.panelActionTypeMouseClick.TabIndex = 30;
            this.panelActionTypeMouseClick.Visible = false;
            // 
            // buttonActionTypeMouseClickSetImage
            // 
            this.buttonActionTypeMouseClickSetImage.Location = new System.Drawing.Point(162, 93);
            this.buttonActionTypeMouseClickSetImage.Name = "buttonActionTypeMouseClickSetImage";
            this.buttonActionTypeMouseClickSetImage.Size = new System.Drawing.Size(155, 23);
            this.buttonActionTypeMouseClickSetImage.TabIndex = 28;
            this.buttonActionTypeMouseClickSetImage.Text = "Set Image";
            this.buttonActionTypeMouseClickSetImage.UseVisualStyleBackColor = true;
            // 
            // buttonActionTypeMouseClickSelectImage
            // 
            this.buttonActionTypeMouseClickSelectImage.Location = new System.Drawing.Point(162, 64);
            this.buttonActionTypeMouseClickSelectImage.Name = "buttonActionTypeMouseClickSelectImage";
            this.buttonActionTypeMouseClickSelectImage.Size = new System.Drawing.Size(155, 23);
            this.buttonActionTypeMouseClickSelectImage.TabIndex = 27;
            this.buttonActionTypeMouseClickSelectImage.Text = "Select Image";
            this.buttonActionTypeMouseClickSelectImage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxActionTypeMouseClickWhichImage
            // 
            this.pictureBoxActionTypeMouseClickWhichImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxActionTypeMouseClickWhichImage.Location = new System.Drawing.Point(8, 64);
            this.pictureBoxActionTypeMouseClickWhichImage.Name = "pictureBoxActionTypeMouseClickWhichImage";
            this.pictureBoxActionTypeMouseClickWhichImage.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxActionTypeMouseClickWhichImage.TabIndex = 26;
            this.pictureBoxActionTypeMouseClickWhichImage.TabStop = false;
            this.pictureBoxActionTypeMouseClickWhichImage.Tag = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "y pos";
            // 
            // textBoxActionTypeMouseClickYPos
            // 
            this.textBoxActionTypeMouseClickYPos.Location = new System.Drawing.Point(112, 38);
            this.textBoxActionTypeMouseClickYPos.Name = "textBoxActionTypeMouseClickYPos";
            this.textBoxActionTypeMouseClickYPos.Size = new System.Drawing.Size(37, 20);
            this.textBoxActionTypeMouseClickYPos.TabIndex = 24;
            this.textBoxActionTypeMouseClickYPos.Tag = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "x pos";
            // 
            // textBoxActionTypeMouseClickXPos
            // 
            this.textBoxActionTypeMouseClickXPos.Location = new System.Drawing.Point(37, 38);
            this.textBoxActionTypeMouseClickXPos.Name = "textBoxActionTypeMouseClickXPos";
            this.textBoxActionTypeMouseClickXPos.Size = new System.Drawing.Size(37, 20);
            this.textBoxActionTypeMouseClickXPos.TabIndex = 22;
            this.textBoxActionTypeMouseClickXPos.Tag = "2";
            // 
            // comboBoxActionTypeMouseClickWhichMouseButton
            // 
            this.comboBoxActionTypeMouseClickWhichMouseButton.FormattingEnabled = true;
            this.comboBoxActionTypeMouseClickWhichMouseButton.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Middle"});
            this.comboBoxActionTypeMouseClickWhichMouseButton.Location = new System.Drawing.Point(118, 10);
            this.comboBoxActionTypeMouseClickWhichMouseButton.Name = "comboBoxActionTypeMouseClickWhichMouseButton";
            this.comboBoxActionTypeMouseClickWhichMouseButton.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActionTypeMouseClickWhichMouseButton.TabIndex = 21;
            this.comboBoxActionTypeMouseClickWhichMouseButton.Tag = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Which Mouse Button";
            // 
            // panelActionTypePassKeys
            // 
            this.panelActionTypePassKeys.Enabled = false;
            this.panelActionTypePassKeys.Location = new System.Drawing.Point(3, 30);
            this.panelActionTypePassKeys.Name = "panelActionTypePassKeys";
            this.panelActionTypePassKeys.Size = new System.Drawing.Size(322, 218);
            this.panelActionTypePassKeys.TabIndex = 31;
            this.panelActionTypePassKeys.Visible = false;
            // 
            // panelActionTypeWait
            // 
            this.panelActionTypeWait.Controls.Add(this.textBoxActionTypeWaitTime);
            this.panelActionTypeWait.Controls.Add(this.label12);
            this.panelActionTypeWait.Enabled = false;
            this.panelActionTypeWait.Location = new System.Drawing.Point(3, 30);
            this.panelActionTypeWait.Name = "panelActionTypeWait";
            this.panelActionTypeWait.Size = new System.Drawing.Size(322, 218);
            this.panelActionTypeWait.TabIndex = 32;
            this.panelActionTypeWait.Visible = false;
            // 
            // textBoxActionTypeWaitTime
            // 
            this.textBoxActionTypeWaitTime.Location = new System.Drawing.Point(78, 7);
            this.textBoxActionTypeWaitTime.Name = "textBoxActionTypeWaitTime";
            this.textBoxActionTypeWaitTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxActionTypeWaitTime.TabIndex = 1;
            this.textBoxActionTypeWaitTime.Tag = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Wait Time(ms)";
            // 
            // panelActionTypeRunMacro
            // 
            this.panelActionTypeRunMacro.Controls.Add(this.textBoxActionTypeRunMacroNameOfMacro);
            this.panelActionTypeRunMacro.Controls.Add(this.label13);
            this.panelActionTypeRunMacro.Enabled = false;
            this.panelActionTypeRunMacro.Location = new System.Drawing.Point(3, 30);
            this.panelActionTypeRunMacro.Name = "panelActionTypeRunMacro";
            this.panelActionTypeRunMacro.Size = new System.Drawing.Size(322, 218);
            this.panelActionTypeRunMacro.TabIndex = 33;
            this.panelActionTypeRunMacro.Visible = false;
            // 
            // textBoxActionTypeRunMacroNameOfMacro
            // 
            this.textBoxActionTypeRunMacroNameOfMacro.Location = new System.Drawing.Point(70, 7);
            this.textBoxActionTypeRunMacroNameOfMacro.Name = "textBoxActionTypeRunMacroNameOfMacro";
            this.textBoxActionTypeRunMacroNameOfMacro.Size = new System.Drawing.Size(100, 20);
            this.textBoxActionTypeRunMacroNameOfMacro.TabIndex = 1;
            this.textBoxActionTypeRunMacroNameOfMacro.Tag = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Macro Name";
            // 
            // lblActionType
            // 
            this.lblActionType.AutoSize = true;
            this.lblActionType.Location = new System.Drawing.Point(3, 6);
            this.lblActionType.Name = "lblActionType";
            this.lblActionType.Size = new System.Drawing.Size(64, 13);
            this.lblActionType.TabIndex = 1;
            this.lblActionType.Text = "Action Type";
            // 
            // comboBoxActionType
            // 
            this.comboBoxActionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxActionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActionType.FormattingEnabled = true;
            this.comboBoxActionType.Location = new System.Drawing.Point(73, 3);
            this.comboBoxActionType.Name = "comboBoxActionType";
            this.comboBoxActionType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActionType.TabIndex = 0;
            this.comboBoxActionType.Tag = "0";
            this.comboBoxActionType.SelectedValueChanged += new System.EventHandler(this.comboBoxActionType_SelectedValueChanged);
            // 
            // textBoxHotKey
            // 
            this.textBoxHotKey.Location = new System.Drawing.Point(101, 113);
            this.textBoxHotKey.Name = "textBoxHotKey";
            this.textBoxHotKey.ReadOnly = true;
            this.textBoxHotKey.Size = new System.Drawing.Size(185, 20);
            this.textBoxHotKey.TabIndex = 4;
            this.textBoxHotKey.Enter += new System.EventHandler(this.textBoxHotKey_Enter);
            this.textBoxHotKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHotKey_KeyDown);
            this.textBoxHotKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxHotKey_KeyUp);
            // 
            // lblHotKey
            // 
            this.lblHotKey.AutoSize = true;
            this.lblHotKey.Location = new System.Drawing.Point(19, 116);
            this.lblHotKey.Name = "lblHotKey";
            this.lblHotKey.Size = new System.Drawing.Size(45, 13);
            this.lblHotKey.TabIndex = 6;
            this.lblHotKey.Text = "Hot Key";
            // 
            // textBoxMacroName
            // 
            this.textBoxMacroName.Location = new System.Drawing.Point(101, 35);
            this.textBoxMacroName.Name = "textBoxMacroName";
            this.textBoxMacroName.Size = new System.Drawing.Size(185, 20);
            this.textBoxMacroName.TabIndex = 0;
            // 
            // lblMacroName
            // 
            this.lblMacroName.AutoSize = true;
            this.lblMacroName.Location = new System.Drawing.Point(19, 38);
            this.lblMacroName.Name = "lblMacroName";
            this.lblMacroName.Size = new System.Drawing.Size(68, 13);
            this.lblMacroName.TabIndex = 1;
            this.lblMacroName.Text = "Macro Name";
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(19, 64);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(76, 13);
            this.lblProcessName.TabIndex = 8;
            this.lblProcessName.Text = "Process Name";
            // 
            // textBoxProcessName
            // 
            this.textBoxProcessName.Location = new System.Drawing.Point(101, 61);
            this.textBoxProcessName.Name = "textBoxProcessName";
            this.textBoxProcessName.Size = new System.Drawing.Size(185, 20);
            this.textBoxProcessName.TabIndex = 7;
            // 
            // lblClassPath
            // 
            this.lblClassPath.AutoSize = true;
            this.lblClassPath.Location = new System.Drawing.Point(19, 90);
            this.lblClassPath.Name = "lblClassPath";
            this.lblClassPath.Size = new System.Drawing.Size(57, 13);
            this.lblClassPath.TabIndex = 10;
            this.lblClassPath.Text = "Class Path";
            // 
            // textBoxClassPath
            // 
            this.textBoxClassPath.Location = new System.Drawing.Point(101, 87);
            this.textBoxClassPath.Name = "textBoxClassPath";
            this.textBoxClassPath.Size = new System.Drawing.Size(185, 20);
            this.textBoxClassPath.TabIndex = 9;
            // 
            // btnAddMacroAction
            // 
            this.btnAddMacroAction.Location = new System.Drawing.Point(22, 416);
            this.btnAddMacroAction.Name = "btnAddMacroAction";
            this.btnAddMacroAction.Size = new System.Drawing.Size(213, 23);
            this.btnAddMacroAction.TabIndex = 11;
            this.btnAddMacroAction.Text = "Add";
            this.btnAddMacroAction.UseVisualStyleBackColor = true;
            this.btnAddMacroAction.Click += new System.EventHandler(this.btnAddMacroAction_Click);
            // 
            // btnDeleteMacroAction
            // 
            this.btnDeleteMacroAction.Location = new System.Drawing.Point(241, 416);
            this.btnDeleteMacroAction.Name = "btnDeleteMacroAction";
            this.btnDeleteMacroAction.Size = new System.Drawing.Size(213, 23);
            this.btnDeleteMacroAction.TabIndex = 12;
            this.btnDeleteMacroAction.Text = "Delete";
            this.btnDeleteMacroAction.UseVisualStyleBackColor = true;
            this.btnDeleteMacroAction.Click += new System.EventHandler(this.btnDeleteMacroAction_Click);
            // 
            // checkBoxDirectInput
            // 
            this.checkBoxDirectInput.AutoSize = true;
            this.checkBoxDirectInput.Location = new System.Drawing.Point(114, 139);
            this.checkBoxDirectInput.Name = "checkBoxDirectInput";
            this.checkBoxDirectInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxDirectInput.Size = new System.Drawing.Size(172, 17);
            this.checkBoxDirectInput.TabIndex = 13;
            this.checkBoxDirectInput.Text = "Direct Input(not recommended)";
            this.checkBoxDirectInput.UseVisualStyleBackColor = true;
            // 
            // btnSaveMacroChanges
            // 
            this.btnSaveMacroChanges.Location = new System.Drawing.Point(647, 38);
            this.btnSaveMacroChanges.Name = "btnSaveMacroChanges";
            this.btnSaveMacroChanges.Size = new System.Drawing.Size(141, 115);
            this.btnSaveMacroChanges.TabIndex = 14;
            this.btnSaveMacroChanges.Text = "Save";
            this.btnSaveMacroChanges.UseVisualStyleBackColor = true;
            this.btnSaveMacroChanges.Click += new System.EventHandler(this.btnSaveMacroChanges_Click);
            // 
            // btnCancelMacroChanges
            // 
            this.btnCancelMacroChanges.Location = new System.Drawing.Point(500, 38);
            this.btnCancelMacroChanges.Name = "btnCancelMacroChanges";
            this.btnCancelMacroChanges.Size = new System.Drawing.Size(141, 115);
            this.btnCancelMacroChanges.TabIndex = 15;
            this.btnCancelMacroChanges.Text = "Cancel";
            this.btnCancelMacroChanges.UseVisualStyleBackColor = true;
            this.btnCancelMacroChanges.Click += new System.EventHandler(this.btnCancelMacroChanges_Click);
            // 
            // lblMacroHotkeyLevel
            // 
            this.lblMacroHotkeyLevel.AutoSize = true;
            this.lblMacroHotkeyLevel.Location = new System.Drawing.Point(328, 35);
            this.lblMacroHotkeyLevel.Name = "lblMacroHotkeyLevel";
            this.lblMacroHotkeyLevel.Size = new System.Drawing.Size(97, 13);
            this.lblMacroHotkeyLevel.TabIndex = 17;
            this.lblMacroHotkeyLevel.Text = "Hotkey Input Level";
            // 
            // comboBoxInputLevel
            // 
            this.comboBoxInputLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxInputLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxInputLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInputLevel.FormattingEnabled = true;
            this.comboBoxInputLevel.Location = new System.Drawing.Point(331, 51);
            this.comboBoxInputLevel.Name = "comboBoxInputLevel";
            this.comboBoxInputLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInputLevel.TabIndex = 18;
            // 
            // PnlTopBar
            // 
            this.PnlTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTopBar.BackColor = System.Drawing.Color.DimGray;
            this.PnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTopBar.Name = "PnlTopBar";
            this.PnlTopBar.Size = new System.Drawing.Size(801, 32);
            this.PnlTopBar.TabIndex = 19;
            this.PnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTopBar_MouseDown);
            this.PnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTopBar_MouseMove);
            this.PnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlTopBar_MouseUp);
            // 
            // FormEditMacro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlTopBar);
            this.Controls.Add(this.comboBoxInputLevel);
            this.Controls.Add(this.lblMacroHotkeyLevel);
            this.Controls.Add(this.btnCancelMacroChanges);
            this.Controls.Add(this.btnSaveMacroChanges);
            this.Controls.Add(this.checkBoxDirectInput);
            this.Controls.Add(this.btnDeleteMacroAction);
            this.Controls.Add(this.btnAddMacroAction);
            this.Controls.Add(this.lblClassPath);
            this.Controls.Add(this.textBoxClassPath);
            this.Controls.Add(this.lblProcessName);
            this.Controls.Add(this.textBoxProcessName);
            this.Controls.Add(this.lblHotKey);
            this.Controls.Add(this.textBoxHotKey);
            this.Controls.Add(this.panelMacroActionEditor);
            this.Controls.Add(this.listBoxMacroActions);
            this.Controls.Add(this.lblMacroName);
            this.Controls.Add(this.textBoxMacroName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditMacro";
            this.Text = "Edit Macro";
            this.panelMacroActionEditor.ResumeLayout(false);
            this.panelMacroActionEditor.PerformLayout();
            this.panelActionTypeKeyUp.ResumeLayout(false);
            this.panelActionTypeKeyUp.PerformLayout();
            this.panelActionTypeKeyDown.ResumeLayout(false);
            this.panelActionTypeKeyDown.PerformLayout();
            this.panelActionTypeMouseUp.ResumeLayout(false);
            this.panelActionTypeMouseUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActionTypeMouseUpWhichImage)).EndInit();
            this.panelActionTypeTypeKey.ResumeLayout(false);
            this.panelActionTypeTypeKey.PerformLayout();
            this.panelActionTypeMouseDown.ResumeLayout(false);
            this.panelActionTypeMouseDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActionTypeMouseDownWhichImage)).EndInit();
            this.panelActionTypeMouseClick.ResumeLayout(false);
            this.panelActionTypeMouseClick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActionTypeMouseClickWhichImage)).EndInit();
            this.panelActionTypeWait.ResumeLayout(false);
            this.panelActionTypeWait.PerformLayout();
            this.panelActionTypeRunMacro.ResumeLayout(false);
            this.panelActionTypeRunMacro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxMacroActions;
        private System.Windows.Forms.Panel panelMacroActionEditor;
        private System.Windows.Forms.TextBox textBoxHotKey;
        private System.Windows.Forms.Label lblHotKey;
        private System.Windows.Forms.TextBox textBoxMacroName;
        private System.Windows.Forms.Label lblMacroName;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.TextBox textBoxProcessName;
        private System.Windows.Forms.Label lblClassPath;
        private System.Windows.Forms.TextBox textBoxClassPath;
        private System.Windows.Forms.Label lblActionType;
        private System.Windows.Forms.ComboBox comboBoxActionType;
        private System.Windows.Forms.Button btnAddMacroAction;
        private System.Windows.Forms.Button btnDeleteMacroAction;
        private System.Windows.Forms.CheckBox checkBoxDirectInput;
        private System.Windows.Forms.Button btnSaveMacroChanges;
        private System.Windows.Forms.Button btnCancelMacroChanges;
        private System.Windows.Forms.Label lblMacroHotkeyLevel;
        private System.Windows.Forms.ComboBox comboBoxInputLevel;
        private System.Windows.Forms.Panel panelActionTypeKeyDown;
        private System.Windows.Forms.Label lblWhichKey;
        private System.Windows.Forms.TextBox textBoxActionTypeKeyDownWhichKey;
        private System.Windows.Forms.Panel panelActionTypeKeyUp;
        private System.Windows.Forms.TextBox textBoxActionTypeKeyUpWhichKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelActionTypeTypeKey;
        private System.Windows.Forms.TextBox textBoxActionTypeTypeKeyWhichKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelActionTypeMouseDown;
        private System.Windows.Forms.Button buttonActionTypeMouseDownSelectImage;
        private System.Windows.Forms.PictureBox pictureBoxActionTypeMouseDownWhichImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxActionTypeMouseDownYPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxActionTypeMouseDownXPos;
        private System.Windows.Forms.ComboBox comboBoxActionTypeMouseDownWhichMouseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonActionTypeMouseDownSetImage;
        private System.Windows.Forms.Panel panelActionTypeMouseUp;
        private System.Windows.Forms.Panel panelActionTypeMouseClick;
        private System.Windows.Forms.Panel panelActionTypePassKeys;
        private System.Windows.Forms.Panel panelActionTypeWait;
        private System.Windows.Forms.Panel panelActionTypeRunMacro;
        private System.Windows.Forms.TextBox textBoxActionTypeRunMacroNameOfMacro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxActionTypeWaitTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonActionTypeMouseClickSetImage;
        private System.Windows.Forms.Button buttonActionTypeMouseClickSelectImage;
        private System.Windows.Forms.PictureBox pictureBoxActionTypeMouseClickWhichImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxActionTypeMouseClickYPos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxActionTypeMouseClickXPos;
        private System.Windows.Forms.ComboBox comboBoxActionTypeMouseClickWhichMouseButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonActionTypeMouseUpSetImage;
        private System.Windows.Forms.Button buttonActionTypeMouseUpSelectImage;
        private System.Windows.Forms.PictureBox pictureBoxActionTypeMouseUpWhichImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxActionTypeMouseUpYPos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxActionTypeMouseUpXPos;
        private System.Windows.Forms.ComboBox comboBoxActionTypeMouseUpWhichMouseButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PnlTopBar;
    }
}