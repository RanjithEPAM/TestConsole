using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public interface IProduct
    {
        void setProcessor(string processor);
        void setMemory(string memory);
        void setStorage(string storage);
        void AdditionalDevices();
        void Shwodetails();
    }
}
