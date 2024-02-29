using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_assessment_1
{


    internal class Program
    {
        static void Main(string[] args)
        {
          

            List<int> april = new List<int>();
            List<int>may = new List<int>();

            List<int> june = new List<int>();

            List<int> july = new List<int>();

            List<int> aug = new List<int>();

            List<int> sep = new List<int>();

            april.Add(1);
            for (int i = 1; i < 30; i++) {
                april.Add((i ) * 2 + april[i-1]);
            }

            may.Add(1);

            for (int i = 1; i < 31; i++)
            {
                may.Add((i ) * 2 + may[i - 1]);
            }

            june.Add(1);

            for (int i = 1; i < 30; i++)
            {
                june.Add((i ) * 2 + june[i - 1]);
            }

            july.Add(1);

            for (int i = 1; i < 31; i++)
            {
                july.Add((i ) * 2 + july[i - 1]);
            }

            aug.Add(1);

            for (int i = 1; i < 31; i++)
            {
                aug.Add((i ) * 2 + aug[i - 1]);
            }
            sep.Add(1);

            for (int i = 1; i < 30; i++)
            {
                sep.Add((i ) * 2 + sep[i - 1]);
            }

            List<List<int>>all=new List<List<int>>() { april,may,june,july,aug,sep};

            List<string>month=new List<string>() { "april", "may", "june", "july", "august", "september" };

            int retail=0;
            int corporate = 0;
            int augtosep = 0;

            for (int i=0;i< all.Count;i++)
            {
                List<int> list = all[i];    
                Console.Write("Month- " + month[i]);
                int sum = 0;
                for(int j= 0;j < list.Count;j++)
                {
                    if((j+1)%5==0)
                    { corporate += list[j]; }
                    else { retail += list[j];  }


                    sum += list[j];
    

                    if((i==4 && j>=14) || (i==5 && j<15))
                    {
                        augtosep += list[j];
                    }
                }
                Console.Write(" Count- "+sum);
                Console.WriteLine();
            }

            Console.WriteLine("Number of vechicles sold to retail customer is- "+retail);
            Console.WriteLine("Number of vechicles sold to corporate customer is- " + corporate);
            Console.WriteLine("Number of vechicles sold from Aug 15th to Sep 15th is- " + augtosep);




        }


    }

}

