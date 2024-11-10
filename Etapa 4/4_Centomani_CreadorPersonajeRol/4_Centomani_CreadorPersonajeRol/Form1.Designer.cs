namespace _4_Centomani_CreadorPersonajeRol
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label8 = new Label();
            comboBox3 = new ComboBox();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.logohp;
            pictureBox1.Location = new Point(379, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 10);
            label1.Name = "label1";
            label1.Size = new Size(672, 38);
            label1.TabIndex = 1;
            label1.Text = "¡Bienvenido al creador de personajes!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(220, 48);
            label2.Name = "label2";
            label2.Size = new Size(153, 38);
            label2.TabIndex = 2;
            label2.Text = "Edición:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sinoreta PERSONAL USE", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 134);
            label3.Name = "label3";
            label3.Size = new Size(264, 32);
            label3.TabIndex = 3;
            label3.Text = "Ingrese el nombre de su personaje:";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.Hand;
            textBox1.Location = new Point(38, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.Hand;
            textBox2.Location = new Point(321, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sinoreta PERSONAL USE", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(321, 134);
            label4.Name = "label4";
            label4.Size = new Size(242, 32);
            label4.TabIndex = 5;
            label4.Text = "Ingrese el nivel de su personaje:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(321, 195);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 7;
            label5.Text = "(Entre 0-100)";
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mago.", "Bruja.", "Animago." });
            comboBox1.Location = new Point(613, 169);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 23);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "No queres ser un muggle, no?";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sinoreta PERSONAL USE", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(613, 134);
            label6.Name = "label6";
            label6.Size = new Size(126, 32);
            label6.TabIndex = 9;
            label6.Text = "¿Qué vas a ser?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sinoreta PERSONAL USE", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 248);
            label7.Name = "label7";
            label7.Size = new Size(287, 32);
            label7.TabIndex = 11;
            label7.Text = "¿Que tipo de personalidad te describe?";
            // 
            // comboBox2
            // 
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Valiente y osado.", "Inteligente y curioso.", "Ambicioso y astuto.", "Leal y honesto." });
            comboBox2.Location = new Point(38, 283);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 23);
            comboBox2.TabIndex = 10;
            comboBox2.Text = "Es muy importante.";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.somselec;
            pictureBox2.Location = new Point(334, 219);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(334, 312);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 13;
            button1.Text = "Tu casa es...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sinoreta PERSONAL USE", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(613, 248);
            label8.Name = "label8";
            label8.Size = new Size(158, 32);
            label8.TabIndex = 15;
            label8.Text = "¿Núcleo de tu varita?";
            // 
            // comboBox3
            // 
            comboBox3.Cursor = Cursors.Hand;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Pluma de fénix.", "Fibra de corazón de Dragón.", "Pelos de la cola de unicornio." });
            comboBox3.Location = new Point(613, 283);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(242, 23);
            comboBox3.TabIndex = 14;
            comboBox3.Text = "Elegí bien (ahre).";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(796, 496);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "Siguiente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.pixil_frame_0__26_;
            pictureBox3.Location = new Point(38, 367);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(163, 152);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.pixil_frame_0__27_;
            pictureBox4.Location = new Point(207, 367);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(163, 152);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.pixil_frame_0__29_;
            pictureBox5.Location = new Point(376, 367);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(163, 152);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = Properties.Resources.pixil_frame_0__28_;
            pictureBox6.Location = new Point(545, 367);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(163, 152);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sinoreta PERSONAL USE", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(38, 332);
            label9.Name = "label9";
            label9.Size = new Size(396, 32);
            label9.TabIndex = 21;
            label9.Text = "¿Cómo te ves? (Los hice yo en menos de ocho minutos)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sinoreta PERSONAL USE", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(451, 248);
            label10.Name = "label10";
            label10.Size = new Size(50, 47);
            label10.TabIndex = 22;
            label10.Text = "???";
            label10.Click += label10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(895, 531);
            Controls.Add(label10);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(comboBox3);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Label label7;
        private ComboBox comboBox2;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label8;
        private ComboBox comboBox3;
        private Button button2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label9;
        private Label label10;
    }
}
