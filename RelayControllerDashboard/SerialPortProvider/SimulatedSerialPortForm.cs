using System.Windows.Forms;

namespace SerialPortProvider
{
    public partial class SimulatedSerialPortForm : Form
    {
        public SimulatedSerialPortForm()
        {
            InitializeComponent();
        }

        public string SerialPortDescription
        {
            get { return lblSerialPort.Text; }
            set { lblSerialPort.Text = value; }
        }

        public string ReadLineValue
        {
            get {

                if (rdoThrowException.Checked)
                {
                    return string.Empty;
                }

                if (rdoReturnOnce.Checked)
                {
                    rdoThrowException.Checked = true;
                }

                return txtSendValue.Text;
            }
        }

    }
}
