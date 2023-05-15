﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract
{
	public abstract class temelSinif
	{
		public DateTime kayitTarih { get; set; }
		public DateTime guncellemeTarih { get; set; }

		public temelSinif()
		{
			kayitTarih = DateTime.Now;
			guncellemeTarih = DateTime.Now;
		}

		public void test()
		{
			Console.WriteLine("temel sınıf => test");
		}

		public abstract void testAbstract(); // metot imzası 
											 //{
											 //}
	}
}
