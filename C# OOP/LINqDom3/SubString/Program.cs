namespace SubString
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Pesho");
            sb.Append("Gosho");
            sb.Append("Valio");
            sb.Append("Mitko");
            sb.Append("Ganio");
            sb.Append("Traicho");
            sb.Append("Simo");
            sb.Append("Valentin");
            sb.Append("Valentinka");
            sb.Append("Nikolaika");
            sb.Append("Gaika");
            sb.Append("Petranka");
            Console.WriteLine("The result from extension method:");
            Console.WriteLine(sb.SubString(0, 10));

            Console.WriteLine("The result from normal string:");
            string str = "PeshoGoshoValioMitkoGanioGosho";
            Console.WriteLine(str.Substring(0, 10));
        } 
    }                     
}                         
                         
                          
