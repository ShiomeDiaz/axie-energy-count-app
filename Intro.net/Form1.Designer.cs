namespace Intro.net
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btMinusOne = new System.Windows.Forms.Button();
            this.btPlusOne = new System.Windows.Forms.Button();
            this.btNewGame = new System.Windows.Forms.Button();
            this.labelRound = new System.Windows.Forms.Label();
            this.labelCountRound = new System.Windows.Forms.Label();
            this.labelTittleEnergy = new System.Windows.Forms.Label();
            this.btNextRound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(136, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMinusOne
            // 
            this.btMinusOne.Location = new System.Drawing.Point(48, 229);
            this.btMinusOne.Name = "btMinusOne";
            this.btMinusOne.Size = new System.Drawing.Size(75, 23);
            this.btMinusOne.TabIndex = 1;
            this.btMinusOne.Text = "- 1";
            this.btMinusOne.UseVisualStyleBackColor = true;
            this.btMinusOne.Click += new System.EventHandler(this.btMinusOne_Click);
            // 
            // btPlusOne
            // 
            this.btPlusOne.Location = new System.Drawing.Point(178, 229);
            this.btPlusOne.Name = "btPlusOne";
            this.btPlusOne.Size = new System.Drawing.Size(80, 23);
            this.btPlusOne.TabIndex = 2;
            this.btPlusOne.Text = "+ 1";
            this.btPlusOne.UseVisualStyleBackColor = true;
            this.btPlusOne.Click += new System.EventHandler(this.btPlusOne_Click);
            // 
            // btNewGame
            // 
            this.btNewGame.Location = new System.Drawing.Point(48, 331);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.Size = new System.Drawing.Size(210, 23);
            this.btNewGame.TabIndex = 3;
            this.btNewGame.Text = "New Game";
            this.btNewGame.UseVisualStyleBackColor = true;
            this.btNewGame.Click += new System.EventHandler(this.btNewGame_Click);
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.BackColor = System.Drawing.Color.Transparent;
            this.labelRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRound.Location = new System.Drawing.Point(33, 55);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(112, 32);
            this.labelRound.TabIndex = 4;
            this.labelRound.Text = "Round:";
            this.labelRound.Click += new System.EventHandler(this.labelRound_Click);
            // 
            // labelCountRound
            // 
            this.labelCountRound.AutoSize = true;
            this.labelCountRound.BackColor = System.Drawing.Color.Transparent;
            this.labelCountRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountRound.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCountRound.Location = new System.Drawing.Point(172, 55);
            this.labelCountRound.Name = "labelCountRound";
            this.labelCountRound.Size = new System.Drawing.Size(31, 32);
            this.labelCountRound.TabIndex = 5;
            this.labelCountRound.Text = "1";
            this.labelCountRound.Click += new System.EventHandler(this.labelCountRound_Click);
            // 
            // labelTittleEnergy
            // 
            this.labelTittleEnergy.AutoSize = true;
            this.labelTittleEnergy.BackColor = System.Drawing.Color.Transparent;
            this.labelTittleEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleEnergy.Location = new System.Drawing.Point(87, 130);
            this.labelTittleEnergy.Name = "labelTittleEnergy";
            this.labelTittleEnergy.Size = new System.Drawing.Size(139, 32);
            this.labelTittleEnergy.TabIndex = 6;
            this.labelTittleEnergy.Text = "ENERGY";
            this.labelTittleEnergy.Click += new System.EventHandler(this.label2_Click);
            // 
            // btNextRound
            // 
            this.btNextRound.Location = new System.Drawing.Point(93, 283);
            this.btNextRound.Name = "btNextRound";
            this.btNextRound.Size = new System.Drawing.Size(134, 23);
            this.btNextRound.TabIndex = 7;
            this.btNextRound.Text = "Next Round";
            this.btNextRound.UseVisualStyleBackColor = true;
            this.btNextRound.Click += new System.EventHandler(this.btNextRound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Intro.net.Properties.Resources.HD_wallpaper_axie_4_infinity;
            this.ClientSize = new System.Drawing.Size(284, 400);
            this.Controls.Add(this.btNextRound);
            this.Controls.Add(this.labelTittleEnergy);
            this.Controls.Add(this.labelCountRound);
            this.Controls.Add(this.labelRound);
            this.Controls.Add(this.btNewGame);
            this.Controls.Add(this.btPlusOne);
            this.Controls.Add(this.btMinusOne);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Axie Infinity Count Energy";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMinusOne;
        private System.Windows.Forms.Button btPlusOne;
        private System.Windows.Forms.Button btNewGame;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.Label labelCountRound;
        private System.Windows.Forms.Label labelTittleEnergy;
        private System.Windows.Forms.Button btNextRound;
    }
}

