﻿namespace Winform_app
{
    partial class FrmDisk
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
            this.dgvDisk = new System.Windows.Forms.DataGridView();
            this.pbxDisk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisk)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisk
            // 
            this.dgvDisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisk.Location = new System.Drawing.Point(8, 45);
            this.dgvDisk.Name = "dgvDisk";
            this.dgvDisk.RowHeadersWidth = 51;
            this.dgvDisk.RowTemplate.Height = 24;
            this.dgvDisk.Size = new System.Drawing.Size(749, 314);
            this.dgvDisk.TabIndex = 0;
            this.dgvDisk.SelectionChanged += new System.EventHandler(this.dgvDisk_SelectionChanged);
            // 
            // pbxDisk
            // 
            this.pbxDisk.Location = new System.Drawing.Point(777, 40);
            this.pbxDisk.Name = "pbxDisk";
            this.pbxDisk.Size = new System.Drawing.Size(369, 328);
            this.pbxDisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDisk.TabIndex = 1;
            this.pbxDisk.TabStop = false;
            // 
            // FrmDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 465);
            this.Controls.Add(this.pbxDisk);
            this.Controls.Add(this.dgvDisk);
            this.Name = "FrmDisk";
            this.Text = "Music Discs";
            this.Load += new System.EventHandler(this.FrmDisk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisk;
        private System.Windows.Forms.PictureBox pbxDisk;
    }
}

