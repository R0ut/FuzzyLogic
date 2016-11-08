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
        wykresy w = new wykresy();

        public MainWindow()
        {
            InitializeComponent();
            TimerPoryDnia tZmianaPoryDnia = new TimerPoryDnia(pictureBoxPoraDnia, labelTemperaturaNaDworzu);
            pictureBoxOkno.ImageLocation = Path.Combine(@"Resources\", "okno.png");

            

           




        }
        private void pictureBoxOkno_OnClick(object sender, EventArgs e)
        {


            string a = labelTemperaturaNaDworzu.Text;

            if (w.zzz(Convert.ToDouble(a)) != 0) w.zzz(Convert.ToDouble(a));
            else if (w.zz(Convert.ToDouble(a)) != 0) w.zz(Convert.ToDouble(a));
            else if (w.z(Convert.ToDouble(a)) != 0) w.z(Convert.ToDouble(a));
            else if (w.ok(Convert.ToDouble(a)) != 0) w.ok(Convert.ToDouble(a));
            else if (w.c(Convert.ToDouble(a)) != 0) w.c(Convert.ToDouble(a));
            else if (w.cc(Convert.ToDouble(a)) != 0) w.cc(Convert.ToDouble(a));
            else if (w.ccc(Convert.ToDouble(a)) != 0) w.ccc(Convert.ToDouble(a));


            textBoxTemperaturaPozadana.Text = w.piecyk.ToString();
            textBoxTemperaturaAktualna.Text = w.klima.ToString();


           // textBoxTemperaturaAktualna.Text = labelTemperaturaNaDworzu.Text;
            if (pictureBoxOkno.ImageLocation == Path.Combine(@"Resources\", "okno.png"))
            {
                pictureBoxOkno.ImageLocation = Path.Combine(@"Resources\", "oknoOtwarte.png");
            }
            else
            {
                pictureBoxOkno.ImageLocation = Path.Combine(@"Resources\", "okno.png");
            }
        }
    }
}
