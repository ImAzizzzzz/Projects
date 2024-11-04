namespace Gestion_D_un_Café
{
    partial class Factures
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factures));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.MontantLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ListeFacture = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListeArticles = new Guna.UI.WinForms.GunaDataGridView();
            this.ImprimerBtn = new System.Windows.Forms.Button();
            this.AjouterBtn = new System.Windows.Forms.Button();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.DateTb = new Guna.UI.WinForms.GunaDateTimePicker();
            this.QuantitéTb = new System.Windows.Forms.TextBox();
            this.ClientTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ArticleTb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeFacture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.MontantLbl);
            this.gunaPanel1.Controls.Add(this.label9);
            this.gunaPanel1.Controls.Add(this.ListeFacture);
            this.gunaPanel1.Controls.Add(this.ListeArticles);
            this.gunaPanel1.Controls.Add(this.ImprimerBtn);
            this.gunaPanel1.Controls.Add(this.AjouterBtn);
            this.gunaPanel1.Controls.Add(this.SupprimerBtn);
            this.gunaPanel1.Controls.Add(this.DateTb);
            this.gunaPanel1.Controls.Add(this.QuantitéTb);
            this.gunaPanel1.Controls.Add(this.ClientTb);
            this.gunaPanel1.Controls.Add(this.label3);
            this.gunaPanel1.Controls.Add(this.label4);
            this.gunaPanel1.Controls.Add(this.ArticleTb);
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Controls.Add(this.label2);
            this.gunaPanel1.Location = new System.Drawing.Point(146, 39);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(788, 459);
            this.gunaPanel1.TabIndex = 0;
            // 
            // MontantLbl
            // 
            this.MontantLbl.AutoSize = true;
            this.MontantLbl.ForeColor = System.Drawing.Color.Sienna;
            this.MontantLbl.Location = new System.Drawing.Point(656, 358);
            this.MontantLbl.Name = "MontantLbl";
            this.MontantLbl.Size = new System.Drawing.Size(72, 23);
            this.MontantLbl.TabIndex = 29;
            this.MontantLbl.Text = "Montant";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(75, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Détails Des Catégories";
            // 
            // ListeFacture
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ListeFacture.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ListeFacture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListeFacture.BackgroundColor = System.Drawing.Color.White;
            this.ListeFacture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListeFacture.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListeFacture.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListeFacture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ListeFacture.ColumnHeadersHeight = 30;
            this.ListeFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListeFacture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListeFacture.DefaultCellStyle = dataGridViewCellStyle9;
            this.ListeFacture.EnableHeadersVisualStyles = false;
            this.ListeFacture.GridColor = System.Drawing.Color.White;
            this.ListeFacture.Location = new System.Drawing.Point(369, 115);
            this.ListeFacture.Name = "ListeFacture";
            this.ListeFacture.RowHeadersVisible = false;
            this.ListeFacture.RowHeadersWidth = 51;
            this.ListeFacture.RowTemplate.Height = 28;
            this.ListeFacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListeFacture.Size = new System.Drawing.Size(379, 231);
            this.ListeFacture.TabIndex = 27;
            this.ListeFacture.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ListeFacture.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ListeFacture.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ListeFacture.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ListeFacture.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ListeFacture.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ListeFacture.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ListeFacture.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.ListeFacture.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Sienna;
            this.ListeFacture.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListeFacture.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeFacture.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ListeFacture.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListeFacture.ThemeStyle.HeaderStyle.Height = 30;
            this.ListeFacture.ThemeStyle.ReadOnly = false;
            this.ListeFacture.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ListeFacture.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListeFacture.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeFacture.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ListeFacture.ThemeStyle.RowsStyle.Height = 28;
            this.ListeFacture.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListeFacture.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ListeFacture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeFacture_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Num";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Article";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prix";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantité";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // ListeArticles
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.ListeArticles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ListeArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListeArticles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(222)))));
            this.ListeArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListeArticles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListeArticles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListeArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ListeArticles.ColumnHeadersHeight = 30;
            this.ListeArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListeArticles.DefaultCellStyle = dataGridViewCellStyle12;
            this.ListeArticles.EnableHeadersVisualStyles = false;
            this.ListeArticles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListeArticles.Location = new System.Drawing.Point(44, 290);
            this.ListeArticles.Name = "ListeArticles";
            this.ListeArticles.ReadOnly = true;
            this.ListeArticles.RowHeadersVisible = false;
            this.ListeArticles.RowHeadersWidth = 51;
            this.ListeArticles.RowTemplate.Height = 28;
            this.ListeArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListeArticles.Size = new System.Drawing.Size(252, 153);
            this.ListeArticles.TabIndex = 26;
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
            this.ListeArticles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeArticles_CellContentClick);
            // 
            // ImprimerBtn
            // 
            this.ImprimerBtn.BackColor = System.Drawing.Color.Sienna;
            this.ImprimerBtn.ForeColor = System.Drawing.Color.White;
            this.ImprimerBtn.Location = new System.Drawing.Point(506, 392);
            this.ImprimerBtn.Name = "ImprimerBtn";
            this.ImprimerBtn.Size = new System.Drawing.Size(128, 44);
            this.ImprimerBtn.TabIndex = 25;
            this.ImprimerBtn.Text = "Imprimer";
            this.ImprimerBtn.UseVisualStyleBackColor = false;
            this.ImprimerBtn.Click += new System.EventHandler(this.ImprimerBtn_Click);
            // 
            // AjouterBtn
            // 
            this.AjouterBtn.BackColor = System.Drawing.Color.Sienna;
            this.AjouterBtn.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterBtn.ForeColor = System.Drawing.Color.White;
            this.AjouterBtn.Location = new System.Drawing.Point(44, 217);
            this.AjouterBtn.Name = "AjouterBtn";
            this.AjouterBtn.Size = new System.Drawing.Size(128, 44);
            this.AjouterBtn.TabIndex = 24;
            this.AjouterBtn.Text = "Ajouter à La Facture";
            this.AjouterBtn.UseVisualStyleBackColor = false;
            this.AjouterBtn.Click += new System.EventHandler(this.AjouterBtn_Click);
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.BackColor = System.Drawing.Color.Sienna;
            this.SupprimerBtn.ForeColor = System.Drawing.Color.White;
            this.SupprimerBtn.Location = new System.Drawing.Point(178, 217);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(128, 44);
            this.SupprimerBtn.TabIndex = 23;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = false;
            this.SupprimerBtn.Click += new System.EventHandler(this.ReinitaliserBtn_Click);
            // 
            // DateTb
            // 
            this.DateTb.BackColor = System.Drawing.Color.Sienna;
            this.DateTb.BaseColor = System.Drawing.Color.Sienna;
            this.DateTb.BorderColor = System.Drawing.Color.Sienna;
            this.DateTb.CustomFormat = null;
            this.DateTb.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTb.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTb.ForeColor = System.Drawing.Color.White;
            this.DateTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTb.Location = new System.Drawing.Point(178, 184);
            this.DateTb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTb.Name = "DateTb";
            this.DateTb.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateTb.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTb.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTb.OnPressedColor = System.Drawing.Color.Black;
            this.DateTb.Size = new System.Drawing.Size(128, 27);
            this.DateTb.TabIndex = 22;
            this.DateTb.Text = "27/04/2024";
            this.DateTb.Value = new System.DateTime(2024, 4, 27, 2, 35, 9, 0);
            // 
            // QuantitéTb
            // 
            this.QuantitéTb.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.QuantitéTb.Location = new System.Drawing.Point(44, 184);
            this.QuantitéTb.Name = "QuantitéTb";
            this.QuantitéTb.Size = new System.Drawing.Size(128, 27);
            this.QuantitéTb.TabIndex = 21;
            this.QuantitéTb.Text = "Quantité";
            // 
            // ClientTb
            // 
            this.ClientTb.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ClientTb.Location = new System.Drawing.Point(178, 151);
            this.ClientTb.Name = "ClientTb";
            this.ClientTb.Size = new System.Drawing.Size(128, 27);
            this.ClientTb.TabIndex = 20;
            this.ClientTb.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(486, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Facture Du Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(75, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Détails Des Catégories";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ArticleTb
            // 
            this.ArticleTb.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ArticleTb.Location = new System.Drawing.Point(44, 151);
            this.ArticleTb.Name = "ArticleTb";
            this.ArticleTb.Size = new System.Drawing.Size(128, 27);
            this.ArticleTb.TabIndex = 17;
            this.ArticleTb.Text = "Article";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(296, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Facturation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Système De Gestion D\'Un Café";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 22);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 75);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Déconnexion";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Factures";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Articles";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Categories";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(930, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(20, 30);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 30;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 230);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 304);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 470);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            // 
            // Factures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(956, 510);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Factures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factures";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeFacture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ArticleTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuantitéTb;
        private System.Windows.Forms.TextBox ClientTb;
        private System.Windows.Forms.Button SupprimerBtn;
        private System.Windows.Forms.Button AjouterBtn;
        private System.Windows.Forms.Button ImprimerBtn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDataGridView ListeFacture;
        private Guna.UI.WinForms.GunaDataGridView ListeArticles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label MontantLbl;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Guna.UI.WinForms.GunaDateTimePicker DateTb;
    }
}