﻿namespace Ejercicio1
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
            this.tbxResultados = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxResultados
            // 
            this.tbxResultados.Location = new System.Drawing.Point(61, 67);
            this.tbxResultados.Multiline = true;
            this.tbxResultados.Name = "tbxResultados";
            this.tbxResultados.Size = new System.Drawing.Size(338, 244);
            this.tbxResultados.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(440, 82);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(143, 91);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 388);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.tbxResultados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxResultados;
        private System.Windows.Forms.Button btnListar;
    }
}

