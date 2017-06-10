namespace Login_Design
{
    partial class MenuEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menueklebtn = new System.Windows.Forms.Button();
            this.menuismitxt = new System.Windows.Forms.TextBox();
            this.menufiyatitxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.eklendilbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menü Fiyatı";
            // 
            // menueklebtn
            // 
            this.menueklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menueklebtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menueklebtn.Image = ((System.Drawing.Image)(resources.GetObject("menueklebtn.Image")));
            this.menueklebtn.Location = new System.Drawing.Point(165, 120);
            this.menueklebtn.Name = "menueklebtn";
            this.menueklebtn.Size = new System.Drawing.Size(75, 40);
            this.menueklebtn.TabIndex = 2;
            this.menueklebtn.UseVisualStyleBackColor = true;
            this.menueklebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuismitxt
            // 
            this.menuismitxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuismitxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuismitxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuismitxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuismitxt.Location = new System.Drawing.Point(165, 12);
            this.menuismitxt.Multiline = true;
            this.menuismitxt.Name = "menuismitxt";
            this.menuismitxt.Size = new System.Drawing.Size(183, 33);
            this.menuismitxt.TabIndex = 3;
            // 
            // menufiyatitxt
            // 
            this.menufiyatitxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menufiyatitxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menufiyatitxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menufiyatitxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menufiyatitxt.Location = new System.Drawing.Point(165, 65);
            this.menufiyatitxt.Multiline = true;
            this.menufiyatitxt.Name = "menufiyatitxt";
            this.menufiyatitxt.Size = new System.Drawing.Size(183, 33);
            this.menufiyatitxt.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(273, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // eklendilbl
            // 
            this.eklendilbl.AutoSize = true;
            this.eklendilbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklendilbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.eklendilbl.Location = new System.Drawing.Point(162, 163);
            this.eklendilbl.Name = "eklendilbl";
            this.eklendilbl.Size = new System.Drawing.Size(48, 13);
            this.eklendilbl.TabIndex = 6;
            this.eklendilbl.Text = "Eklendi";
            this.eklendilbl.Visible = false;
            // 
            // MenuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 179);
            this.Controls.Add(this.eklendilbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menufiyatitxt);
            this.Controls.Add(this.menuismitxt);
            this.Controls.Add(this.menueklebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuEkle";
            this.Load += new System.EventHandler(this.MenuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button menueklebtn;
        private System.Windows.Forms.TextBox menuismitxt;
        private System.Windows.Forms.TextBox menufiyatitxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label eklendilbl;
    }
}