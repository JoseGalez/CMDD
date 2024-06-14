namespace ControlDeEmbarque
{
    partial class FormAgregar
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
            this.lbid = new System.Windows.Forms.Label();
            this.lbPaisOrigen = new System.Windows.Forms.Label();
            this.lbpeso = new System.Windows.Forms.Label();
            this.duID = new System.Windows.Forms.DomainUpDown();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.duPeso = new System.Windows.Forms.DomainUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(215, 144);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(21, 13);
            this.lbid.TabIndex = 0;
            this.lbid.Text = "ID:";
            // 
            // lbPaisOrigen
            // 
            this.lbPaisOrigen.AutoSize = true;
            this.lbPaisOrigen.Location = new System.Drawing.Point(215, 194);
            this.lbPaisOrigen.Name = "lbPaisOrigen";
            this.lbPaisOrigen.Size = new System.Drawing.Size(74, 13);
            this.lbPaisOrigen.TabIndex = 1;
            this.lbPaisOrigen.Text = "Pais de origen";
            // 
            // lbpeso
            // 
            this.lbpeso.AutoSize = true;
            this.lbpeso.Location = new System.Drawing.Point(215, 230);
            this.lbpeso.Name = "lbpeso";
            this.lbpeso.Size = new System.Drawing.Size(31, 13);
            this.lbpeso.TabIndex = 2;
            this.lbpeso.Text = "Peso";
            // 
            // duID
            // 
            this.duID.Location = new System.Drawing.Point(304, 144);
            this.duID.MaximumSize = new System.Drawing.Size(999999, 0);
            this.duID.Name = "duID";
            this.duID.Size = new System.Drawing.Size(214, 20);
            this.duID.TabIndex = 3;
            // 
            // cbPais
            // 
            this.cbPais.AutoCompleteCustomSource.AddRange(new string[] {
            "Paris",
            "Brasil",
            "China",
            "Australia",
            "Canada",
            "Nada"});
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            "Paris",
            "Brasil",
            "China",
            "Australia",
            "Canada",
            "Nada"});
            this.cbPais.Location = new System.Drawing.Point(304, 188);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(214, 21);
            this.cbPais.TabIndex = 4;
            // 
            // duPeso
            // 
            this.duPeso.Location = new System.Drawing.Point(304, 230);
            this.duPeso.MaximumSize = new System.Drawing.Size(999999, 0);
            this.duPeso.Name = "duPeso";
            this.duPeso.Size = new System.Drawing.Size(214, 20);
            this.duPeso.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SeaShell;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Location = new System.Drawing.Point(313, 303);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(181, 50);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.duPeso);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.duID);
            this.Controls.Add(this.lbpeso);
            this.Controls.Add(this.lbPaisOrigen);
            this.Controls.Add(this.lbid);
            this.Name = "FormAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAgregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbPaisOrigen;
        private System.Windows.Forms.Label lbpeso;
        public System.Windows.Forms.DomainUpDown duID;
        public System.Windows.Forms.ComboBox cbPais;
        public System.Windows.Forms.DomainUpDown duPeso;
        public System.Windows.Forms.Button btnAgregar;
    }
}