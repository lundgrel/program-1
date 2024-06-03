using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Code 
    {
        public int CallCount;
        public int LostCallCount;
        
        
        public double RatioLostCalls {
            get {
                if ( CallCount == 0 )
                    return 0.0;
                else 
                    return (double)LostCallCount/(double)CallCount;
            }
        }
        
        public const string Constant = "bbbb";
        
        
        public void BigFeatureMethod()
        {
            // asdf asdf asdf asdf
        }
        
        public void method1()        
        {}
        
        public void method2() 
        {}
        
        public void method3() 
        {}

    }
}