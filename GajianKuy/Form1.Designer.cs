namespace GajianKuy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbLogo = new PictureBox();
            labelTitle = new Label();
            labelSubtitle = new Label();
            gbDataDeveloper = new GroupBox();
            cbStatusKontrak = new ComboBox();
            cbPilihProyek = new ComboBox();
            tbNama = new TextBox();
            labelStatusKontrak = new Label();
            labelPilihProyek = new Label();
            labelNama = new Label();
            gbDataKinerja = new GroupBox();
            tbFiturSelesai = new TextBox();
            labelJumlahBug = new Label();
            labelFiturSelesai = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            gbPerforma = new GroupBox();
            dgPerforma = new DataGridView();
            tbJumlahBug = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbDataDeveloper.SuspendLayout();
            gbDataKinerja.SuspendLayout();
            gbPerforma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPerforma).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(256, 87);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Magneto", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelTitle.Location = new Point(419, 23);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(200, 41);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "GajianKuy";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubtitle.Location = new Point(390, 64);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(260, 18);
            labelSubtitle.TabIndex = 2;
            labelSubtitle.Text = "Developer Team Performance Tracker";
            labelSubtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // gbDataDeveloper
            // 
            gbDataDeveloper.Controls.Add(cbStatusKontrak);
            gbDataDeveloper.Controls.Add(cbPilihProyek);
            gbDataDeveloper.Controls.Add(tbNama);
            gbDataDeveloper.Controls.Add(labelStatusKontrak);
            gbDataDeveloper.Controls.Add(labelPilihProyek);
            gbDataDeveloper.Controls.Add(labelNama);
            gbDataDeveloper.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbDataDeveloper.Location = new Point(12, 105);
            gbDataDeveloper.Name = "gbDataDeveloper";
            gbDataDeveloper.Size = new Size(776, 126);
            gbDataDeveloper.TabIndex = 3;
            gbDataDeveloper.TabStop = false;
            gbDataDeveloper.Text = "Data Developer";
            // 
            // cbStatusKontrak
            // 
            cbStatusKontrak.FormattingEnabled = true;
            cbStatusKontrak.Location = new Point(118, 82);
            cbStatusKontrak.Name = "cbStatusKontrak";
            cbStatusKontrak.Size = new Size(436, 26);
            cbStatusKontrak.TabIndex = 5;
            // 
            // cbPilihProyek
            // 
            cbPilihProyek.FormattingEnabled = true;
            cbPilihProyek.Location = new Point(118, 50);
            cbPilihProyek.Name = "cbPilihProyek";
            cbPilihProyek.Size = new Size(436, 26);
            cbPilihProyek.TabIndex = 4;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(118, 19);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(436, 25);
            tbNama.TabIndex = 3;
            // 
            // labelStatusKontrak
            // 
            labelStatusKontrak.AutoSize = true;
            labelStatusKontrak.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatusKontrak.Location = new Point(6, 88);
            labelStatusKontrak.Name = "labelStatusKontrak";
            labelStatusKontrak.Size = new Size(89, 15);
            labelStatusKontrak.TabIndex = 2;
            labelStatusKontrak.Text = "Status Kontrak:";
            // 
            // labelPilihProyek
            // 
            labelPilihProyek.AutoSize = true;
            labelPilihProyek.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPilihProyek.Location = new Point(6, 56);
            labelPilihProyek.Name = "labelPilihProyek";
            labelPilihProyek.Size = new Size(72, 15);
            labelPilihProyek.TabIndex = 1;
            labelPilihProyek.Text = "Pilih Proyek:";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelNama.Location = new Point(6, 25);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(43, 15);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama:";
            // 
            // gbDataKinerja
            // 
            gbDataKinerja.Controls.Add(tbJumlahBug);
            gbDataKinerja.Controls.Add(tbFiturSelesai);
            gbDataKinerja.Controls.Add(labelJumlahBug);
            gbDataKinerja.Controls.Add(labelFiturSelesai);
            gbDataKinerja.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbDataKinerja.Location = new Point(12, 237);
            gbDataKinerja.Name = "gbDataKinerja";
            gbDataKinerja.Size = new Size(776, 89);
            gbDataKinerja.TabIndex = 6;
            gbDataKinerja.TabStop = false;
            gbDataKinerja.Text = "Data Kinerja";
            // 
            // tbFiturSelesai
            // 
            tbFiturSelesai.Location = new Point(118, 19);
            tbFiturSelesai.Name = "tbFiturSelesai";
            tbFiturSelesai.Size = new Size(436, 25);
            tbFiturSelesai.TabIndex = 3;
            // 
            // labelJumlahBug
            // 
            labelJumlahBug.AutoSize = true;
            labelJumlahBug.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelJumlahBug.Location = new Point(6, 56);
            labelJumlahBug.Name = "labelJumlahBug";
            labelJumlahBug.Size = new Size(71, 15);
            labelJumlahBug.TabIndex = 1;
            labelJumlahBug.Text = "Jumlah Bug:";
            // 
            // labelFiturSelesai
            // 
            labelFiturSelesai.AutoSize = true;
            labelFiturSelesai.Font = new Font("Berlin Sans FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelFiturSelesai.Location = new Point(6, 25);
            labelFiturSelesai.Name = "labelFiturSelesai";
            labelFiturSelesai.Size = new Size(70, 15);
            labelFiturSelesai.TabIndex = 0;
            labelFiturSelesai.Text = "Fitur Selesai:";
            // 
            // btnInsert
            // 
            btnInsert.AutoSize = true;
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(18, 332);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 28);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(99, 332);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 28);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ControlLight;
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(180, 332);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 28);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // gbPerforma
            // 
            gbPerforma.Controls.Add(dgPerforma);
            gbPerforma.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbPerforma.Location = new Point(18, 366);
            gbPerforma.Name = "gbPerforma";
            gbPerforma.Size = new Size(770, 199);
            gbPerforma.TabIndex = 10;
            gbPerforma.TabStop = false;
            gbPerforma.Text = "Daftar Performa Tim";
            // 
            // dgPerforma
            // 
            dgPerforma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPerforma.Location = new Point(10, 24);
            dgPerforma.Name = "dgPerforma";
            dgPerforma.RowTemplate.Height = 25;
            dgPerforma.Size = new Size(754, 169);
            dgPerforma.TabIndex = 0;
            // 
            // tbJumlahBug
            // 
            tbJumlahBug.Location = new Point(118, 50);
            tbJumlahBug.Name = "tbJumlahBug";
            tbJumlahBug.Size = new Size(436, 25);
            tbJumlahBug.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 577);
            Controls.Add(gbPerforma);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(gbDataKinerja);
            Controls.Add(gbDataDeveloper);
            Controls.Add(labelSubtitle);
            Controls.Add(labelTitle);
            Controls.Add(pbLogo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbDataDeveloper.ResumeLayout(false);
            gbDataDeveloper.PerformLayout();
            gbDataKinerja.ResumeLayout(false);
            gbDataKinerja.PerformLayout();
            gbPerforma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPerforma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label labelTitle;
        private Label labelSubtitle;
        private GroupBox gbDataDeveloper;
        private TextBox tbNama;
        private Label labelStatusKontrak;
        private Label labelPilihProyek;
        private Label labelNama;
        private ComboBox cbStatusKontrak;
        private ComboBox cbPilihProyek;
        private GroupBox gbDataKinerja;
        private TextBox tbFiturSelesai;
        private Label labelJumlahBug;
        private Label labelFiturSelesai;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox gbPerforma;
        private DataGridView dgPerforma;
        private TextBox tbJumlahBug;
    }
}