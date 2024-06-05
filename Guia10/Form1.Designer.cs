namespace Guia10
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
            this.btnAgregarNombre = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.gbIngresar = new System.Windows.Forms.GroupBox();
            this.tbIngresar = new System.Windows.Forms.TextBox();
            this.gbMostrar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.rbBinaria = new System.Windows.Forms.RadioButton();
            this.rbSecuencial = new System.Windows.Forms.RadioButton();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.gbLista = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbIngresar.SuspendLayout();
            this.gbMostrar.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            this.gbLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarNombre
            // 
            this.btnAgregarNombre.Location = new System.Drawing.Point(269, 19);
            this.btnAgregarNombre.Name = "btnAgregarNombre";
            this.btnAgregarNombre.Size = new System.Drawing.Size(75, 43);
            this.btnAgregarNombre.TabIndex = 0;
            this.btnAgregarNombre.Text = "Agregar Numero";
            this.btnAgregarNombre.UseVisualStyleBackColor = true;
            this.btnAgregarNombre.Click += new System.EventHandler(this.btnAgregarNombre_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(269, 19);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 42);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(132, 19);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(105, 29);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listrar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(269, 19);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 40);
            this.btnBusqueda.TabIndex = 3;
            this.btnBusqueda.Text = "Busqueda";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.button4_Click);
            // 
            // gbIngresar
            // 
            this.gbIngresar.Controls.Add(this.tbIngresar);
            this.gbIngresar.Controls.Add(this.btnAgregarNombre);
            this.gbIngresar.Location = new System.Drawing.Point(31, 58);
            this.gbIngresar.Name = "gbIngresar";
            this.gbIngresar.Size = new System.Drawing.Size(350, 100);
            this.gbIngresar.TabIndex = 4;
            this.gbIngresar.TabStop = false;
            this.gbIngresar.Text = "Ingresar Numero";
            // 
            // tbIngresar
            // 
            this.tbIngresar.Location = new System.Drawing.Point(60, 31);
            this.tbIngresar.Name = "tbIngresar";
            this.tbIngresar.Size = new System.Drawing.Size(141, 20);
            this.tbIngresar.TabIndex = 1;
            // 
            // gbMostrar
            // 
            this.gbMostrar.Controls.Add(this.label1);
            this.gbMostrar.Controls.Add(this.btnCalcular);
            this.gbMostrar.Location = new System.Drawing.Point(31, 175);
            this.gbMostrar.Name = "gbMostrar";
            this.gbMostrar.Size = new System.Drawing.Size(350, 92);
            this.gbMostrar.TabIndex = 5;
            this.gbMostrar.TabStop = false;
            this.gbMostrar.Text = "Mostrar Promedio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.rbBinaria);
            this.gbBusqueda.Controls.Add(this.rbSecuencial);
            this.gbBusqueda.Controls.Add(this.tbBusqueda);
            this.gbBusqueda.Controls.Add(this.btnBusqueda);
            this.gbBusqueda.Location = new System.Drawing.Point(31, 301);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(350, 119);
            this.gbBusqueda.TabIndex = 6;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda de numero";
            // 
            // rbBinaria
            // 
            this.rbBinaria.AutoSize = true;
            this.rbBinaria.Location = new System.Drawing.Point(70, 96);
            this.rbBinaria.Name = "rbBinaria";
            this.rbBinaria.Size = new System.Drawing.Size(57, 17);
            this.rbBinaria.TabIndex = 5;
            this.rbBinaria.TabStop = true;
            this.rbBinaria.Text = "Binaria";
            this.rbBinaria.UseVisualStyleBackColor = true;
            // 
            // rbSecuencial
            // 
            this.rbSecuencial.AutoSize = true;
            this.rbSecuencial.Location = new System.Drawing.Point(70, 73);
            this.rbSecuencial.Name = "rbSecuencial";
            this.rbSecuencial.Size = new System.Drawing.Size(78, 17);
            this.rbSecuencial.TabIndex = 4;
            this.rbSecuencial.TabStop = true;
            this.rbSecuencial.Text = "Secuencial";
            this.rbSecuencial.UseVisualStyleBackColor = true;
            this.rbSecuencial.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(70, 30);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(141, 20);
            this.tbBusqueda.TabIndex = 2;
            this.tbBusqueda.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // gbLista
            // 
            this.gbLista.Controls.Add(this.listBox1);
            this.gbLista.Controls.Add(this.btnListar);
            this.gbLista.Location = new System.Drawing.Point(533, 58);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(243, 343);
            this.gbLista.TabIndex = 7;
            this.gbLista.TabStop = false;
            this.gbLista.Text = "Lista Ordenada";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 316);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 452);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.gbMostrar);
            this.Controls.Add(this.gbIngresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbIngresar.ResumeLayout(false);
            this.gbIngresar.PerformLayout();
            this.gbMostrar.ResumeLayout(false);
            this.gbMostrar.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarNombre;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.GroupBox gbIngresar;
        private System.Windows.Forms.GroupBox gbMostrar;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.TextBox tbIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbBinaria;
        private System.Windows.Forms.RadioButton rbSecuencial;
    }
}

