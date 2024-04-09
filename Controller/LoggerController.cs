using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LoggerController : ILogger
{
    private Logger _Logger;

    public LoggerController()
    {
        _Logger = new Logger();
    }

    public void TrAcE(int level, int line, string log)
    {
        _Logger.TrAcE(level, line, log);
    }
}

