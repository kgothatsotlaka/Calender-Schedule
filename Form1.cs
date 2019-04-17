using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalenderSchedule
{
    public partial class frmCalenderSchedule : Form
    {
        //Global Variables
        private List<FlowLayoutPanel> _daysInAMonth = new List<FlowLayoutPanel>();
        private DateTime _currentDate = DateTime.Today;

        public frmCalenderSchedule()
        {
          
            InitializeComponent();
            GenerateDays(35);
            DisplayCurrentDate();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Helper Methods
        public void GenerateDays(int totalDaysInMonth)
        {
            if (totalDaysInMonth <= 0) throw new ArgumentOutOfRangeException(nameof(totalDaysInMonth));
            pnlBodyContent.Controls.Clear();

            for (int i = 1; i <= totalDaysInMonth; i++)
            {
                var dayBlock = new FlowLayoutPanel
                {
                    Name = $"f1Day{i}",
                    Size = new Size(134, 95),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };

                pnlBodyContent.Controls.Add(dayBlock);
                _daysInAMonth.Add(dayBlock);
            }
        }

        private void AddLabelDayToFlDay(int startDayAtFlNumber, int totalDaysInMonth)
        {
            foreach (FlowLayoutPanel block in _daysInAMonth)
            {
                block.Controls.Clear();
                block.Tag = 0;
                block.BackColor = Color.White;
            }

            for (int i = 1; i <= totalDaysInMonth; i++)
            {
                var lblDay = new Label
                {
                    Name = $"lblDay{i}",
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleRight,
                    Size = new Size(134, 25),
                    Text = i.ToString(),
                    ForeColor = panel1.BackColor,
                    Font = new Font("Century Gothic", 12)
                };

                _daysInAMonth[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
                _daysInAMonth[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(lblDay);

                if (new DateTime(_currentDate.Year, _currentDate.Month, i) == DateTime.Today)
                {
                    _daysInAMonth[(i - 1) + (startDayAtFlNumber - 1)].BackColor = Color.Aquamarine;
                }


            }
        }

        private void DisplayCurrentDate()
        {
            lblTodaysDate.Text = _currentDate.ToString("MMMM, yyyy");
            int firstDayAtFlNumber = GetFirstDayOfWeekOfCurrentDate();
            int totalDay = GetTotalDaysOfCurrentDate();

            AddLabelDayToFlDay(firstDayAtFlNumber, totalDay);
            

        }


        private void PrevMonth()
        {
            _currentDate = _currentDate.AddMonths(-1);
            DisplayCurrentDate();
        }

        private void NextMonth()
        {
            _currentDate = _currentDate.AddMonths(1);
            DisplayCurrentDate();
        }
        private void Today()
        {
            _currentDate = DateTime.Today;
            DisplayCurrentDate();
        }

        private int GetFirstDayOfWeekOfCurrentDate()
        {
            DateTime firstDayOfMonth = new DateTime(_currentDate.Year, _currentDate.Month, 1);
            return Convert.ToInt32(firstDayOfMonth.DayOfWeek);


        }

        private int GetTotalDaysOfCurrentDate()
        {
            DateTime firstDayOfCurrentDate = new DateTime(_currentDate.Year, _currentDate.Month, 1);
            return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day;


        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void PnlBodyContent_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            Today();
        }

        private void BtnPrevMonth_Click(object sender, EventArgs e)
        {
            PrevMonth();
        }

        private void BtnNextMonth_Click(object sender, EventArgs e)
        {
            NextMonth();
        }
    }
}
