namespace ControlDeEmbarque
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
            this.btnVerListado = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.lbID = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerListado
            // 
            this.btnVerListado.Location = new System.Drawing.Point(416, 90);
            this.btnVerListado.Name = "btnVerListado";
            this.btnVerListado.Size = new System.Drawing.Size(264, 59);
            this.btnVerListado.TabIndex = 0;
            this.btnVerListado.Text = "Ver Listado";
            this.btnVerListado.UseVisualStyleBackColor = true;
            this.btnVerListado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(133, 90);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(224, 59);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(327, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(271, 78);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.tbBuscar);
            this.gbBuscar.Controls.Add(this.lbID);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Location = new System.Drawing.Point(82, 216);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(621, 215);
            this.gbBuscar.TabIndex = 3;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Ver informacion del contenedor";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(48, 83);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 13);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "Pais";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(101, 76);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(193, 20);
            this.tbBuscar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 454);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVerListado);
            this.Name = "Form1";
            this.Text = "Buque de Guerra";
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerListado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label lbID;
    }
}

