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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuLeft = new System.Windows.Forms.Panel();
            this.panelBoxSize = new System.Windows.Forms.Panel();
            this.comboBoxBoxSize = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenuRight = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panelMenuBorder = new System.Windows.Forms.Panel();
            this.webControlMap = new Awesomium.Windows.Forms.WebControl(this.components);
            this.panelMap = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelMenuLeft.SuspendLayout();
            this.panelBoxSize.SuspendLayout();
            this.panelMenuRight.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.Controls.Add(this.panelMenuLeft);
            this.panelMenu.Controls.Add(this.panelMenuRight);
            this.panelMenu.Controls.Add(this.panelMenuBorder);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(586, 36);
            this.panelMenu.TabIndex = 2;
            // 
            // panelMenuLeft
            // 
            this.panelMenuLeft.BackColor = System.Drawing.Color.DimGray;
            this.panelMenuLeft.Controls.Add(this.panelBoxSize);
            this.panelMenuLeft.Controls.Add(this.button1);
            this.panelMenuLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLeft.Name = "panelMenuLeft";
            this.panelMenuLeft.Padding = new System.Windows.Forms.Padding(7, 5, 5, 5);
            this.panelMenuLeft.Size = new System.Drawing.Size(496, 35);
            this.panelMenuLeft.TabIndex = 5;
            // 
            // panelBoxSize
            // 
            this.panelBoxSize.BackColor = System.Drawing.SystemColors.Control;
            this.panelBoxSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBoxSize.Controls.Add(this.comboBoxBoxSize);
            this.panelBoxSize.Location = new System.Drawing.Point(163, 5);
            this.panelBoxSize.Name = "panelBoxSize";
            this.panelBoxSize.Size = new System.Drawing.Size(55, 25);
            this.panelBoxSize.TabIndex = 6;
            // 
            // comboBoxBoxSize
            // 
            this.comboBoxBoxSize.BackColor = System.Drawing.Color.White;
            this.comboBoxBoxSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxBoxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBoxSize.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBoxSize.FormatString = "N0";
            this.comboBoxBoxSize.FormattingEnabled = true;
            this.comboBoxBoxSize.Items.AddRange(new object[] {
            "500",
            "200"});
            this.comboBoxBoxSize.Location = new System.Drawing.Point(0, 0);
            this.comboBoxBoxSize.Name = "comboBoxBoxSize";
            this.comboBoxBoxSize.Size = new System.Drawing.Size(53, 24);
            this.comboBoxBoxSize.TabIndex = 3;
            this.comboBoxBoxSize.Text = "500";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Импорт из SAS.Planet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMenuRight
            // 
            this.panelMenuRight.BackColor = System.Drawing.Color.DimGray;
            this.panelMenuRight.Controls.Add(this.button4);
            this.panelMenuRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuRight.Location = new System.Drawing.Point(496, 0);
            this.panelMenuRight.Name = "panelMenuRight";
            this.panelMenuRight.Padding = new System.Windows.Forms.Padding(5);
            this.panelMenuRight.Size = new System.Drawing.Size(90, 35);
            this.panelMenuRight.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(5, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 25);
            this.button4.TabIndex = 4;
            this.button4.Text = "Справка";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panelMenuBorder
            // 
            this.panelMenuBorder.BackColor = System.Drawing.Color.DimGray;
            this.panelMenuBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenuBorder.Location = new System.Drawing.Point(0, 35);
            this.panelMenuBorder.Name = "panelMenuBorder";
            this.panelMenuBorder.Size = new System.Drawing.Size(586, 1);
            this.panelMenuBorder.TabIndex = 3;
            // 
            // webControlMap
            // 
            this.webControlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControlMap.Location = new System.Drawing.Point(0, 0);
            this.webControlMap.Size = new System.Drawing.Size(586, 408);
            this.webControlMap.Source = new System.Uri("http://google.com/", System.UriKind.Absolute);
            this.webControlMap.TabIndex = 0;
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.webControlMap);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 36);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(586, 408);
            this.panelMap.TabIndex = 3;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F);
            this.button2.Location = new System.Drawing.Point(222, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "SAS.Planet";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сохранить координатную сетку";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelButtons.Controls.Add(this.label1);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.panel2);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 444);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(586, 54);
            this.panelButtons.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 498);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "EasyGrid 1.0";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuLeft.ResumeLayout(false);
            this.panelBoxSize.ResumeLayout(false);
            this.panelMenuRight.ResumeLayout(false);
            this.panelMap.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMenuBorder;
        private Awesomium.Windows.Forms.WebControl a;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelMenuRight;
        private System.Windows.Forms.Panel panelMenuLeft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelBoxSize;
        private System.Windows.Forms.ComboBox comboBoxBoxSize;
        private Awesomium.Windows.Forms.WebControl webControlMap;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButtons;
    }
}

