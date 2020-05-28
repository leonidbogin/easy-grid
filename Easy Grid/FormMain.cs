using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Grid
{
    public partial class FormMain : Form
    {
        private Coordinates lastCoordinates;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            CheckCoordinates();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckCoordinates();
        }

        public void CheckCoordinates()
        {
            Coordinates newCoordinates = FilesWorker.GetCoordinates();
            if (newCoordinates != null)
            { 
                if (lastCoordinates == null || !Coordinates.Equals(newCoordinates, lastCoordinates))
                {
                    
                    lastCoordinates = newCoordinates;
                }
                
            } 
            else
            {
                MessageBox.Show(CONST.Error.LastSelection, CONST.Error.LastSelectionHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
