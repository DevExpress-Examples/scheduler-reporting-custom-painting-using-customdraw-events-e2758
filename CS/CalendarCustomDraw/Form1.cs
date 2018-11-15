using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace CalendarCustomDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Populate();
            schedulerControl1.DayView.TopRowTime = schedulerControl1.DayView.WorkTime.Start;
            schedulerControl1.Start = new DateTime(2010, 12, 12);
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            XtraSchedulerReport1 rep = new XtraSchedulerReport1();
            rep.SchedulerAdapter.SetSourceObject(schedulerStorage1);
            rep.ShowPreviewDialog();
        }

        private void dateNavigator1_CustomDrawDayNumberCell(object sender, 
            DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
        {
            if (e.Date.DayOfYear % 12 == 0)
            {
                Pen p = e.Cache.GetPen(Color.Violet);
                Rectangle r = e.Bounds;
                r.Inflate(-2,0);
                r.Offset(3, 0);
                e.Cache.DrawRectangle(p, r);
            }
        }

        private void Populate()
        {
            Appointment apt = schedulerStorage1.CreateAppointment(AppointmentType.Pattern);
            apt.Start = new DateTime(2010, 12, 12, 10, 0, 0);
            apt.End = apt.Start.AddHours(1.5d);
            apt.RecurrenceInfo.Type = RecurrenceType.Monthly;
            apt.RecurrenceInfo.Start = apt.Start;
            apt.RecurrenceInfo.WeekOfMonth = WeekOfMonth.None;
            apt.RecurrenceInfo.DayNumber = 12;
            apt.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount;
            apt.RecurrenceInfo.OccurrenceCount = 13;
            apt.Subject = "Each 12th day of month";
            schedulerStorage1.Appointments.Add(apt);

            apt.StatusId = 2;
            apt.LabelId = 3;

        }

    }
}