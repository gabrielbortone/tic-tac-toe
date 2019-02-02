namespace Jogo_da_Velha.GameConfig {
    partial class FrmConfig {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.P1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.OptP2 = new System.Windows.Forms.Label();
            this.OptP1 = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 356);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(770, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Font = new System.Drawing.Font("Ailerons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1.ForeColor = System.Drawing.Color.White;
            this.P1.Location = new System.Drawing.Point(45, 69);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(136, 25);
            this.P1.TabIndex = 9;
            this.P1.Text = "Player 1 :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Indigo;
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.btnInit);
            this.groupBox1.Controls.Add(this.OptP2);
            this.groupBox1.Controls.Add(this.OptP1);
            this.groupBox1.Controls.Add(this.P2);
            this.groupBox1.Controls.Add(this.P1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(44, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 303);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Ailerons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(50, 233);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(131, 41);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "Trocar";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInit.Font = new System.Drawing.Font("Ailerons", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInit.ForeColor = System.Drawing.Color.White;
            this.btnInit.Location = new System.Drawing.Point(465, 227);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(179, 47);
            this.btnInit.TabIndex = 12;
            this.btnInit.Text = "Iniciar";
            this.btnInit.UseVisualStyleBackColor = false;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // OptP2
            // 
            this.OptP2.AutoSize = true;
            this.OptP2.Font = new System.Drawing.Font("Ailerons", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptP2.Location = new System.Drawing.Point(590, 53);
            this.OptP2.Name = "OptP2";
            this.OptP2.Size = new System.Drawing.Size(54, 58);
            this.OptP2.TabIndex = 13;
            this.OptP2.Text = "X";
            // 
            // OptP1
            // 
            this.OptP1.AutoSize = true;
            this.OptP1.Font = new System.Drawing.Font("Ailerons", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptP1.Location = new System.Drawing.Point(187, 53);
            this.OptP1.Name = "OptP1";
            this.OptP1.Size = new System.Drawing.Size(54, 58);
            this.OptP1.TabIndex = 12;
            this.OptP1.Text = "0";
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Font = new System.Drawing.Font("Ailerons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2.ForeColor = System.Drawing.Color.White;
            this.P2.Location = new System.Drawing.Point(447, 69);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(137, 25);
            this.P2.TabIndex = 11;
            this.P2.Text = "Player 2 :";
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(770, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label OptP2;
        private System.Windows.Forms.Label OptP1;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Button btnChange;
    }
}