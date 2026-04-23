namespace ONLINEFLOW.UI
{
    using NLog;
    using RTCV.Common;
    using RTCV.UI;
    using RTCV.UI.Modular;
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using static System.Net.Mime.MediaTypeNames;
    // todo: change every reference to onlineflow to CrowdCorrupt
    public partial class PluginForm : ComponentForm, IColorize
    {
        public ONLINEFLOW plugin;
        public static PluginForm pf = null;

        public volatile bool HideOnClose = true;
        private CrowdCorruptMainForm mainWindow;
        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        private bool crowdCorruptEnabled = false;
        private bool twitchConnected = false;
        private string connectedChannel = "No channel linked";
        private string lastAction = "No actions yet";

        public PluginForm(ONLINEFLOW _plugin)
        {
            plugin = _plugin;
            pf = this;

            InitializeComponent();
            FormClosing += PluginForm_FormClosing;
            Text = "CrowdCorrupt";
        }

        private void PluginForm_Load(object sender, EventArgs e)
        {
            RefreshModuleUi();
        }

        private void PluginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HideOnClose)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btnToggleEnabled_Click(object sender, EventArgs e)
        {
            crowdCorruptEnabled = !crowdCorruptEnabled;
            RefreshModuleUi();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            if (mainWindow == null || mainWindow.IsDisposed)
            {
                mainWindow = new CrowdCorruptMainForm();
            }

            if (!mainWindow.Visible)
            {
                mainWindow.Show();
            }

            mainWindow.BringToFront();
            mainWindow.Focus();
        }

        public void SetConnectionState(bool connected, string channelName)
{
    twitchConnected = connected;
    connectedChannel = string.IsNullOrWhiteSpace(channelName)
        ? "unknown channel"
        : channelName;

    RefreshModuleUi();
}

        public void SetLastAction(string actionText)
        {
            lastAction = string.IsNullOrWhiteSpace(actionText)
                ? "No actions yet"
                : actionText;

            RefreshModuleUi();
        }

        public void SetEnabledState(bool enabled)
        {
            crowdCorruptEnabled = enabled;
            RefreshModuleUi();
        }

        private void RefreshModuleUi()
        {
            lblConnectionStatus.Text = twitchConnected
                ? $"Connected to {connectedChannel}"
                : "Not connected";

            lblLastActionValue.Text = lastAction;

            btnToggleEnabled.Text = crowdCorruptEnabled ? "Enabled" : "Disabled";
            btnToggleEnabled.BackColor = crowdCorruptEnabled
                ? Color.FromArgb(76, 175, 80)
                : Color.FromArgb(198, 40, 40);
        }
    }
}