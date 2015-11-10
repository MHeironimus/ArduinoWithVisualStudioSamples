using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Ports;
using System.Linq;
using System.Management;

namespace SerialPortProvider
{
    public class SerialPortAdapter : ISerialPortAdapter
    {
        #region Private: Fields

        private SerialPortViewModel _serialPortViewModel;
        private SerialPort _serialPort;

        #endregion

        #region Public: ISerialPortAdapter Members

        public IEnumerable<SerialPortViewModel> SerialPorts
        {
            get
            {
                return GetSerialPorts();
            }
        }

        public SerialPortViewModel SerialPort
        {
            get
            {
                return _serialPortViewModel;
            }
        }

        public void Connect(SerialPortViewModel serialPort)
        {
            if (serialPort == null)
            {
                throw new ArgumentNullException("serialPort");
            }

            _serialPortViewModel = serialPort;

            _serialPort = new SerialPort(_serialPortViewModel.DeviceId, 9600)
            {
                ReadTimeout = 10,
                DtrEnable = serialPort.DtrEnable,
                NewLine = Environment.NewLine
            };
            _serialPort.Open();
        }

        public string ReadLine()
        {
            if (_serialPort == null)
            {
                throw new InvalidOperationException("Must call Connect before attempting to call ReadLine.");
            }
            return _serialPort.ReadLine();
        }

        public void WriteLine(string text)
        {
            if (_serialPort == null)
            {
                throw new InvalidOperationException("Must call Connect before attempting to call WriteLine.");
            }
            _serialPort.WriteLine(text);
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
                if (_serialPort != null)
                {
                    _serialPort.Dispose();
                }
            }
        }

        ~SerialPortAdapter()
        {
            // Finalizer calls Dispose(false)
            Dispose(false);
        }

        #endregion

        #region Private: Methods

        private static IEnumerable<SerialPortViewModel> GetSerialPorts()
        {
            string wmiQuery = string.Format("SELECT Name, DeviceID FROM Win32_SerialPort");

            var searcher = new ManagementObjectSearcher(wmiQuery);
            var queryResults = searcher.Get();

            var results = new Collection<SerialPortViewModel>();

            foreach (var serialPort in queryResults)
            {
                var serialPortViewModel = new SerialPortViewModel
                {
                    DeviceId = serialPort["DeviceID"].ToString(),
                    Description = serialPort["Name"].ToString()
                };

                if (serialPortViewModel.Description.Contains("Arduino Leonardo") ||
                    serialPortViewModel.Description.Contains("Arduino Micro"))
                {
                    serialPortViewModel.DtrEnable = true;
                }
                results.Add(serialPortViewModel);
            }

            return results.OrderBy(serialPort => serialPort.DeviceId);
        }

        #endregion
    }
}
