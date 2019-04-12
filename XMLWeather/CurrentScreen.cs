using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            dateLabel.Text = Form1.days[0].date;
            tempLabel.Text = Form1.days[0].currentTemp;
            conditionLabel.Text = Form1.days[0].condition;
            maxLabel.Text = Form1.days[0].tempHigh;
            minLabel.Text = Form1.days[0].tempLow;

        }
    }
}
