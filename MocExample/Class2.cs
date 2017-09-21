using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocExample
{
    public class Class2
    {
        Class3 c3;
        public Class2()
        {

        }
        public virtual string MethodClass2()
        {
            return c3.MethodClass3(2).ToString();
        }

        public Class2(Class3 obj)
        {
            c3 = obj;
        }
    }
}
