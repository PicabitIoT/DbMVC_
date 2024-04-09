using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Data : IData //Data
{
    //app
    private string AppName = "App MVC";
    private string AppRoute = (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\").Remove(0, 6);
    private string AppVersion = "V 1.0.11 Rev 00";
    private string AppYear = "2024 © " + DateTime.Now.Year.ToString();
    private string LoggerRoute = (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\").Remove(0, 6);
    private int LoggerLevel = 5;
    //DBCon
    private string Chain1 = DbMVC.Properties.Settings.Default.dataBase1;
    //app
    public string GetAppName()
    {
        return AppName;
    }
    public void SetAppName(string _AppName) // Set
    {
        AppName = _AppName;
    }
    public string GetAppRoute()
    {
        return AppRoute;
    }
    public string GetAppVersion()
    {
        return AppVersion;
    }
    public string GetAppYear()
    {
        return AppYear;
    }
    public string GetLoggerRoute()
    {
        return LoggerRoute;
    }
    public int GetLoggerLevel()
    {
        return LoggerLevel;
    }
    //DbCon
    public string GetChain1()
    {
        return Chain1;
    }
}
