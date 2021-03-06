﻿namespace NHSE.WinForms
{
    partial class PlayerItemEditor<T>
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
            this.B_Cancel = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.B_Dump = new System.Windows.Forms.Button();
            this.B_Load = new System.Windows.Forms.Button();
            this.ItemEditor = new NHSE.WinForms.ItemEditor();
            this.PAN_Items = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // B_Cancel
            // 
            this.B_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Cancel.Location = new System.Drawing.Point(422, 228);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(72, 23);
            this.B_Cancel.TabIndex = 5;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // B_Save
            // 
            this.B_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Save.Location = new System.Drawing.Point(500, 228);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(72, 23);
            this.B_Save.TabIndex = 4;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // B_Dump
            // 
            this.B_Dump.Location = new System.Drawing.Point(9, 228);
            this.B_Dump.Name = "B_Dump";
            this.B_Dump.Size = new System.Drawing.Size(90, 23);
            this.B_Dump.TabIndex = 7;
            this.B_Dump.Text = "Dump";
            this.B_Dump.UseVisualStyleBackColor = true;
            this.B_Dump.Click += new System.EventHandler(this.B_Dump_Click);
            // 
            // B_Load
            // 
            this.B_Load.Location = new System.Drawing.Point(105, 228);
            this.B_Load.Name = "B_Load";
            this.B_Load.Size = new System.Drawing.Size(90, 23);
            this.B_Load.TabIndex = 8;
            this.B_Load.Text = "Load";
            this.B_Load.UseVisualStyleBackColor = true;
            this.B_Load.Click += new System.EventHandler(this.B_Load_Click);
            // 
            // ItemEditor
            // 
            this.ItemEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemEditor.Location = new System.Drawing.Point(422, 12);
            this.ItemEditor.Name = "ItemEditor";
            this.ItemEditor.Size = new System.Drawing.Size(150, 210);
            this.ItemEditor.TabIndex = 6;
            // 
            // PAN_Items
            // 
            this.PAN_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PAN_Items.Location = new System.Drawing.Point(9, 12);
            this.PAN_Items.Name = "PAN_Items";
            this.PAN_Items.Size = new System.Drawing.Size(407, 210);
            this.PAN_Items.TabIndex = 9;
            // 
            // PlayerItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.PAN_Items);
            this.Controls.Add(this.B_Load);
            this.Controls.Add(this.B_Dump);
            this.Controls.Add(this.ItemEditor);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.B_Save);
            this.Icon = global::NHSE.WinForms.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayerItemEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.Button B_Save;
        private ItemEditor ItemEditor;
        private System.Windows.Forms.Button B_Dump;
        private System.Windows.Forms.Button B_Load;
        private System.Windows.Forms.Panel PAN_Items;
    }
}