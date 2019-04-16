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
            cityOutput.Text = Form1.days[0].location + " ON";
            dateLabel.Text = Form1.days[0].date;
            tempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString(".");
            conditionLabel.Text = Form1.days[0].condition;
            //minLabel.Text = Form1.days[0].tempLow + "  / " + Form1.days[0].tempHigh;
            minLabel.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString(".") + "  / " + Convert.ToDouble(Form1.days[0].tempHigh).ToString(".");

            date2Label.Text = Form1.days[1].date;
            date3Label.Text = Form1.days[2].date;
            date4Label.Text = Form1.days[3].date;

            min2Label.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString(".") + "  /";
            min3Label.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString(".") + "  /";
            min4Label.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString(".") + "  /";

            max2Label.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString(".");
            max3Label.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString(".");
            max4Label.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString(".");

            condition2Label.Text = Form1.days[1].condition;
            condition3Label.Text = Form1.days[2].condition;
            condition4Label.Text = Form1.days[3].condition;
        }

    }
}
