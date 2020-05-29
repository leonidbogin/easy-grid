using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Grid
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FormMain : Form
    {
        private Coordinates coordinates;

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
            coordinates = null;
            CheckCoordinates();
        }

        public void CheckCoordinates()
        {
            Coordinates newCoordinates = FilesWorker.GetCoordinates();
            if (newCoordinates != null)
            { 
                if (coordinates == null || !Coordinates.Equals(newCoordinates, coordinates))
                {
                    coordinates = newCoordinates;
                    Grid grid = GeoCalc.GetGrid(coordinates, 500);
                    //webControlMaps.Source = new Uri(StaticAPI.GetURL(coordinates, grid.line));
                    webControlMaps.Source = new Uri(Application.StartupPath + @"\index.html");
                    comboBox1.Text = Application.StartupPath + @"\index.html";
                }
                
            } 
            else
            {
                MessageBox.Show(CONST.Error.LastSelection, CONST.Error.LastSelectionHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
