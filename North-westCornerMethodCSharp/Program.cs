using System;
using System.Collections.Generic;


namespace North_westCornerMethodCSharp
{
    class Program
    {
        static void Main(string[] args)

        {
            List<string> Nwcmethod(int[] supply, int[] demand)
            {
                
                int[] supply_copie = supply.Clone() as int[];
                int[] demand_copie = demand.Clone() as int[];

                
                int i = 0;
                int j = 0;

                
                var Lfds = new List<String>();

                
                while (Lfds.Count < supply.Length + demand.Length - 1) 
                {
                    int s = supply_copie[i];
                    int d = demand_copie[j];

                
                    int v = Math.Min(s, d); 

                    
                    supply_copie[i] -= v; 
                    demand_copie[j] -= v;

                   
                    Lfds.Add("Cell (" + i.ToString() +","+ j.ToString() + ")" + " -Value x = " + v.ToString());

                    
                    if (supply_copie[i] == 0 && i < supply.Length - 1)
                        i += 1;
                    else if (demand_copie[j] == 0 && j < demand.Length - 1)
                        j += 1;
                }
                return Lfds;
            }

            //// ****** OUTPUT *******
            int[] Supply = { 40, 20 };
            int[] Demand = { 25, 10, 25 };

            List<string> lfds = Nwcmethod(Supply, Demand);

            foreach (string value in lfds)
                Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
