using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocExample
{
    public class Class1
    {
        Class2 c2;
        Class3 c3;
        
        public Class1(Class2 obj, Class3 obj2)
        {
            c2 = obj;
            c3 = obj2;
        }
        public int MethodClass1(int i)
        {
            int j= Convert.ToInt32(c2.MethodClass2()) + c3.MethodClass3(i);
            return j;   
        }
    }
}
