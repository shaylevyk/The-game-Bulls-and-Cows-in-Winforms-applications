using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameForms
{
    public partial class ColorForm : Form
    {
        private Color selectedColor = new Color();
        private Button AquamarineColoredButton;
        // $G$ DSN-004 (-5) Code duplication. You could have used a collection of colors/buttons instead.
        private Button TomatoColoredButton;
        private Button NavyColoredButton;
        private Button YellowGreenColoredButton;
        private Button DarkRedColoredButton;
        private Button LavenderColoredButton;
        private Button NavajoWhiteColoredButton;
        private Button DarkMagentaColoredButton;

        public Color SelectedColor
        {
            get
            {
                return selectedColor;
            }

            set
            {
                selectedColor = value;
            }
        }

        public ColorForm()
        {
            InitializeComponent();
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {
        }

        private void AquamarineColoredButton_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Aquamarine;
            this.Close();
        }

        private void TomatoColoredButton_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Tomato;
            this.Close();
        }

        private void NavyColoredButton_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Navy;
            this.Close();
        }

        private void YellowGreenColoredButton_Click(object sender, EventArgs e)
        {
            selectedColor = Color.YellowGreen;
            this.Close();
        }

        private void DarkRedColoredButton_Click(object sender, EventArgs e)
        {
            selectedColor = Color.DarkRed;
            this.Close();
        }

        private void LavenderColoredButton_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Lavender;
            this.Close();
        }

        private void NavajoWhiteColoredButton_Click(object sender, EventArgs e)
        {
            selectedColor = Color.NavajoWhite;
            this.Close();
        }

        private void DarkMagentaColoredButton_Click(object sender, EventArgs e)
        {
            selectedColor = Color.DarkMagenta;
            this.Close();
        }

        private void InitializeComponent()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.AquamarineColoredButton = new System.Windows.Forms.Button();
            this.TomatoColoredButton = new System.Windows.Forms.Button();
            this.NavyColoredButton = new System.Windows.Forms.Button();
            this.YellowGreenColoredButton = new System.Windows.Forms.Button();
            this.DarkRedColoredButton = new System.Windows.Forms.Button();
            this.LavenderColoredButton = new System.Windows.Forms.Button();
            this.NavajoWhiteColoredButton = new System.Windows.Forms.Button();
            this.DarkMagentaColoredButton = new System.Windows.Forms.Button();

            this.AquamarineColoredButton.Location = new System.Drawing.Point(20, 20);
            this.AquamarineColoredButton.Name = "AquamarineColoredButton";
            this.AquamarineColoredButton.Size = new System.Drawing.Size(35, 35);
            this.AquamarineColoredButton.TabIndex = 0;
            this.AquamarineColoredButton.Text = " ";
            AquamarineColoredButton.BackColor = Color.Aquamarine;
            this.AquamarineColoredButton.Click += new System.EventHandler(this.AquamarineColoredButton_Click);

            this.TomatoColoredButton.Location = new System.Drawing.Point(60, 20);
            this.TomatoColoredButton.Name = "TomatoColoredButton";
            this.TomatoColoredButton.Size = new System.Drawing.Size(35, 35);
            this.TomatoColoredButton.TabIndex = 0;
            this.TomatoColoredButton.Text = " ";
            TomatoColoredButton.BackColor = Color.Tomato;
            this.TomatoColoredButton.Click += new System.EventHandler(this.TomatoColoredButton_Click);

            this.NavyColoredButton.Location = new System.Drawing.Point(100, 20);
            this.NavyColoredButton.Name = "NavyColoredButton";
            this.NavyColoredButton.Size = new System.Drawing.Size(35, 35);
            this.NavyColoredButton.TabIndex = 0;
            this.NavyColoredButton.Text = " ";
            NavyColoredButton.BackColor = Color.Navy;
            this.NavyColoredButton.Click += new System.EventHandler(this.NavyColoredButton_Click);

            this.YellowGreenColoredButton.Location = new System.Drawing.Point(140, 20);
            this.YellowGreenColoredButton.Name = "YellowGreenColoredButton";
            this.YellowGreenColoredButton.Size = new System.Drawing.Size(35, 35);
            this.YellowGreenColoredButton.TabIndex = 0;
            this.YellowGreenColoredButton.Text = " ";
            YellowGreenColoredButton.BackColor = Color.YellowGreen;
            this.YellowGreenColoredButton.Click += new System.EventHandler(this.YellowGreenColoredButton_Click);

            this.DarkRedColoredButton.Location = new System.Drawing.Point(20, 60);
            this.DarkRedColoredButton.Name = "DarkRedColoredButton";
            this.DarkRedColoredButton.Size = new System.Drawing.Size(35, 35);
            this.DarkRedColoredButton.TabIndex = 0;
            this.DarkRedColoredButton.Text = " ";
            DarkRedColoredButton.BackColor = Color.DarkRed;
            this.DarkRedColoredButton.Click += new System.EventHandler(this.DarkRedColoredButton_Click);

            this.LavenderColoredButton.Location = new System.Drawing.Point(60, 60);
            this.LavenderColoredButton.Name = "LavenderColoredButton";
            this.LavenderColoredButton.Size = new System.Drawing.Size(35, 35);
            this.LavenderColoredButton.TabIndex = 0;
            this.LavenderColoredButton.Text = " ";
            LavenderColoredButton.BackColor = Color.Lavender;
            this.LavenderColoredButton.Click += new System.EventHandler(this.LavenderColoredButton_Click);

            this.NavajoWhiteColoredButton.Location = new System.Drawing.Point(100, 60);
            this.NavajoWhiteColoredButton.Name = "NavajoWhiteColoredButton";
            this.NavajoWhiteColoredButton.Size = new System.Drawing.Size(35, 35);
            this.NavajoWhiteColoredButton.TabIndex = 0;
            this.NavajoWhiteColoredButton.Text = " ";
            NavajoWhiteColoredButton.BackColor = Color.NavajoWhite;
            this.NavajoWhiteColoredButton.Click += new System.EventHandler(this.NavajoWhiteColoredButton_Click);

            this.DarkMagentaColoredButton.Location = new System.Drawing.Point(140, 60);
            this.DarkMagentaColoredButton.Name = "DarkMagentaColoredButton";
            this.DarkMagentaColoredButton.Size = new System.Drawing.Size(35, 35);
            this.DarkMagentaColoredButton.TabIndex = 0;
            this.DarkMagentaColoredButton.Text = " ";
            DarkMagentaColoredButton.BackColor = Color.DarkMagenta;
            this.DarkMagentaColoredButton.Click += new System.EventHandler(this.DarkMagentaColoredButton_Click);

            this.Controls.Add(AquamarineColoredButton);
            this.Controls.Add(TomatoColoredButton);
            this.Controls.Add(NavyColoredButton);
            this.Controls.Add(YellowGreenColoredButton);
            this.Controls.Add(DarkRedColoredButton);
            this.Controls.Add(LavenderColoredButton);
            this.Controls.Add(NavajoWhiteColoredButton);
            this.Controls.Add(DarkMagentaColoredButton);

            this.ClientSize = new System.Drawing.Size(191, 115);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColorForm";
            this.ResumeLayout(false);
        }
    }
}
