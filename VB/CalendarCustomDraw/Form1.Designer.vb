Imports Microsoft.VisualBasic
Imports System
Namespace CalendarCustomDraw
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnShowReport = New DevExpress.XtraEditors.SimpleButton()
			Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 43)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(696, 503)
			Me.schedulerControl1.Start = New System.DateTime(2010, 12, 13, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnShowReport)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(875, 43)
			Me.panelControl1.TabIndex = 1
			' 
			' btnShowReport
			' 
			Me.btnShowReport.Location = New System.Drawing.Point(12, 12)
			Me.btnShowReport.Name = "btnShowReport"
			Me.btnShowReport.Size = New System.Drawing.Size(75, 23)
			Me.btnShowReport.TabIndex = 0
			Me.btnShowReport.Text = "Show Report"
'			Me.btnShowReport.Click += New System.EventHandler(Me.btnShowReport_Click);
			' 
			' dateNavigator1
			' 
			Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Right
			Me.dateNavigator1.HotDate = Nothing
			Me.dateNavigator1.Location = New System.Drawing.Point(696, 43)
			Me.dateNavigator1.Name = "dateNavigator1"
			Me.dateNavigator1.SchedulerControl = Me.schedulerControl1
			Me.dateNavigator1.Size = New System.Drawing.Size(179, 503)
			Me.dateNavigator1.TabIndex = 1
'			Me.dateNavigator1.CustomDrawDayNumberCell += New DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventHandler(Me.dateNavigator1_CustomDrawDayNumberCell);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(875, 546)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Controls.Add(Me.dateNavigator1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnShowReport As DevExpress.XtraEditors.SimpleButton
		Private WithEvents dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
	End Class
End Namespace
