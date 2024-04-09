using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DataController
{
    private readonly IData _dataModel;
    public DataController(IData dataModel)
    {
        _dataModel = dataModel;
    }
    public string GetAppName()
    {
        return _dataModel.GetAppName();
    }
    public void SetAppName(string appName)
    {
        _dataModel.SetAppName(appName);
    }
    public string GetAppRoute()
    {
        return _dataModel.GetAppRoute();
    }
    public string GetAppVersion()
    {
        return _dataModel.GetAppVersion();
    }
    public string GetAppYear()
    {
        return _dataModel.GetAppYear();
    }
    public string LoggerRoute()
    {
        return _dataModel.GetLoggerRoute();
    }
    public int LoggerLevel()
    {
        return _dataModel.GetLoggerLevel();
    }
    public string GetChain1()
    {
        return _dataModel.GetChain1();
    }
}
