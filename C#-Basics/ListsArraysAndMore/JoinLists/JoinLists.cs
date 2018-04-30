using System;
using System.Collections.Generic;
class JoinLists
{
    static void Main()
    {
        string[] inputOne = Console.ReadLine().Split();
        string[] inputTwo = Console.ReadLine().Split();
        List<int> listOne = new List<int>();
        List<int> listTwo = new List<int>();
        for (int i = 0; i < inputOne.Length; i++)
        {
            listOne.Add(int.Parse(inputOne[i]));
        }
        for (int i = 0; i < inputTwo.Length; i++)
        {
            listTwo.Add(int.Parse(inputTwo[i]));
        }
        listOne.Sort();
        List<int> listOneReslut = new List<int>(listOne);
        for (int i = 0; i < listOne.Count-1; i++)
        {
                if (listOne[i] == listOne[i+1])
                {
                    listOneReslut.RemoveAt(i);
                }
        }
        for (int i = 0; i < listOneReslut.Count; i++)
        {
            for (int j = 0; j < listTwo.Count; j++)
            {
                if (listOneReslut[i] == listTwo[j])
                {
                    listTwo.RemoveAt(j);
                }
            }
        }
        foreach (var num in listTwo)
        {
            listOneReslut.Add(num);
        }
        listOneReslut.Sort();
        Console.WriteLine(String.Join(",",listOneReslut.ToArray()));

        
        
        



        

    }
}

