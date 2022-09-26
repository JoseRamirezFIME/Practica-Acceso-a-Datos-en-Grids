namespace appTestBD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtAccion = new System.Windows.Forms.TextBox();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnLlenarDataGrid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVariables = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.btnLlenarListView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtAccion
            // 
            this.txtAccion.Location = new System.Drawing.Point(14, 35);
            this.txtAccion.Name = "txtAccion";
            this.txtAccion.Size = new System.Drawing.Size(98, 20);
            this.txtAccion.TabIndex = 1;
            // 
            // btnConsultas
            // 
            this.btnConsultas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultas.FlatAppearance.BorderSize = 7;
            this.btnConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnConsultas.Location = new System.Drawing.Point(14, 97);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(98, 55);
            this.btnConsultas.TabIndex = 2;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(118, 97);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(115, 55);
            this.btnSeleccion.TabIndex = 3;
            this.btnSeleccion.Text = "Selects";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(518, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(302, 218);
            this.dataGridView1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(826, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(184, 219);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnLlenarDataGrid
            // 
            this.btnLlenarDataGrid.Location = new System.Drawing.Point(239, 97);
            this.btnLlenarDataGrid.Name = "btnLlenarDataGrid";
            this.btnLlenarDataGrid.Size = new System.Drawing.Size(118, 55);
            this.btnLlenarDataGrid.TabIndex = 7;
            this.btnLlenarDataGrid.Text = "Llenar DataGrid";
            this.btnLlenarDataGrid.UseVisualStyleBackColor = true;
            this.btnLlenarDataGrid.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Accion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Variables a Usar";
            // 
            // txtVariables
            // 
            this.txtVariables.Location = new System.Drawing.Point(130, 35);
            this.txtVariables.Name = "txtVariables";
            this.txtVariables.Size = new System.Drawing.Size(137, 20);
            this.txtVariables.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tabla a Utilizar";
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(290, 35);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(125, 20);
            this.txtTabla.TabIndex = 11;
            // 
            // btnLlenarListView
            // 
            this.btnLlenarListView.Location = new System.Drawing.Point(363, 97);
            this.btnLlenarListView.Name = "btnLlenarListView";
            this.btnLlenarListView.Size = new System.Drawing.Size(122, 55);
            this.btnLlenarListView.TabIndex = 13;
            this.btnLlenarListView.Text = "Llenar ListView";
            this.btnLlenarListView.UseVisualStyleBackColor = true;
            this.btnLlenarListView.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 249);
            this.Controls.Add(this.btnLlenarListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVariables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLlenarDataGrid);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.txtAccion);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtAccion;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnLlenarDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVariables;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Button btnLlenarListView;
    }
}

