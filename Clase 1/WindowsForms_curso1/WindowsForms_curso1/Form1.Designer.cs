namespace WindowsForms_curso1
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
            this.buttonSaludar = new System.Windows.Forms.Button();
            this.textBoxSaludo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSaludar
            // 
            this.buttonSaludar.Location = new System.Drawing.Point(204, 95);
            this.buttonSaludar.Name = "buttonSaludar";
            this.buttonSaludar.Size = new System.Drawing.Size(75, 23);
            this.buttonSaludar.TabIndex = 0;
            this.buttonSaludar.Text = "button";
            this.buttonSaludar.UseVisualStyleBackColor = true;
            this.buttonSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSaludo
            // 
            this.textBoxSaludo.Location = new System.Drawing.Point(195, 197);
            this.textBoxSaludo.Name = "textBoxSaludo";
            this.textBoxSaludo.Size = new System.Drawing.Size(100, 20);
            this.textBoxSaludo.TabIndex = 1;
            this.textBoxSaludo.TextChanged += new System.EventHandler(this.textBoxSaludo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 280);
            this.Controls.Add(this.textBoxSaludo);
            this.Controls.Add(this.buttonSaludar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaludar;
        private System.Windows.Forms.TextBox textBoxSaludo;
    }
}

