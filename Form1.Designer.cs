namespace Compilador_2021
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.convertirAMayúsculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertirAMinúsculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarCtrlSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarCtrlSToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerCtrlSToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerCtrlSToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.CompilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoDelSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(559, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(513, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Filas:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(0, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(590, 267);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertirAMayúsculasToolStripMenuItem,
            this.convertirAMinúsculasToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 48);
            // 
            // convertirAMayúsculasToolStripMenuItem
            // 
            this.convertirAMayúsculasToolStripMenuItem.Name = "convertirAMayúsculasToolStripMenuItem";
            this.convertirAMayúsculasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.convertirAMayúsculasToolStripMenuItem.Text = "Convertir a Mayúsculas";
            this.convertirAMayúsculasToolStripMenuItem.Click += new System.EventHandler(this.convertirAMayúsculasToolStripMenuItem_Click);
            // 
            // convertirAMinúsculasToolStripMenuItem
            // 
            this.convertirAMinúsculasToolStripMenuItem.Name = "convertirAMinúsculasToolStripMenuItem";
            this.convertirAMinúsculasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.convertirAMinúsculasToolStripMenuItem.Text = "Convertir a Minúsculas";
            this.convertirAMinúsculasToolStripMenuItem.Click += new System.EventHandler(this.convertirAMinúsculasToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(635, -102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "ANALIZADOR LÉXICO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.CompilaToolStripMenuItem,
            this.acercaDeToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoCtrlSToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.archivoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Gray;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.guardarToolStripMenuItem.Text = "Guardar                      Ctrl+S";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoCtrlSToolStripMenuItem
            // 
            this.guardarComoCtrlSToolStripMenuItem.Name = "guardarComoCtrlSToolStripMenuItem";
            this.guardarComoCtrlSToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.guardarComoCtrlSToolStripMenuItem.Text = "Guardar Como          Ctrl+D";
            this.guardarComoCtrlSToolStripMenuItem.Click += new System.EventHandler(this.guardarComoCtrlSToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarCtrlSToolStripMenuItem,
            this.pegarCtrlSToolStripMenuItem1,
            this.cortarCtrlSToolStripMenuItem2,
            this.deshacerCtrlSToolStripMenuItem3,
            this.rehacerCtrlSToolStripMenuItem4});
            this.ediciónToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ediciónToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Gray;
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // copiarCtrlSToolStripMenuItem
            // 
            this.copiarCtrlSToolStripMenuItem.Name = "copiarCtrlSToolStripMenuItem";
            this.copiarCtrlSToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.copiarCtrlSToolStripMenuItem.Text = "Copiar                    Ctrl+C";
            this.copiarCtrlSToolStripMenuItem.Click += new System.EventHandler(this.copiarCtrlSToolStripMenuItem_Click);
            // 
            // pegarCtrlSToolStripMenuItem1
            // 
            this.pegarCtrlSToolStripMenuItem1.Name = "pegarCtrlSToolStripMenuItem1";
            this.pegarCtrlSToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.pegarCtrlSToolStripMenuItem1.Text = "Pegar                      Ctrl+V";
            this.pegarCtrlSToolStripMenuItem1.Click += new System.EventHandler(this.pegarCtrlSToolStripMenuItem1_Click);
            // 
            // cortarCtrlSToolStripMenuItem2
            // 
            this.cortarCtrlSToolStripMenuItem2.Name = "cortarCtrlSToolStripMenuItem2";
            this.cortarCtrlSToolStripMenuItem2.Size = new System.Drawing.Size(208, 22);
            this.cortarCtrlSToolStripMenuItem2.Text = "Cortar                     Ctrl+O";
            this.cortarCtrlSToolStripMenuItem2.Click += new System.EventHandler(this.cortarCtrlSToolStripMenuItem2_Click);
            // 
            // deshacerCtrlSToolStripMenuItem3
            // 
            this.deshacerCtrlSToolStripMenuItem3.Name = "deshacerCtrlSToolStripMenuItem3";
            this.deshacerCtrlSToolStripMenuItem3.Size = new System.Drawing.Size(208, 22);
            this.deshacerCtrlSToolStripMenuItem3.Text = "Deshacer                Ctrl+M";
            this.deshacerCtrlSToolStripMenuItem3.Click += new System.EventHandler(this.deshacerCtrlSToolStripMenuItem3_Click);
            // 
            // rehacerCtrlSToolStripMenuItem4
            // 
            this.rehacerCtrlSToolStripMenuItem4.Name = "rehacerCtrlSToolStripMenuItem4";
            this.rehacerCtrlSToolStripMenuItem4.Size = new System.Drawing.Size(208, 22);
            this.rehacerCtrlSToolStripMenuItem4.Text = "Rehacer                  Ctrl+R";
            this.rehacerCtrlSToolStripMenuItem4.Click += new System.EventHandler(this.rehacerCtrlSToolStripMenuItem4_Click);
            // 
            // CompilaToolStripMenuItem
            // 
            this.CompilaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.CompilaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Gray;
            this.CompilaToolStripMenuItem.Name = "CompilaToolStripMenuItem";
            this.CompilaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.CompilaToolStripMenuItem.Text = "Compilar";
            this.CompilaToolStripMenuItem.Click += new System.EventHandler(this.CompilaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoDelSoftwareToolStripMenuItem});
            this.acercaDeToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.acercaDeToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Gray;
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de...";
            // 
            // codigoDelSoftwareToolStripMenuItem
            // 
            this.codigoDelSoftwareToolStripMenuItem.Name = "codigoDelSoftwareToolStripMenuItem";
            this.codigoDelSoftwareToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.codigoDelSoftwareToolStripMenuItem.Text = "Codigo del Software";
            this.codigoDelSoftwareToolStripMenuItem.Click += new System.EventHandler(this.codigoDelSoftwareToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Caviar Dreams", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "RESULTADO DE ANALIZADOR:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView2.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView2.Location = new System.Drawing.Point(0, 319);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(590, 249);
            this.dataGridView2.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ESTRUCTURA";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DETALLE";
            this.Column2.MinimumWidth = 460;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 460;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4});
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(591, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.Size = new System.Drawing.Size(383, 541);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.Visible = false;
            // 
            // c1
            // 
            this.c1.HeaderText = "LEXEMA";
            this.c1.MinimumWidth = 50;
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Width = 150;
            // 
            // c2
            // 
            this.c2.HeaderText = "TOKEN";
            this.c2.MinimumWidth = 50;
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            // 
            // c3
            // 
            this.c3.HeaderText = "LINEA";
            this.c3.MinimumWidth = 50;
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c3.Width = 50;
            // 
            // c4
            // 
            this.c4.HeaderText = "COLUMNA";
            this.c4.MinimumWidth = 65;
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            this.c4.Width = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 25);
            this.panel1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(693, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "ANALIZADOR LÉXICO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarCtrlSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cortarCtrlSToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deshacerCtrlSToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem rehacerCtrlSToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem CompilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem convertirAMayúsculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertirAMinúsculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoDelSoftwareToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

