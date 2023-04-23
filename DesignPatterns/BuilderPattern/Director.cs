using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class Director
    {
        public IProduct CreateProduct(IBuilder builder, string param)
        {
            builder.CreateObject();
            builder.InitializeObject(param);
                return builder.ReturnObject();
        }
    }
}
