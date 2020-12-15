namespace Irf_project
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.felhomeret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxfokDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minfokDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataListaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataListaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataListaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataListaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 652);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "Betöltés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(1018, 714);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumDataGridViewTextBoxColumn1,
            this.felhomeret,
            this.maxfokDataGridViewTextBoxColumn1,
            this.minfokDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.dataListaBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(50, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1659, 528);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(1013, 682);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Írd be, a törölni kívánt napot (20200101)- formátumban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nunito Light", 16F);
            this.label2.Location = new System.Drawing.Point(674, 590);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "Töltsd be a CSV file-t";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(217, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 55);
            this.label3.TabIndex = 11;
            this.label3.Text = "labelFok1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(573, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 55);
            this.label4.TabIndex = 12;
            this.label4.Text = "labelFok2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(1079, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 55);
            this.label5.TabIndex = 13;
            this.label5.Text = "labelFok3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(315, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1178, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 202);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nunito Black", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(668, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(391, 83);
            this.label6.TabIndex = 16;
            this.label6.Text = "Időjárás app";
            // 
            // felhomeret
            // 
            this.felhomeret.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.felhomeret.DataPropertyName = "felhomeret";
            this.felhomeret.HeaderText = "Felhőméret (%)";
            this.felhomeret.MinimumWidth = 8;
            this.felhomeret.Name = "felhomeret";
            // 
            // datumDataGridViewTextBoxColumn1
            // 
            this.datumDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumDataGridViewTextBoxColumn1.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn1.HeaderText = "Dátum";
            this.datumDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.datumDataGridViewTextBoxColumn1.Name = "datumDataGridViewTextBoxColumn1";
            // 
            // maxfokDataGridViewTextBoxColumn1
            // 
            this.maxfokDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maxfokDataGridViewTextBoxColumn1.DataPropertyName = "maxfok";
            this.maxfokDataGridViewTextBoxColumn1.HeaderText = "Maximum Fok (C)";
            this.maxfokDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.maxfokDataGridViewTextBoxColumn1.Name = "maxfokDataGridViewTextBoxColumn1";
            // 
            // minfokDataGridViewTextBoxColumn1
            // 
            this.minfokDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.minfokDataGridViewTextBoxColumn1.DataPropertyName = "minfok";
            this.minfokDataGridViewTextBoxColumn1.HeaderText = "Minimum Fok (C)";
            this.minfokDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.minfokDataGridViewTextBoxColumn1.Name = "minfokDataGridViewTextBoxColumn1";
            // 
            // dataListaBindingSource4
            // 
            this.dataListaBindingSource4.DataSource = typeof(Irf_project.dataLista);
            // 
            // dataListaBindingSource3
            // 
            this.dataListaBindingSource3.DataSource = typeof(Irf_project.dataLista);
            // 
            // dataListaBindingSource2
            // 
            this.dataListaBindingSource2.DataSource = typeof(Irf_project.dataLista);
            // 
            // dataListaBindingSource1
            // 
            this.dataListaBindingSource1.DataSource = typeof(Irf_project.dataLista);
            // 
            // dataListaBindingSource
            // 
            this.dataListaBindingSource.DataSource = typeof(Irf_project.dataLista);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Irf_project.Properties.Resources.miui_8_weather_background_minimal_hd_wallpaper_thumb;
            this.ClientSize = new System.Drawing.Size(1781, 1019);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataListaBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource dataListaBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn szelsebessegDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataListaBindingSource2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource dataListaBindingSource3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource dataListaBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn felhomeret;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxfokDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minfokDataGridViewTextBoxColumn1;
    }
}

