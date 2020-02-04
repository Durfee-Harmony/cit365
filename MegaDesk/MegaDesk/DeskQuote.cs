using System.IO;

namespace MegaDesk
{
	public class DeskQuote
	{
		public string CustomerName { get; set; }
		public int DaysToComplete {get; set;}
		public Desk Desk {get; set;}
		public decimal FinalPrice { get; set; }
		public static int[] PRICES {get; set;}
		public int BASE_PRICE = 200;

		public void getRushOrderPrices()
		{
			int i = 0;
			StreamReader reader = new StreamReader("prices.txt");
			while (reader.EndOfStream == false)
			{
				int number = int.Parse(reader.ReadLine());
				DeskQuote.PRICES[i++] = number;
			}
			reader.Close();			
		}

		public void CalculateQuotePrice()
		{
			decimal deskPrice = (decimal)this.BASE_PRICE;
			decimal surfaceArea = this.Desk.Width * this.Desk.Depth;
			decimal numberOfDrawers = this.Desk.NumberOfDrawers;
			DesktopMaterial material = this.Desk.DesktopMaterial;
			this.getRushOrderPrices();

			deskPrice += numberOfDrawers * 50M;

			if (surfaceArea > 1000M)
			{
				deskPrice += surfaceArea - 1000M;
			}

			if (material.Equals(1))
			{
				deskPrice += 200M;
			}
			else if (material.Equals(2))
			{
				deskPrice += 100M;
			}
			else if (material.Equals(3))
			{
				deskPrice += 50M;
			}
			else if (material.Equals(4))
			{
				deskPrice += 300M;
			}
			else if (material.Equals(5))
			{
				deskPrice += 125M;
			}

			if (DaysToComplete == 3)
			{
				if (surfaceArea < 1000)
				{
					deskPrice += PRICES[0];
				} else if (surfaceArea <= 2000)
				{
					deskPrice += PRICES[1];
				}
				else
				{
					deskPrice += PRICES[2];
				}
			} else if (DaysToComplete == 5)
			{
				if (surfaceArea < 1000)
				{
					deskPrice += PRICES[3];
				}
				else if (surfaceArea <= 2000)
				{
					deskPrice += PRICES[4];
				}
				else
				{
					deskPrice += PRICES[5];
				}
			} else if (DaysToComplete == 7)
			{
				if (surfaceArea < 1000)
				{
					deskPrice += PRICES[6];
				}
				else if (surfaceArea <= 2000)
				{
					deskPrice += PRICES[7];
				}
				else
				{
					deskPrice += PRICES[8];
				}
			}
			this.FinalPrice = deskPrice;
		}
	}
}
