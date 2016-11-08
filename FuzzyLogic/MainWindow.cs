using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyLogic
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            TimerPoryDnia tZmianaPoryDnia = new TimerPoryDnia(pictureBoxPoraDnia, labelTemperaturaNaDworzu);
            pictureBoxOkno.ImageLocation = Path.Combine(Environment.CurrentDirectory, @"Resources\", "okno.png");

        }
        private void pictureBoxOkno_OnClick(object sender, EventArgs e)
        {
            textBoxTemperaturaAktualna.Text = labelTemperaturaNaDworzu.Text;
            if (pictureBoxOkno.ImageLocation == Path.Combine(Environment.CurrentDirectory, @"Resources\", "okno.png"))
            {
                pictureBoxOkno.ImageLocation = Path.Combine(Environment.CurrentDirectory, @"Resources\", "oknoOtwarte.png");
            }
            else
            {
                pictureBoxOkno.ImageLocation = Path.Combine(Environment.CurrentDirectory, @"Resources\", "okno.png");
            }
            //textBoxTemperaturaPozadana.Text = pictureBoxOkno.ImageLocation.Substring(pictureBoxOkno.ImageLocation.LastIndexOf('.')-4);
        }
    }
}
