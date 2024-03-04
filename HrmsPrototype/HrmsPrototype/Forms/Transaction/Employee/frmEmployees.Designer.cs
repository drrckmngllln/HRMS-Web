namespace HrmsPrototype.Forms.Transaction
{
    partial class frmEmployees
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
            this.EmployeeMenu = new Krypton.Toolkit.KryptonGroup();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnPds = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panelTask = new System.Windows.Forms.Panel();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeMenu.Panel)).BeginInit();
            this.EmployeeMenu.Panel.SuspendLayout();
            this.EmployeeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Employees";
            // 
            // EmployeeMenu
            // 
            this.EmployeeMenu.CornerRoundingRadius = 15F;
            this.EmployeeMenu.Location = new System.Drawing.Point(16, 151);
            this.EmployeeMenu.Name = "EmployeeMenu";
            // 
            // EmployeeMenu.Panel
            // 
            this.EmployeeMenu.Panel.Controls.Add(this.btnAttendance);
            this.EmployeeMenu.Panel.Controls.Add(this.btnLeave);
            this.EmployeeMenu.Panel.Controls.Add(this.btnPds);
            this.EmployeeMenu.Panel.Controls.Add(this.btnDelete);
            this.EmployeeMenu.Panel.Controls.Add(this.btnUpdate);
            this.EmployeeMenu.Panel.Controls.Add(this.btnNew);
            this.EmployeeMenu.Size = new System.Drawing.Size(293, 331);
            this.EmployeeMenu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EmployeeMenu.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EmployeeMenu.StateCommon.Border.Rounding = 15F;
            this.EmployeeMenu.TabIndex = 40;
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAttendance.Location = new System.Drawing.Point(0, 260);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(281, 52);
            this.btnAttendance.TabIndex = 5;
            this.btnAttendance.Text = "Attendance History";
            this.btnAttendance.UseVisualStyleBackColor = false;
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeave.FlatAppearance.BorderSize = 0;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLeave.Location = new System.Drawing.Point(0, 208);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(281, 52);
            this.btnLeave.TabIndex = 4;
            this.btnLeave.Text = "Leave History";
            this.btnLeave.UseVisualStyleBackColor = false;
            // 
            // btnPds
            // 
            this.btnPds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnPds.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPds.FlatAppearance.BorderSize = 0;
            this.btnPds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPds.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPds.Location = new System.Drawing.Point(0, 156);
            this.btnPds.Name = "btnPds";
            this.btnPds.Size = new System.Drawing.Size(281, 52);
            this.btnPds.TabIndex = 3;
            this.btnPds.Text = "Personal Data Sheet";
            this.btnPds.UseVisualStyleBackColor = false;
            this.btnPds.Click += new System.EventHandler(this.btnPds_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(0, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(281, 52);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(0, 52);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(281, 52);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(281, 52);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Employee";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panelTask
            // 
            this.panelTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTask.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelTask.Location = new System.Drawing.Point(315, 47);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(832, 602);
            this.panelTask.TabIndex = 41;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.CornerRoundingRadius = 15F;
            this.kryptonGroup1.Location = new System.Drawing.Point(16, 85);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.btnHome);
            this.kryptonGroup1.Size = new System.Drawing.Size(293, 60);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonGroup1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup1.StateCommon.Border.Rounding = 15F;
            this.kryptonGroup1.TabIndex = 42;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(281, 48);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1159, 661);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.EmployeeMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployees";
            this.Text = "frmEmployees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeMenu.Panel)).EndInit();
            this.EmployeeMenu.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeMenu)).EndInit();
            this.EmployeeMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonGroup EmployeeMenu;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnPds;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panelTask;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private System.Windows.Forms.Button btnHome;
    }
}