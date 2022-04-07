
namespace chislMethod
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
            this.label1 = new System.Windows.Forms.Label();
            this.acuValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timeTrap = new System.Windows.Forms.TextBox();
            this.timeSimp = new System.Windows.Forms.TextBox();
            this.timeNew = new System.Windows.Forms.TextBox();
            this.razbTrap = new System.Windows.Forms.TextBox();
            this.razbSimp = new System.Windows.Forms.TextBox();
            this.acuTrap = new System.Windows.Forms.TextBox();
            this.razbNew = new System.Windows.Forms.TextBox();
            this.acuSimp = new System.Windows.Forms.TextBox();
            this.acuNew = new System.Windows.Forms.TextBox();
            this.ansTrap = new System.Windows.Forms.TextBox();
            this.ansSimp = new System.Windows.Forms.TextBox();
            this.ansNew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходные данные";
            // 
            // acuValue
            // 
            this.acuValue.Location = new System.Drawing.Point(13, 58);
            this.acuValue.Name = "acuValue";
            this.acuValue.PlaceholderText = "точность";
            this.acuValue.Size = new System.Drawing.Size(106, 23);
            this.acuValue.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Решение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Трапеция";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Симпсон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ньютон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Время";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Разбиение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Точность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ответ";
            // 
            // timeTrap
            // 
            this.timeTrap.Location = new System.Drawing.Point(228, 57);
            this.timeTrap.Name = "timeTrap";
            this.timeTrap.Size = new System.Drawing.Size(100, 23);
            this.timeTrap.TabIndex = 11;
            // 
            // timeSimp
            // 
            this.timeSimp.Location = new System.Drawing.Point(413, 58);
            this.timeSimp.Name = "timeSimp";
            this.timeSimp.Size = new System.Drawing.Size(100, 23);
            this.timeSimp.TabIndex = 12;
            // 
            // timeNew
            // 
            this.timeNew.Location = new System.Drawing.Point(601, 57);
            this.timeNew.Name = "timeNew";
            this.timeNew.Size = new System.Drawing.Size(100, 23);
            this.timeNew.TabIndex = 13;
            // 
            // razbTrap
            // 
            this.razbTrap.Location = new System.Drawing.Point(228, 136);
            this.razbTrap.Name = "razbTrap";
            this.razbTrap.Size = new System.Drawing.Size(100, 23);
            this.razbTrap.TabIndex = 14;
            // 
            // razbSimp
            // 
            this.razbSimp.Location = new System.Drawing.Point(413, 136);
            this.razbSimp.Name = "razbSimp";
            this.razbSimp.Size = new System.Drawing.Size(100, 23);
            this.razbSimp.TabIndex = 15;
            // 
            // acuTrap
            // 
            this.acuTrap.Location = new System.Drawing.Point(228, 212);
            this.acuTrap.Name = "acuTrap";
            this.acuTrap.Size = new System.Drawing.Size(100, 23);
            this.acuTrap.TabIndex = 16;
            // 
            // razbNew
            // 
            this.razbNew.Location = new System.Drawing.Point(601, 136);
            this.razbNew.Name = "razbNew";
            this.razbNew.Size = new System.Drawing.Size(100, 23);
            this.razbNew.TabIndex = 16;
            // 
            // acuSimp
            // 
            this.acuSimp.Location = new System.Drawing.Point(413, 212);
            this.acuSimp.Name = "acuSimp";
            this.acuSimp.Size = new System.Drawing.Size(100, 23);
            this.acuSimp.TabIndex = 17;
            // 
            // acuNew
            // 
            this.acuNew.Location = new System.Drawing.Point(601, 212);
            this.acuNew.Name = "acuNew";
            this.acuNew.Size = new System.Drawing.Size(100, 23);
            this.acuNew.TabIndex = 18;
            // 
            // ansTrap
            // 
            this.ansTrap.Location = new System.Drawing.Point(228, 290);
            this.ansTrap.Name = "ansTrap";
            this.ansTrap.Size = new System.Drawing.Size(100, 23);
            this.ansTrap.TabIndex = 19;
            // 
            // ansSimp
            // 
            this.ansSimp.Location = new System.Drawing.Point(413, 290);
            this.ansSimp.Name = "ansSimp";
            this.ansSimp.Size = new System.Drawing.Size(100, 23);
            this.ansSimp.TabIndex = 20;
            // 
            // ansNew
            // 
            this.ansNew.Location = new System.Drawing.Point(601, 290);
            this.ansNew.Name = "ansNew";
            this.ansNew.Size = new System.Drawing.Size(100, 23);
            this.ansNew.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 334);
            this.Controls.Add(this.ansNew);
            this.Controls.Add(this.ansSimp);
            this.Controls.Add(this.ansTrap);
            this.Controls.Add(this.acuNew);
            this.Controls.Add(this.acuSimp);
            this.Controls.Add(this.razbNew);
            this.Controls.Add(this.acuTrap);
            this.Controls.Add(this.razbSimp);
            this.Controls.Add(this.razbTrap);
            this.Controls.Add(this.timeNew);
            this.Controls.Add(this.timeSimp);
            this.Controls.Add(this.timeTrap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.acuValue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox acuValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox timeTrap;
        private System.Windows.Forms.TextBox timeSimp;
        private System.Windows.Forms.TextBox timeNew;
        private System.Windows.Forms.TextBox razbTrap;
        private System.Windows.Forms.TextBox razbSimp;
        private System.Windows.Forms.TextBox acuTrap;
        private System.Windows.Forms.TextBox razbNew;
        private System.Windows.Forms.TextBox acuSimp;
        private System.Windows.Forms.TextBox acuNew;
        private System.Windows.Forms.TextBox ansTrap;
        private System.Windows.Forms.TextBox ansSimp;
        private System.Windows.Forms.TextBox ansNew;
    }
}

