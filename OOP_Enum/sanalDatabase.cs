﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Enum
{
	public class sanalDatabase
	{
		ArrayList sanalDB = new ArrayList();

		public musteriReturnValue musteriYeniKayit(Musteri M)
		{

			// parametre kontrol 

			// kayıt kontrol 

			sanalDB.Add(M);
			return musteriReturnValue.kayitBasarili;
		}
	}
}
