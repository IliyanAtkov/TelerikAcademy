namespace Kitchen
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            Peel(potato);
            Peel(carrot);
            this.Cut(potato);
            this.Cut(carrot);
            Bowl bowl = this.GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        public static void Main()
        {
        }

        private static void Peel(Vegetable vegetable)
        {
            Console.WriteLine("Peeling");
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private void Cut(Vegetable vegetable)
        {
        }
    }
}