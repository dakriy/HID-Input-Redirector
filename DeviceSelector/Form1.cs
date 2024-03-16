using HidLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceSelector
{
    public partial class HIDRedirector : Form
    {
        InputRedirector redirector = null;
        HIDDevices devices = new HIDDevices();
        GetWindows windows = new GetWindows();

        public HIDRedirector()
        {
            InitializeComponent();
            PopulateTextBoxes();
            InputRedirector.Register(Handle);
        }

        // The WndProc is overridden to allow us to intercept
        // messages to the window and thus catch WM_INPUT messages
        protected override void WndProc(ref Message message)
        {
            redirector?.ProcessMessage(message);
            base.WndProc(ref message);
        }

        private void doUnhook_Click(object sender, EventArgs e)
        {
            redirector = null;
            hookLabel.Text = "";
        }

        private void doRefresh_Click(object sender, EventArgs e)
        {
            PopulateTextBoxes();
        }

        private void PopulateTextBoxes()
        {
            applicationBox.SelectedIndex = -1;
            applicationBox.Items.Clear();
            foreach (Window window in windows.AllWindows())
            {
                applicationBox.Items.Add(window);
            }

            deviceBox.SelectedIndex = -1;
            deviceBox.Items.Clear();
            foreach (Device device in devices.GetDevices())
            {
                deviceBox.Items.Add(device);
            }

        }

        private void doHook_Click(object sender, EventArgs e)
        {
            Window application = (Window)applicationBox.SelectedItem;
            Device device = (Device)deviceBox.SelectedItem;
            if (application == null)
            {
                hookLabel.Text = "Please select an application.";
                return;
            }
            if (device == null)
            {
                hookLabel.Text = "Please select a device.";
                return;
            }
            redirector = new InputRedirector(application, device);
            hookLabel.Text = "Redirecting input from " + device.ToString() + " to " + application.ToString();
        }
    }
}
