using System;
using System.Collections.Generic;
using System.Text;

class Template
{
    void Deligate()
    {
        // 配列に格納された整数を降順で並べ替える
        int[] arr = { 10, 409, 3, 64, 0, -2, 13 };
        //Array.Sort(arr, (a, b) => b - a);
        Array.Sort(arr, (int x, int y) => { return y - x; });
        //Array.ForEach(arr, Console.WriteLine);
        Array.ForEach(arr, (int i) => { Console.WriteLine(i); });
    }
}
