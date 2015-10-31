// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short,
// ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class VariableTypes
{
    static void Main(string[] args)
    {
        byte byteType = 97;
        sbyte sbyteType = -115;
        short shortType = -10000;
        ushort ushortType = 52130;
        int intType = 4825932;
        Console.WriteLine("byte = {0} sbyte = {1} short = {2} ushort = {3} int = {4}", byteType, sbyteType, shortType, ushortType, intType);
    }
}

