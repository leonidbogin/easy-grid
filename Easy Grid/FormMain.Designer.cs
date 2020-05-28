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
            this.userControlСoordinates1 = new Easy_Grid.Views.UserControlСoordinates();
            this.SuspendLayout();
            // 
            // userControlСoordinates1
            // 
            this.userControlСoordinates1.BackColor = System.Drawing.Color.White;
            this.userControlСoordinates1.Location = new System.Drawing.Point(3, 3);
            this.userControlСoordinates1.Name = "userControlСoordinates1";
            this.userControlСoordinates1.Size = new System.Drawing.Size(580, 456);
            this.userControlСoordinates1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 455);
            this.Controls.Add(this.userControlСoordinates1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "EasyGrid 1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.UserControlСoordinates userControlСoordinates1;
    }
}

