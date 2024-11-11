namespace Game
{
    partial class PlayerNome
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
            this.txtBoxNnNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnNnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNnNome
            // 
            this.txtBoxNnNome.Location = new System.Drawing.Point(51, 46);
            this.txtBoxNnNome.Name = "txtBoxNnNome";
            this.txtBoxNnNome.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNnNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // bttnNnConfirmar
            // 
            this.bttnNnConfirmar.Location = new System.Drawing.Point(66, 72);
            this.bttnNnConfirmar.Name = "bttnNnConfirmar";
            this.bttnNnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bttnNnConfirmar.TabIndex = 2;
            this.bttnNnConfirmar.Text = "Confirmar";
            this.bttnNnConfirmar.UseVisualStyleBackColor = true;
            this.bttnNnConfirmar.Click += new System.EventHandler(this.bttnNnConfirmar_Click);
            // 
            // PlayerNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.Blue;
            this.ClientSize = new System.Drawing.Size(204, 114);
            this.Controls.Add(this.bttnNnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNnNome);
            this.MaximizeBox = false;
            this.Name = "PlayerNome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nickname";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNnNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnNnConfirmar;
    }
}