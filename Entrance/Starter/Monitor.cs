using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter
{
	public class Monitor
	{
		public void Start(Menu menu) {
			while (true)
			{
				int number = 1;
				foreach (var page in menu.Pages)
					Console.WriteLine(number++ + ". " + page.Title);

				Console.WriteLine(number + ". Exit");

				while (true)
				{
					string read = Console.ReadLine();

					if (int.TryParse(read, out number) && number > 0)
					{
						if (number == menu.Pages.Count + 1)
							return;

						if (number <= menu.Pages.Count)
						{
							StartPage(menu.Pages[number - 1]);
							break;
						}
					}
				}
			}
		}

		public void StartPage(Page page)
		{
			while (true)
			{
				int number = 1;
				foreach (var problem in page.Problems)
					Console.WriteLine(number++ + ". " + problem.Description);
				Console.WriteLine(number + ". Exit");

				while (true)
				{
					string read = Console.ReadLine();

					if (int.TryParse(read, out number) && number > 0)
					{
						if (number == page.Problems.Count + 1)
							return;

						if (number <= page.Problems.Count)
						{
							Calculation(page.Problems[number - 1]);
							break;
						}
					}
				}
			}
		}

		private void Calculation(Problem p)
		{
			Console.WriteLine("Calculating..." + Environment.NewLine);
			Console.WriteLine(p.Description);
			try
			{
				p.Type.GetMethod(p.Method).Invoke(Activator.CreateInstance(p.Type), null);
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
