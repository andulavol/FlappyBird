
namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zeme = new System.Windows.Forms.PictureBox();
            this.prekazkaDOWN = new System.Windows.Forms.PictureBox();
            this.prekazkaTOP = new System.Windows.Forms.PictureBox();
            this.ptacek = new System.Windows.Forms.PictureBox();
            this.skore = new System.Windows.Forms.Label();
            this.startNapis = new System.Windows.Forms.PictureBox();
            this.konecNapis = new System.Windows.Forms.PictureBox();
            this.casovacHry = new System.Windows.Forms.Timer(this.components);
            this.hratZnovu = new System.Windows.Forms.Label();
            this.zmackniMe = new System.Windows.Forms.Label();
            this.vysledekLabel = new System.Windows.Forms.Label();
            this.prekazkaTOP2 = new System.Windows.Forms.PictureBox();
            this.prekazkaDOWN2 = new System.Windows.Forms.PictureBox();
            this.prekazkaTOP3 = new System.Windows.Forms.PictureBox();
            this.prekazkaDOWN3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.zeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekazkaDOWN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekazkaTOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptacek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNapis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konecNapis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekazkaTOP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekazkaDOWN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekazkaTOP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekazkaDOWN3)).BeginInit();
            this.SuspendLayout();
            // 
            // zeme
            // 
            this.zeme.Image = global::FlappyBird.Properties.Resources._base;
            this.zeme.Location = new System.Drawing.Point(0, 402);
            this.zeme.Name = "zeme";
            this.zeme.Size = new System.Drawing.Size(270, 70);
            this.zeme.TabIndex = 0;
            this.zeme.TabStop = false;
            // 
            // prekazkaDOWN
            // 
            this.prekazkaDOWN.Image = global::FlappyBird.Properties.Resources.mff_pipe;
            this.prekazkaDOWN.Location = new System.Drawing.Point(208, 260);
            this.prekazkaDOWN.Name = "prekazkaDOWN";
            this.prekazkaDOWN.Size = new System.Drawing.Size(50, 260);
            this.prekazkaDOWN.TabIndex = 1;
            this.prekazkaDOWN.TabStop = false;
            this.prekazkaDOWN.Tag = "DWN";
            // 
            // prekazkaTOP
            // 
            this.prekazkaTOP.Image = global::FlappyBird.Properties.Resources.mff_pipe2;
            this.prekazkaTOP.Location = new System.Drawing.Point(208, -215);
            this.prekazkaTOP.Name = "prekazkaTOP";
            this.prekazkaTOP.Size = new System.Drawing.Size(50, 319);
            this.prekazkaTOP.TabIndex = 2;
            this.prekazkaTOP.TabStop = false;
            this.prekazkaTOP.Tag = "TP";
            // 
            // ptacek
            // 
            this.ptacek.BackColor = System.Drawing.Color.Transparent;
            this.ptacek.Image = global::FlappyBird.Properties.Resources.student_flap;
            this.ptacek.Location = new System.Drawing.Point(120, 195);
            this.ptacek.Name = "ptacek";
            this.ptacek.Size = new System.Drawing.Size(36, 27);
            this.ptacek.TabIndex = 3;
            this.ptacek.TabStop = false;
            // 
            // skore
            // 
            this.skore.AutoSize = true;
            this.skore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(217)))), ((int)(((byte)(150)))));
            this.skore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skore.Location = new System.Drawing.Point(0, 438);
            this.skore.Name = "skore";
            this.skore.Size = new System.Drawing.Size(127, 18);
            this.skore.TabIndex = 4;
            this.skore.Text = "Počet kreditů: 0";
            // 
            // startNapis
            // 
            this.startNapis.BackColor = System.Drawing.Color.Transparent;
            this.startNapis.Image = global::FlappyBird.Properties.Resources.message;
            this.startNapis.Location = new System.Drawing.Point(48, 26);
            this.startNapis.Name = "startNapis";
            this.startNapis.Size = new System.Drawing.Size(184, 284);
            this.startNapis.TabIndex = 5;
            this.startNapis.TabStop = false;
            this.startNapis.Visible = false;
            // 
            // konecNapis
            // 
            this.konecNapis.BackColor = System.Drawing.Color.Transparent;
            this.konecNapis.Image = global::FlappyBird.Properties.Resources.gameover;
            this.konecNapis.Location = new System.Drawing.Point(34, 121);
            this.konecNapis.Name = "konecNapis";
            this.konecNapis.Size = new System.Drawing.Size(193, 45);
            this.konecNapis.TabIndex = 6;
            this.konecNapis.TabStop = false;
            this.konecNapis.Visible = false;
            // 
            // casovacHry
            // 
            this.casovacHry.Enabled = true;
            this.casovacHry.Interval = 20;
            this.casovacHry.Tick += new System.EventHandler(this.CasovacHryEvent);
            // 
            // hratZnovu
            // 
            this.hratZnovu.AutoSize = true;
            this.hratZnovu.BackColor = System.Drawing.Color.Transparent;
            this.hratZnovu.Font = new System.Drawing.Font("Tahoma", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hratZnovu.Location = new System.Drawing.Point(12, 283);
            this.hratZnovu.Name = "hratZnovu";
            this.hratZnovu.Size = new System.Drawing.Size(263, 27);
            this.hratZnovu.TabIndex = 7;
            this.hratZnovu.Text = "Chceš to zkusit znovu?";
            // 
            // zmackniMe
            // 
            this.zmackniMe.AutoSize = true;
            this.zmackniMe.BackColor = System.Drawing.Color.Transparent;
            this.zmackniMe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zmackniMe.Location = new System.Drawing.Point(45, 321);
            this.zmackniMe.Name = "zmackniMe";
            this.zmackniMe.Size = new System.Drawing.Size(185, 24);
            this.zmackniMe.TabIndex = 8;
            this.zmackniMe.Text = "Stiskni mezerník!";
            // 
            // vysledekLabel
            // 
            this.vysledekLabel.AutoSize = true;
            this.vysledekLabel.BackColor = System.Drawing.Color.Transparent;
            this.vysledekLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vysledekLabel.Location = new System.Drawing.Point(39, 181);
            this.vysledekLabel.Name = "vysledekLabel";
            this.vysledekLabel.Size = new System.Drawing.Size(101, 24);
            this.vysledekLabel.TabIndex = 9;
            this.vysledekLabel.Text = "Výsledek";
            // 
            // prekazkaTOP2
            // 
            this.prekazkaTOP2.Image = global::FlappyBird.Properties.Resources.mff_pipe2;
            this.prekazkaTOP2.Location = new System.Drawing.Point(330, -120);
            this.prekazkaTOP2.Name = "prekazkaTOP2";
            this.prekazkaTOP2.Size = new System.Drawing.Size(50, 319);
            this.prekazkaTOP2.TabIndex = 10;
            this.prekazkaTOP2.TabStop = false;
            this.prekazkaTOP2.Tag = "TP";
            // 
            // prekazkaDOWN2
            // 
            this.prekazkaDOWN2.Image = global::FlappyBird.Properties.Resources.mff_pipe;
            this.prekazkaDOWN2.Location = new System.Drawing.Point(330, 355);
            this.prekazkaDOWN2.Name = "prekazkaDOWN2";
            this.prekazkaDOWN2.Size = new System.Drawing.Size(50, 260);
            this.prekazkaDOWN2.TabIndex = 11;
            this.prekazkaDOWN2.TabStop = false;
            this.prekazkaDOWN2.Tag = "DWN";
            // 
            // prekazkaTOP3
            // 
            this.prekazkaTOP3.Image = global::FlappyBird.Properties.Resources.mff_pipe2;
            this.prekazkaTOP3.Location = new System.Drawing.Point(352, -150);
            this.prekazkaTOP3.Name = "prekazkaTOP3";
            this.prekazkaTOP3.Size = new System.Drawing.Size(50, 319);
            this.prekazkaTOP3.TabIndex = 12;
            this.prekazkaTOP3.TabStop = false;
            this.prekazkaTOP3.Tag = "TP";
            // 
            // prekazkaDOWN3
            // 
            this.prekazkaDOWN3.Image = global::FlappyBird.Properties.Resources.mff_pipe;
            this.prekazkaDOWN3.Location = new System.Drawing.Point(352, 225);
            this.prekazkaDOWN3.Name = "prekazkaDOWN3";
            this.prekazkaDOWN3.Size = new System.Drawing.Size(50, 260);
            this.prekazkaDOWN3.TabIndex = 13;
            this.prekazkaDOWN3.TabStop = false;
            this.prekazkaDOWN3.Tag = "DWN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(270, 465);
            this.Controls.Add(this.prekazkaDOWN3);
            this.Controls.Add(this.prekazkaTOP3);
            this.Controls.Add(this.prekazkaDOWN2);
            this.Controls.Add(this.prekazkaTOP2);
            this.Controls.Add(this.vysledekLabel);
            this.Controls.Add(this.zmackniMe);
            this.Controls.Add(this.hratZnovu);
            this.Controls.Add(this.konecNapis);
            this.Controls.Add(this.startNapis);
            this.Controls.Add(this.skore);
            this.Controls.Add(this.ptacek);
            this.Controls.Add(this.prekazkaTOP);
            this.Controls.Add(this.prekazkaDOWN);
            this.Controls.Add(this.zeme);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.zeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekazkaDOWN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekazkaTOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptacek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNapis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konecNapis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekazkaTOP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekazkaDOWN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekazkaTOP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekazkaDOWN3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox zeme;
        private System.Windows.Forms.PictureBox prekazkaDOWN;
        private System.Windows.Forms.PictureBox prekazkaTOP;
        private System.Windows.Forms.PictureBox ptacek;
        private System.Windows.Forms.Label skore;
        private System.Windows.Forms.PictureBox startNapis;
        private System.Windows.Forms.PictureBox konecNapis;
        private System.Windows.Forms.Timer casovacHry;
        private System.Windows.Forms.Label hratZnovu;
        private System.Windows.Forms.Label zmackniMe;
        private System.Windows.Forms.Label vysledekLabel;
        private System.Windows.Forms.PictureBox prekazkaTOP2;
        private System.Windows.Forms.PictureBox prekazkaDOWN2;
        private System.Windows.Forms.PictureBox prekazkaTOP3;
        private System.Windows.Forms.PictureBox prekazkaDOWN3;
    }
}

