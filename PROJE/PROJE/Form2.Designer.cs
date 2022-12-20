namespace PROJE
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diziFilmListeDataSet = new PROJE.DiziFilmListeDataSet();
            this.diziFilmListeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Adı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tür = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YayınTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diziFilmListeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diziFilmListeDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Film\\Dizi Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yenile";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(371, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Film\\Dizi Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(508, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Film\\Dizi Sil";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adı,
            this.Tür,
            this.Durum,
            this.Platform,
            this.YayınTarihi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 230);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // diziFilmListeDataSet
            // 
            this.diziFilmListeDataSet.DataSetName = "DiziFilmListeDataSet";
            this.diziFilmListeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diziFilmListeDataSetBindingSource
            // 
            this.diziFilmListeDataSetBindingSource.DataSource = this.diziFilmListeDataSet;
            this.diziFilmListeDataSetBindingSource.Position = 0;
            // 
            // Adı
            // 
            this.Adı.HeaderText = "Adı";
            this.Adı.Name = "Adı";
            // 
            // Tür
            // 
            this.Tür.HeaderText = "Tür";
            this.Tür.Name = "Tür";
            this.Tür.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tür.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Durum
            // 
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            this.Durum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Durum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Platform
            // 
            this.Platform.HeaderText = "Platform";
            this.Platform.Name = "Platform";
            // 
            // YayınTarihi
            // 
            this.YayınTarihi.HeaderText = "Yayın Tarihi";
            this.YayınTarihi.Name = "YayınTarihi";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(743, 380);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diziFilmListeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diziFilmListeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private DiziFilmListeDataSet diziFilmListeDataSet;
        private System.Windows.Forms.BindingSource diziFilmListeDataSetBindingSource;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tür;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn YayınTarihi;
    }
}