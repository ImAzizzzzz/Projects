namespace Gestion_D_un_Café
{
    partial class Articles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articles));
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.ListeArticles = new Guna.UI.WinForms.GunaDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.AjouterBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateExp = new Guna.UI.WinForms.GunaDateTimePicker();
            this.CategorieCb = new System.Windows.Forms.ComboBox();
            this.PrixTb = new System.Windows.Forms.TextBox();
            this.NomTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Système De Gestion D\'Un Café";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.ListeArticles);
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Controls.Add(this.SupprimerBtn);
            this.gunaPanel1.Controls.Add(this.ModifierBtn);
            this.gunaPanel1.Controls.Add(this.AjouterBtn);
            this.gunaPanel1.Controls.Add(this.label4);
            this.gunaPanel1.Controls.Add(this.label3);
            this.gunaPanel1.Controls.Add(this.DateExp);
            this.gunaPanel1.Controls.Add(this.CategorieCb);
            this.gunaPanel1.Controls.Add(this.PrixTb);
            this.gunaPanel1.Controls.Add(this.NomTb);
            this.gunaPanel1.Controls.Add(this.label2);
            this.gunaPanel1.Location = new System.Drawing.Point(146, 39);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(788, 459);
            this.gunaPanel1.TabIndex = 1;
            // 
            // ListeArticles
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.ListeArticles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.ListeArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListeArticles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(222)))));
            this.ListeArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListeArticles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListeArticles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListeArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ListeArticles.ColumnHeadersHeight = 30;
            this.ListeArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListeArticles.DefaultCellStyle = dataGridViewCellStyle15;
            this.ListeArticles.EnableHeadersVisualStyles = false;
            this.ListeArticles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListeArticles.Location = new System.Drawing.Point(325, 111);
            this.ListeArticles.Name = "ListeArticles";
            this.ListeArticles.ReadOnly = true;
            this.ListeArticles.RowHeadersVisible = false;
            this.ListeArticles.RowHeadersWidth = 51;
            this.ListeArticles.RowTemplate.Height = 28;
            this.ListeArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListeArticles.Size = new System.Drawing.Size(430, 312);
            this.ListeArticles.TabIndex = 22;
            this.ListeArticles.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ListeArticles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ListeArticles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ListeArticles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ListeArticles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ListeArticles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ListeArticles.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(222)))));
            this.ListeArticles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListeArticles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Sienna;
            this.ListeArticles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListeArticles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeArticles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ListeArticles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListeArticles.ThemeStyle.HeaderStyle.Height = 30;
            this.ListeArticles.ThemeStyle.ReadOnly = true;
            this.ListeArticles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ListeArticles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListeArticles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeArticles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ListeArticles.ThemeStyle.RowsStyle.Height = 28;
            this.ListeArticles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListeArticles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ListeArticles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeCategorie_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.BackColor = System.Drawing.Color.Sienna;
            this.SupprimerBtn.Location = new System.Drawing.Point(111, 403);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(100, 44);
            this.SupprimerBtn.TabIndex = 10;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = false;
            this.SupprimerBtn.Click += new System.EventHandler(this.SupprimerBtn_Click);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.Color.Sienna;
            this.ModifierBtn.Location = new System.Drawing.Point(170, 353);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(100, 44);
            this.ModifierBtn.TabIndex = 9;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // AjouterBtn
            // 
            this.AjouterBtn.BackColor = System.Drawing.Color.Sienna;
            this.AjouterBtn.Location = new System.Drawing.Point(56, 353);
            this.AjouterBtn.Name = "AjouterBtn";
            this.AjouterBtn.Size = new System.Drawing.Size(100, 44);
            this.AjouterBtn.TabIndex = 8;
            this.AjouterBtn.Text = "Ajouter";
            this.AjouterBtn.UseVisualStyleBackColor = false;
            this.AjouterBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(76, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Détails Des Articles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(466, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Liste Des Articles";
            // 
            // DateExp
            // 
            this.DateExp.BackColor = System.Drawing.Color.Sienna;
            this.DateExp.BaseColor = System.Drawing.Color.Sienna;
            this.DateExp.BorderColor = System.Drawing.Color.Sienna;
            this.DateExp.CustomFormat = null;
            this.DateExp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateExp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateExp.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateExp.ForeColor = System.Drawing.Color.White;
            this.DateExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateExp.Location = new System.Drawing.Point(56, 306);
            this.DateExp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateExp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateExp.Name = "DateExp";
            this.DateExp.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateExp.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateExp.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateExp.OnPressedColor = System.Drawing.Color.Black;
            this.DateExp.Size = new System.Drawing.Size(214, 30);
            this.DateExp.TabIndex = 4;
            this.DateExp.Text = "27/04/2024";
            this.DateExp.Value = new System.DateTime(2024, 4, 27, 2, 35, 2, 0);
            // 
            // CategorieCb
            // 
            this.CategorieCb.FormattingEnabled = true;
            this.CategorieCb.Location = new System.Drawing.Point(56, 260);
            this.CategorieCb.Name = "CategorieCb";
            this.CategorieCb.Size = new System.Drawing.Size(214, 31);
            this.CategorieCb.TabIndex = 3;
            // 
            // PrixTb
            // 
            this.PrixTb.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrixTb.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PrixTb.Location = new System.Drawing.Point(56, 214);
            this.PrixTb.Name = "PrixTb";
            this.PrixTb.Size = new System.Drawing.Size(214, 27);
            this.PrixTb.TabIndex = 2;
            this.PrixTb.Text = "Prix";
            // 
            // NomTb
            // 
            this.NomTb.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomTb.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NomTb.Location = new System.Drawing.Point(56, 172);
            this.NomTb.Name = "NomTb";
            this.NomTb.Size = new System.Drawing.Size(214, 27);
            this.NomTb.TabIndex = 1;
            this.NomTb.Text = "Nom De L\'Article";
            this.NomTb.TextChanged += new System.EventHandler(this.NomTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(296, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gestion Des Articles";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 230);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 304);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 469);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Categories";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Articles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Factures";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Déconnexion";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 22);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 75);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(930, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(20, 30);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 23;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(956, 510);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Articles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articles";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.ComboBox CategorieCb;
        private System.Windows.Forms.TextBox PrixTb;
        private System.Windows.Forms.TextBox NomTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SupprimerBtn;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.Button AjouterBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Guna.UI.WinForms.GunaDataGridView ListeArticles;
        private Guna.UI.WinForms.GunaDateTimePicker DateExp;
        private System.Windows.Forms.PictureBox ExitBtn;
    }
}