namespace crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btninst = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsdata = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Drop = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.icono = new System.Windows.Forms.PictureBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnchanger = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsdata)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 82);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btninst);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 58);
            this.panel2.TabIndex = 1;
            // 
            // btninst
            // 
            this.btninst.BackColor = System.Drawing.Color.DimGray;
            this.btninst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninst.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btninst.Location = new System.Drawing.Point(292, 10);
            this.btninst.Name = "btninst";
            this.btninst.Size = new System.Drawing.Size(122, 37);
            this.btninst.TabIndex = 4;
            this.btninst.Text = "Agregar";
            this.btninst.UseVisualStyleBackColor = false;
            this.btninst.Click += new System.EventHandler(this.btninst_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(63, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 10);
            this.panel3.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dsdata
            // 
            this.dsdata.AllowUserToAddRows = false;
            this.dsdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Drop});
            this.dsdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsdata.Location = new System.Drawing.Point(0, 82);
            this.dsdata.Name = "dsdata";
            this.dsdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsdata.Size = new System.Drawing.Size(1200, 576);
            this.dsdata.TabIndex = 1;
            this.dsdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsdata_CellClick);
            this.dsdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsdata_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            // 
            // Drop
            // 
            this.Drop.HeaderText = "Drop";
            this.Drop.Image = ((System.Drawing.Image)(resources.GetObject("Drop.Image")));
            this.Drop.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Drop.Name = "Drop";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.icono);
            this.panel4.Controls.Add(this.btnvolver);
            this.panel4.Controls.Add(this.btnchanger);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.txtPass);
            this.panel4.Controls.Add(this.txtUser);
            this.panel4.Controls.Add(this.lblpass);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(312, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(544, 293);
            this.panel4.TabIndex = 2;
            this.panel4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Imagen";
            // 
            // icono
            // 
            this.icono.Location = new System.Drawing.Point(190, 136);
            this.icono.Name = "icono";
            this.icono.Size = new System.Drawing.Size(129, 50);
            this.icono.TabIndex = 6;
            this.icono.TabStop = false;
            this.icono.Click += new System.EventHandler(this.icono_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(323, 205);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 5;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnchanger
            // 
            this.btnchanger.Location = new System.Drawing.Point(206, 205);
            this.btnchanger.Name = "btnchanger";
            this.btnchanger.Size = new System.Drawing.Size(75, 23);
            this.btnchanger.TabIndex = 4;
            this.btnchanger.Text = "Cambio";
            this.btnchanger.UseVisualStyleBackColor = true;
            this.btnchanger.Click += new System.EventHandler(this.btnchanger_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(132, 85);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(294, 26);
            this.txtPass.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(132, 41);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(294, 26);
            this.txtUser.TabIndex = 2;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(40, 88);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(69, 19);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuarios";
            // 
            // open
            // 
            this.open.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dsdata);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "user_proyecto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsdata)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btninst;
        private System.Windows.Forms.DataGridView dsdata;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox icono;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnchanger;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Drop;
    }
}

