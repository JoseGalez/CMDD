﻿namespace ControlDeEmbarque
{
    partial class FormBuscar
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
            this.lbBuscar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbBuscar
            // 
            this.lbBuscar.FormattingEnabled = true;
            this.lbBuscar.Location = new System.Drawing.Point(26, 24);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(324, 264);
            this.lbBuscar.TabIndex = 0;
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 367);
            this.Controls.Add(this.lbBuscar);
            this.Name = "FormBuscar";
            this.Text = "FormBuscar";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbBuscar;
    }
}