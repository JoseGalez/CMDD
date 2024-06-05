namespace Guia10._1
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
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbBicicleta = new System.Windows.Forms.RadioButton();
            this.rbTransporte = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbMoto = new System.Windows.Forms.RadioButton();
            this.gbDistancia = new System.Windows.Forms.GroupBox();
            this.gbIngrese = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.gbLista = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnVerResultado = new System.Windows.Forms.Button();
            this.gbTipo.SuspendLayout();
            this.gbDistancia.SuspendLayout();
            this.gbIngrese.SuspendLayout();
            this.gbLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbMoto);
            this.gbTipo.Controls.Add(this.rbAuto);
            this.gbTipo.Controls.Add(this.rbTransporte);
            this.gbTipo.Controls.Add(this.rbBicicleta);
            this.gbTipo.Location = new System.Drawing.Point(7, 19);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(362, 206);
            this.gbTipo.TabIndex = 0;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo de transporte de uso mas frecuente";
            // 
            // rbBicicleta
            // 
            this.rbBicicleta.AutoSize = true;
            this.rbBicicleta.Location = new System.Drawing.Point(6, 36);
            this.rbBicicleta.Name = "rbBicicleta";
            this.rbBicicleta.Size = new System.Drawing.Size(65, 17);
            this.rbBicicleta.TabIndex = 0;
            this.rbBicicleta.TabStop = true;
            this.rbBicicleta.Text = "Bicicleta";
            this.rbBicicleta.UseVisualStyleBackColor = true;
            // 
            // rbTransporte
            // 
            this.rbTransporte.AutoSize = true;
            this.rbTransporte.Location = new System.Drawing.Point(6, 105);
            this.rbTransporte.Name = "rbTransporte";
            this.rbTransporte.Size = new System.Drawing.Size(216, 17);
            this.rbTransporte.TabIndex = 1;
            this.rbTransporte.TabStop = true;
            this.rbTransporte.Text = "Transporte publico (colectivo, remis, etc)";
            this.rbTransporte.UseVisualStyleBackColor = true;
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(6, 82);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(71, 17);
            this.rbAuto.TabIndex = 2;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Automovil";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // rbMoto
            // 
            this.rbMoto.AutoSize = true;
            this.rbMoto.Location = new System.Drawing.Point(6, 59);
            this.rbMoto.Name = "rbMoto";
            this.rbMoto.Size = new System.Drawing.Size(80, 17);
            this.rbMoto.TabIndex = 3;
            this.rbMoto.TabStop = true;
            this.rbMoto.Text = "Motocicleta";
            this.rbMoto.UseVisualStyleBackColor = true;
            // 
            // gbDistancia
            // 
            this.gbDistancia.Controls.Add(this.tbDistancia);
            this.gbDistancia.Location = new System.Drawing.Point(7, 246);
            this.gbDistancia.Name = "gbDistancia";
            this.gbDistancia.Size = new System.Drawing.Size(362, 88);
            this.gbDistancia.TabIndex = 1;
            this.gbDistancia.TabStop = false;
            this.gbDistancia.Text = "Distancia aproximada segun el vehiculo seleccionado";
            this.gbDistancia.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // gbIngrese
            // 
            this.gbIngrese.Controls.Add(this.btnRegistrar);
            this.gbIngrese.Controls.Add(this.gbDistancia);
            this.gbIngrese.Controls.Add(this.gbTipo);
            this.gbIngrese.Location = new System.Drawing.Point(12, 23);
            this.gbIngrese.Name = "gbIngrese";
            this.gbIngrese.Size = new System.Drawing.Size(543, 340);
            this.gbIngrese.TabIndex = 2;
            this.gbIngrese.TabStop = false;
            this.gbIngrese.Text = "Ingresar Numero";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(390, 80);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(126, 58);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar Encuesta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(45, 39);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(254, 20);
            this.tbDistancia.TabIndex = 0;
            // 
            // gbLista
            // 
            this.gbLista.Controls.Add(this.btnVerResultado);
            this.gbLista.Controls.Add(this.listBox1);
            this.gbLista.Location = new System.Drawing.Point(12, 369);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(543, 185);
            this.gbLista.TabIndex = 3;
            this.gbLista.TabStop = false;
            this.gbLista.Text = "Lista ordenada";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(509, 121);
            this.listBox1.TabIndex = 0;
            // 
            // btnVerResultado
            // 
            this.btnVerResultado.Location = new System.Drawing.Point(189, 146);
            this.btnVerResultado.Name = "btnVerResultado";
            this.btnVerResultado.Size = new System.Drawing.Size(128, 28);
            this.btnVerResultado.TabIndex = 1;
            this.btnVerResultado.Text = "Ver Resultados";
            this.btnVerResultado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 581);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.gbIngrese);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.gbDistancia.ResumeLayout(false);
            this.gbDistancia.PerformLayout();
            this.gbIngrese.ResumeLayout(false);
            this.gbLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbMoto;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.RadioButton rbTransporte;
        private System.Windows.Forms.RadioButton rbBicicleta;
        private System.Windows.Forms.GroupBox gbDistancia;
        private System.Windows.Forms.GroupBox gbIngrese;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.Button btnVerResultado;
        private System.Windows.Forms.ListBox listBox1;
    }
}

