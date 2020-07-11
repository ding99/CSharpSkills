using System;
using System.Text;

namespace Starter
{
	public class Monitor
	{
		public void Start(Menu menu) {
			while (true)
			{
				Console.WriteLine("== Euler Problems Main Menu ==");

				int number = 1;
				foreach (var page in menu.Pages)
					Console.WriteLine(new StringBuilder((number++).ToString()).Append(". ").Append(page.Title).ToString());

				Console.WriteLine(new StringBuilder(number.ToString()).Append(". Exit").ToString());

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
				Console.WriteLine(new StringBuilder("-- ").Append(page.Title).Append(" --").ToString());
				int number = 1;
				foreach (var problem in page.Problems) {
					var builder = new StringBuilder((number++).ToString()).Append(". ").Append(problem.Description);
					if (!string.IsNullOrWhiteSpace(problem.Comment))
						builder.Append(" (").Append(problem.Comment).Append(")");
					Console.WriteLine(builder.ToString());
				}
				Console.WriteLine(new StringBuilder(number.ToString()).Append(". Exit").ToString());

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
			Console.WriteLine(p.Description);
			Console.WriteLine("Calculating...");

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
