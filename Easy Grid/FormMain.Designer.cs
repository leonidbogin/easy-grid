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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.panelParameters.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelButtons.Controls.Add(this.panel2);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 414);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(586, 84);
            this.panelButtons.TabIndex = 1;
            // 
            // panelParameters
            // 
            this.panelParameters.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelParameters.Controls.Add(this.panel1);
            this.panelParameters.Controls.Add(this.button1);
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
            this.webBrowserMap.AllowWebBrowserDrop = false;
            this.webBrowserMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMap.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserMap.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMap.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.ScrollBarsEnabled = false;
            this.webBrowserMap.Size = new System.Drawing.Size(586, 373);
            this.webBrowserMap.TabIndex = 0;
            this.webBrowserMap.Url = new System.Uri("https://static-maps.yandex.ru/1.x/?ll=27.6374929707889,53.915409267192&size=565,3" +
        "40&z=14&l=sat,skl", System.UriKind.Absolute);
            this.webBrowserMap.WebBrowserShortcutsEnabled = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер квадратов в метрах";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(439, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить координаты";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 1);
            this.panel2.TabIndex = 4;
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
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

