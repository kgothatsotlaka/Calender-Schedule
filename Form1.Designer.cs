namespace CalenderSchedule
{
    partial class frmCalenderSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalenderSchedule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.btnMinimiza = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlWeekDays = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTodaysDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.pnlBodyContent = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlWeekDays.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblSchedule);
            this.panel1.Controls.Add(this.btnMinimiza);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 48);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.ForeColor = System.Drawing.Color.White;
            this.lblSchedule.Location = new System.Drawing.Point(12, 15);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(82, 19);
            this.lblSchedule.TabIndex = 3;
            this.lblSchedule.Text = "Schedule";
            // 
            // btnMinimiza
            // 
            this.btnMinimiza.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimiza.FlatAppearance.BorderSize = 0;
            this.btnMinimiza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMinimiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimiza.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimiza.Image")));
            this.btnMinimiza.Location = new System.Drawing.Point(905, 0);
            this.btnMinimiza.Name = "btnMinimiza";
            this.btnMinimiza.Size = new System.Drawing.Size(40, 48);
            this.btnMinimiza.TabIndex = 2;
            this.btnMinimiza.UseVisualStyleBackColor = true;
            this.btnMinimiza.Click += new System.EventHandler(this.BtnMinimiza_Click);
            // 
            // btnclose
            // 
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(945, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 48);
            this.btnclose.TabIndex = 1;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlBodyContent);
            this.pnlBody.Controls.Add(this.pnlWeekDays);
            this.pnlBody.Controls.Add(this.panel2);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 48);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(985, 698);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlWeekDays
            // 
            this.pnlWeekDays.BackColor = System.Drawing.Color.White;
            this.pnlWeekDays.Controls.Add(this.button7);
            this.pnlWeekDays.Controls.Add(this.button6);
            this.pnlWeekDays.Controls.Add(this.button5);
            this.pnlWeekDays.Controls.Add(this.button4);
            this.pnlWeekDays.Controls.Add(this.button3);
            this.pnlWeekDays.Controls.Add(this.button2);
            this.pnlWeekDays.Controls.Add(this.button1);
            this.pnlWeekDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWeekDays.Location = new System.Drawing.Point(0, 70);
            this.pnlWeekDays.Name = "pnlWeekDays";
            this.pnlWeekDays.Size = new System.Drawing.Size(985, 48);
            this.pnlWeekDays.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(844, 11);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 29);
            this.button7.TabIndex = 8;
            this.button7.Text = "Sunday";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(704, 11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 29);
            this.button6.TabIndex = 7;
            this.button6.Text = "Saturday";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(564, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 29);
            this.button5.TabIndex = 6;
            this.button5.Text = "Friday";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(424, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "Thursday";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(284, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Wednesday";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(144, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tuesday";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(4, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Monday";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.lblTodaysDate);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 70);
            this.panel2.TabIndex = 0;
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysDate.ForeColor = System.Drawing.Color.White;
            this.lblTodaysDate.Location = new System.Drawing.Point(26, 27);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(117, 19);
            this.lblTodaysDate.TabIndex = 4;
            this.lblTodaysDate.Text = "January, 2019";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNextMonth);
            this.panel3.Controls.Add(this.btnPrevMonth);
            this.panel3.Controls.Add(this.btnToday);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(781, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 70);
            this.panel3.TabIndex = 0;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.FlatAppearance.BorderSize = 0;
            this.btnNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextMonth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMonth.ForeColor = System.Drawing.Color.White;
            this.btnNextMonth.Location = new System.Drawing.Point(142, 15);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(44, 42);
            this.btnNextMonth.TabIndex = 4;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.BtnNextMonth_Click);
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.FlatAppearance.BorderSize = 0;
            this.btnPrevMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevMonth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevMonth.ForeColor = System.Drawing.Color.White;
            this.btnPrevMonth.Location = new System.Drawing.Point(16, 15);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(44, 42);
            this.btnPrevMonth.TabIndex = 3;
            this.btnPrevMonth.Text = "<";
            this.btnPrevMonth.UseVisualStyleBackColor = true;
            this.btnPrevMonth.Click += new System.EventHandler(this.BtnPrevMonth_Click);
            // 
            // btnToday
            // 
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(66, 15);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(70, 42);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.BtnToday_Click);
            // 
            // pnlBodyContent
            // 
            this.pnlBodyContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBodyContent.Location = new System.Drawing.Point(0, 118);
            this.pnlBodyContent.Name = "pnlBodyContent";
            this.pnlBodyContent.Size = new System.Drawing.Size(985, 580);
            this.pnlBodyContent.TabIndex = 2;
            // 
            // frmCalenderSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 746);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCalenderSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calender Schedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlWeekDays.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimiza;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPrevMonth;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Panel pnlWeekDays;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTodaysDate;
        private System.Windows.Forms.FlowLayoutPanel pnlBodyContent;
    }
}

