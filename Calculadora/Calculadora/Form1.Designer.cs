namespace Calculadora
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
            this.bc = new System.Windows.Forms.Button();
            this.bmas = new System.Windows.Forms.Button();
            this.bigu = new System.Windows.Forms.Button();
            this.bce = new System.Windows.Forms.Button();
            this.bres = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bmult = new System.Windows.Forms.Button();
            this.bpo = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.restb = new System.Windows.Forms.TextBox();
            this.bpunt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bc
            // 
            this.bc.Location = new System.Drawing.Point(222, 49);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(46, 47);
            this.bc.TabIndex = 0;
            this.bc.Text = "C";
            this.bc.UseVisualStyleBackColor = true;
            this.bc.Click += new System.EventHandler(this.Bc_Click);
            // 
            // bmas
            // 
            this.bmas.Location = new System.Drawing.Point(222, 103);
            this.bmas.Name = "bmas";
            this.bmas.Size = new System.Drawing.Size(46, 48);
            this.bmas.TabIndex = 1;
            this.bmas.Text = "+";
            this.bmas.UseVisualStyleBackColor = true;
            this.bmas.Click += new System.EventHandler(this.Bmas_Click);
            // 
            // bigu
            // 
            this.bigu.Location = new System.Drawing.Point(222, 156);
            this.bigu.Name = "bigu";
            this.bigu.Size = new System.Drawing.Size(46, 102);
            this.bigu.TabIndex = 2;
            this.bigu.Text = "=";
            this.bigu.UseVisualStyleBackColor = true;
            this.bigu.Click += new System.EventHandler(this.Bigu_Click);
            // 
            // bce
            // 
            this.bce.Location = new System.Drawing.Point(170, 49);
            this.bce.Name = "bce";
            this.bce.Size = new System.Drawing.Size(46, 48);
            this.bce.TabIndex = 3;
            this.bce.Text = "CE";
            this.bce.UseVisualStyleBackColor = true;
            this.bce.Click += new System.EventHandler(this.Bce_Click);
            // 
            // bres
            // 
            this.bres.Location = new System.Drawing.Point(170, 103);
            this.bres.Name = "bres";
            this.bres.Size = new System.Drawing.Size(46, 48);
            this.bres.TabIndex = 4;
            this.bres.Text = "-";
            this.bres.UseVisualStyleBackColor = true;
            this.bres.Click += new System.EventHandler(this.Bres_Click);
            // 
            // bdiv
            // 
            this.bdiv.Location = new System.Drawing.Point(170, 156);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(46, 48);
            this.bdiv.TabIndex = 5;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.Click += new System.EventHandler(this.Bdiv_Click);
            // 
            // bmult
            // 
            this.bmult.Location = new System.Drawing.Point(170, 211);
            this.bmult.Name = "bmult";
            this.bmult.Size = new System.Drawing.Size(46, 47);
            this.bmult.TabIndex = 6;
            this.bmult.Text = "*";
            this.bmult.UseVisualStyleBackColor = true;
            this.bmult.Click += new System.EventHandler(this.Bmult_Click);
            // 
            // bpo
            // 
            this.bpo.Location = new System.Drawing.Point(14, 211);
            this.bpo.Name = "bpo";
            this.bpo.Size = new System.Drawing.Size(45, 47);
            this.bpo.TabIndex = 7;
            this.bpo.Text = "%";
            this.bpo.UseVisualStyleBackColor = true;
            this.bpo.Click += new System.EventHandler(this.Bpo_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(65, 211);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(47, 47);
            this.b0.TabIndex = 9;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.B0_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(14, 156);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(45, 48);
            this.b1.TabIndex = 10;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.B1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(65, 156);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(47, 49);
            this.b2.TabIndex = 11;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.B2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(118, 156);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(46, 49);
            this.b3.TabIndex = 12;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.B3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(14, 102);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(45, 48);
            this.b4.TabIndex = 13;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.B4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(65, 102);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(47, 48);
            this.b5.TabIndex = 14;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.B5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(118, 102);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(46, 48);
            this.b6.TabIndex = 15;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.B6_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(14, 47);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(45, 49);
            this.b7.TabIndex = 16;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.B7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(65, 48);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(47, 49);
            this.b8.TabIndex = 17;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.B8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(118, 49);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(46, 48);
            this.b9.TabIndex = 18;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.B9_Click);
            // 
            // restb
            // 
            this.restb.BackColor = System.Drawing.Color.White;
            this.restb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restb.ForeColor = System.Drawing.Color.Black;
            this.restb.Location = new System.Drawing.Point(15, 12);
            this.restb.Name = "restb";
            this.restb.Size = new System.Drawing.Size(252, 26);
            this.restb.TabIndex = 19;
            this.restb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.restb.TextChanged += new System.EventHandler(this.Restb_TextChanged);
            this.restb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Restb_KeyPress);
            // 
            // bpunt
            // 
            this.bpunt.Location = new System.Drawing.Point(118, 211);
            this.bpunt.Name = "bpunt";
            this.bpunt.Size = new System.Drawing.Size(46, 47);
            this.bpunt.TabIndex = 8;
            this.bpunt.Text = ".";
            this.bpunt.UseVisualStyleBackColor = true;
            this.bpunt.Click += new System.EventHandler(this.Bpunt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 270);
            this.Controls.Add(this.restb);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bpunt);
            this.Controls.Add(this.bpo);
            this.Controls.Add(this.bmult);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bres);
            this.Controls.Add(this.bce);
            this.Controls.Add(this.bigu);
            this.Controls.Add(this.bmas);
            this.Controls.Add(this.bc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button bmas;
        private System.Windows.Forms.Button bigu;
        private System.Windows.Forms.Button bce;
        private System.Windows.Forms.Button bres;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bmult;
        private System.Windows.Forms.Button bpo;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.TextBox restb;
        private System.Windows.Forms.Button bpunt;
    }
}

