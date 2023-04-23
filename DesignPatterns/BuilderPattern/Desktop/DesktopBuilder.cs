using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Desktop
{
    public class DesktopBuilder : IBuilder
    {
        Desktop objDesktop;
        public void CreateObject()
        {
            objDesktop = new Desktop();
        }

        public void InitializeObject(string param)
        {
            string[] Params = param.Split(',');
            objDesktop.setStorage(Params[0]);
            objDesktop.setProcessor(Params[1]);
            objDesktop.setMemory(Params[2]);
            objDesktop.AdditionalDevices();
        }

        public IProduct ReturnObject()
        {
            return objDesktop;
        }
    }
}