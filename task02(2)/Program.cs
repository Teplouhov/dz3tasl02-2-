using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task02_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            oduvanchik od=new oduvanchik("yellow",50);
            tulpan tul1=new tulpan();
            tulpan tul2=new tulpan("blue",200);
            gvozdika gv=new gvozdika("red",50);
            roza roz1=new roza();
            roza roz2=new roza("pink",150);
            roza roz3=new roza("rozovaja",300);

            flower[] byket = new flower[7];
            byket[0]=roz3;
            byket[1] = tul1;
            byket[2] = gv;
            byket[3] = roz2;
            byket[4] = od;
            byket[5] = tul2;
            byket[6] = roz1;

            int fcost=0;
            for (int i = 0; i < byket.Length; i++)
            {
                fcost += byket[i].Cost;
            }
            Console.WriteLine(fcost);
        }
    }
}
