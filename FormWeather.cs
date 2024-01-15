using CefSharp.Web;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleExample
{
    public partial class FormWeather : Form
    {
        public static float windspeed = 0;
        public static string direction = "";
        internal CustomControls.RJControls.RJButton buttonFetchWeather;
        private Label labelTitleSelection;
        public Label labelWindSpeed;
        public Label labelWindDirection;
        public static FormWeather instance;
        public FormWeather()
        {
            InitializeComponent();
            instance = this;
            MouseDown += Form_MouseDown_Drag;
            MouseMove += Form_MouseMove_Drag;
        }

        public void Form_MouseDown_Drag(object sender, MouseEventArgs e)
        {
            // Store the current mouse position
            GroundStation.instance.previousMousePosition = new Point(e.X, e.Y);
        }

        public void Form_MouseMove_Drag(object sender, MouseEventArgs e)
        {
            // Move the form when dragging
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    GroundStation.instance.Left += e.X - GroundStation.instance.previousMousePosition.X;
                    GroundStation.instance.Top += e.Y - GroundStation.instance.previousMousePosition.Y;
                }
            }
            catch
            {

            }
        }
        private async void buttonFetchWindData_Click(object sender, EventArgs e)
        {
            // Replace "YOUR_API_KEY" with your actual API key
            string apiKey = "bf1eff3e175047e9b8d35912241501";
            string city = "Niteroi";

            try
            {
                string apiUrl = $"http://api.weatherapi.com/v1/forecast.json?key={apiKey}&q={city}&days=1&aqi=no&alerts=no";

                using (HttpClient client = new HttpClient())
                {
                    string jsonResponse = await client.GetStringAsync(apiUrl);

                    // Parse JSON and extract wind data
                    Dictionary<string, object> data = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonResponse);


                    // Extract wind speed and direction
                    float windSpeed = 0.0f;
                    string windDirection = "OI :D";

                    // Update UI elements with wind data
                    instance.labelWindSpeed.Text = $"Wind Speed: {windSpeed} m/s";
                    instance.labelWindDirection.Text = $"Wind Direction: {windDirection} degrees";
                    foreach (var kvp in data)
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching weather data: {ex.Message}");
            }
        }

        // Define uma classe para representar os dados do tempo
        public class WeatherData
        {
            public WindData wind { get; set; }
        }

        public class WindData
        {
            public float speed { get; set; }
            public string deg { get; set; }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelControlData_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Updates the serial port list when the user clicks on the combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void rjTextBoxLogDirectory__TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSeneca_Click(object sender, EventArgs e)
        {
            FormSeneca formSeneca = new FormSeneca();
            formSeneca.ShowDialog();
        }

        private void InitializeComponent()
        {
            this.buttonFetchWeather = new CustomControls.RJControls.RJButton();
            this.labelTitleSelection = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.labelWindDirection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFetchWeather
            // 
            this.buttonFetchWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonFetchWeather.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonFetchWeather.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonFetchWeather.BorderRadius = 10;
            this.buttonFetchWeather.BorderSize = 0;
            this.buttonFetchWeather.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchWeather.FlatAppearance.BorderSize = 0;
            this.buttonFetchWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchWeather.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchWeather.ForeColor = System.Drawing.Color.Coral;
            this.buttonFetchWeather.Location = new System.Drawing.Point(761, 12);
            this.buttonFetchWeather.Name = "buttonFetchWeather";
            this.buttonFetchWeather.Size = new System.Drawing.Size(137, 31);
            this.buttonFetchWeather.TabIndex = 18;
            this.buttonFetchWeather.Text = "Atualizar clima";
            this.buttonFetchWeather.TextColor = System.Drawing.Color.Coral;
            this.buttonFetchWeather.UseVisualStyleBackColor = false;
            this.buttonFetchWeather.Click += new System.EventHandler(this.buttonFetchWindData_Click);
            // 
            // labelTitleSelection
            // 
            this.labelTitleSelection.AutoSize = true;
            this.labelTitleSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleSelection.ForeColor = System.Drawing.Color.Coral;
            this.labelTitleSelection.Location = new System.Drawing.Point(37, 55);
            this.labelTitleSelection.Name = "labelTitleSelection";
            this.labelTitleSelection.Size = new System.Drawing.Size(245, 32);
            this.labelTitleSelection.TabIndex = 19;
            this.labelTitleSelection.Text = "Dados climáticos";
            this.labelTitleSelection.Click += new System.EventHandler(this.labelTitleSelection_Click);
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeed.ForeColor = System.Drawing.Color.Coral;
            this.labelWindSpeed.Location = new System.Drawing.Point(103, 123);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(179, 20);
            this.labelWindSpeed.TabIndex = 21;
            this.labelWindSpeed.Text = "Aguardando dados...";
            // 
            // labelWindDirection
            // 
            this.labelWindDirection.AutoSize = true;
            this.labelWindDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindDirection.ForeColor = System.Drawing.Color.Coral;
            this.labelWindDirection.Location = new System.Drawing.Point(103, 163);
            this.labelWindDirection.Name = "labelWindDirection";
            this.labelWindDirection.Size = new System.Drawing.Size(179, 20);
            this.labelWindDirection.TabIndex = 22;
            this.labelWindDirection.Text = "Aguardando dados...";
            // 
            // FormWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(910, 480);
            this.Controls.Add(this.labelWindDirection);
            this.Controls.Add(this.labelWindSpeed);
            this.Controls.Add(this.labelTitleSelection);
            this.Controls.Add(this.buttonFetchWeather);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWeather";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormWeather_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormWeather_Load(object sender, EventArgs e)
        {

        }

        private void labelTitleSelection_Click(object sender, EventArgs e)
        {

        }
    }
}
