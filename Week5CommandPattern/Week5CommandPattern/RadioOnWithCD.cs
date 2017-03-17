using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CommandPattern
{
    class RadioOnWithCD:Command
    {
        private String status;
        Radio myRadio;
        public RadioOnWithCD(Radio r)
        {    
            myRadio = r;
        }
        public String execute()
        {
            status = myRadio.on();
            status = status +"\n"+ myRadio.insertCD();
            return status;
        }
    }
}
