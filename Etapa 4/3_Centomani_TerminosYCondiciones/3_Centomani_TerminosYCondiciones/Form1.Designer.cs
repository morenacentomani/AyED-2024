namespace _3_Centomani_TerminosYCondiciones
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
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sinoreta PERSONAL USE", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(459, 47);
            label1.TabIndex = 0;
            label1.Text = "Acepto los terminos y condicones sin leer.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(142, 17);
            label2.TabIndex = 1;
            label2.Text = "Terminos y condiciones...";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Sinoreta PERSONAL USE", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(12, 76);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(270, 34);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "He leído los terminos y condiciones.";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(473, 248);
            ControlBox = false;
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.No;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
    }
}
