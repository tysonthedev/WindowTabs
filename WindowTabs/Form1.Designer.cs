namespace WindowTabs
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCurrentWindowName = new System.Windows.Forms.Label();
            this.lblWindowHandle = new System.Windows.Forms.Label();
            this.pictureBoxProgram = new System.Windows.Forms.PictureBox();
            this.lblCurrentProcessID = new System.Windows.Forms.Label();
            this.btnAddWindow = new System.Windows.Forms.Button();
            this.imageListCurrentPrograms = new System.Windows.Forms.ImageList(this.components);
            this.listViewWindowTabs = new System.Windows.Forms.ListView();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.backgroundWorkerAddWindow = new System.ComponentModel.BackgroundWorker();
            this.pnkCurrentMacroList = new System.Windows.Forms.Panel();
            this.macroListItem = new WindowTabs.MacroListItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2a = new System.Windows.Forms.Label();
            this.label1a = new System.Windows.Forms.Label();
            this.btnEditMacroa = new System.Windows.Forms.Button();
            this.macroList = new WindowTabs.MacroList();
            this.btnAddMacro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgram)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            this.pnkCurrentMacroList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentWindowName
            // 
            this.lblCurrentWindowName.AutoSize = true;
            this.lblCurrentWindowName.Location = new System.Drawing.Point(140, 3);
            this.lblCurrentWindowName.Name = "lblCurrentWindowName";
            this.lblCurrentWindowName.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentWindowName.TabIndex = 0;
            this.lblCurrentWindowName.Text = "label1";
            // 
            // lblWindowHandle
            // 
            this.lblWindowHandle.AutoSize = true;
            this.lblWindowHandle.Location = new System.Drawing.Point(293, 3);
            this.lblWindowHandle.Name = "lblWindowHandle";
            this.lblWindowHandle.Size = new System.Drawing.Size(35, 13);
            this.lblWindowHandle.TabIndex = 1;
            this.lblWindowHandle.Text = "label1";
            // 
            // pictureBoxProgram
            // 
            this.pictureBoxProgram.Location = new System.Drawing.Point(653, 38);
            this.pictureBoxProgram.Name = "pictureBoxProgram";
            this.pictureBoxProgram.Size = new System.Drawing.Size(281, 108);
            this.pictureBoxProgram.TabIndex = 2;
            this.pictureBoxProgram.TabStop = false;
            // 
            // lblCurrentProcessID
            // 
            this.lblCurrentProcessID.AutoSize = true;
            this.lblCurrentProcessID.Location = new System.Drawing.Point(436, 3);
            this.lblCurrentProcessID.Name = "lblCurrentProcessID";
            this.lblCurrentProcessID.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentProcessID.TabIndex = 3;
            this.lblCurrentProcessID.Text = "label1";
            // 
            // btnAddWindow
            // 
            this.btnAddWindow.Location = new System.Drawing.Point(3, 3);
            this.btnAddWindow.Name = "btnAddWindow";
            this.btnAddWindow.Size = new System.Drawing.Size(131, 25);
            this.btnAddWindow.TabIndex = 4;
            this.btnAddWindow.Text = "Add Window";
            this.btnAddWindow.UseVisualStyleBackColor = true;
            this.btnAddWindow.Click += new System.EventHandler(this.BtnAddWindow_Click);
            // 
            // imageListCurrentPrograms
            // 
            this.imageListCurrentPrograms.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListCurrentPrograms.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListCurrentPrograms.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listViewWindowTabs
            // 
            this.listViewWindowTabs.BackColor = System.Drawing.Color.DimGray;
            this.listViewWindowTabs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewWindowTabs.ForeColor = System.Drawing.Color.Black;
            this.listViewWindowTabs.Location = new System.Drawing.Point(0, 32);
            this.listViewWindowTabs.MultiSelect = false;
            this.listViewWindowTabs.Name = "listViewWindowTabs";
            this.listViewWindowTabs.Scrollable = false;
            this.listViewWindowTabs.Size = new System.Drawing.Size(32, 590);
            this.listViewWindowTabs.SmallImageList = this.imageListCurrentPrograms;
            this.listViewWindowTabs.TabIndex = 5;
            this.listViewWindowTabs.UseCompatibleStateImageBehavior = false;
            this.listViewWindowTabs.View = System.Windows.Forms.View.SmallIcon;
            this.listViewWindowTabs.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewWindowTabs_ItemSelectionChanged);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopBar.BackColor = System.Drawing.Color.DimGray;
            this.pnlTopBar.Controls.Add(this.lblCurrentProcessID);
            this.pnlTopBar.Controls.Add(this.lblCurrentWindowName);
            this.pnlTopBar.Controls.Add(this.btnAddWindow);
            this.pnlTopBar.Controls.Add(this.lblWindowHandle);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1201, 32);
            this.pnlTopBar.TabIndex = 6;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTopBar_MouseDown);
            this.pnlTopBar.MouseLeave += new System.EventHandler(this.PnlTopBar_MouseLeave);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTopBar_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlTopBar_MouseUp);
            // 
            // backgroundWorkerAddWindow
            // 
            this.backgroundWorkerAddWindow.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerAddWindow_DoWork);
            this.backgroundWorkerAddWindow.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerAddWindow_RunWorkerCompleted);
            // 
            // pnkCurrentMacroList
            // 
            this.pnkCurrentMacroList.BackColor = System.Drawing.Color.Silver;
            this.pnkCurrentMacroList.Controls.Add(this.macroListItem);
            this.pnkCurrentMacroList.Controls.Add(this.panel1);
            this.pnkCurrentMacroList.Location = new System.Drawing.Point(32, 32);
            this.pnkCurrentMacroList.Name = "pnkCurrentMacroList";
            this.pnkCurrentMacroList.Size = new System.Drawing.Size(200, 590);
            this.pnkCurrentMacroList.TabIndex = 7;
            // 
            // macroListItem
            // 
            this.macroListItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.macroListItem.HotKey = "ctrl+e+f";
            this.macroListItem.Location = new System.Drawing.Point(0, 56);
            this.macroListItem.MacroName = "Next Song";
            this.macroListItem.Name = "macroListItem";
            this.macroListItem.Size = new System.Drawing.Size(200, 50);
            this.macroListItem.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label2a);
            this.panel1.Controls.Add(this.label1a);
            this.panel1.Controls.Add(this.btnEditMacroa);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 0;
            // 
            // label2a
            // 
            this.label2a.AutoSize = true;
            this.label2a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2a.Location = new System.Drawing.Point(3, 23);
            this.label2a.Name = "label2a";
            this.label2a.Size = new System.Drawing.Size(83, 20);
            this.label2a.TabIndex = 2;
            this.label2a.Text = "Next Song";
            // 
            // label1a
            // 
            this.label1a.AutoSize = true;
            this.label1a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1a.Location = new System.Drawing.Point(3, 3);
            this.label1a.Name = "label1a";
            this.label1a.Size = new System.Drawing.Size(66, 20);
            this.label1a.TabIndex = 1;
            this.label1a.Text = "ctrl+e+g";
            // 
            // btnEditMacroa
            // 
            this.btnEditMacroa.Location = new System.Drawing.Point(150, 0);
            this.btnEditMacroa.Name = "btnEditMacroa";
            this.btnEditMacroa.Size = new System.Drawing.Size(50, 50);
            this.btnEditMacroa.TabIndex = 0;
            this.btnEditMacroa.Text = "edit";
            this.btnEditMacroa.UseVisualStyleBackColor = true;
            // 
            // macroList
            // 
            this.macroList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.macroList.Location = new System.Drawing.Point(317, 32);
            this.macroList.Name = "macroList";
            this.macroList.Size = new System.Drawing.Size(200, 535);
            this.macroList.TabIndex = 8;
            // 
            // btnAddMacro
            // 
            this.btnAddMacro.Location = new System.Drawing.Point(317, 576);
            this.btnAddMacro.Name = "btnAddMacro";
            this.btnAddMacro.Size = new System.Drawing.Size(200, 35);
            this.btnAddMacro.TabIndex = 9;
            this.btnAddMacro.Text = "Add Macro";
            this.btnAddMacro.UseVisualStyleBackColor = true;
            this.btnAddMacro.Click += new System.EventHandler(this.BtnAddMacro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1198, 620);
            this.Controls.Add(this.btnAddMacro);
            this.Controls.Add(this.macroList);
            this.Controls.Add(this.pnkCurrentMacroList);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.listViewWindowTabs);
            this.Controls.Add(this.pictureBoxProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgram)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnkCurrentMacroList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblCurrentWindowName;
        public System.Windows.Forms.Label lblWindowHandle;
        private System.Windows.Forms.PictureBox pictureBoxProgram;
        public System.Windows.Forms.Label lblCurrentProcessID;
        private System.Windows.Forms.Button btnAddWindow;
        private System.Windows.Forms.ImageList imageListCurrentPrograms;
        private System.Windows.Forms.ListView listViewWindowTabs;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAddWindow;
        private System.Windows.Forms.Panel pnkCurrentMacroList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2a;
        private System.Windows.Forms.Label label1a;
        private System.Windows.Forms.Button btnEditMacroa;
        private WindowTabs.MacroListItem macroListItem;
        private MacroList macroList;
        private System.Windows.Forms.Button btnAddMacro;
    }
}

