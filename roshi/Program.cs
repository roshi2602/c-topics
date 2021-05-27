using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshi
{

    class Program
    {
         
           //for function
           static void fun(string x)            //static keyword is mandatory to combine with class
                                                //void defined that it dosent return any value
           {
               Console.WriteLine("this is function" + x);

           }


           //now we are creating function to return value
           //method returning int value
           static int fun2(int g, int h)
           {
               int c = g + h;
               return c / 2;
           }

           //method returning float value
           static float fun3(float f, float e)
           {
               return (e + f) / 2;
           }



           


        static void Main(string[] args)
        {

          
                     //data types
                     string e = "my name is roshi"; 
                     char t = 'a';
                     bool w = true;
                     float z = 0.05F;
                     int x = 25;
                     string y = Console.ReadLine(); //readline returns string
                     Console.WriteLine("hello roshi"+y);
                     Console.WriteLine(z);
                     Console.WriteLine(e);
                     Console.WriteLine(t);
                     Console.WriteLine(w);
                     Console.Write("roshi");
                     Console.WriteLine("hello roshi"+x);
                     Console.ReadLine();

                     //typecasting
                     int a = 3;
                     float b = a;
                     float var = Convert.ToInt32(3.50);
                     Console.WriteLine(var);
                     Console.WriteLine(b);




                     Console.WriteLine("enter your name");
                     string nam = Console.ReadLine();
                     Console.WriteLine("hello" + nam);
                     Console.ReadLine();



                     Console.WriteLine("enter value");
                     string can = Console.ReadLine();
                     Console.WriteLine("candy" + (Convert.ToInt32(can) + 5));
                     Console.ReadLine();




                     //operators
                     //arithmetic
                     int c = 10;
                     int d = 20;
                     Console.WriteLine(c + d);
                     Console.ReadLine();


                     //assignment
                     int d = 5;
                     int e = d;
                     e += 5;
                     Console.WriteLine(e);
                     Console.ReadLine();


                     //logical
                     Console.WriteLine(true && false);
                     Console.WriteLine(true || false);
                     Console.WriteLine(!true);
                     Console.ReadLine();


                     //comparison
                     Console.WriteLine(10 > 20);
                     Console.WriteLine(10 >= 20);
                     Console.WriteLine(10 <= 20);
                     Console.WriteLine(20 == 20);
                     Console.ReadLine();


                     //to find max , sqrt value
                     int w = Math.Min(30, 50);
                     double l = Math.Sqrt(25);  //int does not take sqrt, double take
                     Console.WriteLine(l);
                     Console.WriteLine(w);
                     Console.ReadLine();


                     string jo = "good morning";
                     Console.WriteLine(jo.ToUpper());
                     Console.WriteLine(jo.Length);
                     Console.WriteLine(jo + "evryone");
                     Console.ReadLine();



                     string age = Console.ReadLine();
                     string gender = Console.ReadLine();
                     Console.WriteLine($"your age {age} is and gender{ gender} is");
                     Console.ReadLine();


                     //to find out index
                     string hel = "hii everyone";
                     Console.WriteLine(hel[2]);
                     Console.ReadLine();


                     //to find string methods
                     string ok = "hey there";
                     Console.WriteLine(ok.IndexOf("the"));
                     //substring method
                     Console.WriteLine(ok.Substring(2));
                     Console.ReadLine();


                     //escape sequence characters

                     string op = "hey\nyou";
                     Console.WriteLine(op);
                     Console.ReadLine();


                     //if else else if  statements

                     int agee = 20;
                     if (agee > 30)
                     {
                         Console.WriteLine("eligible");
                     }
                     else if (agee < 23)
                     {
                         Console.WriteLine("not eligible");
                     }
                     else
                     {
                         Console.WriteLine("uneligible");

                     }
                     Console.ReadLine();




                     //using operators in if else

                     string agstr = Console.ReadLine();
                     int ag = Convert.ToInt32(agstr);
                     bool isban = true;
                  if (ag > 30 || isban)
                         {
                             Console.WriteLine("eligible");
                         }
                         else if (ag < 23 || isban)
                         {
                             Console.WriteLine("not eligible");
                         }
                         else
                         {
                             Console.WriteLine("uneligible");

                         }
                     Console.ReadLine();




                     //program for switch case

                     int aged = 50;
                     switch(aged)            //to watch this variable
                     {
                         case 10:
                             Console.WriteLine("wait for 1 year");
                             break;

                         case 20:
                             Console.WriteLine("you are done");
                             break;

                         default:
                             Console.WriteLine("enjoy");
                             break;

                     }
                     Console.ReadLine();




                     //loops in c#
                     //it is  better alternative for repetated statements
                     //while loop

                     int i = 0;
                     while(i<5)
                     {
                         Console.WriteLine(i);
                         i++;
                     }
                     Console.ReadLine();




                     //do while loop
                     int j = 0;
                     do                                       //do will work atleast one time(mandatory) and next will depend upon conditions
                     {
                         Console.WriteLine(j + 1);
                         j++;
                     } while (j < 10);

                     Console.ReadLine();




                     //for loop
                     for(int m=0; m<12; m++)
                     {
                         Console.WriteLine(m+1);
                     }
                     Console.ReadLine();




                     //break and continue

                     //break means to leave the loop
                     for (int n = 0; n < 13; n++)
                     {
                         Console.WriteLine(n + 1);
                         break;
                     }
                     Console.ReadLine();



                     //continue

                     //continue means start from next iteration
                     for (int h = 0; h < 5; h++)
                     {
                         if (h == 0)
                         {
                             continue;          //this means run for next iteration(leaving 1)
                         }
                         Console.WriteLine(h + 1);

                     }
                     Console.ReadLine();


                     //break -leave this loop forever
                     //continue=leave the next iteration for ever and move to next





                     fun("part");   //calling of fun1
                     Console.WriteLine(fun2(10, 20));        //calling for fun2
                     Console.WriteLine(fun3(5, 6)); //calling for fun3

                     Console.ReadLine();

           

            //to find array
            //arrays are list of items
            //creating an array
            int[] x = new int[5];
            x[1] = 10;
            x[2] = 20;
            //  Console.WriteLine(x[2]);


            //for traversing through all elements in array
           
            for (int v = 0; v < x.Length; v++)
            {
                Console.WriteLine(x [v]);
        }
            
            //for each element
            foreach (int i in x)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();        //getting value 




        }
    }
}
