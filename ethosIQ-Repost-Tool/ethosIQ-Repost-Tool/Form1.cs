using ethosIQ_Configuration;
using ethosIQ_Database;
using ethosIQ_Encrypt;
using ethosIQ_Extensions;
using ethosIQ_FTP;
using ethosIQ_Repost_Tool.Configuration;
using ethosIQ_Repost_Tool.Report;
using ethosIQ_Repost_Tool.Report.Report_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ethosIQ_Repost_Tool
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private Database CollectionDatabase;
        private Database ConfigurationDatabase;

        private List<HistoricalOutput> HistoricalOutputs;
        private int IntervalInMinutes;
        private string LocalDirectory;

        private StreamWriter Writer;
        private EventLog eventLog;

        public Form1()
        {
            InitializeComponent();
            loadConfigurationWorker.RunWorkerAsync();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dataSourceLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private List<HistoricalOutput> GetHistoricalOutputs()
        {
            List<HistoricalOutput> historicalOutputs = new List<HistoricalOutput>();

            try
            {
                foreach (HistoricalOutputElement element in HistoricalOutputConfiguration.GetConfigurationFromFile())
                {
                    if (element.FTPType == "SFTP")
                    {
                        historicalOutputs.Add(new HistoricalOutput(element.Name, element.FTPType,element.Directory, FTPFactory.CreateFTP(new FTPBuilder(element.FTPType, element.Host, element.Port, element.Username, Password.Decrypt(element.Password), element.PSFTPPath, element.BatchFilePath))));
                        Console.WriteLine("Added {0} historical outputs (SFTP).", historicalOutputs.Count);
                    }
                    else if (element.FTPType == "FTPS")
                    {
                        historicalOutputs.Add(new HistoricalOutput(element.Name, element.FTPType, element.Directory, FTPFactory.CreateFTP(new FTPBuilder(element.FTPType, element.Host, element.Port, element.Username, Password.Decrypt(element.Password)))));
                        Console.WriteLine("Added {0} historical outputs (FTPS).", historicalOutputs.Count);
                    }
                    else
                    {
                        historicalOutputs.Add(new HistoricalOutput(element.Name, element.FTPType, element.Directory, FTPFactory.CreateFTP(new FTPBuilder(element.FTPType, element.Host, element.Port, element.Username, Password.Decrypt(element.Password)))));
                        Console.WriteLine("Added {0} historical outputs.", historicalOutputs.Count);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "FTP Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return historicalOutputs;
        }

        private void loadConfigurationWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!EventLog.SourceExists("Repost"))
            {
                EventLog.CreateEventSource("Repost", "WFM Historical Service");
            }

            eventLog = new EventLog();
            eventLog.Log = "WFM Historical Service";
            eventLog.Source = "Repost";

            try
            {
                ConfigurationDatabase = LocalDatabaseConfiguration.GetConfigurationDatabase();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Configuration Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                multiMediaCheckBox.Invoke(new Action(() => multiMediaCheckBox.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["Multimedia"].ToString())));
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Multimedia Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                LocalDirectory = ConfigurationManager.AppSettings["LocalDirectory"].ToString();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Local Directory Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                IntervalInMinutes = Convert.ToInt32(ConfigurationManager.AppSettings["Interval"].ToString());

                if(IntervalInMinutes == 15)
                {
                    fifteenRadioButton.Invoke(new Action(() => fifteenRadioButton.Checked = true));
                }
                else if(IntervalInMinutes == 30)
                {
                    thirtyMinuteRadioButton.Invoke(new Action(() => thirtyMinuteRadioButton.Checked = true));
                }
                else
                {
                    thirtyMinuteRadioButton.Invoke(new Action(() => thirtyMinuteRadioButton.Checked = true));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Interval Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ConfigurationDatabase != null)
            {
                try
                {
                    CollectionDatabaseConfiguration collectionDatabaseConfiguration = new CollectionDatabaseConfiguration(ConfigurationDatabase);
                    CollectionDatabase = collectionDatabaseConfiguration.GetCollectionDatabase();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Collection Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (CollectionDatabase != null)
                {
                    try
                    {
                        CollectionDatabase.CreateOpenConnection();
                        connectedLabel.Invoke(new Action(() => connectedLabel.Text = "Connected"));
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Collection Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (CollectionDatabase != null)
                {
                    databaseTypeTextBox.Invoke(new Action(() => databaseTypeTextBox.Text = CollectionDatabase.DatabaseType.ToString()));
                    dataSourceTextBox.Invoke(new Action(() => dataSourceTextBox.Text = CollectionDatabase.DataSource));
                    hostTextBox.Invoke(new Action(() => hostTextBox.Text = CollectionDatabase.Host));
                    portTextBox.Invoke(new Action(() => portTextBox.Text = CollectionDatabase.Port.ToString()));
                    usernameTextBox.Invoke(new Action(() => usernameTextBox.Text = CollectionDatabase.Username));
                    passwordTextBox.Invoke(new Action(() => passwordTextBox.Text = CollectionDatabase.Password));
                }
            }

            HistoricalOutputs = GetHistoricalOutputs();

            if (HistoricalOutputs != null)
            {
                try
                {
                    foreach (HistoricalOutput output in HistoricalOutputs)
                    {
                        Debug.WriteLine(output.Ftp.RemoteHost + " " + output.Ftp.Port);
                        ftpDataGridView.Invoke(new Action(() => ftpDataGridView.Rows.Add(output.Name.ToString(),output.FTPType.ToString(), output.Ftp.RemoteHost, output.Directory, output.Ftp.Port, output.Ftp.Username)));
                    }
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message, "FTP Data Grid View", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkDatabaseConnectionButton_Click(object sender, EventArgs e)
        {
            checkCollectionDatabaseConnectionWorker.RunWorkerAsync();
        }

        private void checkCollectionDatabaseConnectionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                CollectionDatabaseConfiguration collectionDatabaseConfiguration = new CollectionDatabaseConfiguration();

                CollectionDatabase = collectionDatabaseConfiguration.GetCollectionDatabaseManually(databaseTypeTextBox.Text,
                                                                                                   dataSourceTextBox.Text,
                                                                                                   hostTextBox.Text,
                                                                                                   Convert.ToInt32(portTextBox.Text),
                                                                                                   usernameTextBox.Text,
                                                                                                   passwordTextBox.Text);
            }
            catch (Exception exception)
            {
                connectedLabel.Text = "Disconnected";
                MessageBox.Show(exception.Message, "Collection Database Manual Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (CollectionDatabase != null)
            {
                try
                {
                    using (IDbConnection connection = CollectionDatabase.CreateConnection())
                    {
                        connection.Open();
                    }

                    connectedLabel.Invoke(new Action(() => connectedLabel.Text = "Connected"));
                }
                catch (Exception exception)
                {
                    connectedLabel.Invoke(new Action(() => connectedLabel.Text = "Disconnected"));
                    MessageBox.Show(exception.Message, "Collection Database Manual Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkFTPConnectionButton_Click(object sender, EventArgs e)
        {
            checkFTPConnectionWorker.RunWorkerAsync();
        }

        private void checkFTPConnectionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            HistoricalOutput output = null;

            if(ftpDataGridView.Rows.Count > 0)
            {
                
                output = HistoricalOutputs.Where(x => x.Ftp.RemoteHost == ftpDataGridView.SelectedRows[0].Cells[2].Value.ToString() &&
                                                      x.Ftp.Port == Convert.ToInt32(ftpDataGridView.SelectedRows[0].Cells[4].Value)).FirstOrDefault();
                                                      
                //output = HistoricalOutputs.Where(x => x.Ftp.RemoteHost == ftpDataGridView.SelectedRows[0].Cells[2].Value.ToString()).FirstOrDefault();

            }

            

            if(output != null)
            {
                try
                {
                    output.SendFile(Environment.CurrentDirectory + @"\FTP Test.txt", "FTP Test.txt");
                    MessageBox.Show("Successfully FTP'd file FTP Test.txt!", "Check FTP Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception exception)
                {
                    if(exception?.InnerException?.Message != null)
                    {
                        MessageBox.Show(exception.Message + " " + exception.InnerException.Message, "Check FTP Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show(exception.Message, "Check FTP Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("An output must be selected! ", "Select FTP Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repostButton_Click(object sender, EventArgs e)
        {
            repostWorker.RunWorkerAsync();
        }

        private void repostWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            multiMediaCheckBox.Invoke(new Action(() => multiMediaCheckBox.Enabled = false));
            fifteenRadioButton.Invoke(new Action(() => fifteenRadioButton.Enabled = false));
            thirtyMinuteRadioButton.Invoke(new Action(() => thirtyMinuteRadioButton.Enabled = false));
            repostButton.Invoke(new Action(() => repostButton.Enabled = false));

            List<RepostReport> Reports = new List<RepostReport>();

            string PassLog = "";

            DateTime StartTime = fromDatePicker.Value;
            DateTime EndTime = toDatePicker.Value;

            DateTime StartTimeUTC = fromDatePicker.Value.ToUniversalTime();
            DateTime EndTimeUTC = toDatePicker.Value.ToUniversalTime();

            long StartTimeSeconds = StartTimeUTC.GetEpochTime();
            long EndTimeSeconds = EndTimeUTC.GetEpochTime();

            long TempStartTimeSeconds = StartTimeSeconds;
            long TempEndTimeSeconds = StartTimeSeconds + IntervalInMinutes * 60;

            while(TempStartTimeSeconds < EndTimeSeconds)
            {
                Reports.Add(new RepostReport(StartTime,TempStartTimeSeconds, TempEndTimeSeconds));

                StartTime = StartTime.AddMinutes(IntervalInMinutes);
                TempStartTimeSeconds = TempEndTimeSeconds;
                TempEndTimeSeconds = TempEndTimeSeconds + IntervalInMinutes * 60;
            }

            HistoricalSource historicalSource = new HistoricalSource("Collection Database", CollectionDatabase);

            int CurrentReport = 1;
            int Percentage = 0;

            /*
            List<HistoricalOutput> outputs = new List<HistoricalOutput>();

            if (ftpDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in ftpDataGridView.SelectedRows)
                {
                    outputs.Add(HistoricalOutputs.Where(x => x.Ftp.RemoteHost == ftpDataGridView.SelectedRows[0].Cells[1].Value.ToString() &&
                                                      x.Ftp.Port == Convert.ToInt32(ftpDataGridView.SelectedRows[0].Cells[3].Value)).FirstOrDefault());
                }
            }
            */
            DialogResult result = MessageBox.Show("Are you sure you want to repost " + Reports.Count + " reports?", "Verify Repost", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                foreach (RepostReport report in Reports)
                {
                    if (repostWorker.CancellationPending == false)
                    {
                        try
                        {
                            ContactTypeReport contactTypeReport;
                            ContactTypeMMReport contactTypeMMReport;
                            AgentContactTypeReport agentContactTypeReport;
                            AgentSystemPerformanceReport agentSystemPerformanceReport;

                            string FilePath = LocalDirectory + @"\" + report.StartTime.ToString("MMddyy") + "." + report.StartTime.ToString("HHmm");
                            string FileName = report.StartTime.ToString("MMddyy") + "." + report.StartTime.ToString("HHmm");

                            contactTypeReport = new ContactTypeReport(report.StartTime);
                            contactTypeMMReport = new ContactTypeMMReport(report.StartTime);
                            agentContactTypeReport = new AgentContactTypeReport(report.StartTime);
                            agentSystemPerformanceReport = new AgentSystemPerformanceReport(report.StartTime);

                            Writer = new StreamWriter(FilePath);

                            Console.WriteLine(report.StartTime.ToString() + ": ");

                            try
                            {
                                if (multiMediaCheckBox.Checked)
                                {
                                    foreach (ContactTypeMM contactType in historicalSource.GetContactTypeMMReport(report.StartTimeSeconds, report.EndTimeSeconds - 1))
                                    {
                                        contactTypeMMReport.ContactTypes.Add(contactType);
                                    }

                                    Console.WriteLine(historicalSource.Name + " - ContactType Count: " + contactTypeReport.ContactTypes.Count);
                                }
                                else
                                {
                                    foreach (ContactType contactType in historicalSource.GetContactTypeReport(report.StartTimeSeconds, report.EndTimeSeconds - 1))
                                    {
                                        contactTypeReport.ContactTypes.Add(contactType);
                                    }

                                    Console.WriteLine(historicalSource.Name + " - ContactType Count: " + contactTypeReport.ContactTypes.Count);
                                }

                                if (multiMediaCheckBox.Checked)
                                {
                                    foreach (AgentContactType agentContactType in historicalSource.GetAgentContactTypeMMReport(report.StartTimeSeconds, report.EndTimeSeconds - 1))
                                    {
                                        agentContactTypeReport.AgentContactTypes.Add(agentContactType);
                                    }

                                    Console.WriteLine(historicalSource.Name + " - AgentContactType Count: " + agentContactTypeReport.AgentContactTypes.Count);
                                }
                                else
                                {
                                    foreach (AgentContactType agentContactType in historicalSource.GetAgentContactTypeReport(report.StartTimeSeconds, report.EndTimeSeconds - 1))
                                    {
                                        agentContactTypeReport.AgentContactTypes.Add(agentContactType);
                                    }

                                    Console.WriteLine(historicalSource.Name + " - AgentContactType Count: " + agentContactTypeReport.AgentContactTypes.Count);
                                }

                                if (multiMediaCheckBox.Checked)
                                {
                                    foreach (AgentSystemPerformance agentSystemPerformance in historicalSource.GetAgentSystemPerformanceMMReport(report.StartTimeSeconds, report.EndTimeSeconds - 1))
                                    {
                                        agentSystemPerformanceReport.AgentSystemPerformances.Add(agentSystemPerformance);
                                    }

                                    Console.WriteLine(historicalSource.Name + " - AgentSystemPerformance Count: " + agentSystemPerformanceReport.AgentSystemPerformances.Count);
                                }
                                else
                                {
                                    foreach (AgentSystemPerformance agentSystemPerformance in historicalSource.GetAgentSystemPerformanceReport(report.StartTimeSeconds, report.EndTimeSeconds - 1))
                                    {
                                        agentSystemPerformanceReport.AgentSystemPerformances.Add(agentSystemPerformance);
                                    }

                                    Console.WriteLine(historicalSource.Name + " - AgentSystemPerformance Count: " + agentSystemPerformanceReport.AgentSystemPerformances.Count);
                                }

                                report.Pass = true;
                            }
                            catch (Exception exception)
                            {
                                eventLog.WriteEntry("Failed to pull data from source: " + historicalSource.Name + ". " + exception.Message, EventLogEntryType.Error);
                                report.Pass = false;
                            }

                            if (report.Pass)
                            {
                                try
                                {
                                    if (multiMediaCheckBox.Checked)
                                    {
                                        Writer.WriteLine(contactTypeMMReport.Name);
                                        Writer.WriteLine(contactTypeMMReport.ReportTimeString);
                                        Writer.WriteLine(contactTypeMMReport.ColumnHeader);
                                        foreach (ContactTypeMM contactType in contactTypeMMReport.ContactTypes)
                                        {
                                            Writer.WriteLine(contactType.ToString());
                                        }
                                        Writer.WriteLine(contactTypeMMReport.EndName);
                                    }
                                    else
                                    {
                                        Writer.WriteLine(contactTypeReport.Name);
                                        Writer.WriteLine(contactTypeReport.ReportTimeString);
                                        Writer.WriteLine(contactTypeReport.ColumnHeader);
                                        foreach (ContactType contactType in contactTypeReport.ContactTypes)
                                        {
                                            Writer.WriteLine(contactType.ToString());
                                        }
                                        Writer.WriteLine(contactTypeReport.EndName);
                                    }

                                    Writer.WriteLine(agentContactTypeReport.Name);
                                    Writer.WriteLine(agentContactTypeReport.ReportTimeString);
                                    Writer.WriteLine(agentContactTypeReport.ColumnHeader);
                                    foreach (AgentContactType agentContactType in agentContactTypeReport.AgentContactTypes)
                                    {
                                        Writer.WriteLine(agentContactType.ToString());
                                    }
                                    Writer.WriteLine(agentContactTypeReport.EndName);

                                    Writer.WriteLine(agentSystemPerformanceReport.Name);
                                    Writer.WriteLine(agentSystemPerformanceReport.ReportTimeString);
                                    Writer.WriteLine(agentSystemPerformanceReport.ColumnHeader);

                                    foreach (AgentSystemPerformance agentSystemPerformance in agentSystemPerformanceReport.AgentSystemPerformances)
                                    {
                                        Writer.WriteLine(agentSystemPerformance.ToString());
                                    }

                                    Writer.WriteLine(agentSystemPerformanceReport.EndName);

                                    Writer.Flush();
                                    Writer.Close();

                                    //eventLog.WriteEntry("Successfully wrote data to file: " + FilePath + ". ", EventLogEntryType.Information);
                                }
                                catch (Exception exception)
                                {
                                    eventLog.WriteEntry("Failed to write data to file: " + FilePath + ". " + exception.Message, EventLogEntryType.Error);
                                }

                                /*
                                List<HistoricalOutput> outputs = new List<HistoricalOutput>();

                                if (ftpDataGridView.Rows.Count > 0)
                                {
                                    foreach(DataGridViewRow row in ftpDataGridView.SelectedRows)
                                    {
                                        outputs.Add(HistoricalOutputs.Where(x => x.Ftp.RemoteHost == ftpDataGridView.SelectedRows[0].Cells[1].Value.ToString() &&
                                                                          x.Ftp.Port == Convert.ToInt32(ftpDataGridView.SelectedRows[0].Cells[3].Value)).FirstOrDefault());
                                    }
                                }
                                */

                                if (HistoricalOutputs.Count > 0)
                                {
                                    try
                                    {
                                        foreach (HistoricalOutput output in HistoricalOutputs)
                                        {
                                            try
                                            {
                                                output.SendFile(FilePath, FileName);
                                                report.Pass = true;
                                                //MessageBox.Show("Successfully FTP'd!", "Repost Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            catch (Exception exception)
                                            {
                                                if (exception?.InnerException?.Message != null)
                                                {
                                                    MessageBox.Show("Failed to send file to " + output.Name + ". " + exception.Message + " " + exception.InnerException.Message, "Repost Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }

                                                MessageBox.Show(exception.Message, "Repost Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                    catch (Exception exception)
                                    {
                                        if (exception?.InnerException?.Message != null)
                                        {
                                            MessageBox.Show(exception.Message + " " + exception.InnerException.Message, "Repost Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                        MessageBox.Show(exception.Message, "Repost Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }

                            /*
                            foreach (HistoricalOutput historicalOutput in HistoricalOutputs)
                            {
                                historicalOutput.SendFile(FilePath, FileName);

                                report.Pass = true;
                            }
                            */
                        }
                        catch (Exception exception)
                        {
                            eventLog.WriteEntry("Error: Unable to retrieve interval posting. " + exception.Message, EventLogEntryType.Error);
                        }
                    
                    }
                    else
                    {
                        e.Cancel = true;
                        MessageBox.Show("Reposting has been stopped.", "Reposting Stopped", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        repostWorker.ReportProgress(0);
                        break;
                    }
                    double test = (CurrentReport * 100 / Reports.Count);
                    Percentage = (CurrentReport * 100 / Reports.Count);
                    repostWorker.ReportProgress(Percentage);
                    CurrentReport++;
                    PassLog += "Report Start Time: " + report.StartTime.ToString() + " Pass: " + report.Pass + "\n";
                }

                eventLog.WriteEntry(PassLog, EventLogEntryType.Information);
                MessageBox.Show(PassLog, "Completed Reposting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                repostWorker.ReportProgress(0);
            }
            multiMediaCheckBox.Invoke(new Action(() => multiMediaCheckBox.Enabled = true));
            fifteenRadioButton.Invoke(new Action(() => fifteenRadioButton.Enabled = true));
            thirtyMinuteRadioButton.Invoke(new Action(() => thirtyMinuteRadioButton.Enabled = true));
            repostButton.Invoke(new Action(() => repostButton.Enabled = true));
        }

        private void repostWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            repostProgressBar.Value = e.ProgressPercentage;
        }


        private void stopButton_Click(object sender, EventArgs e)
        {
            if (repostWorker.IsBusy && repostWorker.WorkerSupportsCancellation)
            {
                repostWorker.CancelAsync();
            }
        }

        private void fifteenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            IntervalInMinutes = 15;
        }

        private void thirtyMinuteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            IntervalInMinutes = 30;
        }
    }
}
