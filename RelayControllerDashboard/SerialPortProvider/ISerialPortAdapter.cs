using System;
using System.Collections.Generic;

namespace SerialPortProvider
{
    /// <summary>
    /// Interface that Serial Port adapters must implement for this application.
    /// </summary>
    public interface ISerialPortAdapter : IDisposable
    {
        /// <summary>
        /// Provides a list of serial ports currently available to the application.
        /// </summary>
        IEnumerable<SerialPortViewModel> SerialPorts { get; }

        /// <summary>
        /// Gets the currently connected serial port.
        /// </summary>
        SerialPortViewModel SerialPort { get; }

        /// <summary>
        /// Opens a new serial port connection.
        /// </summary>
        /// <param name="serialPort">
        /// The port to connect to. 
        /// </param>
        /// <remarks>
        /// Available ports are provided by the SerialPorts property.
        /// </remarks>
        void Connect(SerialPortViewModel serialPort);

        /// <summary>
        /// Reads and returns the next line in the input buffer.
        /// </summary>
        /// <returns>
        /// The next line in the input buffer.
        /// </returns>
        string ReadLine();

        /// <summary>
        /// Writes the specified string and a new line character to the output buffer.
        /// </summary>
        /// <param name="text">
        /// The string to write to the output buffer.
        /// </param>
        void WriteLine(string text);
    }
}
