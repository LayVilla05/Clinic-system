public partial class ReportForm : Form
{
    public ReportForm(int appointmentId)
    {
        InitializeComponent();
        GenerateAppointmentReport(appointmentId);
    }

    private void GenerateAppointmentReport(int appointmentId)
    {
        // Retrieve the appointment details
        Appointment appointment = GetAppointmentById(appointmentId);

        // Load the Crystal Report
        ReportDocument reportDocument = new ReportDocument();
        reportDocument.Load("PathToYourCrystalReportFile.rpt");

        // Set the data source for the report
        reportDocument.SetDataSource(new List<Appointment> { appointment });

        // Display the report in the CrystalReportViewer control
        crystalReportViewer.ReportSource = reportDocument;
        crystalReportViewer.Refresh();
    }
}
