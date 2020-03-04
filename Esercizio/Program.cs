using System;
using System.Collections.Generic;
using System.IO;

namespace Esercizio
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileinput = "input.txt";
            string fileoutput = "output.txt";
            List<string> testo = new List<string>();
            bool spazio = false;
            string yin = "";
            string xfin = "";
            int N;
            bool spazio1 = false;
            bool spazio2 = false;
            List<string> x = new List<string>();
            List<string> y = new List<string>();
            List<string> y1 = new List<string>();

            using (StreamReader reader = new StreamReader(fileinput))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    testo.Add(line);
                }
            }

            using (StreamWriter writer = new StreamWriter(fileoutput)) { }

            string linea = testo[0];
            for (int c = 0; c < linea.Length; c++)
            {
                if (linea[c] == ' ')
                {
                    spazio = true;
                }
                else if (spazio == false)
                {
                    yin += linea[c];
                }
                else if (spazio == true)
                {
                    xfin += linea[c];
                }
            }

            N = int.Parse(testo[1]);

            for (int c = 2; c < testo.Count; c++)
            {
                spazio1 = false;
                spazio2 = false;
                linea = testo[c];
                string X = "";
                string Y = "";
                string Y1 = "";
                for (int i = 0; i < linea.Length; i++)
                {
                    if (linea[i] == ' ')
                    {
                        if (spazio1 == false)
                        {
                            spazio1 = true;
                        }
                        else if (spazio1 == true)
                        {
                            spazio2 = true;
                        }
                    }
                    else if (spazio1 == false)
                    {
                        X += linea[i];
                    }
                    else if (spazio1 == true)
                    {
                        if (spazio2 == false)
                        {
                            Y += linea[i];
                        }
                        else if (spazio2 == true)
                        {
                            Y1 += linea[i];
                        }
                    }
                    x.Add(X);
                    y.Add(Y);
                    y1.Add(Y1);
                }
            }

            Console.WriteLine($"{yin} {xfin}");
            Console.WriteLine(N);
            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine($"{x[i]} {y[i]} {y1[i]}");
            }
        }   
    }
}
