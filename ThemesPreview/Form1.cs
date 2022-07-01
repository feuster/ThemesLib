namespace ThemesPreview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Maximum=Feuster.Themes.ThemeList.Length-1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool dm = false;
            colorDialog1.AllowFullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            var Color1 = colorDialog1.Color;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            var Color2 = colorDialog1.Color;

            Feuster.Themes.Theme theme = Feuster.Themes.GetThemeByGradient(Color1, Color2, 8);

            if (theme == null || Form1.ActiveForm == null)
                return;
            dm = theme.DarkMode;

            //Clear boxes
            foreach (Control control in this.panel1.Controls)
            {
                if (control is RichTextBox)
                {
                    RichTextBox? RTB = control as RichTextBox;
                    if (RTB != null)
                    {
                        RTB.BackColor = Color.White;
                        RTB.ForeColor = Color.Black;
                        RTB.Text = "";
                        RTB.Visible = false;
                    }
                }
            }

            if (Form1.ActiveForm != null)
            {
                Form1.ActiveForm.BackColor = theme.GetColor(0);
                Form1.ActiveForm.ForeColor = theme.GetColor(theme.ColorCount);
                label1.BackColor = theme.GetColor(0);
                label1.ForeColor = theme.GetColor(theme.ColorCount);
                label1.Text = theme.Name;
                if (theme.ColorCount == 8)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(7);
                        textBox1.ForeColor = theme.GetColor(2);
                    }
                    else
                    {
                        textBox1.BackColor = theme.GetColor(0);
                        textBox1.ForeColor = theme.GetColor(4);
                    }
                }
                else if (theme.ColorCount == 7)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(6);
                        textBox1.ForeColor = theme.GetColor(3);
                    }
                    else
                    {
                        textBox1.BackColor = theme.GetColor(0);
                        textBox1.ForeColor = theme.GetColor(3);
                    }
                }
                else if (theme.ColorCount == 6)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(1);
                        textBox1.ForeColor = theme.GetColor(4);
                    }
                    else
                    {
                        textBox1.BackColor = theme.GetColor(2);
                        textBox1.ForeColor = theme.GetColor(1);
                    }
                }
                else if (theme.ColorCount == 5)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(1);
                        textBox1.ForeColor = theme.GetColor(2);
                    }
                    else
                    {
                        textBox1.BackColor = theme.GetColor(2);
                        textBox1.ForeColor = theme.GetColor(1);
                    }
                }
                else if (theme.ColorCount == 4)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(1);
                        textBox1.ForeColor = theme.GetColor(2);
                    }
                    else
                    {
                        textBox1.BackColor = theme.GetColor(2);
                        textBox1.ForeColor = theme.GetColor(1);
                    }
                }
                else if (theme.ColorCount == 3)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(0);
                        textBox1.ForeColor = theme.GetColor(1);
                    }
                    else
                    {
                        textBox1.BackColor = theme.GetColor(2);
                        textBox1.ForeColor = theme.GetColor(1);
                    }
                }
                else if (theme.ColorCount == 1)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(0);
                        textBox1.ForeColor = theme.GetColor(1);
                    }
                    else
                    {
                        textBox1.BackColor = theme.GetColor(1);
                        textBox1.ForeColor = theme.GetColor(0);
                    }
                }
                else
                {
                    textBox1.BackColor = Color.Blue;
                    textBox1.ForeColor = Color.White;
                }
            }
            button1.BackColor = textBox1.BackColor;
            button1.ForeColor = textBox1.ForeColor;

            //Paint boxes
            for (int i = 0; i < theme.ColorCount; i++)
            {
                foreach (Control control in this.panel1.Controls)
                {
                    if (control is RichTextBox)
                    {
                        RichTextBox? RTB = control as RichTextBox;
                        if (RTB == null) continue;
                        if (RTB.Name.Contains((i + 1).ToString()))
                        {
                            theme.DarkMode = dm;
                            RTB.BackColor = theme.GetColor(i);
                            if (theme.ColorCount == 3 && i == 1)
                                RTB.ForeColor = theme.GetColor(theme.ColorCount - 1);
                            else if (theme.ColorCount == 5 && i == 2)
                                RTB.ForeColor = theme.GetColor(theme.ColorCount - 1);
                            else if (theme.ColorCount == 7 && i == 3)
                                RTB.ForeColor = theme.GetColor(theme.ColorCount - 1);
                            else
                            {
                                theme.DarkMode = !dm;
                                RTB.ForeColor = theme.GetColor(i);
                                theme.DarkMode = !theme.DarkMode;
                            }
                            RTB.Text = theme.Name + Environment.NewLine + Environment.NewLine + "Color Index " + (i + 1).ToString() + " of " + theme.ColorCount.ToString();
                            RTB.Visible = true;
                        }
                    }
                }
            }

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //Clear boxes
            foreach (Control control in this.panel1.Controls)
            {
                if (control is RichTextBox)
                {
                    RichTextBox? RTB = control as RichTextBox;
                    if (RTB != null)
                    {
                        RTB.BackColor = Color.White;
                        RTB.ForeColor = Color.Black;
                        RTB.Text = "";
                        RTB.Visible = false;
                    }
                }
            }

            //Get actual selected theme
            bool dm = false;
            Feuster.Themes.Theme theme = Feuster.Themes.ThemeList[trackBar1.Value];
            
            if (theme == null)
                return;
            dm = theme.DarkMode;
            if (Form1.ActiveForm != null)
            {
                Form1.ActiveForm.BackColor = theme.GetColor(0);
                Form1.ActiveForm.ForeColor = theme.GetColor(theme.ColorCount);
                label1.BackColor = theme.GetColor(0);
                label1.ForeColor = theme.GetColor(theme.ColorCount);
                label1.Text = theme.Name;
                if (theme.ColorCount == 8)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(7);
                        textBox1.ForeColor = theme.GetColor(2);
                    }
                    else
                    {
                        textBox1.BackColor = theme.GetColor(0);
                        textBox1.ForeColor = theme.GetColor(4);
                    }
                }
                else if (theme.ColorCount == 7)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(6);
                        textBox1.ForeColor = theme.GetColor(3);
                    }
                    else
                    { 
                        textBox1.BackColor = theme.GetColor(0);
                        textBox1.ForeColor = theme.GetColor(3);
                    }
                }
                else if (theme.ColorCount == 6)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(1);
                        textBox1.ForeColor = theme.GetColor(4);
                    }
                    else
                    {
                        textBox1.BackColor = theme.GetColor(2);
                        textBox1.ForeColor = theme.GetColor(1);
                    }
                }
                else if (theme.ColorCount == 5)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(1);
                        textBox1.ForeColor = theme.GetColor(2);
                    }
                    else
                    {
                        textBox1.BackColor = theme.GetColor(2);
                        textBox1.ForeColor = theme.GetColor(1);
                    }
                }
                else if (theme.ColorCount == 4)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(1);
                        textBox1.ForeColor = theme.GetColor(2);
                    }
                    else
                    {
                        textBox1.BackColor = theme.GetColor(2);
                        textBox1.ForeColor = theme.GetColor(1);
                    }
                }
                else if (theme.ColorCount == 3)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(0);
                        textBox1.ForeColor = theme.GetColor(1);
                    }
                    else
                    {
                        textBox1.BackColor = theme.GetColor(2);
                        textBox1.ForeColor = theme.GetColor(1);
                    }
                }
                else if (theme.ColorCount == 1)
                {
                    if (dm)
                    {
                        textBox1.BackColor = theme.GetColor(0);
                        textBox1.ForeColor = theme.GetColor(1);
                    }
                    else
                    {
                        textBox1.BackColor = theme.GetColor(1);
                        textBox1.ForeColor = theme.GetColor(0);
                    }
                }
                else
                {
                    textBox1.BackColor = Color.Blue;
                    textBox1.ForeColor = Color.White;
                }
            }
            button1.BackColor = textBox1.BackColor;
            button1.ForeColor = textBox1.ForeColor;

            //Paint boxes
            for (int i = 0; i < theme.ColorCount; i++)
            {
                foreach (Control control in this.panel1.Controls)
                {
                    if (control is RichTextBox)
                    {
                        RichTextBox? RTB = control as RichTextBox;
                        if (RTB == null) continue;
                        if (RTB.Name.Contains((i + 1).ToString()))
                        {
                            theme.DarkMode = dm;
                            RTB.BackColor = theme.GetColor(i);
                            if (theme.ColorCount == 3 && i == 1)
                                RTB.ForeColor = theme.GetColor(theme.ColorCount - 1);
                            else if (theme.ColorCount == 5 && i == 2)
                                RTB.ForeColor = theme.GetColor(theme.ColorCount - 1);
                            else if (theme.ColorCount == 7 && i == 3)
                                RTB.ForeColor = theme.GetColor(theme.ColorCount - 1);
                            else
                            {
                                theme.DarkMode = !dm;
                                RTB.ForeColor = theme.GetColor(i);
                                theme.DarkMode = !theme.DarkMode;
                            }
                            RTB.Text = theme.Name + Environment.NewLine + Environment.NewLine + "Color Index " + (i+1).ToString() + " of " + Feuster.Themes.GetThemeColorCount(theme.Name);
                            RTB.Visible = true;
                        }
                    }
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.Text = string.Join(Environment.NewLine, Feuster.Themes.GetThemeNamesByColorCount(1, true));
            trackBar1_ValueChanged(sender, e);
        }
    }
}