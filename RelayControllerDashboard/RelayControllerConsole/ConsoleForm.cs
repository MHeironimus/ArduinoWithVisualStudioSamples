using RelayControllerConsole.Properties;
using SerialPortProvider;
using System;
using System.Windows.Forms;

namespace RelayControllerConsole
{
    public partial class ConsoleForm : Form
    {
        enum Light
        {
            Red = 1,
            Yellow = 2,
            Green = 3,
            Christmas = 4
        }

        private readonly ISerialPortAdapter _serialPortAdapter;
        private int _lastStoplightState = 3;
        private bool _lastChristmasLightState;

        public ConsoleForm()
        {
            InitializeComponent();

#if SIMULATOR
            _serialPortAdapter = new SimulatedSerialPortAdapter();
#else
            _serialPortAdapter = new SerialPortAdapter();
#endif
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            var connectionDialog = new ConnectionDialog();

            if (connectionDialog.ShowDialog() != DialogResult.OK)
            {
                Close();
                return;
            }

            InitailizeSerialPort(connectionDialog.SerialPort);
            tmrReadSerialPort.Enabled = true;

            InitializeRelays();
        }

        private void InitializeRelays()
        {
            SendRelayCommand(Light.Red, false);
            SendRelayCommand(Light.Yellow, false);
            SendRelayCommand(Light.Green, false);
            SendRelayCommand(Light.Christmas, false);
        }

        private void InitailizeSerialPort(SerialPortViewModel serialPort)
        {
            _serialPortAdapter.Connect(serialPort);
            LogMessage(string.Format("Connected to {0}", serialPort.DisplayValue));
        }

        private void ReceiveAndProcessNextCommand()
        {
            var lineRead = _serialPortAdapter.ReadLine();
            LogCommandReceived(lineRead);
            ProcessCommandReceived(lineRead);
        }

        private void ProcessCommandReceived(string lineRead)
        {
            string[] tokens = lineRead.Split(' ');

            if (tokens.Length < 2)
            {
                return;
            }

            int relayId;
            if (!int.TryParse(tokens[0], out relayId))
            {
                return;
            }

            int turnOn;
            if (!int.TryParse(tokens[1], out turnOn))
            {
                return;
            }

            switch (relayId)
            {
                case 1:
                    picRedLight.Image = (turnOn == 0 ? Resources.bulb_red_off : Resources.bulb_red_on);
                    break;

                case 2:
                    picYellowLight.Image = (turnOn == 0 ? Resources.bulb_yellow_off : Resources.bulb_yellow_on);
                    break;

                case 3:
                    picGreenLight.Image = (turnOn == 0 ? Resources.bulb_green_off : Resources.bulb_green_on);
                    break;

                case 4:
                    picChristmasLights.Image = (turnOn == 0 ? Resources.christmas_lights_off : Resources.christmas_lights_on);
                    break;
            }
        }

        private void LogMessage(string message)
        {
            txtConsoleLog.AppendText(
                string.Format("{0:HH:mm:ss.fffff}: {1}{2}",
                DateTime.Now,
                message,
                Environment.NewLine));
            txtConsoleLog.SelectionStart = txtConsoleLog.TextLength;
            txtConsoleLog.ScrollToCaret();
        }

        private void LogCommandSent(string command)
        {
            LogMessage(string.Format("SENT: {0}", command));
        }
        private void LogCommandReceived(string command)
        {
            LogMessage(string.Format("RECEIVED: {0}", command));
        }

        private void ConsoleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _serialPortAdapter.Dispose();
        }

        private void cmdRedOn_Click(object sender, EventArgs e)
        {
            SendRelayCommand(Light.Red, true);
        }

        private void cmdRedOff_Click(object sender, EventArgs e)
        {
            SendRelayCommand(Light.Red, false);
        }

        private void cmdYellowOn_Click(object sender, EventArgs e)
        {
            SendRelayCommand(Light.Yellow, true);
        }

        private void cmdYellowOff_Click(object sender, EventArgs e)
        {
            SendRelayCommand(Light.Yellow, false);
        }

        private void cmdGreenOn_Click(object sender, EventArgs e)
        {
            SendRelayCommand(Light.Green, true);
        }

        private void cmdGreenOff_Click(object sender, EventArgs e)
        {
            SendRelayCommand(Light.Green, false);
        }

        private void cmdChristmasOn_Click(object sender, EventArgs e)
        {
            SendRelayCommand(Light.Christmas, true);
        }

        private void cmdChristmasOff_Click(object sender, EventArgs e)
        {
            SendRelayCommand(Light.Christmas, false);
        }

        private void SendRelayCommand(Light light, bool turnOn)
        {
            var relayId = (int)light;
            var commandToSend = string.Format("{0} {1}", relayId, (turnOn ? 1 : 0));
            _serialPortAdapter.WriteLine(commandToSend);
            LogCommandSent(commandToSend);
        }

        private void tmrReadSerialPort_Tick(object sender, EventArgs e)
        {
            var timer = (Timer)sender;

            timer.Enabled = false;
            try
            {
                do
                {
                    ReceiveAndProcessNextCommand();
                } while (true);
            }
            catch (TimeoutException)
            {
            }

            tmrReadSerialPort.Enabled = true;
        }

        private void tmrStoplight_Tick(object sender, EventArgs e)
        {
            _lastStoplightState++;
            if (_lastStoplightState > 3)
            {
                _lastStoplightState = 1;
            }

            switch (_lastStoplightState)
            {
                case 1:
                    SendRelayCommand(Light.Red, true);
                    SendRelayCommand(Light.Yellow, false);
                    SendRelayCommand(Light.Green, false);
                    break;

                case 2:
                    SendRelayCommand(Light.Red, false);
                    SendRelayCommand(Light.Yellow, false);
                    SendRelayCommand(Light.Green, true);
                    break;

                case 3:
                    SendRelayCommand(Light.Red, false);
                    SendRelayCommand(Light.Yellow, true);
                    SendRelayCommand(Light.Green, false);
                    break;
            }
        }

        private void chkStoplight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStoplight.Checked)
            {
                tmrStoplight_Tick(sender, e);
            }
            tmrStoplight.Enabled = chkStoplight.Checked;
        }

        private void chkFlashChristmas_CheckedChanged(object sender, EventArgs e)
        {
            tmrChristmasLights.Enabled = chkFlashChristmas.Checked;
        }

        private void tmrChristmasLights_Tick(object sender, EventArgs e)
        {
            _lastChristmasLightState = !_lastChristmasLightState;
            SendRelayCommand(Light.Christmas, _lastChristmasLightState);
        }
    }
}
