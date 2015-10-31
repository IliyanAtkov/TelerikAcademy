using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//
//
//class Program
//{
//    static void Main()
//    {
//        string input = Console.ReadLine();
//        List<string> listche = new List<string>();
//        string res = "";
//        StringBuilder sb = new StringBuilder();
//        for (char i = 'A'; i <= 'Z'; i++)
//        {
//            listche.Add(i.ToString());
//        }
//        for (char i = 'a'; i <= 'f'; i++)
//        {
//            for (char j = 'A'; j <= 'Z'; j++)
//            {
//                listche.Add(i.ToString() + j.ToString());
//            }
//        }
//        char[] ch = input.ToCharArray();
//        int index = 0;
//        Bi sum = 0;
//        int lenght = 0;
//        StringBuilder newsb = new StringBuilder();
//            for (int i = 0; i < ch.Length; i++)
//            {
//                if (char.IsUpper(ch[i]))
//                {
//                    newsb.Append(ch[i].ToString());
//            //       if (sb.Length == 0)
//            //       {
//            //           sum += listche.IndexOf(ch[i].ToString()); //+ ((ch.Length - i - 1) * 168);
//            //           
//            //       }
//              //     if (sb.Length != 0)
//              //     {
//              //         sb.Append(ch[i]);
//              //         sum += listche.IndexOf(sb.ToString()); //+ ((ch.Length - i - 1) * 168);
//              //         sb.Clear();
//              //         lenght--;
//              //     }
//                }
//                if (char.IsLower(ch[i]))
//                {
//                    if (ch.Length != 2)
//                    {
//                        int num = 0;
//                        sb.Append(ch[i].ToString());
//                        sb.Append(ch[i + 1].ToString());
//                       // sum += listche.IndexOf(sb.ToString()) + ((ch.Length - i) * 167);
//                        if ((num = listche.IndexOf(sb.ToString())) < 26)
//                        {
//                            sum += num;
//                        }
//                        else if ((num = listche.IndexOf(sb.ToString())) < 26 * 2)
//                        {
//                            sum += num + ((ch.Length - i - 1) * 167);
//                        }
//                        else if ((num = listche.IndexOf(sb.ToString())) < 26 * 3)
//                        {
//                            sum += num + ((ch.Length - i - 2) * 167);
//                        }
//                        else if ((num = listche.IndexOf(sb.ToString())) < 26 * 4)
//                        {
//                            sum += num + ((ch.Length - i - 3) * 167);
//                        }
//                        else if ((num = listche.IndexOf(sb.ToString())) < 26 * 5)
//                        {
//                            sum += num + ((ch.Length - i - 4) * 167);
//                        }
//                        else
//                        {
//                            sum += num + ((ch.Length - i) * 167);
//                        }
//                        sb.Clear();
//                        lenght = ch.Length;
//                        lenght--;
//                        i++;
//                    }
//                    else
//                   {
//                       sb.Append(ch[i].ToString());
//                       sb.Append(ch[i + 1].ToString());
//                       sum += listche.IndexOf(sb.ToString());
//                       lenght--;
//                       break;
//                   }
//                   
//                }
//                
//            }
//            
//        
//        
//        
//        for (int i = 0; i < newsb.Length; i++)
//        {
//            sum += listche.IndexOf(newsb[i].ToString()) + ((ch.Length - lenght - 1) * 167);
//            lenght--;
//        }
//        
//        
//        Console.WriteLine(sum);
//        
//    }
//}

