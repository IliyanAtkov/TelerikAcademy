namespace School
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Disciplines History = new Disciplines("History", 5, 5);
            Disciplines English = new Disciplines("English", 10, 4);
            Disciplines Math = new Disciplines("Math", 11, 3);
            Disciplines Biology = new Disciplines("Biology", 3, 5);

            Teachers penka = new Teachers("Penka");
            penka.disciplines.Add(History);
            penka.disciplines.Add(Math);
            Teachers dzurla = new Teachers("Dzurla");
            dzurla.disciplines.Add(Biology);
            dzurla.disciplines.Add(English);
            Teachers valq = new Teachers("Valq");
            valq.disciplines.Add(History);
            valq.disciplines.Add(English);

            Classes classA = new Classes("A");
            classA.teachers.Add(penka);
            classA.teachers.Add(valq);
            classA.students.Add(new Students("Pesho Iliev", "2345"));
            classA.students.Add(new Students("Gosho Chumata", "13"));
            classA.students.Add(new Students("Dzurlio Dzurlev", "412"));
            classA.students.Add(new Students("Ganka Shikerova", "4124"));
            classA.students.Add(new Students("Petur Petrov", "4124"));
            Console.WriteLine(classA.ToString());
           

        }
    }
}
