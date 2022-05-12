using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasAmazon
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ExamenAmazon1();
        }

        public void ExamenAmazon1()
        {
            List<int> packageWeights = new List<int>();
            //packageWeights.Add(20);
            //packageWeights.Add(5);
            //packageWeights.Add(9);
            //packageWeights.Add(30);
            //packageWeights.Add(10);
            //packageWeights.Add(2);
            //packageWeights.Add(3);
            //packageWeights.Add(1);

            //packageWeights.Add(2);
            //packageWeights.Add(9);
            //packageWeights.Add(10);
            //packageWeights.Add(3);
            //packageWeights.Add(7);
            packageWeights.Add(30);
            packageWeights.Add(10);
            packageWeights.Add(5);
            packageWeights.Add(20);
            packageWeights.Add(33);
            packageWeights.Add(2);

            List<int> number2 = new List<int>();
           
            bool continua = true;
            int indexbig = 0;
            int count = 0;
            int convinaciones = 0;
            int maxValue = 0;
            while (continua == true)
            {
                if(count < packageWeights.Count)
                {
                    if (packageWeights[count] > packageWeights[indexbig])
                    {
                        indexbig = count;
                    }
                    if ((indexbig - 1) >= 0 && (packageWeights.Count -1) == count)
                    {
                        if (packageWeights[indexbig] > packageWeights[indexbig - 1])
                        {
                            packageWeights[indexbig - 1] = packageWeights[indexbig] + packageWeights[indexbig - 1];
                            packageWeights.RemoveAt(indexbig);
                            count = 0;
                            indexbig = 0;

                        }
                    }

                }
                else 
                {
                    convinaciones = validarConvinaciones(packageWeights);
                    if (convinaciones > 0)
                    {
                        count = convinaciones - 1;
                        indexbig = convinaciones - 1;
                    }
                    else {

                        maxValue = packageWeights.Max();
                        continua = false;
                    }

                }
                count++;
                
            }
            Console.WriteLine("Maximum possible weight is:: {0}", maxValue);
            Console.ReadLine();
            
        }
        public int validarConvinaciones(List<int> packageWeights)
        {
            int convinaciones = 0;
            for (int i = 1; i < packageWeights.Count; i++)
            {
                if (packageWeights[i] > packageWeights[i - 1])
                {
                    convinaciones = i;
                    break;
                }
            }
            return convinaciones;
        }
        public int ExamenAmazon2(List<int> packageWeights)
        {

            bool continua = true;
            int indexbig = 0;
            int count = 0;
            int convinaciones = 0;
            int maxValue = 0;
            while (continua == true)
            {
                if (count < packageWeights.Count)
                {
                    if (packageWeights[count] > packageWeights[indexbig])
                    {
                        indexbig = count;
                    }
                    if ((indexbig - 1) >= 0 && (packageWeights.Count - 1) == count)
                    {
                        if (packageWeights[indexbig] > packageWeights[indexbig - 1])
                        {
                            packageWeights[indexbig - 1] = packageWeights[indexbig] + packageWeights[indexbig - 1];
                            packageWeights.RemoveAt(indexbig);
                            count = 0;
                            indexbig = 0;

                        }
                    }

                }
                else
                {
                    convinaciones = validarConvinaciones(packageWeights);
                    if (convinaciones > 0)
                    {
                        count = convinaciones - 1;
                        indexbig = convinaciones - 1;
                    }
                    else
                    {

                        maxValue = packageWeights.Max();
                        continua = false;
                    }

                }
                count++;

            }
            return maxValue;
        }
        
    }
}
