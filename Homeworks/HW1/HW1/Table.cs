using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Table
    {
        #region Data
        private double startOfInterval;
        private double endOfInterval;
        private int numberOfSteps;
        #endregion

        #region Props
        public double StartOfInterval
        {
            get { return startOfInterval; }
            set { startOfInterval = value; }
        }

        public double EndOfInterval
        {
            get { return endOfInterval; }
            set { endOfInterval = value;}
        }

        public int NumberOfSteps
        {
            get { return numberOfSteps; }
            set { numberOfSteps = value > 0 ? value : 1; }
        }
        #endregion

        #region Constructor 

        public Table(double start = 0, double end = 0, int steps = 1)
        {
            StartOfInterval = start;
            EndOfInterval = end;
            NumberOfSteps = steps;
        } 
        #endregion

        //function f(x)
        private double FunctionAlg(double x)
        {
            return ((Math.Abs(x - 2) * Math.Abs(x - 2)) / (x * x + 1));
        }

        public void MakeTable()
        {
            //Console.WriteLine($"[{StartOfInterval}, {EndOfInterval}] for {NumberOfSteps} steps");
            
            //how much is a value of a step
            double difference = (endOfInterval - StartOfInterval)/numberOfSteps;
            //Console.WriteLine($"{"step",10}|{"x",10}|{"f(x)",10}|");
            //table header
            Console.WriteLine($"|{"x",10}|{"f(x)",10}|");
            for (int i = 0; i < numberOfSteps; i++)
            {
                //every 20 steps it wants a confirmation to continue
                if ((i+1) % 20 == 1 && i>19)
                {
                    Console.WriteLine("Press return to continue …");
                    string ans=Console.ReadLine();
                    if (ans != "Return") break;
                }
                //creating x for the step
                double x = startOfInterval + (difference * i);
                //Writing the table
                //Console.WriteLine($"{i+1,10}|{x, 10:f4}|{FunctionAlg(x), 10:f4}|");
                Console.WriteLine($"|{x,10:f4}|{FunctionAlg(x),10:f4}|");
            }
        }
    }
}
