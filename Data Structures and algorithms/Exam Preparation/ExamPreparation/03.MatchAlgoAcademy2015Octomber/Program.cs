namespace _03.MatchAlgoAcademy2015Octomber
{
    using System;

    class Hash
    {
        private const ulong BASE1 = 127;
        private const ulong BASE2 = 257;
        private const ulong MOD = 1000000033;

        private static ulong[] powers1;
        private static ulong[] powers2;

        public static void ComputePowers(int n)
        {
            powers1 = new ulong[n + 1];
            powers2 = new ulong[n + 1];
            powers1[0] = 1;
            powers2[0] = 1;

            for (int i = 0; i < n; i++)
            {
                powers1[i + 1] =
                  powers1[i] * BASE1 % MOD;

                powers2[i + 1] =
                  powers2[i] * BASE2 % MOD;
            }
        }

        public ulong Value1 { get; private set; }
        public ulong Value2 { get; private set; }

        public Hash(string str)
        {
            this.Value1 = 0;

            foreach (char c in str)
            {
                this.Add(c);
            }
        }

        public void Add(char c)
        {
            this.Value1 =
                (this.Value1 * BASE1 + c)
                          % MOD;

            this.Value2 =
                (this.Value2 * BASE2 + c)
                          % MOD;
        }

        public void Remove(char c, int n)
        {
            this.Value1 = (MOD +
              this.Value1 - powers1[n] * c % MOD)
                    % MOD;

            this.Value2 = (MOD +
              this.Value2 - powers2[n] * c % MOD)
                    % MOD;
        }
    }



    class Program
    {
        static void Main()
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
        }
    }
}
