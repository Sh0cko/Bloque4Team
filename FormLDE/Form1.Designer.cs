namespace FormLDE
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ConectButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DesconectButton = new System.Windows.Forms.Button();
            this.TxtBoxMensaje = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // ConectButton
            // 
            this.ConectButton.Location = new System.Drawing.Point(370, 10);
            this.ConectButton.Name = "ConectButton";
            this.ConectButton.Size = new System.Drawing.Size(75, 23);
            this.ConectButton.TabIndex = 1;
            this.ConectButton.Text = "Conectar";
            this.ConectButton.UseVisualStyleBackColor = true;
            this.ConectButton.Click += new System.EventHandler(this.ConectButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(667, 10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Salir";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DesconectButton
            // 
            this.DesconectButton.Location = new System.Drawing.Point(513, 10);
            this.DesconectButton.Name = "DesconectButton";
            this.DesconectButton.Size = new System.Drawing.Size(88, 23);
            this.DesconectButton.TabIndex = 3;
            this.DesconectButton.Text = "Desconectar";
            this.DesconectButton.UseVisualStyleBackColor = true;
            // 
            // TxtBoxMensaje
            // 
            this.TxtBoxMensaje.Location = new System.Drawing.Point(30, 284);
            this.TxtBoxMensaje.Multiline = true;
            this.TxtBoxMensaje.Name = "TxtBoxMensaje";
            this.TxtBoxMensaje.Size = new System.Drawing.Size(740, 141);
            this.TxtBoxMensaje.TabIndex = 4;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(258, 255);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Enviar";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(513, 255);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.TxtBoxMensaje);
            this.Controls.Add(this.DesconectButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConectButton);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Conectador de cosas pibes skibidi sigma ponmi digital chamba fortnite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ConectButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DesconectButton;
        private System.Windows.Forms.TextBox TxtBoxMensaje;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

