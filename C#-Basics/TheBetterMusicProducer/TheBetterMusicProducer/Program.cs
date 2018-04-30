using System;

    class Program
    {
        static void Main()
        {
            //1.	The number of albums sold in Europe
            //2.	The price of an album in euro
            //3.	The number of albums sold in North America
            //4.	The price of an album in dollars
            //5.	The number of albums sold in South America
            //6.	Price of an album in pesos
            //7.	The number of concerts during a tour
            //8.	Profit from a single concert in euro

            decimal albumsSoldEurope = decimal.Parse(Console.ReadLine());
            decimal albumPriceEurope = decimal.Parse(Console.ReadLine());

            decimal albumsInNorthAmerica= decimal.Parse(Console.ReadLine());
            decimal albumPriceNorthAmerica = decimal.Parse(Console.ReadLine());

            decimal albumsSoldSouthAmerica = decimal.Parse(Console.ReadLine());
            decimal albumPriceSouthAmerica = decimal.Parse(Console.ReadLine());

            decimal numberConcersts = decimal.Parse(Console.ReadLine());
            decimal profitForOneConcert = decimal.Parse(Console.ReadLine());

            decimal dollar = 1.72m;
            decimal euro = 1.94m;
            decimal pesosInLeva = albumPriceSouthAmerica / 332.74m;


            decimal albumProfitNA = (dollar*albumPriceNorthAmerica) * albumsInNorthAmerica;
            decimal albumProfitSA = albumsSoldSouthAmerica * pesosInLeva;
            decimal albumProfitEU = albumsSoldEurope *(albumPriceEurope * euro);

            decimal albumsProfit = albumProfitEU + albumProfitNA + albumProfitSA;
            albumsProfit = albumsProfit - ((albumsProfit * 35) / 100);
            albumsProfit -= ((albumsProfit * 20) / 100);

            decimal concertProfit = numberConcersts * (profitForOneConcert * euro);
            if (concertProfit> 100000)
            {
                concertProfit-=((concertProfit * 15) / 100);
            }

            if (albumsProfit>concertProfit)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:f2}lv.", albumsProfit);
            }
            else if(concertProfit>=albumsProfit)
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:f2}lv.", concertProfit);
            }
            
                
        }
    }

