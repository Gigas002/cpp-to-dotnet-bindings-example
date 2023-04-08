using System;
using System.Runtime.InteropServices;

namespace MathLibrary.NET.Core
{
    public static class Api
    {
        private const string DllPath = "/runtimes/win-x64/native/MathLibrary.dll";

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        private static extern int test(int number);

        public static int Test(int number) => test(number);
    }
}
