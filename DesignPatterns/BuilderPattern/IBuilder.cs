using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public interface IBuilder
    {
        void CreateObject();
        void InitializeObject(string param);
        IProduct ReturnObject();
    }
}
