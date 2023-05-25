namespace Registro_de_visitas_proyecto_final
{
    partial class visitas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visitas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
       
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARRERADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDIFICIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORADEENTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORADESALIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOTIVODEVISITADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cODIGODataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.aPELLIDODataGridViewTextBoxColumn,
            this.cARRERADataGridViewTextBoxColumn,
            this.eDIFICIODataGridViewTextBoxColumn,
            this.hORADEENTRADADataGridViewTextBoxColumn,
            this.hORADESALIDADataGridViewTextBoxColumn,
            this.mOTIVODEVISITADataGridViewTextBoxColumn,
            this.aULADataGridViewTextBoxColumn});
            
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(-22, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 167);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rEGISTRO_VISITADataSet
            // 
           
            // 
            // rEGISTROVBindingSource
            // 
           
            // 
            // rEGISTROVTableAdapter
            // 
          
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            this.cODIGODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // aPELLIDODataGridViewTextBoxColumn
            // 
            this.aPELLIDODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.HeaderText = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.Name = "aPELLIDODataGridViewTextBoxColumn";
            // 
            // cARRERADataGridViewTextBoxColumn
            // 
            this.cARRERADataGridViewTextBoxColumn.DataPropertyName = "CARRERA";
            this.cARRERADataGridViewTextBoxColumn.HeaderText = "CARRERA";
            this.cARRERADataGridViewTextBoxColumn.Name = "cARRERADataGridViewTextBoxColumn";
            // 
            // eDIFICIODataGridViewTextBoxColumn
            // 
            this.eDIFICIODataGridViewTextBoxColumn.DataPropertyName = "EDIFICIO";
            this.eDIFICIODataGridViewTextBoxColumn.HeaderText = "EDIFICIO";
            this.eDIFICIODataGridViewTextBoxColumn.Name = "eDIFICIODataGridViewTextBoxColumn";
            // 
            // hORADEENTRADADataGridViewTextBoxColumn
            // 
            this.hORADEENTRADADataGridViewTextBoxColumn.DataPropertyName = "HORADEENTRADA";
            this.hORADEENTRADADataGridViewTextBoxColumn.HeaderText = "HORADEENTRADA";
            this.hORADEENTRADADataGridViewTextBoxColumn.Name = "hORADEENTRADADataGridViewTextBoxColumn";
            // 
            // hORADESALIDADataGridViewTextBoxColumn
            // 
            this.hORADESALIDADataGridViewTextBoxColumn.DataPropertyName = "HORADESALIDA";
            this.hORADESALIDADataGridViewTextBoxColumn.HeaderText = "HORADESALIDA";
            this.hORADESALIDADataGridViewTextBoxColumn.Name = "hORADESALIDADataGridViewTextBoxColumn";
            // 
            // mOTIVODEVISITADataGridViewTextBoxColumn
            // 
            this.mOTIVODEVISITADataGridViewTextBoxColumn.DataPropertyName = "MOTIVODEVISITA";
            this.mOTIVODEVISITADataGridViewTextBoxColumn.HeaderText = "MOTIVODEVISITA";
            this.mOTIVODEVISITADataGridViewTextBoxColumn.Name = "mOTIVODEVISITADataGridViewTextBoxColumn";
            // 
            // aULADataGridViewTextBoxColumn
            // 
            this.aULADataGridViewTextBoxColumn.DataPropertyName = "AULA";
            this.aULADataGridViewTextBoxColumn.HeaderText = "AULA";
            this.aULADataGridViewTextBoxColumn.Name = "aULADataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(362, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 125);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(131, 393);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 34);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // visitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "visitas";
            this.Text = "Visitas";
            this.Load += new System.EventHandler(this.visitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        
 
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARRERADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDIFICIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORADEENTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORADESALIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTIVODEVISITADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aULADataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEliminar;
    }
}