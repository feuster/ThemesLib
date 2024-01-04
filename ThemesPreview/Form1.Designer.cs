namespace ThemesPreview
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            richTextBox8 = new RichTextBox();
            richTextBox7 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            panel2 = new Panel();
            trackBar1 = new TrackBar();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            colorDialog1 = new ColorDialog();
            panel4 = new Panel();
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(richTextBox8);
            panel1.Controls.Add(richTextBox7);
            panel1.Controls.Add(richTextBox6);
            panel1.Controls.Add(richTextBox5);
            panel1.Controls.Add(richTextBox4);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(richTextBox1);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 254);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1064, 97);
            label1.TabIndex = 24;
            label1.Text = "Actual Theme";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox8
            // 
            richTextBox8.Location = new Point(928, 117);
            richTextBox8.Name = "richTextBox8";
            richTextBox8.Size = new Size(125, 120);
            richTextBox8.TabIndex = 23;
            richTextBox8.Text = "";
            // 
            // richTextBox7
            // 
            richTextBox7.Location = new Point(797, 117);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(125, 120);
            richTextBox7.TabIndex = 22;
            richTextBox7.Text = "";
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(666, 117);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(125, 120);
            richTextBox6.TabIndex = 21;
            richTextBox6.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(535, 117);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(125, 120);
            richTextBox5.TabIndex = 20;
            richTextBox5.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(404, 117);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(125, 120);
            richTextBox4.TabIndex = 19;
            richTextBox4.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(273, 117);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(125, 120);
            richTextBox3.TabIndex = 18;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(142, 117);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(125, 120);
            richTextBox2.TabIndex = 17;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(11, 117);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(125, 120);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 100);
            button1.Name = "button1";
            button1.Size = new Size(125, 56);
            button1.TabIndex = 25;
            button1.Text = "Gradient";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(trackBar1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 272);
            panel2.Name = "panel2";
            panel2.Size = new Size(1064, 177);
            panel2.TabIndex = 18;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(142, 100);
            trackBar1.Maximum = 5;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(912, 56);
            trackBar1.TabIndex = 26;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1064, 97);
            label2.TabIndex = 25;
            label2.Text = "Theme Selector";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(0, 455);
            panel3.Name = "panel3";
            panel3.Size = new Size(1064, 229);
            panel3.TabIndex = 19;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1064, 97);
            label3.TabIndex = 26;
            label3.Text = "Themes List";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(1042, 121);
            textBox1.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(listView1);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(1070, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(408, 672);
            panel4.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Clipboard format: #RRGGBB", "Clipboard format: RRGGBB", "Clipboard format: R(RR) G(GG) B(BB)", "Clipboard format: ARGB" });
            comboBox1.Location = new Point(0, 636);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(396, 28);
            comboBox1.TabIndex = 27;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.AutoArrange = false;
            listView1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.LabelWrap = false;
            listView1.Location = new Point(3, 117);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.ShowGroups = false;
            listView1.Size = new Size(393, 500);
            listView1.TabIndex = 26;
            listView1.TileSize = new Size(460, 100);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(408, 97);
            label4.TabIndex = 25;
            label4.Text = "All Colors Selector";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 692);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Theme Preview";
            Shown += Form1_Shown;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private RichTextBox richTextBox8;
        private RichTextBox richTextBox7;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Panel panel2;
        private TrackBar trackBar1;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private ColorDialog colorDialog1;
        private Panel panel4;
        private ListView listView1;
        private Label label4;
        private ComboBox comboBox1;
    }
}