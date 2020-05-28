namespace Easy_Grid
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelParameters = new System.Windows.Forms.Panel();
            this.panelMap = new System.Windows.Forms.Panel();
            this.webBrowserMap = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelParameters.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 414);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(586, 84);
            this.panelButtons.TabIndex = 1;
            // 
            // panelParameters
            // 
            this.panelParameters.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelParameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelParameters.Controls.Add(this.comboBox1);
            this.panelParameters.Controls.Add(this.label1);
            this.panelParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParameters.Location = new System.Drawing.Point(0, 0);
            this.panelParameters.Name = "panelParameters";
            this.panelParameters.Size = new System.Drawing.Size(586, 41);
            this.panelParameters.TabIndex = 2;
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.webBrowserMap);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 41);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(586, 373);
            this.panelMap.TabIndex = 3;
            // 
            // webBrowserMap
            // 
            this.webBrowserMap.AllowNavigation = false;
            this.webBrowserMap.AllowWebBrowserDrop = false;
            this.webBrowserMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMap.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserMap.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.Size = new System.Drawing.Size(586, 373);
            this.webBrowserMap.TabIndex = 0;
            this.webBrowserMap.Url = new System.Uri("https://static-maps.yandex.ru/1.x/?ll=27.6374929707889,53.915409267192&size=650,4" +
        "50&z=14&l=sat,skl", System.UriKind.Absolute);
            this.webBrowserMap.WebBrowserShortcutsEnabled = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер квадрата в метрах";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 498);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.panelParameters);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "EasyGrid 1.0";
            this.panelParameters.ResumeLayout(false);
            this.panelParameters.PerformLayout();
            this.panelMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelParameters;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.WebBrowser webBrowserMap;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

