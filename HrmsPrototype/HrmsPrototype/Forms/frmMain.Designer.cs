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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTransaction = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.btnAttendanceCategory = new System.Windows.Forms.Button();
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
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelSidebar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTransaction.SuspendLayout();
            this.panelLibrary.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
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
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
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
            this.panelTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.panelTransaction.Controls.Add(this.button1);
            this.panelTransaction.Controls.Add(this.btnEmployees);
            this.panelTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTransaction.Location = new System.Drawing.Point(0, 366);
            this.panelTransaction.Name = "panelTransaction";
            this.panelTransaction.Size = new System.Drawing.Size(246, 117);
            this.panelTransaction.TabIndex = 3;
            this.panelTransaction.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(0, 35);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(246, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Attendance Monitoring";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmployees.Location = new System.Drawing.Point(0, 0);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(246, 35);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.ImageKey = "transaction.png";
            this.btnTransaction.ImageList = this.imageList1;
            this.btnTransaction.Location = new System.Drawing.Point(0, 319);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTransaction.Size = new System.Drawing.Size(246, 47);
            this.btnTransaction.TabIndex = 2;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // panelLibrary
            // 
            this.panelLibrary.BackColor = System.Drawing.SystemColors.Control;
            this.panelLibrary.Controls.Add(this.btnAttendanceCategory);
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
            // btnAttendanceCategory
            // 
            this.btnAttendanceCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendanceCategory.FlatAppearance.BorderSize = 0;
            this.btnAttendanceCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendanceCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAttendanceCategory.Location = new System.Drawing.Point(0, 175);
            this.btnAttendanceCategory.Name = "btnAttendanceCategory";
            this.btnAttendanceCategory.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnAttendanceCategory.Size = new System.Drawing.Size(246, 35);
            this.btnAttendanceCategory.TabIndex = 7;
            this.btnAttendanceCategory.Text = "Attendance Category";
            this.btnAttendanceCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendanceCategory.UseVisualStyleBackColor = true;
            this.btnAttendanceCategory.Click += new System.EventHandler(this.btnAttendanceCategory_Click);
            // 
            // btnAttendanceEnrollment
            // 
            this.btnAttendanceEnrollment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendanceEnrollment.FlatAppearance.BorderSize = 0;
            this.btnAttendanceEnrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendanceEnrollment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAttendanceEnrollment.Location = new System.Drawing.Point(0, 140);
            this.btnAttendanceEnrollment.Name = "btnAttendanceEnrollment";
            this.btnAttendanceEnrollment.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnAttendanceEnrollment.Size = new System.Drawing.Size(246, 35);
            this.btnAttendanceEnrollment.TabIndex = 5;
            this.btnAttendanceEnrollment.Text = "Attendance Setup";
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
            this.btnLeaveSetup.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.btnCampus.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.btnPositions.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.btnDepartments.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.btnLibrary.BackColor = System.Drawing.SystemColors.Control;
            this.btnLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibrary.FlatAppearance.BorderSize = 0;
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.ImageKey = "book.png";
            this.btnLibrary.ImageList = this.imageList1;
            this.btnLibrary.Location = new System.Drawing.Point(0, 0);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLibrary.Size = new System.Drawing.Size(246, 47);
            this.btnLibrary.TabIndex = 0;
            this.btnLibrary.Text = "Library Files";
            this.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibrary.UseVisualStyleBackColor = false;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.SystemColors.Control;
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
            this.tLogout.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.tAccessLevel.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.tUsername.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.panelTask.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelTask.BackgroundImage = global::HrmsPrototype.Properties.Resources.Untitled_design;
            this.panelTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTask.Location = new System.Drawing.Point(0, 0);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(1017, 743);
            this.panelTask.TabIndex = 1;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonGroup1.CornerRoundingRadius = 15F;
            this.kryptonGroup1.Location = new System.Drawing.Point(246, 0);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.panelTask);
            this.kryptonGroup1.Size = new System.Drawing.Size(1029, 755);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.kryptonGroup1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup1.StateCommon.Border.Rounding = 15F;
            this.kryptonGroup1.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "transaction.png");
            this.imageList1.Images.SetKeyName(1, "book.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 767);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.panelSidebar);
            this.CornerRoundingRadius = 10F;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.SystemColors.Control;
            this.StateActive.Back.Color2 = System.Drawing.SystemColors.Control;
            this.StateActive.Border.Color1 = System.Drawing.SystemColors.Control;
            this.StateActive.Border.Color2 = System.Drawing.SystemColors.Control;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Back.Color1 = System.Drawing.SystemColors.Control;
            this.StateActive.Header.Back.Color2 = System.Drawing.SystemColors.Control;
            this.StateActive.Header.Border.Color1 = System.Drawing.SystemColors.Control;
            this.StateActive.Header.Border.Color2 = System.Drawing.SystemColors.Control;
            this.StateActive.Header.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Content.ShortText.Color1 = System.Drawing.SystemColors.ControlText;
            this.StateActive.Header.Content.ShortText.Color2 = System.Drawing.SystemColors.Control;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10F;
            this.StateInactive.Back.Color1 = System.Drawing.SystemColors.Control;
            this.StateInactive.Back.Color2 = System.Drawing.SystemColors.Control;
            this.StateInactive.Border.Color1 = System.Drawing.SystemColors.Control;
            this.StateInactive.Border.Color2 = System.Drawing.SystemColors.Control;
            this.StateInactive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Header.Back.Color1 = System.Drawing.SystemColors.Control;
            this.StateInactive.Header.Back.Color2 = System.Drawing.SystemColors.Control;
            this.StateInactive.Header.Border.Color1 = System.Drawing.SystemColors.Control;
            this.StateInactive.Header.Border.Color2 = System.Drawing.SystemColors.Control;
            this.StateInactive.Header.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "Human Resource Management System - Hermes 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelTransaction.ResumeLayout(false);
            this.panelLibrary.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Button btnCampus;
        private System.Windows.Forms.Button btnLeaveSetup;
        private System.Windows.Forms.Button btnAttendanceEnrollment;
        private System.Windows.Forms.Button btnAttendanceCategory;
        private System.Windows.Forms.Button button1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private System.Windows.Forms.ImageList imageList1;
    }
}