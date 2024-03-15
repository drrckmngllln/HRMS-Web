namespace HrmsPrototype.Forms
{
    partial class frmMain
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTransaction = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnAttendanceEnrollment = new System.Windows.Forms.Button();
            this.btnLeaveSetup = new System.Windows.Forms.Button();
            this.btnCampus = new System.Windows.Forms.Button();
            this.btnPositions = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.tLogout = new System.Windows.Forms.Label();
            this.tAccessLevel = new System.Windows.Forms.Label();
            this.tUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTask = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTransaction.SuspendLayout();
            this.panelLibrary.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelSidebar.Controls.Add(this.panelMenu);
            this.panelSidebar.Controls.Add(this.panelUser);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(246, 767);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.Controls.Add(this.panelTransaction);
            this.panelMenu.Controls.Add(this.btnTransaction);
            this.panelMenu.Controls.Add(this.panelLibrary);
            this.panelMenu.Controls.Add(this.btnLibrary);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 210);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(246, 557);
            this.panelMenu.TabIndex = 1;
            // 
            // panelTransaction
            // 
            this.panelTransaction.Controls.Add(this.button1);
            this.panelTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTransaction.Location = new System.Drawing.Point(0, 366);
            this.panelTransaction.Name = "panelTransaction";
            this.panelTransaction.Size = new System.Drawing.Size(246, 117);
            this.panelTransaction.TabIndex = 3;
            this.panelTransaction.Visible = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(246, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Employees";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTransaction.Location = new System.Drawing.Point(0, 319);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTransaction.Size = new System.Drawing.Size(246, 47);
            this.btnTransaction.TabIndex = 2;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // panelLibrary
            // 
            this.panelLibrary.Controls.Add(this.btnUserManagement);
            this.panelLibrary.Controls.Add(this.btnAttendanceEnrollment);
            this.panelLibrary.Controls.Add(this.btnLeaveSetup);
            this.panelLibrary.Controls.Add(this.btnCampus);
            this.panelLibrary.Controls.Add(this.btnPositions);
            this.panelLibrary.Controls.Add(this.btnDepartments);
            this.panelLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLibrary.Location = new System.Drawing.Point(0, 47);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Size = new System.Drawing.Size(246, 272);
            this.panelLibrary.TabIndex = 1;
            this.panelLibrary.Visible = false;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUserManagement.Location = new System.Drawing.Point(0, 175);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnUserManagement.Size = new System.Drawing.Size(246, 35);
            this.btnUserManagement.TabIndex = 7;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // btnAttendanceEnrollment
            // 
            this.btnAttendanceEnrollment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendanceEnrollment.FlatAppearance.BorderSize = 0;
            this.btnAttendanceEnrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendanceEnrollment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAttendanceEnrollment.Location = new System.Drawing.Point(0, 140);
            this.btnAttendanceEnrollment.Name = "btnAttendanceEnrollment";
            this.btnAttendanceEnrollment.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnAttendanceEnrollment.Size = new System.Drawing.Size(246, 35);
            this.btnAttendanceEnrollment.TabIndex = 5;
            this.btnAttendanceEnrollment.Text = "Attendance Enrollment";
            this.btnAttendanceEnrollment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendanceEnrollment.UseVisualStyleBackColor = true;
            this.btnAttendanceEnrollment.Click += new System.EventHandler(this.btnAttendanceSetup_Click);
            // 
            // btnLeaveSetup
            // 
            this.btnLeaveSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeaveSetup.FlatAppearance.BorderSize = 0;
            this.btnLeaveSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveSetup.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLeaveSetup.Location = new System.Drawing.Point(0, 105);
            this.btnLeaveSetup.Name = "btnLeaveSetup";
            this.btnLeaveSetup.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnLeaveSetup.Size = new System.Drawing.Size(246, 35);
            this.btnLeaveSetup.TabIndex = 4;
            this.btnLeaveSetup.Text = "Leave Setup";
            this.btnLeaveSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeaveSetup.UseVisualStyleBackColor = true;
            this.btnLeaveSetup.Click += new System.EventHandler(this.btnLeaveSetup_Click);
            // 
            // btnCampus
            // 
            this.btnCampus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCampus.FlatAppearance.BorderSize = 0;
            this.btnCampus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCampus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCampus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCampus.Location = new System.Drawing.Point(0, 70);
            this.btnCampus.Name = "btnCampus";
            this.btnCampus.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnCampus.Size = new System.Drawing.Size(246, 35);
            this.btnCampus.TabIndex = 3;
            this.btnCampus.Text = "Campus";
            this.btnCampus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCampus.UseVisualStyleBackColor = true;
            this.btnCampus.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPositions
            // 
            this.btnPositions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPositions.FlatAppearance.BorderSize = 0;
            this.btnPositions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPositions.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPositions.Location = new System.Drawing.Point(0, 35);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnPositions.Size = new System.Drawing.Size(246, 35);
            this.btnPositions.TabIndex = 2;
            this.btnPositions.Text = "Positions";
            this.btnPositions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPositions.UseVisualStyleBackColor = true;
            this.btnPositions.Click += new System.EventHandler(this.btnPositions_Click);
            // 
            // btnDepartments
            // 
            this.btnDepartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartments.FlatAppearance.BorderSize = 0;
            this.btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartments.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDepartments.Location = new System.Drawing.Point(0, 0);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnDepartments.Size = new System.Drawing.Size(246, 35);
            this.btnDepartments.TabIndex = 1;
            this.btnDepartments.Text = "Departments";
            this.btnDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartments.UseVisualStyleBackColor = true;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibrary.FlatAppearance.BorderSize = 0;
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLibrary.Location = new System.Drawing.Point(0, 0);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLibrary.Size = new System.Drawing.Size(246, 47);
            this.btnLibrary.TabIndex = 0;
            this.btnLibrary.Text = "Library Files";
            this.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.tLogout);
            this.panelUser.Controls.Add(this.tAccessLevel);
            this.panelUser.Controls.Add(this.tUsername);
            this.panelUser.Controls.Add(this.pictureBox1);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(246, 210);
            this.panelUser.TabIndex = 0;
            // 
            // tLogout
            // 
            this.tLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.tLogout.Location = new System.Drawing.Point(3, 169);
            this.tLogout.Name = "tLogout";
            this.tLogout.Size = new System.Drawing.Size(237, 23);
            this.tLogout.TabIndex = 3;
            this.tLogout.Text = "Logout";
            this.tLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tAccessLevel
            // 
            this.tAccessLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAccessLevel.ForeColor = System.Drawing.SystemColors.Control;
            this.tAccessLevel.Location = new System.Drawing.Point(3, 146);
            this.tAccessLevel.Name = "tAccessLevel";
            this.tAccessLevel.Size = new System.Drawing.Size(237, 23);
            this.tAccessLevel.TabIndex = 2;
            this.tAccessLevel.Text = "Access Level";
            this.tAccessLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tUsername
            // 
            this.tUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.tUsername.Location = new System.Drawing.Point(3, 123);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(237, 23);
            this.tUsername.TabIndex = 1;
            this.tUsername.Text = "Username";
            this.tUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HrmsPrototype.Properties.Resources.Untitled_design;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTask
            // 
            this.panelTask.BackgroundImage = global::HrmsPrototype.Properties.Resources.Untitled_design;
            this.panelTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTask.Location = new System.Drawing.Point(246, 0);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(1041, 767);
            this.panelTask.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 767);
            this.ControlBox = false;
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.panelSidebar);
            this.CornerRoundingRadius = 10F;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateActive.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateActive.Header.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateActive.Header.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateActive.Header.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.StateActive.Header.Content.ShortText.Color2 = System.Drawing.SystemColors.Control;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10F;
            this.StateInactive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateInactive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateInactive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateInactive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateInactive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateInactive.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateInactive.Header.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateInactive.Header.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StateInactive.Header.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelTransaction.ResumeLayout(false);
            this.panelLibrary.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Label tLogout;
        private System.Windows.Forms.Label tAccessLevel;
        private System.Windows.Forms.Label tUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.Panel panelLibrary;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Panel panelTransaction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Button btnCampus;
        private System.Windows.Forms.Button btnLeaveSetup;
        private System.Windows.Forms.Button btnAttendanceEnrollment;
        private System.Windows.Forms.Button btnUserManagement;
    }
}