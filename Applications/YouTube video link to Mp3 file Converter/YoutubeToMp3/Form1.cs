using System.Drawing;
using System.Windows.Forms;

namespace YoutubeToMp3
{
    public partial class Form1 : Form
    {
        public Point downPoint = Point.Empty;
        public Form1() => InitializeComponent();
        private void VideoLinkTextBoxPropertyChanged(object sender, System.EventArgs e) => DownloadManager.VideoURL = videoLinkTextBox.Text;

        private void DestinationLinkTextBoxPropertyChanged(object sender, System.EventArgs e)
        {
            DownloadManager.DestinationPath = destinationTextBox.Text;
            DestinationManager.UpdateDestinationPath(destinationTextBox.Text);
        }

        private void DownloadButton_Click(object sender, System.EventArgs e) => DownloadManager.DownloadAndConvert();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            completeNotifyLabel.Text = null;
            DownloadManager.OperationFinished += NotifyOperationFinish;
            DownloadManager.ShowVideoName += GetVideoDescription;
            DestinationManager.CheckActualDestinationPath();
            destinationTextBox.Text = DestinationManager.DestinationPath;
        }
        private void NotifyOperationFinish() => completeNotifyLabel.Text = DownloadManager.Notify();

        private void CloseButton_Click(object sender, System.EventArgs e) => Application.Exit();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) downPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty) Location = new Point(Left + e.X - downPoint.X, Top + e.Y -downPoint.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) downPoint = Point.Empty;
        }
        private void GetVideoDescription()
        {
            videoNameLabel.Visible = true;
            videoNameLabel.Text = DownloadManager.VideoName;
        }
    }
}
