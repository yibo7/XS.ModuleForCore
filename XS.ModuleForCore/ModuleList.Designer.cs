﻿namespace XS.ModuleForCore
{
    partial class ModuleList
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
            this.lvTools = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvTools
            // 
            this.lvTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTools.Location = new System.Drawing.Point(0, 0);
            this.lvTools.Name = "lvTools";
            this.lvTools.Size = new System.Drawing.Size(214, 450);
            this.lvTools.TabIndex = 0;
            this.lvTools.UseCompatibleStateImageBehavior = false;
            // 
            // ModuleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 450);
            this.Controls.Add(this.lvTools);
            this.Name = "ModuleList";
            this.Text = "ModuleList";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvTools;
    }
}