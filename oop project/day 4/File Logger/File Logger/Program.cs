//using System;
//using System.IO;

//public class FileLogger : IDisposable
//{
//    private StreamWriter _writer;
//    private bool _disposed = false;

//    public FileLogger(string filePath)
//    {
//               _writer = new StreamWriter(filePath, append: true);

//    }

//    public void Log(string message)
//    {
//        if (_disposed)
//            throw new ObjectDisposedException("FileLogger");
//        _writer.WriteLine($"{DateTime.Now} : (message)";
//    }

//    public void Dispose()
//    {
//        if (!_disposed)
//        {
//            _writer?.Close();
//            _writer?.Dispose();
//            _writer = true;
//        }

//    }
//}