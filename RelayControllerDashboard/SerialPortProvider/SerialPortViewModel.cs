namespace SerialPortProvider
{
    /// <summary>
    /// Class used to display information about a serial port.
    /// </summary>
    public class SerialPortViewModel
    {
        /// <summary>
        /// Device ID for the serial port (i.e. COM1, COM2, etc.).
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// Description of the serial port.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value that enables the Data Terminal Ready (DTR) 
        /// signal during serial communication.
        /// </summary>
        /// <remarks>
        /// This property should be set to true for Arduino Leonardo and 
        /// Arduino Micro boards. All other boards should have this
        /// value set to false.
        /// </remarks>
        public bool DtrEnable { get; set; }

        /// <summary>
        /// Device ID and Description of the Serial port.
        /// </summary>
        public string DisplayValue
        {
            get
            {
                return string.Format("{0}: {1}", DeviceId, Description);
            }
        }
    }
}
