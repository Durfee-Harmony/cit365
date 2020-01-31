using System.IO;

namespace MegaDesk
{
	// Ryan's comment
	public class DeskQuote
	{
// Nathan
		string CustomerName;
		int DaysToComplete;
		Desk desk;
		int BASE_PRICE = 200;

		static string[] getRushOrderPrices()
		{
			var pricesFile = @"rushOrderPrices.txt";
			string[] prices = File.ReadAllLines(pricesFile);
			return prices;
		}

		decimal CalculateQuotePrice()
		{
			decimal deskPrice = (decimal)this.BASE_PRICE;
			decimal surfaceArea = this.desk.Width * this.desk.Depth;
			decimal numberOfDrawers = this.desk.NumberOfDrawers;
			DesktopMaterial material = this.desk.DesktopMaterial;

			if (surfaceArea > 1000M)
			{
				deskPrice += surfaceArea - 1000M;
			}

			deskPrice += numberOfDrawers * 50M;

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

			if (surfaceArea < 1000)
			{
				if (this.DaysToComplete == 3)
				{
					//30
				}
				else if (this.DaysToComplete == 5)
				{
					//40
				}
				else if (this.DaysToComplete == 7)
				{
					//60
				}
			}
			else if (surfaceArea <= 2000)
			{
				if (this.DaysToComplete == 3)
				{
				}
				else if (this.DaysToComplete == 5)
				{
				}
				else if (this.DaysToComplete == 7)
				{
				}
			}
			else
			{
				if (this.DaysToComplete == 3)
				{
				}
				else if (this.DaysToComplete == 5)
				{
				}
				else if (this.DaysToComplete == 7)
				{
				}
			}


		}
	}
}
