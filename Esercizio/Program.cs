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
            string Yin = "";
            string Xfin = "";
            int yin = 0;
            int xfin = 0;
            int N;
            bool spazio1 = false;
            bool spazio2 = false;
            List<int> x = new List<int>();
            List<int> y = new List<int>();
            List<int> y1 = new List<int>();
            int xattuale = 0;


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
                    Yin += linea[c];
                }
                else if (spazio == true)
                {
                    Xfin += linea[c];
                }
            }
            yin = int.Parse(Yin);
            xfin = int.Parse(Xfin);

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
                }
                x.Add(int.Parse(X));
                y.Add(int.Parse(Y));
                y1.Add(int.Parse(Y1));
            }

            int j = 0;
            int lunghezza = xfin;
            int yattuale = 0;
            int y1attuale = 0;

            do
            {
                if (xattuale == x[j])
                {
                    yattuale = y[j];
                    y1attuale = y1[j];
                    if (Math.Abs(yin - yattuale) < Math.Abs(yin - y1attuale))
                    {
                        lunghezza += Math.Abs(yin - yattuale);
                        yin = yattuale;
                    }
                    else
                    {
                        lunghezza += Math.Abs(yin - y1attuale);
                        yin = y1attuale;
                    }
                    j++;
                }
                xattuale++;
            } while (xattuale < xfin);

            Console.WriteLine($"{yin} {xfin}");
            Console.WriteLine(N);
            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine($"{x[i]} {y[i]} {y1[i]}");
            }
            Console.WriteLine(lunghezza);
        }   
    }
}
