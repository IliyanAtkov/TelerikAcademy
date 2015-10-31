namespace SubString
{
    using System;
    using System.Text;

    public static class SubstringExtension
    {
        public static StringBuilder SubString(this StringBuilder sb, int index, int length)
        {
            if (index < sb.Length && index >= 0
                && length > 0
                && index + length < sb.Length)
            {
                StringBuilder result = new StringBuilder();
                for (int i = index; i < length; i++)
                {
                    result.Append(sb[i]);
                }
                return result;
            }
            else
            {
                throw new IndexOutOfRangeException("Index was out of range or length is zero or less");
            }
        }
    }
}
