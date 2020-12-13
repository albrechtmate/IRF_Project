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
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxfokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minfokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kozepfokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felhotakaroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataListaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1191, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "Betöltés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1191, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 88);
            this.button2.TabIndex = 1;
            this.button2.Text = "Megjelenítés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1191, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 88);
            this.button3.TabIndex = 3;
            this.button3.Text = "Törlés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1021, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 26);
            this.textBox1.TabIndex = 4;
            // 
            // bindingSource3
            // 
           
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumDataGridViewTextBoxColumn,
            this.maxfokDataGridViewTextBoxColumn,
            this.minfokDataGridViewTextBoxColumn,
            this.kozepfokDataGridViewTextBoxColumn,
            this.felhotakaroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataListaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(70, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(869, 366);
            this.dataGridView1.TabIndex = 5;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 150;
            // 
            // maxfokDataGridViewTextBoxColumn
            // 
            this.maxfokDataGridViewTextBoxColumn.DataPropertyName = "maxfok";
            this.maxfokDataGridViewTextBoxColumn.HeaderText = "maxfok";
            this.maxfokDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maxfokDataGridViewTextBoxColumn.Name = "maxfokDataGridViewTextBoxColumn";
            this.maxfokDataGridViewTextBoxColumn.Width = 150;
            // 
            // minfokDataGridViewTextBoxColumn
            // 
            this.minfokDataGridViewTextBoxColumn.DataPropertyName = "minfok";
            this.minfokDataGridViewTextBoxColumn.HeaderText = "minfok";
            this.minfokDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.minfokDataGridViewTextBoxColumn.Name = "minfokDataGridViewTextBoxColumn";
            this.minfokDataGridViewTextBoxColumn.Width = 150;
            // 
            // kozepfokDataGridViewTextBoxColumn
            // 
            this.kozepfokDataGridViewTextBoxColumn.DataPropertyName = "kozepfok";
            this.kozepfokDataGridViewTextBoxColumn.HeaderText = "kozepfok";
            this.kozepfokDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kozepfokDataGridViewTextBoxColumn.Name = "kozepfokDataGridViewTextBoxColumn";
            this.kozepfokDataGridViewTextBoxColumn.Width = 150;
            // 
            // felhotakaroDataGridViewTextBoxColumn
            // 
            this.felhotakaroDataGridViewTextBoxColumn.DataPropertyName = "felhotakaro";
            this.felhotakaroDataGridViewTextBoxColumn.HeaderText = "felhotakaro";
            this.felhotakaroDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.felhotakaroDataGridViewTextBoxColumn.Name = "felhotakaroDataGridViewTextBoxColumn";
            this.felhotakaroDataGridViewTextBoxColumn.Width = 150;
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
            this.ClientSize = new System.Drawing.Size(2053, 900);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource dataListaBindingSource;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.BindingSource bindingSource4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxfokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minfokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kozepfokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn felhotakaroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataListaBindingSource1;
    }
}

