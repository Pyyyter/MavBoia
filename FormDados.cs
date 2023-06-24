﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleExample
{
    public partial class FormDados : Form
    {
        public static Form instance;
        public static float currentMotor { get; set; } = 0.0f;
        public static float currentMPPT = 0.0f;
        public static float currentBattery = 0.0f;
        public static float batteryVoltage = 0.0f;
        public static float latitude = 0.000000f;
        public static float longitude = 0.000000f;
        public static float temperatureMotor = 0.0f;
        public static float temperatureMPPT = 0.0f;
        public FormDados()
        {
            InitializeComponent();
            instance = this;
            
        }
    }
}
