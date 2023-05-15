using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_InnerType
{
	public class MusteriAdres
	{
		public string adresTip { get; set; }
		public string Il { get; set; }
		public string Ilce { get; set; }
		public string Adres { get; set; }

		public MusteriAdres()
		{
			Console.WriteLine("Musteri Adres yapıcı metotu çalıştı...");
		}

		public void MusteriAdresTestMetot()
		{
			Console.WriteLine("MusteriAdresTestMetot");
		}
	}
}
