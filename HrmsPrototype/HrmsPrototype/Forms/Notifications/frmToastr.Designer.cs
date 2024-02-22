namespace HrmsPrototype.Forms.Notifications
{
    partial class frmToastr
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
            this.toastColor = new System.Windows.Forms.Panel();
            this.tType = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toastTimer = new System.Windows.Forms.Timer(this.components);
            this.toastHide = new System.Windows.Forms.Timer(this.components);
            this.tMessage = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.cType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // toastColor
            // 
            this.toastColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.toastColor.Location = new System.Drawing.Point(-21, -6);
            this.toastColor.Name = "toastColor";
            this.toastColor.Size = new System.Drawing.Size(46, 100);
            this.toastColor.TabIndex = 0;
            // 
            // tType
            // 
            this.tType.AutoSize = true;
            this.tType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tType.Location = new System.Drawing.Point(111, 9);
            this.tType.Name = "tType";
            this.tType.Size = new System.Drawing.Size(44, 17);
            this.tType.TabIndex = 1;
            this.tType.Text = "Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HrmsPrototype.Properties.Resources.check;
            this.pictureBox1.Location = new System.Drawing.Point(31, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // toastTimer
            // 
            this.toastTimer.Enabled = true;
            this.toastTimer.Interval = 10;
            this.toastTimer.Tick += new System.EventHandler(this.toastTimer_Tick);
            // 
            // toastHide
            // 
            this.toastHide.Enabled = true;
            this.toastHide.Interval = 10;
            this.toastHide.Tick += new System.EventHandler(this.toastHide_Tick);
            // 
            // tMessage
            // 
            this.tMessage.AutoSize = true;
            this.tMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.tMessage.Location = new System.Drawing.Point(111, 58);
            this.tMessage.Name = "tMessage";
            this.tMessage.Size = new System.Drawing.Size(58, 15);
            this.tMessage.TabIndex = 3;
            this.tMessage.Text = "Message";
            // 
            // pic
            // 
            this.pic.Image = global::HrmsPrototype.Properties.Resources.check;
            this.pic.Location = new System.Drawing.Point(31, 7);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(74, 68);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // cType
            // 
            this.cType.AutoSize = true;
            this.cType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cType.ForeColor = System.Drawing.SystemColors.Control;
            this.cType.Location = new System.Drawing.Point(111, 9);
            this.cType.Name = "cType";
            this.cType.Size = new System.Drawing.Size(44, 17);
            this.cType.TabIndex = 1;
            this.cType.Text = "Type";
            // 
            // frmToastr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(482, 82);
            this.Controls.Add(this.cType);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.tMessage);
            this.Controls.Add(this.toastColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmToastr";
            this.Text = "frmToastr";
            this.Load += new System.EventHandler(this.frmToastr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toastColor;
        private System.Windows.Forms.Label tType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastHide;
        private System.Windows.Forms.Label tMessage;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label cType;
    }
}