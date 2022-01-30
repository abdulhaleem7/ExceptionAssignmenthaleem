using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentException
{
    public class Invalidnumberexpression:Exception
    {
        public Invalidnumberexpression(string message):base(message)
        {
            
        }
    }
}
