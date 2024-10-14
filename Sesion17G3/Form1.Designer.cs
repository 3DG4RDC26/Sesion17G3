namespace Sesion17G3
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.tbID = new System.Windows.Forms.TextBox();
         this.tbName = new System.Windows.Forms.TextBox();
         this.tbPrice = new System.Windows.Forms.TextBox();
         this.gbDatos = new System.Windows.Forms.GroupBox();
         this.dgvRegistros = new System.Windows.Forms.DataGridView();
         this.tbDescripcion = new System.Windows.Forms.TextBox();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
         this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
         this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
         this.gbDatos.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
         this.toolStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(115, 77);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(97, 15);
         this.label1.TabIndex = 0;
         this.label1.Text = "Datos Generales";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(85, 111);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(49, 15);
         this.label2.TabIndex = 1;
         this.label2.Text = "Codigo:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(81, 149);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(52, 15);
         this.label3.TabIndex = 2;
         this.label3.Text = "Nombre:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(62, 187);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(74, 15);
         this.label4.TabIndex = 3;
         this.label4.Text = "Descripcion:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(88, 242);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(43, 15);
         this.label5.TabIndex = 4;
         this.label5.Text = "Precio:";
         // 
         // tbID
         // 
         this.tbID.Location = new System.Drawing.Point(148, 108);
         this.tbID.Name = "tbID";
         this.tbID.Size = new System.Drawing.Size(100, 20);
         this.tbID.TabIndex = 5;
         // 
         // tbName
         // 
         this.tbName.Location = new System.Drawing.Point(148, 149);
         this.tbName.Name = "tbName";
         this.tbName.Size = new System.Drawing.Size(100, 20);
         this.tbName.TabIndex = 6;
         // 
         // tbPrice
         // 
         this.tbPrice.Location = new System.Drawing.Point(148, 239);
         this.tbPrice.Name = "tbPrice";
         this.tbPrice.Size = new System.Drawing.Size(100, 20);
         this.tbPrice.TabIndex = 7;
         // 
         // gbDatos
         // 
         this.gbDatos.Controls.Add(this.dgvRegistros);
         this.gbDatos.Location = new System.Drawing.Point(65, 282);
         this.gbDatos.Name = "gbDatos";
         this.gbDatos.Size = new System.Drawing.Size(489, 156);
         this.gbDatos.TabIndex = 8;
         this.gbDatos.TabStop = false;
         this.gbDatos.Text = "Registros de Datos";
         // 
         // dgvRegistros
         // 
         this.dgvRegistros.AllowUserToAddRows = false;
         this.dgvRegistros.AllowUserToDeleteRows = false;
         this.dgvRegistros.AllowUserToOrderColumns = true;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
         this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dgvRegistros.Location = new System.Drawing.Point(3, 16);
         this.dgvRegistros.Name = "dgvRegistros";
         this.dgvRegistros.ReadOnly = true;
         this.dgvRegistros.Size = new System.Drawing.Size(483, 137);
         this.dgvRegistros.TabIndex = 0;
         // 
         // tbDescripcion
         // 
         this.tbDescripcion.Location = new System.Drawing.Point(148, 187);
         this.tbDescripcion.Multiline = true;
         this.tbDescripcion.Name = "tbDescripcion";
         this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.tbDescripcion.Size = new System.Drawing.Size(100, 33);
         this.tbDescripcion.TabIndex = 9;
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbEliminar,
            this.tsbActualizar});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(651, 25);
         this.toolStrip1.TabIndex = 10;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // tsbAgregar
         // 
         this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.tsbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgregar.Image")));
         this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.tsbAgregar.Name = "tsbAgregar";
         this.tsbAgregar.Size = new System.Drawing.Size(23, 22);
         this.tsbAgregar.Text = "toolStripButton1";
         this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
         // 
         // tsbEliminar
         // 
         this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
         this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.tsbEliminar.Name = "tsbEliminar";
         this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
         this.tsbEliminar.Text = "toolStripButton2";
         // 
         // tsbActualizar
         // 
         this.tsbActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.tsbActualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsbActualizar.Image")));
         this.tsbActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.tsbActualizar.Name = "tsbActualizar";
         this.tsbActualizar.Size = new System.Drawing.Size(23, 22);
         this.tsbActualizar.Text = "toolStripButton3";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(651, 503);
         this.Controls.Add(this.toolStrip1);
         this.Controls.Add(this.tbDescripcion);
         this.Controls.Add(this.gbDatos);
         this.Controls.Add(this.tbPrice);
         this.Controls.Add(this.tbName);
         this.Controls.Add(this.tbID);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.gbDatos.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox tbID;
      private System.Windows.Forms.TextBox tbName;
      private System.Windows.Forms.TextBox tbPrice;
      private System.Windows.Forms.GroupBox gbDatos;
      private System.Windows.Forms.DataGridView dgvRegistros;
      private System.Windows.Forms.TextBox tbDescripcion;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton tsbAgregar;
      private System.Windows.Forms.ToolStripButton tsbEliminar;
      private System.Windows.Forms.ToolStripButton tsbActualizar;
   }
}

