using System;
using System.IO;

public class Logger : ILogger
{
    private readonly Data data;

    public Logger()
    {
        data = new Data(); //C.instancia de IData
    }
    public void TrAcE(int level, int line, string log)
    {
        try
        {
            string FicheroAhora = (DateTime.Now.ToString("yyyyMMdd"));
            if (level > 0 && data.GetLoggerLevel() >= level && data.GetLoggerLevel() < 6)
            {
                try
                {
                    if (!Directory.Exists(data.GetLoggerRoute()))
                    {
                        Directory.CreateDirectory(data.GetLoggerRoute());
                    }
                    string logFilePath = Path.Combine(data.GetLoggerRoute(), $"TrAcE_{FicheroAhora}.log");
                    string mensaje = $"Level:{level} >>> {DateTime.Now} - Linea: {line} >>> {log}\n";
                    File.AppendAllText(logFilePath, mensaje);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("TrAcE = Error: " + ex.Message);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("TrAcE = Error: " + ex.Message);
        }
    }
}
