namespace acodwtrn
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.adminProg = new System.Windows.Forms.Label();
            this.userProg = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.adminStatusLabel = new System.Windows.Forms.Label();
            this.userProgrammLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Admin Programm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "User Programm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(40, 136);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(365, 26);
            this.time.TabIndex = 3;
            this.time.Text = "10 seconds between program launches";
            this.time.Click += new System.EventHandler(this.label1_Click);
            // 
            // adminProg
            // 
            this.adminProg.AutoSize = true;
            this.adminProg.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminProg.Location = new System.Drawing.Point(192, 80);
            this.adminProg.Name = "adminProg";
            this.adminProg.Size = new System.Drawing.Size(17, 26);
            this.adminProg.TabIndex = 4;
            this.adminProg.Text = " ";
            // 
            // userProg
            // 
            this.userProg.AutoSize = true;
            this.userProg.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userProg.Location = new System.Drawing.Point(192, 192);
            this.userProg.Name = "userProg";
            this.userProg.Size = new System.Drawing.Size(17, 26);
            this.userProg.TabIndex = 5;
            this.userProg.Text = " ";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(40, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(440, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adminStatusLabel
            // 
            this.adminStatusLabel.AutoSize = true;
            this.adminStatusLabel.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminStatusLabel.Location = new System.Drawing.Point(40, 296);
            this.adminStatusLabel.Name = "adminStatusLabel";
            this.adminStatusLabel.Size = new System.Drawing.Size(17, 26);
            this.adminStatusLabel.TabIndex = 7;
            this.adminStatusLabel.Text = " ";
            // 
            // userProgrammLabel
            // 
            this.userProgrammLabel.AutoSize = true;
            this.userProgrammLabel.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userProgrammLabel.Location = new System.Drawing.Point(40, 344);
            this.userProgrammLabel.Name = "userProgrammLabel";
            this.userProgrammLabel.Size = new System.Drawing.Size(17, 26);
            this.userProgrammLabel.TabIndex = 8;
            this.userProgrammLabel.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(527, 396);
            this.Controls.Add(this.userProgrammLabel);
            this.Controls.Add(this.adminStatusLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.userProg);
            this.Controls.Add(this.adminProg);
            this.Controls.Add(this.time);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "2Prog1button";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label adminProg;
        private System.Windows.Forms.Label userProg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label adminStatusLabel;
        private System.Windows.Forms.Label userProgrammLabel;
    }
}

