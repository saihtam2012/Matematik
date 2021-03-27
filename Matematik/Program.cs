using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine();
            Console.WriteLine("Beregner");
            Console.WriteLine("Omkreds, areal eller rumfang");
            Console.WriteLine("Hvis du vil regne med tal skal du skrive L");
            string op = Console.ReadLine();


            if (op == "omkreds" || op == "areal" || op == "rumfang")
            {
                if (op == "omkreds")
                {
                    Console.WriteLine("Vælg trekant, firkant eller cirkel");
                    string om = Console.ReadLine();

                    if (om == "trekant")
                    {
                        Console.WriteLine("Skriv den ene sidelængde: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Skriv den anden sidelængde: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Skriv den trejde sidelændge: ");
                        double num3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"Omkredsen af trekanten er {num1 + num2 + num3:N2}");
                        Console.ReadLine();
                    }

                    if (om == "firkant")
                    {
                        Console.WriteLine("Skriv side a: ");
                        double fir1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Skriv side b: ");
                        double fir2 = Convert.ToDouble(Console.ReadLine());


                        Console.WriteLine($"Omkredsen af firkanten er {(fir1 + fir2) * 2:N2}");
                        Console.ReadLine();
                    }

                    if (om == "cirkel")
                    {
                        Console.WriteLine("Skriv diameter: ");
                        double dia = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"Omkredsen af cirklen {dia * Math.PI:N2}");
                        Console.ReadLine();
                    }



                }




                if (op == "areal")
                {
                    Console.WriteLine("Vælg trekant, firkant eller cirkel");
                    string ar = Console.ReadLine();

                    if (ar == "trekant")
                    {
                        Console.WriteLine("Skriv side a: ");
                        double are1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Skriv side b: ");
                        double are2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"Arealet er trekanten er {are1 * are2 / 2:N2}");
                        Console.ReadLine();
                    }
                    if (ar == "firkant")
                    {
                        Console.WriteLine("Skriv side a: ");
                        double are3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Skriv side b: ");
                        double are4 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"Arealet af firkanten er {are3 * are4:N2}");
                        Console.ReadLine();
                    }

                    if (ar == "cirkel")
                    {
                        Console.WriteLine("Skriv radius: ");
                        double rad = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"Arealet af cirklen er {(rad * rad) * Math.PI:N2}");
                        Console.ReadLine();
                    }



                }

                if (op == "rumfang")
                {
                    Console.WriteLine("Vælg firkant, cylinder eller kugle");
                    string ru = Console.ReadLine();

                    if (ru == "firkant")
                    {


                        Console.WriteLine("Skriv side a: ");
                        double rum1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Skriv side b: ");
                        double rum2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Skriv side c: ");
                        double rum3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"Rumfanget er firkanten er {rum1 * rum2 * rum3:N2}");
                        Console.ReadLine();
                    }

                    if (ru == "cylinder")
                    {
                        Console.WriteLine("Skriv radius: ");
                        double cyl1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Skriv højde: ");
                        double cyl2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"Rumfanget af cylinderen {((cyl1 * cyl1) * Math.PI) * cyl2:N2}");
                        Console.ReadLine();
                    }

                    if (ru == "kugle")
                    {
                        Console.WriteLine("Skriv radius: ");
                        double kug1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"Rumfanget af kuglen {Math.Pow(kug1, 3) * Math.PI * 4/3:N2}");
                        Console.ReadLine();

                        
                    }


                     
                        Console.ReadLine();


                }

                

            }
            string i;
            if (op == "L" || op == "l")
            {
                Console.WriteLine("Skrv det første tal");
                i = Console.ReadLine();
                double tal1 = Convert.ToDouble(i);
                Console.WriteLine("Skriv regnemetode");
                i = Console.ReadLine();
                string regne1 = Convert.ToString(i);

                Console.WriteLine("Skriv det andet tal");
                i = Console.ReadLine();
                double tal2 = Convert.ToDouble(i);
                if (regne1 == "+")
                {
                    Console.WriteLine($"Tallet giver {tal1 + tal2}");
                }
                if (regne1 == "-")
                {
                    Console.WriteLine($"Tallet giver {tal1 - tal2}");
                }
                if (regne1 == "*")
                {
                    Console.WriteLine($"Tallet giver {tal1 * tal2}");
                }
                if (regne1 == "/")
                {
                    Console.WriteLine($"Tallet giver {tal1 / tal2}");
                }
            }






        }
    }
}
