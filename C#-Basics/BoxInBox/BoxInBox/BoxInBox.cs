using System;

class BoxInBox
{
    static void Main()
    {
        //int widthSmall = 12;
        //int heightSmall = 4;
        //int depthSmall = 8;

        //int widthBig = 9;
        //int heightBig = 16;
        //int depthBig = 14;
        int[] smallBox = new int[3];
        int[] BigBox = new int[3];
        for (int i = 0; i < smallBox.Length; i++)
        {
            smallBox[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < BigBox.Length; i++)
        {
            BigBox[i] = int.Parse(Console.ReadLine());
        }
        
        

    }
}

