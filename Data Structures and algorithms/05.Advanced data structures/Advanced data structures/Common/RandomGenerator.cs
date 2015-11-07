namespace Common
{
    using System;
    using System.Text;

    public class RandomGenerator
    {
        private const string Aplhabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private Random random;

        public RandomGenerator()
        {
            this.random = new Random();
        }

        public string GenerateRandomString(int minLength, int maxLength)
        {
            StringBuilder sb = new StringBuilder();
            var length = GenerateRandomNumber(minLength, maxLength);
            for (int i = 0; i < length; i++)
            {
                sb.Append(Aplhabet[GenerateRandomNumber(1, 25)]);
            }

            return sb.ToString();

        }

        public int GenerateRandomNumber(int minNumber, int maxNumber)
        {
            return this.random.Next(minNumber, maxNumber + 1);
        }
    }
}