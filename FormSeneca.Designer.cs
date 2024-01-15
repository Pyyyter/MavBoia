﻿namespace SimpleExample
{
    partial class FormSeneca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeneca));
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxBipolar = new System.Windows.Forms.CheckBox();
            this.labelEscalaMin = new System.Windows.Forms.Label();
            this.rjTextBoxEscalaMin = new CustomControls.RJControls.RJTextBox();
            this.rjTextBoxCurrent = new CustomControls.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rjTextBoxEscalaMax = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rjTextBoxBurden = new CustomControls.RJControls.RJTextBox();
            this.labelCorrente = new System.Windows.Forms.Label();
            this.rjTextBoxmilliVoltage = new CustomControls.RJControls.RJTextBox();
            this.labelT201 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelConfigurações = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(41, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Modo bipolar";
            // 
            // checkBoxBipolar
            // 
            this.checkBoxBipolar.AutoSize = true;
            this.checkBoxBipolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.checkBoxBipolar.ForeColor = System.Drawing.Color.Coral;
            this.checkBoxBipolar.Location = new System.Drawing.Point(180, 89);
            this.checkBoxBipolar.Name = "checkBoxBipolar";
            this.checkBoxBipolar.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBipolar.TabIndex = 56;
            this.checkBoxBipolar.UseVisualStyleBackColor = true;
            // 
            // labelEscalaMin
            // 
            this.labelEscalaMin.AutoSize = true;
            this.labelEscalaMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEscalaMin.ForeColor = System.Drawing.Color.Coral;
            this.labelEscalaMin.Location = new System.Drawing.Point(41, 123);
            this.labelEscalaMin.Name = "labelEscalaMin";
            this.labelEscalaMin.Size = new System.Drawing.Size(111, 17);
            this.labelEscalaMin.TabIndex = 55;
            this.labelEscalaMin.Text = "Escala Mínima";
            // 
            // rjTextBoxEscalaMin
            // 
            this.rjTextBoxEscalaMin.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxEscalaMin.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxEscalaMin.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxEscalaMin.BorderRadius = 0;
            this.rjTextBoxEscalaMin.BorderSize = 2;
            this.rjTextBoxEscalaMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxEscalaMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxEscalaMin.Location = new System.Drawing.Point(180, 123);
            this.rjTextBoxEscalaMin.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxEscalaMin.Multiline = false;
            this.rjTextBoxEscalaMin.Name = "rjTextBoxEscalaMin";
            this.rjTextBoxEscalaMin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxEscalaMin.PasswordChar = false;
            this.rjTextBoxEscalaMin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxEscalaMin.PlaceholderText = "";
            this.rjTextBoxEscalaMin.Size = new System.Drawing.Size(116, 30);
            this.rjTextBoxEscalaMin.TabIndex = 54;
            this.rjTextBoxEscalaMin.Texts = "0";
            this.rjTextBoxEscalaMin.UnderlinedStyle = false;
            // 
            // rjTextBoxCurrent
            // 
            this.rjTextBoxCurrent.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxCurrent.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxCurrent.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxCurrent.BorderRadius = 0;
            this.rjTextBoxCurrent.BorderSize = 2;
            this.rjTextBoxCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxCurrent.Location = new System.Drawing.Point(180, 383);
            this.rjTextBoxCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxCurrent.Multiline = false;
            this.rjTextBoxCurrent.Name = "rjTextBoxCurrent";
            this.rjTextBoxCurrent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxCurrent.PasswordChar = false;
            this.rjTextBoxCurrent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxCurrent.PlaceholderText = "";
            this.rjTextBoxCurrent.Size = new System.Drawing.Size(116, 30);
            this.rjTextBoxCurrent.TabIndex = 53;
            this.rjTextBoxCurrent.Texts = "0";
            this.rjTextBoxCurrent.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(41, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Escala Máxima";
            // 
            // rjTextBoxEscalaMax
            // 
            this.rjTextBoxEscalaMax.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxEscalaMax.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxEscalaMax.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxEscalaMax.BorderRadius = 0;
            this.rjTextBoxEscalaMax.BorderSize = 2;
            this.rjTextBoxEscalaMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxEscalaMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxEscalaMax.Location = new System.Drawing.Point(180, 170);
            this.rjTextBoxEscalaMax.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxEscalaMax.Multiline = false;
            this.rjTextBoxEscalaMax.Name = "rjTextBoxEscalaMax";
            this.rjTextBoxEscalaMax.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxEscalaMax.PasswordChar = false;
            this.rjTextBoxEscalaMax.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxEscalaMax.PlaceholderText = "";
            this.rjTextBoxEscalaMax.Size = new System.Drawing.Size(116, 30);
            this.rjTextBoxEscalaMax.TabIndex = 51;
            this.rjTextBoxEscalaMax.Texts = "100";
            this.rjTextBoxEscalaMax.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(41, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Valor burden";
            // 
            // rjTextBoxBurden
            // 
            this.rjTextBoxBurden.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxBurden.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxBurden.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxBurden.BorderRadius = 0;
            this.rjTextBoxBurden.BorderSize = 2;
            this.rjTextBoxBurden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxBurden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxBurden.Location = new System.Drawing.Point(180, 216);
            this.rjTextBoxBurden.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxBurden.Multiline = false;
            this.rjTextBoxBurden.Name = "rjTextBoxBurden";
            this.rjTextBoxBurden.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxBurden.PasswordChar = false;
            this.rjTextBoxBurden.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxBurden.PlaceholderText = "";
            this.rjTextBoxBurden.Size = new System.Drawing.Size(116, 30);
            this.rjTextBoxBurden.TabIndex = 49;
            this.rjTextBoxBurden.Texts = "47";
            this.rjTextBoxBurden.UnderlinedStyle = false;
            // 
            // labelCorrente
            // 
            this.labelCorrente.AutoSize = true;
            this.labelCorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrente.ForeColor = System.Drawing.Color.Coral;
            this.labelCorrente.Location = new System.Drawing.Point(41, 383);
            this.labelCorrente.Name = "labelCorrente";
            this.labelCorrente.Size = new System.Drawing.Size(113, 17);
            this.labelCorrente.TabIndex = 48;
            this.labelCorrente.Text = "Corrente T201";
            // 
            // rjTextBoxmilliVoltage
            // 
            this.rjTextBoxmilliVoltage.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxmilliVoltage.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxmilliVoltage.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxmilliVoltage.BorderRadius = 0;
            this.rjTextBoxmilliVoltage.BorderSize = 2;
            this.rjTextBoxmilliVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxmilliVoltage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxmilliVoltage.Location = new System.Drawing.Point(180, 318);
            this.rjTextBoxmilliVoltage.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxmilliVoltage.Multiline = false;
            this.rjTextBoxmilliVoltage.Name = "rjTextBoxmilliVoltage";
            this.rjTextBoxmilliVoltage.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxmilliVoltage.PasswordChar = false;
            this.rjTextBoxmilliVoltage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxmilliVoltage.PlaceholderText = "";
            this.rjTextBoxmilliVoltage.Size = new System.Drawing.Size(116, 30);
            this.rjTextBoxmilliVoltage.TabIndex = 47;
            this.rjTextBoxmilliVoltage.Texts = "0";
            this.rjTextBoxmilliVoltage.UnderlinedStyle = false;
            // 
            // labelT201
            // 
            this.labelT201.AutoSize = true;
            this.labelT201.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT201.ForeColor = System.Drawing.Color.Coral;
            this.labelT201.Location = new System.Drawing.Point(47, 276);
            this.labelT201.Name = "labelT201";
            this.labelT201.Size = new System.Drawing.Size(89, 17);
            this.labelT201.TabIndex = 46;
            this.labelT201.Text = "Tensão mV";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(180, 276);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(116, 45);
            this.trackBar1.TabIndex = 45;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // labelConfigurações
            // 
            this.labelConfigurações.AutoSize = true;
            this.labelConfigurações.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurações.ForeColor = System.Drawing.Color.Coral;
            this.labelConfigurações.Location = new System.Drawing.Point(116, 27);
            this.labelConfigurações.Name = "labelConfigurações";
            this.labelConfigurações.Size = new System.Drawing.Size(339, 32);
            this.labelConfigurações.TabIndex = 58;
            this.labelConfigurações.Text = "Calculadora do T201DC";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(326, 334);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // FormSeneca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelConfigurações);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxBipolar);
            this.Controls.Add(this.labelEscalaMin);
            this.Controls.Add(this.rjTextBoxEscalaMin);
            this.Controls.Add(this.rjTextBoxCurrent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rjTextBoxEscalaMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rjTextBoxBurden);
            this.Controls.Add(this.labelCorrente);
            this.Controls.Add(this.rjTextBoxmilliVoltage);
            this.Controls.Add(this.labelT201);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSeneca";
            this.Text = "FormSeneca";
            this.Load += new System.EventHandler(this.FormSeneca_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown_Drag);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove_Drag);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxBipolar;
        public System.Windows.Forms.Label labelEscalaMin;
        internal CustomControls.RJControls.RJTextBox rjTextBoxEscalaMin;
        internal CustomControls.RJControls.RJTextBox rjTextBoxCurrent;
        public System.Windows.Forms.Label label5;
        internal CustomControls.RJControls.RJTextBox rjTextBoxEscalaMax;
        public System.Windows.Forms.Label label4;
        internal CustomControls.RJControls.RJTextBox rjTextBoxBurden;
        public System.Windows.Forms.Label labelCorrente;
        internal CustomControls.RJControls.RJTextBox rjTextBoxmilliVoltage;
        public System.Windows.Forms.Label labelT201;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelConfigurações;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}