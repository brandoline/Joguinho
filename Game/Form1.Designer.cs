namespace Game
{
    partial class FormInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcBoxFormInicialPlayer = new System.Windows.Forms.PictureBox();
            this.pcBoxFormInicialNext = new System.Windows.Forms.PictureBox();
            this.pcBoxFormInicialPrevious = new System.Windows.Forms.PictureBox();
            this.bttnFormInicialConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFormInicialPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFormInicialNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFormInicialPrevious)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBoxFormInicialPlayer
            // 
            this.pcBoxFormInicialPlayer.Image = global::Game.Properties.Resources.Player;
            this.pcBoxFormInicialPlayer.Location = new System.Drawing.Point(138, 61);
            this.pcBoxFormInicialPlayer.Name = "pcBoxFormInicialPlayer";
            this.pcBoxFormInicialPlayer.Size = new System.Drawing.Size(33, 36);
            this.pcBoxFormInicialPlayer.TabIndex = 0;
            this.pcBoxFormInicialPlayer.TabStop = false;
            // 
            // pcBoxFormInicialNext
            // 
            this.pcBoxFormInicialNext.Image = global::Game.Properties.Resources.Next;
            this.pcBoxFormInicialNext.Location = new System.Drawing.Point(177, 76);
            this.pcBoxFormInicialNext.Name = "pcBoxFormInicialNext";
            this.pcBoxFormInicialNext.Size = new System.Drawing.Size(21, 21);
            this.pcBoxFormInicialNext.TabIndex = 1;
            this.pcBoxFormInicialNext.TabStop = false;
            this.pcBoxFormInicialNext.Click += new System.EventHandler(this.pcBoxFormInicialNext_Click);
            // 
            // pcBoxFormInicialPrevious
            // 
            this.pcBoxFormInicialPrevious.Image = global::Game.Properties.Resources.Previous;
            this.pcBoxFormInicialPrevious.Location = new System.Drawing.Point(112, 76);
            this.pcBoxFormInicialPrevious.Name = "pcBoxFormInicialPrevious";
            this.pcBoxFormInicialPrevious.Size = new System.Drawing.Size(20, 21);
            this.pcBoxFormInicialPrevious.TabIndex = 2;
            this.pcBoxFormInicialPrevious.TabStop = false;
            this.pcBoxFormInicialPrevious.Click += new System.EventHandler(this.pcBoxFormInicialPrevious_Click);
            // 
            // bttnFormInicialConfirmar
            // 
            this.bttnFormInicialConfirmar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttnFormInicialConfirmar.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnFormInicialConfirmar.ForeColor = System.Drawing.Color.DarkGray;
            this.bttnFormInicialConfirmar.Location = new System.Drawing.Point(108, 103);
            this.bttnFormInicialConfirmar.Name = "bttnFormInicialConfirmar";
            this.bttnFormInicialConfirmar.Size = new System.Drawing.Size(93, 29);
            this.bttnFormInicialConfirmar.TabIndex = 3;
            this.bttnFormInicialConfirmar.Text = "Confirmar";
            this.bttnFormInicialConfirmar.UseVisualStyleBackColor = false;
            this.bttnFormInicialConfirmar.Click += new System.EventHandler(this.bttnFormInicialConfirmar_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.Blue;
            this.ClientSize = new System.Drawing.Size(310, 204);
            this.Controls.Add(this.bttnFormInicialConfirmar);
            this.Controls.Add(this.pcBoxFormInicialPrevious);
            this.Controls.Add(this.pcBoxFormInicialNext);
            this.Controls.Add(this.pcBoxFormInicialPlayer);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose your Player";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFormInicialPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFormInicialNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFormInicialPrevious)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBoxFormInicialPlayer;
        private System.Windows.Forms.PictureBox pcBoxFormInicialNext;
        private System.Windows.Forms.PictureBox pcBoxFormInicialPrevious;
        private System.Windows.Forms.Button bttnFormInicialConfirmar;
    }
}

