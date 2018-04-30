using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinningTicket
{
    class WinningTicket
    {
        static void Main()
        {
            var ticketsInput = Console.ReadLine().Split(',');
            var ticketsArgs = new List<string>();

            foreach (var ticket in ticketsInput)
            {
                ticketsArgs.Add(ticket.Trim());
            }

            foreach (var ticket in ticketsArgs)
            {
                Regex regexTicketExactLen = new Regex(@"^.{20}$");
                if (!regexTicketExactLen.IsMatch(ticket))
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                //Dividing the ticket
                var ticketLeftSideList = new List<char>();

                for (int i = 0; i < 10; i++)
                {
                    ticketLeftSideList.Add(ticket[i]);
                }

                var ticketRightSideList = new List<char>();

                for (int i = 10; i < ticket.Length; i++)
                {
                    ticketRightSideList.Add(ticket[i]);
                }

                string ticketLeftSideStr = string.Join("", ticketLeftSideList);
                string ticketRightSideStr = string.Join("", ticketRightSideList);

                Regex regexSpecailSym = new Regex(@"(\${6,10})|(\#{6,10})|(\@{6,10})|(\^{6,10})");
                if (!regexSpecailSym.IsMatch(ticketLeftSideStr) || !regexSpecailSym.IsMatch(ticketRightSideStr))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                }
               
                int specialSymCountLeft = regexSpecailSym.Match(ticketLeftSideStr).Value.Count();

                int specialSymCountRight = regexSpecailSym.Match(ticketRightSideStr).Value.Count();
                int symCount = 0;
                if (specialSymCountLeft <= specialSymCountRight)
                {
                    symCount = specialSymCountLeft;
                }
                else
                {
                    symCount = specialSymCountRight;
                }

                //if (specialSymCountLeft != specialSymCountRight)
                //{
                //    Console.WriteLine($"ticket \"{ticket}\" - no match");
                //    continue;
                //}

                //Check for jackpot
                var spesSym = regexSpecailSym.Match(ticketLeftSideStr).ToString()[0];
                if (symCount == 10)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {symCount}{spesSym} Jackpot!");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {symCount}{spesSym}");
                }
            }
        }
    }
}
