using System;

namespace Aufgabe1
{
    class Program
    {
        public String ToRoman(int number)
        {
            String Ausgabe ="";
            if ((number <=999) && (number >=1))
            {
                do
                {
                    if (number >= 900)
                    { 
                        Ausgabe += "CM";
                        number -= 900;
                    }
                    else
                    {     
                        if (number >= 500) 
                        { 
                            Ausgabe += "D";
                            number -= 500;
                        }
                        else
                        {
                            if (number >= 400)
                            { 
                                Ausgabe += "CD";
                                number -= 400;
                            }
                            else
                            {
                                if (number >= 100) 
                                { 
                                    Ausgabe += "C";
                                    number -= 100;  
                                }
                                else
                                {          
                                    if (number >= 90) 
                                    { 
                                        Ausgabe += "XC";
                                        number -= 90;
                                    }
                                    else
                                    {
                                        if (number >= 50) 
                                        { 
                                            Ausgabe += "L";
                                            number -= 50;
                                        }
                                        else
                                        {
                                            if (number >= 40) 
                                            { 
                                                Ausgabe += "XL";
                                                number -= 40;
                                            }
                                            else
                                            {
                                                if (number >= 10) 
                                                { 
                                                    Ausgabe += "X";
                                                    number -= 10;
                                                }
                                                else
                                                {
                                                    if (number >= 9) 
                                                    { 
                                                        Ausgabe += "IX";
                                                        number -= 9; 
                                                    }
                                                    else 
                                                    {
                                                        if (number >= 5) 
                                                        { 
                                                            Ausgabe += "V";
                                                            number -= 5;
                                                        }
                                                        else
                                                        {
                                                            if (number >= 4) 
                                                            { 
                                                                Ausgabe += "IV";
                                                                number -= 4;
                                                            }
                                                            else
                                                            {
                                                                if (number >= 1)
                                                                {  
                                                                    Ausgabe += "I";
                                                                    number -= 1;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }          
                }       
                while (number != 0);
                return Ausgabe; 
            }  
            else
            {
                return Ausgabe="Fehler";
            }
        }  
        static void Main(string[] args)
        {
            Program a = new Program ();
            Console.Write(a.ToRoman(8));
        }
    }
}
