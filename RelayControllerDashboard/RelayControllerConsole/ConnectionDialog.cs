using System;
using System.Linq;
using System.Windows.Forms;
using SerialPortProvider;

namespace RelayControllerConsole
{
    public partial class ConnectionDialog : Form
    {
        private readonly ISerialPortAdapter _serialPortAdapter;

        public ConnectionDialog()
        {
            InitializeComponent();

#if SIMULATOR
            _serialPortAdapter = new SimulatedSerialPortAdapter();
#else
            _serialPortAdapter = new SerialPortAdapter();
#endif
        }

        #region Public: Properties

        public SerialPortViewModel SerialPort { get; set; }

#endregion

        private void ConnectionDialog_Load(object sender, EventArgs e)
        {
            var serialPorts = _serialPortAdapter.SerialPorts.ToArray();

            if (serialPorts.Length < 1)
            {
                MessageBox.Show("No serial ports are currently available.", 
                    "No Serial Ports Available",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            cboSerialPort.DisplayMember = "DisplayValue";
            cboSerialPort.DataSource = serialPorts;
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            SerialPort = (SerialPortViewModel)cboSerialPort.SelectedValue;
            SerialPort.DtrEnable = chkDtrEnable.Checked;
        }

        private void cboSerialPort_SelectedValueChanged(object sender, EventArgs e)
        {
            SerialPort = (SerialPortViewModel)cboSerialPort.SelectedValue;
            chkDtrEnable.Checked = SerialPort.DtrEnable;
        }
    }
}
