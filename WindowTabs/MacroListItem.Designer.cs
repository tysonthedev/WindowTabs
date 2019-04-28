namespace WindowTabs
{
    partial class MacroListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNameOfMacro = new System.Windows.Forms.Label();
            this.lblHotkey = new System.Windows.Forms.Label();
            this.btnEditMacro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameOfMacro
            // 
            this.lblNameOfMacro.AutoSize = true;
            this.lblNameOfMacro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfMacro.Location = new System.Drawing.Point(3, 25);
            this.lblNameOfMacro.Name = "lblNameOfMacro";
            this.lblNameOfMacro.Size = new System.Drawing.Size(83, 20);
            this.lblNameOfMacro.TabIndex = 2;
            this.lblNameOfMacro.Text = "Next Song";
            // 
            // lblHotkey
            // 
            this.lblHotkey.AutoSize = true;
            this.lblHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotkey.Location = new System.Drawing.Point(3, 5);
            this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(66, 20);
            this.lblHotkey.TabIndex = 1;
            this.lblHotkey.Text = "ctrl+e+g";
            // 
            // btnEditMacro
            // 
            this.btnEditMacro.Location = new System.Drawing.Point(150, 0);
            this.btnEditMacro.Name = "btnEditMacro";
            this.btnEditMacro.Size = new System.Drawing.Size(50, 50);
            this.btnEditMacro.TabIndex = 0;
            this.btnEditMacro.Text = "edit";
            this.btnEditMacro.UseVisualStyleBackColor = true;
            // 
            // MacroListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.btnEditMacro);
            this.Controls.Add(this.lblNameOfMacro);
            this.Controls.Add(this.lblHotkey);
            this.Name = "MacroListItem";
            this.Size = new System.Drawing.Size(200, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameOfMacro;
        private System.Windows.Forms.Label lblHotkey;
        private System.Windows.Forms.Button btnEditMacro;
    }
}
