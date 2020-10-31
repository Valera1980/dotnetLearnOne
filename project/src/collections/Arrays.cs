using System;
using System.Runtime.InteropServices;

namespace ArrayArea
{
    public class ArrayWorking
    {
        private double[] _arr;
        private bool _useDefault = false;

        public ArrayWorking([Optional] double[] arrParam)
        {
            if (arrParam is Array)
            {
                this._arr = arrParam;
            }
            else
            {
                this._arr = new [] { 12.55, 45.66, 78 };
                this._useDefault = true;
            }
        }
        public void loop()
        {
            _print();
        }
        private void _print()
        {
            if (this._useDefault == false)
            {
                for (int i = 0; i < _arr.Length; ++i)
                {
                    System.Console.WriteLine($"i = {_arr[i]}");
                }
            }
            else
            {
                System.Console.WriteLine(" === Use default params ===");
                for (int i = 0; i < _arr.Length; ++i)
                {
                    System.Console.WriteLine($"i = {_arr[i]}");
                }
            }
        }
    }

}