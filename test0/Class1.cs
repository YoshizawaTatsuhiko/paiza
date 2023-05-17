using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        char[,] dotPicture = new char[data[0], data[1]];
        string result = "";
        bool isLineSymmetry = false, isPointSymmetry = false;

        for (int v = 0; v < data[0]; v++)
        {
            string info = Console.ReadLine();

            for (int h = 0; h < data[1]; h++)
            {
                dotPicture[v, h] = info[h];
            }
        }
        isLineSymmetry = IsLineSymmetry(dotPicture);    // 渡されたchar[,]が線対称かを判断する
        isPointSymmetry = IsPointSymmetry(dotPicture);  // 渡されたchar[,]が点対称かを判断する

        if (isLineSymmetry && isPointSymmetry) result = "line point symmetry";
        else if (isLineSymmetry) result = "line symmetry";
        else if (isPointSymmetry) result = "point symmetry";
        else result = "none";

        Console.WriteLine(result);

        bool IsLineSymmetry(char[,] twoDimentionalArray)
        {
            // 2次元配列の縦(横)の長さ
            int vLength = twoDimentionalArray.GetLength(0);
            int hLength = twoDimentionalArray.GetLength(1);
            // 垂直(水平)方向に対称かどうか確認するための変数
            bool isVerticallySymmetrical = true, isHorizontallySymmetrical = true;

            // 水平方向に対称かどうかを判定
            for (int v = 0; v < vLength; v++)
            {
                for (int h = 0; h < hLength / 2; h++)
                {
                    int n = hLength - 1 - h;

                    if (twoDimentionalArray[v, h] != twoDimentionalArray[v, n])
                    {
                        isHorizontallySymmetrical = false;
                        break;
                    }
                }
                if (!isHorizontallySymmetrical) break;
            }

            // 垂直方向に対称かどうかを判定
            for (int v = 0; v < vLength; v++)
            {
                for (int h = 0; h < hLength; h++)
                {
                    int n = vLength - 1 - v;

                    if (twoDimentionalArray[v, h] != twoDimentionalArray[n, h])
                    {
                        isVerticallySymmetrical = false;
                        break;
                    }
                }
                if (!isVerticallySymmetrical) break;
            }

            // 水平 または 垂直方向に対称かどうかを返す。
            return isVerticallySymmetrical || isHorizontallySymmetrical;
        }

        bool IsPointSymmetry(char[,] twoDimentionalArray)
        {
            int vLength = twoDimentionalArray.GetLength(0);
            int hLength = twoDimentionalArray.GetLength(1);
            int arrayHalfSize = vLength * hLength / 2;

            char[] firstHalfArray = new char[arrayHalfSize];
            char[] LatterHalfArray = new char[arrayHalfSize];
            bool isFirstHalfFinish = false, isLatterHalfFinish = false;

            for (int v = 0, index = 0; v < vLength; v++)
            {
                for (int h = 0; h < hLength; h++, index++)
                {
                    if (index >= arrayHalfSize)
                    {
                        isFirstHalfFinish = true;
                        break;
                    }
                    firstHalfArray[index] = twoDimentionalArray[v, h];
                }
                if (isFirstHalfFinish) break;
            }

            for (int v = vLength - 1, index = 0; v >= 0; v--)
            {
                for (int h = hLength - 1; h >= 0; h--, index++)
                {
                    if (index >= arrayHalfSize)
                    {
                        isLatterHalfFinish = true;
                        break;
                    }
                    LatterHalfArray[index] = twoDimentionalArray[v, h];
                }
                if (isLatterHalfFinish) break;
            }

            return firstHalfArray.SequenceEqual(LatterHalfArray);
        }
    }
}