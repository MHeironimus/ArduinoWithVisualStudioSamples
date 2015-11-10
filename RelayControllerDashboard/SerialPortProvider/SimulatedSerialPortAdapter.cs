using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SerialPortProvider
{
    public class SimulatedSerialPortAdapter : ISerialPortAdapter
    {
        #region Private: Fields

        private SimulatedSerialPortForm _simulationForm;

        #endregion

        #region Public: ISerialPortAdapter Members

        public IEnumerable<SerialPortViewModel> SerialPorts
        {
            get
            {
                return new List<SerialPortViewModel>
                {
                    new SerialPortViewModel { DeviceId = "COM3", Description = "Simulated Arduino Leonardo", DtrEnable = true},
                    new SerialPortViewModel { DeviceId = "COM4", Description = "Simulated Arduino UNO"  },
                    new SerialPortViewModel { DeviceId = "COM6", Description = "Simulated Standard Internal Serial Port"  },
                };
            }
        }

        public SerialPortViewModel SerialPort { get; private set; }

        public void Connect(SerialPortViewModel serialPort)
        {
            if (serialPort == null)
            {
                throw new ArgumentNullException("serialPort");
            }

            SerialPort = serialPort;
            _simulationForm = new SimulatedSerialPortForm
            {
                SerialPortDescription = string.Format("{0} (DtrEnable: {1})", serialPort.DisplayValue, serialPort.DtrEnable)
            };
            _simulationForm.Show();
        }

        public string ReadLine()
        {
            var lineToReturn = _simulationForm.ReadLineValue;

            if (string.IsNullOrWhiteSpace(lineToReturn))
            {
                throw new TimeoutException();
            }

            return lineToReturn;
        }

        public void WriteLine(string text)
        {
        }

        #endregion

        #region Public: IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_simulationForm != null)
                {
                    if (Application.OpenForms.Cast<object>().Any(form => form == _simulationForm))
                    {
                        _simulationForm.Close();
                        _simulationForm = null;
                    }
                }
            }
        }

        ~SimulatedSerialPortAdapter()
        {
            // Finalizer calls Dispose(false)
            Dispose(false);
        }

        #endregion
    }
}
