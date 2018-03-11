namespace Calculator
{
    partial class binomialD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(binomialD));
            this.labTotal = new System.Windows.Forms.Label();
            this.labSukses = new System.Windows.Forms.Label();
            this.labProbabiliteti = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSukses = new System.Windows.Forms.TextBox();
            this.txtPro = new System.Windows.Forms.TextBox();
            this.btnLlogarite = new System.Windows.Forms.Button();
            this.txtProBinomial = new System.Windows.Forms.TextBox();
            this.txtPro2 = new System.Windows.Forms.TextBox();
            this.txtPro1 = new System.Windows.Forms.TextBox();
            this.labProBinomial = new System.Windows.Forms.Label();
            this.labProPak = new System.Windows.Forms.Label();
            this.labProPak2 = new System.Windows.Forms.Label();
            this.labShume2 = new System.Windows.Forms.Label();
            this.labProShume = new System.Windows.Forms.Label();
            this.txtPro3 = new System.Windows.Forms.TextBox();
            this.txtPro4 = new System.Windows.Forms.TextBox();
            this.txtKujdes = new System.Windows.Forms.TextBox();
            this.labKujdes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labTotal.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labTotal.Location = new System.Drawing.Point(29, 57);
            this.labTotal.Name = "labTotal";
            this.labTotal.Padding = new System.Windows.Forms.Padding(3);
            this.labTotal.Size = new System.Drawing.Size(171, 25);
            this.labTotal.TabIndex = 0;
            this.labTotal.Text = "Numri total i provave";
            // 
            // labSukses
            // 
            this.labSukses.AutoSize = true;
            this.labSukses.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labSukses.Cursor = System.Windows.Forms.Cursors.Help;
            this.labSukses.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSukses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labSukses.Location = new System.Drawing.Point(45, 100);
            this.labSukses.Name = "labSukses";
            this.labSukses.Padding = new System.Windows.Forms.Padding(3);
            this.labSukses.Size = new System.Drawing.Size(155, 25);
            this.labSukses.TabIndex = 1;
            this.labSukses.Text = "Numri i realizimeve";
            this.labSukses.MouseHover += new System.EventHandler(this.labSukses_MouseHover);
            // 
            // labProbabiliteti
            // 
            this.labProbabiliteti.AutoSize = true;
            this.labProbabiliteti.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labProbabiliteti.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProbabiliteti.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labProbabiliteti.Location = new System.Drawing.Point(22, 146);
            this.labProbabiliteti.Name = "labProbabiliteti";
            this.labProbabiliteti.Padding = new System.Windows.Forms.Padding(3);
            this.labProbabiliteti.Size = new System.Drawing.Size(178, 25);
            this.labProbabiliteti.TabIndex = 2;
            this.labProbabiliteti.Text = "Probabiliteti i realizimit";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(220, 57);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(188, 27);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWrite_KeyPress);
            // 
            // txtSukses
            // 
            this.txtSukses.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSukses.Location = new System.Drawing.Point(220, 100);
            this.txtSukses.Name = "txtSukses";
            this.txtSukses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSukses.Size = new System.Drawing.Size(188, 27);
            this.txtSukses.TabIndex = 4;
            this.txtSukses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSukses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWrite_KeyPress);
            // 
            // txtPro
            // 
            this.txtPro.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPro.Location = new System.Drawing.Point(220, 144);
            this.txtPro.Name = "txtPro";
            this.txtPro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPro.Size = new System.Drawing.Size(188, 27);
            this.txtPro.TabIndex = 5;
            this.txtPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPro_KeyPress);
            this.txtPro.Leave += new System.EventHandler(this.txtPro_TextChanged);
            // 
            // btnLlogarite
            // 
            this.btnLlogarite.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLlogarite.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlogarite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLlogarite.Location = new System.Drawing.Point(430, 88);
            this.btnLlogarite.Name = "btnLlogarite";
            this.btnLlogarite.Size = new System.Drawing.Size(142, 49);
            this.btnLlogarite.TabIndex = 6;
            this.btnLlogarite.Text = "Llogarit";
            this.btnLlogarite.UseVisualStyleBackColor = false;
            this.btnLlogarite.Click += new System.EventHandler(this.btnLlogarite_Click);
            // 
            // txtProBinomial
            // 
            this.txtProBinomial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtProBinomial.Enabled = false;
            this.txtProBinomial.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProBinomial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProBinomial.Location = new System.Drawing.Point(223, 224);
            this.txtProBinomial.Name = "txtProBinomial";
            this.txtProBinomial.Size = new System.Drawing.Size(188, 27);
            this.txtProBinomial.TabIndex = 7;
            this.txtProBinomial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPro2
            // 
            this.txtPro2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPro2.Enabled = false;
            this.txtPro2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPro2.Location = new System.Drawing.Point(223, 311);
            this.txtPro2.Name = "txtPro2";
            this.txtPro2.Size = new System.Drawing.Size(188, 27);
            this.txtPro2.TabIndex = 8;
            this.txtPro2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPro1
            // 
            this.txtPro1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPro1.Enabled = false;
            this.txtPro1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPro1.Location = new System.Drawing.Point(223, 266);
            this.txtPro1.Name = "txtPro1";
            this.txtPro1.Size = new System.Drawing.Size(188, 27);
            this.txtPro1.TabIndex = 9;
            this.txtPro1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labProBinomial
            // 
            this.labProBinomial.AutoSize = true;
            this.labProBinomial.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labProBinomial.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProBinomial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labProBinomial.Location = new System.Drawing.Point(33, 226);
            this.labProBinomial.Name = "labProBinomial";
            this.labProBinomial.Padding = new System.Windows.Forms.Padding(3);
            this.labProBinomial.Size = new System.Drawing.Size(167, 25);
            this.labProBinomial.TabIndex = 10;
            this.labProBinomial.Text = "Probabiliteti binomial";
            // 
            // labProPak
            // 
            this.labProPak.AutoSize = true;
            this.labProPak.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labProPak.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProPak.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labProPak.Location = new System.Drawing.Point(132, 268);
            this.labProPak.Name = "labProPak";
            this.labProPak.Padding = new System.Windows.Forms.Padding(3);
            this.labProPak.Size = new System.Drawing.Size(68, 25);
            this.labProPak.TabIndex = 11;
            this.labProPak.Text = "P(X<x)";
            // 
            // labProPak2
            // 
            this.labProPak2.AutoSize = true;
            this.labProPak2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labProPak2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProPak2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labProPak2.Location = new System.Drawing.Point(132, 311);
            this.labProPak2.Name = "labProPak2";
            this.labProPak2.Padding = new System.Windows.Forms.Padding(3);
            this.labProPak2.Size = new System.Drawing.Size(68, 25);
            this.labProPak2.TabIndex = 12;
            this.labProPak2.Text = "P(X≤x)";
            // 
            // labShume2
            // 
            this.labShume2.AutoSize = true;
            this.labShume2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labShume2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labShume2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labShume2.Location = new System.Drawing.Point(132, 399);
            this.labShume2.Name = "labShume2";
            this.labShume2.Padding = new System.Windows.Forms.Padding(3);
            this.labShume2.Size = new System.Drawing.Size(68, 25);
            this.labShume2.TabIndex = 16;
            this.labShume2.Text = "P(X≥x)";
            // 
            // labProShume
            // 
            this.labProShume.AutoSize = true;
            this.labProShume.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labProShume.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProShume.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labProShume.Location = new System.Drawing.Point(132, 356);
            this.labProShume.Name = "labProShume";
            this.labProShume.Padding = new System.Windows.Forms.Padding(3);
            this.labProShume.Size = new System.Drawing.Size(68, 25);
            this.labProShume.TabIndex = 15;
            this.labProShume.Text = "P(X>x)";
            // 
            // txtPro3
            // 
            this.txtPro3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPro3.Enabled = false;
            this.txtPro3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPro3.Location = new System.Drawing.Point(223, 354);
            this.txtPro3.Name = "txtPro3";
            this.txtPro3.Size = new System.Drawing.Size(188, 27);
            this.txtPro3.TabIndex = 14;
            this.txtPro3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPro4
            // 
            this.txtPro4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPro4.Enabled = false;
            this.txtPro4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPro4.Location = new System.Drawing.Point(223, 399);
            this.txtPro4.Name = "txtPro4";
            this.txtPro4.Size = new System.Drawing.Size(188, 27);
            this.txtPro4.TabIndex = 13;
            this.txtPro4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKujdes
            // 
            this.txtKujdes.BackColor = System.Drawing.Color.DarkGreen;
            this.txtKujdes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtKujdes.Location = new System.Drawing.Point(431, 254);
            this.txtKujdes.Multiline = true;
            this.txtKujdes.Name = "txtKujdes";
            this.txtKujdes.ReadOnly = true;
            this.txtKujdes.Size = new System.Drawing.Size(142, 161);
            this.txtKujdes.TabIndex = 17;
            this.txtKujdes.Text = "*Sigurohuni qe i keni plotesuar fushat perkatese.\r\n\r\n*Vlerat e probabilitetit duh" +
    "et te jene mes 0 dhe 1.\r\n\r\n*Numri i provave dhe provave te suksesshme duhet te j" +
    "ene numra te plote jo negativ ";
            // 
            // labKujdes
            // 
            this.labKujdes.AutoSize = true;
            this.labKujdes.BackColor = System.Drawing.Color.Maroon;
            this.labKujdes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labKujdes.Location = new System.Drawing.Point(438, 238);
            this.labKujdes.Name = "labKujdes";
            this.labKujdes.Size = new System.Drawing.Size(52, 13);
            this.labKujdes.TabIndex = 18;
            this.labKujdes.Text = "KUJDES!";
            // 
            // binomialD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.labKujdes);
            this.Controls.Add(this.txtKujdes);
            this.Controls.Add(this.labShume2);
            this.Controls.Add(this.labProShume);
            this.Controls.Add(this.txtPro3);
            this.Controls.Add(this.txtPro4);
            this.Controls.Add(this.labProPak2);
            this.Controls.Add(this.labProPak);
            this.Controls.Add(this.labProBinomial);
            this.Controls.Add(this.txtPro1);
            this.Controls.Add(this.txtPro2);
            this.Controls.Add(this.txtProBinomial);
            this.Controls.Add(this.btnLlogarite);
            this.Controls.Add(this.txtPro);
            this.Controls.Add(this.txtSukses);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.labProbabiliteti);
            this.Controls.Add(this.labSukses);
            this.Controls.Add(this.labTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "binomialD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shperndarja Binomiale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label labSukses;
        private System.Windows.Forms.Label labProbabiliteti;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSukses;
        private System.Windows.Forms.TextBox txtPro;
        private System.Windows.Forms.Button btnLlogarite;
        private System.Windows.Forms.TextBox txtProBinomial;
        private System.Windows.Forms.TextBox txtPro2;
        private System.Windows.Forms.TextBox txtPro1;
        private System.Windows.Forms.Label labProBinomial;
        private System.Windows.Forms.Label labProPak;
        private System.Windows.Forms.Label labProPak2;
        private System.Windows.Forms.Label labShume2;
        private System.Windows.Forms.Label labProShume;
        private System.Windows.Forms.TextBox txtPro3;
        private System.Windows.Forms.TextBox txtPro4;
        private System.Windows.Forms.TextBox txtKujdes;
        private System.Windows.Forms.Label labKujdes;
    }
}

