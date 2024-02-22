namespace HrmsPrototype.Forms.Notifications
{
    partial class frmMessageBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HrmsPrototype.Properties.Resources.check;
            this.pictureBox1.Location = new System.Drawing.Point(132, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.CornerRoundingRadius = 10F;
            this.btnDelete.Location = new System.Drawing.Point(197, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 32);
            this.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.Maroon;
            this.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnDelete.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.btnDelete.StateCommon.Border.Color2 = System.Drawing.Color.Maroon;
            this.btnDelete.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Rounding = 10F;
            this.btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Values.Text = "No";
            // 
            // btnSave
            // 
            this.btnSave.CornerRoundingRadius = 10F;
            this.btnSave.Location = new System.Drawing.Point(92, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 32);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.DarkBlue;
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.btnSave.StateCommon.Border.Color1 = System.Drawing.Color.DarkBlue;
            this.btnSave.StateCommon.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 10F;
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 18;
            this.btnSave.Values.Text = "Yes";
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(396, 203);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.CornerRoundingRadius = 10F;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10F;
            this.Text = "frmMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnSave;
    }
}