using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyBilliard
{
    class AndreyBilliard
    {
        static void Main()
        {
            var shopItems = new Dictionary<string, decimal>();
            int lenght = int.Parse(Console.ReadLine());
            shopItems = FillShopItems(lenght);
            List<Customer> customers = TakeOrders(shopItems);
            PrintOrderAndBill(customers);
        }

        public static Dictionary<string, decimal> FillShopItems(int listLenght)
        {
            var shopList = new Dictionary<string, decimal>();

            for (int i = 0; i < listLenght; i++)
            {
                string[] args = Console.ReadLine().Split('-');
                string itemName = args[0];
                decimal price = decimal.Parse(args[1]);

                if (!shopList.ContainsKey(itemName))
                {
                    shopList.Add(itemName, price);
                }
                else
                {
                    shopList[itemName] = price;
                }

                
            }

            return shopList;
        }
        public static List<Customer> TakeOrders(Dictionary<string,decimal> shopItems)
        {
            var customers = new List<Customer>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of clients")
                {
                    break;
                }
                Customer customer = new Customer();
                string[] args = input.Split('-');
                string name = args[0];
                var ItemAndQuantity = args[1].Split(',');
                string itemName = ItemAndQuantity[0];
                int quantity = int.Parse(ItemAndQuantity[1]);
                //Check if the shop have the item
                if (!shopItems.ContainsKey(itemName))
                {
                    continue;
                }

                decimal itemPrice = shopItems[itemName];

                customer.Name = name;

                if (!customer.ShopList.ContainsKey(itemName))
                {
                    customer.ShopList.Add(itemName, quantity);
                }
                else
                {
                    customer.ShopList[itemName] += quantity;
                }

                customer.Bill += itemPrice * quantity;

                customers.Add(customer);
            }

            return customers;
        }
        public static void PrintOrderAndBill(List<Customer> customers)
        {
            foreach (var customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
            }
            Console.WriteLine($"Total bill: {customers.Select(c => c.Bill).Sum():f2}");
        }
    }
}
