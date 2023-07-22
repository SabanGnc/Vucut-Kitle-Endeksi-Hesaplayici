namespace VKİ_Hesaplayıcı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBoy = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelKilo = new System.Windows.Forms.Label();
            this.textBoxKilo = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonHesapla = new Guna.UI2.WinForms.Guna2Button();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.textBoxVKI = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("LEMON MILK Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boy (cm):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxBoy
            // 
            this.textBoxBoy.BorderColor = System.Drawing.Color.HotPink;
            this.textBoxBoy.BorderThickness = 3;
            this.textBoxBoy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxBoy.DefaultText = "";
            this.textBoxBoy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxBoy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxBoy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxBoy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxBoy.FillColor = System.Drawing.Color.LightPink;
            this.textBoxBoy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxBoy.Font = new System.Drawing.Font("LEMON MILK Bold", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxBoy.ForeColor = System.Drawing.Color.Black;
            this.textBoxBoy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxBoy.Location = new System.Drawing.Point(169, 212);
            this.textBoxBoy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBoy.Name = "textBoxBoy";
            this.textBoxBoy.PasswordChar = '\0';
            this.textBoxBoy.PlaceholderText = "";
            this.textBoxBoy.SelectedText = "";
            this.textBoxBoy.Size = new System.Drawing.Size(209, 38);
            this.textBoxBoy.TabIndex = 1;
            this.textBoxBoy.TextChanged += new System.EventHandler(this.textBoxBoy_TextChanged);
            // 
            // labelKilo
            // 
            this.labelKilo.AutoSize = true;
            this.labelKilo.BackColor = System.Drawing.Color.Transparent;
            this.labelKilo.Font = new System.Drawing.Font("LEMON MILK Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKilo.Location = new System.Drawing.Point(12, 263);
            this.labelKilo.Name = "labelKilo";
            this.labelKilo.Size = new System.Drawing.Size(154, 36);
            this.labelKilo.TabIndex = 2;
            this.labelKilo.Text = "Kilo (kg):";
            // 
            // textBoxKilo
            // 
            this.textBoxKilo.BorderColor = System.Drawing.Color.HotPink;
            this.textBoxKilo.BorderThickness = 3;
            this.textBoxKilo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxKilo.DefaultText = "";
            this.textBoxKilo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxKilo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxKilo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxKilo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxKilo.FillColor = System.Drawing.Color.LightPink;
            this.textBoxKilo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxKilo.Font = new System.Drawing.Font("LEMON MILK Bold", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxKilo.ForeColor = System.Drawing.Color.Black;
            this.textBoxKilo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxKilo.Location = new System.Drawing.Point(169, 261);
            this.textBoxKilo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKilo.Name = "textBoxKilo";
            this.textBoxKilo.PasswordChar = '\0';
            this.textBoxKilo.PlaceholderText = "";
            this.textBoxKilo.SelectedText = "";
            this.textBoxKilo.Size = new System.Drawing.Size(209, 38);
            this.textBoxKilo.TabIndex = 1;
            this.textBoxKilo.TextChanged += new System.EventHandler(this.textBoxKilo_TextChanged);
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Animated = true;
            this.buttonHesapla.BackColor = System.Drawing.Color.Transparent;
            this.buttonHesapla.BorderColor = System.Drawing.Color.HotPink;
            this.buttonHesapla.BorderRadius = 15;
            this.buttonHesapla.BorderThickness = 3;
            this.buttonHesapla.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonHesapla.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonHesapla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonHesapla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonHesapla.FillColor = System.Drawing.Color.LightPink;
            this.buttonHesapla.Font = new System.Drawing.Font("LEMON MILK Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHesapla.ForeColor = System.Drawing.Color.Black;
            this.buttonHesapla.Location = new System.Drawing.Point(597, 261);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(209, 87);
            this.buttonHesapla.TabIndex = 3;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseTransparentBackground = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.BackColor = System.Drawing.Color.Transparent;
            this.labelSonuc.Font = new System.Drawing.Font("LEMON MILK Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSonuc.Location = new System.Drawing.Point(12, 313);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(121, 36);
            this.labelSonuc.TabIndex = 4;
            this.labelSonuc.Text = "Sonuç:";
            // 
            // textBoxVKI
            // 
            this.textBoxVKI.BorderColor = System.Drawing.Color.HotPink;
            this.textBoxVKI.BorderThickness = 3;
            this.textBoxVKI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxVKI.DefaultText = "";
            this.textBoxVKI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxVKI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxVKI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxVKI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxVKI.FillColor = System.Drawing.Color.LightPink;
            this.textBoxVKI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxVKI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxVKI.ForeColor = System.Drawing.Color.Black;
            this.textBoxVKI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxVKI.Location = new System.Drawing.Point(169, 313);
            this.textBoxVKI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxVKI.Name = "textBoxVKI";
            this.textBoxVKI.PasswordChar = '\0';
            this.textBoxVKI.PlaceholderText = "";
            this.textBoxVKI.SelectedText = "";
            this.textBoxVKI.Size = new System.Drawing.Size(209, 38);
            this.textBoxVKI.TabIndex = 5;
            this.textBoxVKI.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.BackColor = System.Drawing.Color.Transparent;
            this.labelDurum.Font = new System.Drawing.Font("LEMON MILK Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDurum.Location = new System.Drawing.Point(12, 364);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(191, 36);
            this.labelDurum.TabIndex = 6;
            this.labelDurum.Text = "VKİ Durumu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 501);
            this.Controls.Add(this.labelDurum);
            this.Controls.Add(this.textBoxVKI);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.labelKilo);
            this.Controls.Add(this.textBoxKilo);
            this.Controls.Add(this.textBoxBoy);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VKİ Hesaplayıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxBoy;
        private System.Windows.Forms.Label labelKilo;
        private Guna.UI2.WinForms.Guna2TextBox textBoxKilo;
        private Guna.UI2.WinForms.Guna2Button buttonHesapla;
        private System.Windows.Forms.Label labelSonuc;
        private Guna.UI2.WinForms.Guna2TextBox textBoxVKI;
        private System.Windows.Forms.Label labelDurum;
    }
}

