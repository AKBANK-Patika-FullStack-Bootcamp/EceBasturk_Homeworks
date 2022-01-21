using Microsoft.AspNetCore.Mvc;

namespace GameStore2.Controllers
{
    public class Logger : ControllerBase
    {
        string _Path = @"D:\.NetProjects\GameStore\Log\";
        string _FileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";

        public void createLog(string message)
        {
            FileStream fs = new FileStream(_Path + _FileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(DateTime.Now.ToString() + ": " + message);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
