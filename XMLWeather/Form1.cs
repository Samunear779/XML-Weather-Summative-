using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        //create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //create a day object
                Day d = new Day();

                //TODO: fill day object with required data

                //date
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                // current conditions 
                reader.ReadToFollowing("symbol");
                d.condition = reader.GetAttribute("name");

                //temp low 
                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                //temp High
                d.tempHigh = reader.GetAttribute("max");

                Day d2 = new Day();
                //d2
                reader.ReadToFollowing("time");
                d2.date = reader.GetAttribute("day");
                //2Condition
                reader.ReadToFollowing("symbol");
                d2.condition = reader.GetAttribute("name");
                //2L 
                reader.ReadToFollowing("temperature");
                d2.tempLow = reader.GetAttribute("min");
                //2H
                d2.tempHigh = reader.GetAttribute("max");
             

                Day d3 = new Day();
                //d3
                reader.ReadToFollowing("time");
                d3.date = reader.GetAttribute("day");
                //3Condition
                reader.ReadToFollowing("symbol");
                d3.condition = reader.GetAttribute("name");
                //3L
                reader.ReadToFollowing("temperature");
                d3.tempLow = reader.GetAttribute("min");
                //3H
                d3.tempHigh = reader.GetAttribute("max");
              

                Day d4 = new Day();
                //d4
                reader.ReadToFollowing("time");
                d4.date = reader.GetAttribute("day");
                //4Condition
                reader.ReadToFollowing("symbol");
                d4.condition = reader.GetAttribute("name");
                //4L
                reader.ReadToFollowing("temperature");
                d4.tempLow = reader.GetAttribute("min");
                //4H
                d4.tempHigh = reader.GetAttribute("max");
           

                //if day object not null add to the days list
                if (d.date!= null)
                {
                    days.Add(d);
                    days.Add(d2);
                    days.Add(d3);
                    days.Add(d4);
                }             
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            //current temp
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
        }
    }
}
