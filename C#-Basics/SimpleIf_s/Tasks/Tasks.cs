namespace Tasks
{
    using System;
    class Tasks
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = null;
            if (n <10 && n >= 0)
            {
                result = DigitsToWord(n);
            }
            else if (n >= 10 && n < 20)
            {
                result = Between10And19ToWord(n);
            }
            else if (n >=20 && n <100 )
            {
                result = NumberToWord(n);
            }
            else if(n == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
                return;
            }
            Console.WriteLine(result);
            
        }

        static string NumberToWord(int number)
        {
            string result = null;
            
                if (number < 10)
                {
                    result = DigitsToWord(number);
                }
                else if (number >=10 && number <20)
	            {
		            result = Between10And19ToWord(number);
	            }
                else if (number >=20 && number < 100)
                {
                    int reminder = number % 10;
                    if (reminder == 0 )
                    {
                        int firstNum = (number / 10) % 10;
                        switch (firstNum)
                        {
                            case 2: result = "twenty"; break;
                            case 3: result = "thirty"; break;
                            case 4: result = "forty"; break;
                            case 5: result = "fifty"; break;
                            case 6: result = "sixty"; break;
                            case 7: result = "seventy"; break;
                            case 8: result = "eighty"; break;
                            case 9: result = "ninty"; break;
                               
                        }
                    }
                    else
                    {
                        int secReminder = (number /10) % 10;
                        switch (secReminder)
                        {
                            case 2: result = "twenty"; break;
                            case 3: result = "thirty"; break;
                            case 4: result = "fourty"; break;
                            case 5: result = "fifty"; break;
                            case 6: result = "sixty"; break;
                            case 7: result = "seventy"; break;
                            case 8: result = "eighty"; break;
                            case 9: result = "ninety"; break;

                        }
                        result = result + " " + DigitsToWord(reminder);
                    }
                    
                }
            
            return result;
        }

        static string DigitsToWord(int number)
        {
            string result = null;
            switch (number)
            {
                case 0: result = "zero"; break;
                case 1: result = "one"; break;
                case 2: result = "two"; break;
                case 3: result = "three"; break;
                case 4: result = "four"; break;
                case 5: result = "five"; break;
                case 6: result = "six"; break;
                case 7: result = "seven"; break;
                case 8: result = "eight"; break;
                case 9: result = "nine"; break;
            }
            return result;
        }

        static string Between10And19ToWord(int number)
        {
            string result = null;
            switch (number)
            {
                case 10: result = "ten"; break;
                case 11: result = "eleven"; break;
                case 12: result = "twelve"; break;
                case 13: result = "thirteen"; break;
                case 14: result = "fourteen"; break;
                case 15: result = "fifteen"; break;
                case 16: result = "sixteen"; break;
                case 17: result = "seventeen"; break;
                case 18: result = "eighteen"; break;
                case 19: result = "nineteen"; break;
            }
            return result;
        }
    }
}
