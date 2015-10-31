using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = width;
            int leftDots = width / 2 - 1;
            int rightDots = width / 2 - 1;
            int space = 0;
            int slash = 1;
            int innerSlash = 1;
            int backslash = 1;
           
            int innerSpace = 0;
            

            for (int i = 0; i < 2; i++)
            {
                Console.Write(new string('.',leftDots));
                Console.Write(new string('/', slash));
                Console.Write(new string(' ', space));
                Console.Write(new string('\\', backslash));
                Console.Write(new string('.', rightDots));
                space += 2;
                leftDots--;
                rightDots--;
                
                
                if (i == 1)
                {
                    Console.WriteLine();
                        
                        space = 1;
                        for (int j = 3; j < width / 2 + 1; j++)
                        {


                            Console.Write(new string('.', leftDots));
                            Console.Write(new string('/', slash));
                            Console.Write(new string(' ', space));
                            Console.Write(new string('/', innerSlash));
                            
                            if (j == width / 2 - 1)
                            {
                                innerSpace = 1;
                                Console.Write(new string(' ', innerSpace));
                                Console.Write(new string('/', slash));
                            }
                            else if (j != width / 2)
                            {
                               Console.Write(new string(' ', innerSpace));
                            }
 
                            if(j == width / 2)
                            {

                                innerSpace = 1;
                                Console.Write(new string(' ', innerSpace));
                                Console.Write(new string('/', slash));
                                Console.Write(new string(' ', innerSpace + 1));
                            }
                           
                            // }
                            // 
                       
                            //
                            // Console.Write(new string(' ', innerSpace));
                            Console.Write(new string('\\', backslash));
                            Console.Write(new string(' ', space));
                            
                            Console.Write(new string('\\', backslash));

                            if (j == width / 2 - 1)
                            {
                                Console.Write(new string(' ', space));
                                Console.Write(new string('\\', backslash));
                            }
                            if (j == width / 2)
                            {
                                Console.Write(new string(' ', space));
                                Console.Write(new string('\\', backslash));
                            }
                            Console.Write(new string('.', rightDots));
                            leftDots--;
                            rightDots--;
                           
                            innerSpace = 2;
                            Console.WriteLine();
                        }
                }
                Console.WriteLine();
            }
              Console.WriteLine();

        }
    }

