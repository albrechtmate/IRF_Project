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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataListaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataListaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.datumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxfokDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minfokDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szelsebessegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "Betöltés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1062, 701);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(437, 102);
            this.button2.TabIndex = 1;
            this.button2.Text = "Megjelenítés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(26, 701);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(354, 102);
            this.button3.TabIndex = 3;
            this.button3.Text = "Törlés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(118, 661);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumDataGridViewTextBoxColumn1,
            this.maxfokDataGridViewTextBoxColumn1,
            this.minfokDataGridViewTextBoxColumn1,
            this.szelsebessegDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataListaBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1663, 600);
            this.dataGridView1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(662, 898);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(328, 88);
            this.button4.TabIndex = 6;
            this.button4.Text = "Exportálás";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(571, 847);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Írd be, a törölni kívánt napot (20200101)- formátumban";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(671, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Töltsd be a CSV file-t";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1178, 850);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(309, 116);
            this.button6.TabIndex = 10;
            this.button6.Text = "Kirajzolás";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(168, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 55);
            this.label3.TabIndex = 11;
            this.label3.Text = "labelFok1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(500, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 55);
            this.label4.TabIndex = 12;
            this.label4.Text = "labelFok2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(800, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 55);
            this.label5.TabIndex = 13;
            this.label5.Text = "labelFok3";
            // 
            // dataListaBindingSource1
            // 
            this.dataListaBindingSource1.DataSource = typeof(Irf_project.dataLista);
            // 
            // dataListaBindingSource
            // 
            this.dataListaBindingSource.DataSource = typeof(Irf_project.dataLista);
            // 
            // dataListaBindingSource2
            // 
            this.dataListaBindingSource2.DataSource = typeof(Irf_project.dataLista);
            // 
            // datumDataGridViewTextBoxColumn1
            // 
            this.datumDataGridViewTextBoxColumn1.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn1.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.datumDataGridViewTextBoxColumn1.Name = "datumDataGridViewTextBoxColumn1";
            this.datumDataGridViewTextBoxColumn1.Width = 150;
            // 
            // maxfokDataGridViewTextBoxColumn1
            // 
            this.maxfokDataGridViewTextBoxColumn1.DataPropertyName = "maxfok";
            this.maxfokDataGridViewTextBoxColumn1.HeaderText = "maxfok";
            this.maxfokDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.maxfokDataGridViewTextBoxColumn1.Name = "maxfokDataGridViewTextBoxColumn1";
            this.maxfokDataGridViewTextBoxColumn1.Width = 150;
            // 
            // minfokDataGridViewTextBoxColumn1
            // 
            this.minfokDataGridViewTextBoxColumn1.DataPropertyName = "minfok";
            this.minfokDataGridViewTextBoxColumn1.HeaderText = "minfok";
            this.minfokDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.minfokDataGridViewTextBoxColumn1.Name = "minfokDataGridViewTextBoxColumn1";
            this.minfokDataGridViewTextBoxColumn1.Width = 150;
            // 
            // szelsebessegDataGridViewTextBoxColumn
            // 
            this.szelsebessegDataGridViewTextBoxColumn.DataPropertyName = "szelsebesseg";
            this.szelsebessegDataGridViewTextBoxColumn.HeaderText = "szelsebesseg";
            this.szelsebessegDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.szelsebessegDataGridViewTextBoxColumn.Name = "szelsebessegDataGridViewTextBoxColumn";
            this.szelsebessegDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Irf_project.Properties.Resources.idojaras_appok_nyitokep_V2_opt;
            this.ClientSize = new System.Drawing.Size(1670, 1019);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataListaBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource dataListaBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxfokDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minfokDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn szelsebessegDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataListaBindingSource2;
    }
}

