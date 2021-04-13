using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ResponsiPemograman3313
{
	class Program
	{
		static void Main(string[] args)
		{
            Karyawan karyawan1 = new Karyawan("20113313", "Andi", 3000000);
			Karyawan karyawan2 = new Karyawan("20113313", "Andi", 2000000 + 1000000);
			
			Console.WriteLine(Gaji Awal);
			Console.WriteLine("Nim			:{0}", karyawan1.Nim);
			Console.WriteLine("Nama			:{0}", karyawan1.Nama);
			Console.WriteLine("Gaji 		:{0}", karyawan1.Gaji);
			Console.WriteLine();
			Console.WriteLine(Setelah Mendapatkan Bonus);
			Console.WriteLine("Nim			:{0}", karyawan2.Nim);
			Console.WriteLine("Nama			:{0}", karyawan2.Nama);
			Console.WriteLine("Gaji 		:{0}", karyawan2.Gaji);

			Console.Readkey();
		}
	}
	
	public class Karyawan
	{
		public string Nim {get; set;}
		{
			Nim = nim;
		}
		
		public string Nama {get; set;}
		{
			Nama = nama;
		}
		
		public double Gaji {get; set;}
		{
			Gaji = gaji;
		}
	}
        
}
		
			