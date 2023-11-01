using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class TestTable
    {
        static void Main(string[] args)
        {
            //reading user input
            double start = Convert.ToDouble(Console.ReadLine());
            double end = Convert.ToDouble(Console.ReadLine());
            int step = Convert.ToInt32(Console.ReadLine());

            //swap start and end if needed 
            if(start > end)
            {
                double temp=start; 
                start = end; 
                end = temp;
            }
            //creating table
            Table table = new Table(start,end,step);

            //using MakeTable
            table.MakeTable();
        }
    }
}
