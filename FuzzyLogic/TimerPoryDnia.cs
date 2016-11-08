using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyLogic
{
    class TimerPoryDnia
    {
        PictureBox picBox { get; set; }
        Label labelTemperaturaNaDworzu { get; set; }
        public TimerPoryDnia(PictureBox PicBox, Label LabelTemperaturaNaDworzu)
        {
            picBox = PicBox;
            labelTemperaturaNaDworzu = LabelTemperaturaNaDworzu;
            labelTemperaturaNaDworzu.Text = Randomizer.RandomNumber(5, 20).ToString();
            TimerImplementation();
        }
        private void TimerImplementation()
        {
            System.Timers.Timer timerZmianaPoryDnia = new System.Timers.Timer();
            timerZmianaPoryDnia.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            timerZmianaPoryDnia.Interval = 250;
            timerZmianaPoryDnia.Enabled = true;
        }


        int czas = 0;
        string temperatura;
        private void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            czas++;
            if(czas <120 && czas % 30 == 0) //temp dzien
            {
                temperatura = Randomizer.RandomNumber(5, 20).ToString();
                SetText(temperatura);
            }
            if(czas > 120 && czas % 30 == 0) //temp noc
            {
                temperatura = Randomizer.RandomNumber(-10, 10).ToString();
                SetText(temperatura);
            }
            if (czas == 120)
            {
                picBox.Image = Properties.Resources.noc; 
            }
            if (czas == 180)
            {
                picBox.Image = Properties.Resources.dzien;
                czas = 0;
            }
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if(this.labelTemperaturaNaDworzu.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                labelTemperaturaNaDworzu.Invoke(d, new object[] { text });
            }
            else
            {
                this.labelTemperaturaNaDworzu.Text = text;
            }
        }
    }
}
