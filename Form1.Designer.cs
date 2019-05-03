namespace RussianRoulette
{
    partial class Form1
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnAway = new System.Windows.Forms.Button();
            this.lblAway = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDodge = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLoses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoad.FlatAppearance.BorderSize = 2;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoad.Location = new System.Drawing.Point(653, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(107, 41);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "READY UP";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSpin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSpin.FlatAppearance.BorderSize = 2;
            this.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpin.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpin.Location = new System.Drawing.Point(653, 59);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(107, 54);
            this.btnSpin.TabIndex = 1;
            this.btnSpin.Text = "READY THE ENEMY";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.BtnSpin_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.BorderSize = 2;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Location = new System.Drawing.Point(12, 391);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(134, 47);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play Again";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFire.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFire.FlatAppearance.BorderSize = 2;
            this.btnFire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFire.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFire.Location = new System.Drawing.Point(653, 119);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(107, 54);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "FIRE";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.BtnFire_Click);
            // 
            // btnAway
            // 
            this.btnAway.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAway.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAway.FlatAppearance.BorderSize = 2;
            this.btnAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAway.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAway.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAway.Location = new System.Drawing.Point(428, 12);
            this.btnAway.Name = "btnAway";
            this.btnAway.Size = new System.Drawing.Size(103, 39);
            this.btnAway.TabIndex = 4;
            this.btnAway.Text = "Dodge";
            this.btnAway.UseVisualStyleBackColor = false;
            this.btnAway.Click += new System.EventHandler(this.BtnAway_Click);
            // 
            // lblAway
            // 
            this.lblAway.AllowDrop = true;
            this.lblAway.AutoEllipsis = true;
            this.lblAway.AutoSize = true;
            this.lblAway.BackColor = System.Drawing.Color.Transparent;
            this.lblAway.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAway.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAway.Location = new System.Drawing.Point(439, 77);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(0, 17);
            this.lblAway.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(607, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "#1";
            // 
            // lblDodge
            // 
            this.lblDodge.BackColor = System.Drawing.Color.Transparent;
            this.lblDodge.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDodge.Location = new System.Drawing.Point(423, 54);
            this.lblDodge.Name = "lblDodge";
            this.lblDodge.Size = new System.Drawing.Size(118, 23);
            this.lblDodge.TabIndex = 12;
            this.lblDodge.Text = "You are not dodging.";
            this.lblDodge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWin.Location = new System.Drawing.Point(13, 300);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(45, 20);
            this.lblWin.TabIndex = 13;
            this.lblWin.Text = "Wins:";
            // 
            // lblLoses
            // 
            this.lblLoses.AutoSize = true;
            this.lblLoses.BackColor = System.Drawing.Color.Transparent;
            this.lblLoses.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoses.Location = new System.Drawing.Point(13, 320);
            this.lblLoses.Name = "lblLoses";
            this.lblLoses.Size = new System.Drawing.Size(50, 20);
            this.lblLoses.TabIndex = 14;
            this.lblLoses.Text = "Loses:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(607, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "#2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(607, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "#3";
            // 
            // lblGP
            // 
            this.lblGP.AutoSize = true;
            this.lblGP.BackColor = System.Drawing.Color.Transparent;
            this.lblGP.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGP.Location = new System.Drawing.Point(13, 340);
            this.lblGP.Name = "lblGP";
            this.lblGP.Size = new System.Drawing.Size(103, 20);
            this.lblGP.TabIndex = 17;
            this.lblGP.Text = "Games Played:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianRoulette.Resource1.dodgeball_logo1;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.lblGP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLoses);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblDodge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAway);
            this.Controls.Add(this.btnAway);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnAway;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDodge;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLoses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGP;
    }
}

