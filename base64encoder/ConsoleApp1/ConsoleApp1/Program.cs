using System;
using System.Text;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string wpis;
			wpis = Console.ReadLine();

			byte[] bity = System.Text.Encoding.Default.GetBytes(wpis); 
			char[] wynik2 = Kodowanie(bity);
			Console.WriteLine(wynik2);
		}
		public static char[] Kodowanie(byte[] bity)
		{
			int dl, dl2;
			int pozostale;
			int reszta;

			dl = bity.Length;

			if ((dl % 3) == 0)
			{
				reszta = 0;
				pozostale = dl / 3;
			}
			else
			{
				reszta = 3 - (dl % 3);
				pozostale = (dl + reszta) / 3;
			}

			dl2 = dl + reszta;

			byte[] bity2;
			bity2 = new byte[dl2];

			for (int x = 0; x < dl2; x++)
			{
				if (x < dl)
				{
					bity2[x] = bity[x];
				}
				else
				{
					bity2[x] = 0;
				}
			}

			byte b1, b2, b3;
			byte t, t1, t2, t3, t4;
			byte[] kodowanko = new byte[pozostale * 4];
			char[] wynik = new char[pozostale * 4];

			for (int x = 0; x < pozostale; x++)
			{
				b1 = bity2[x * 3];
				b2 = bity2[x * 3 + 1];
				b3 = bity2[x * 3 + 2];

				t1 = (byte)((b1 & 252) >> 2);

				t = (byte)((b1 & 3) << 4);
				t2 = (byte)((b2 & 240) >> 4);
				t2 += t;

				t = (byte)((b2 & 15) << 2);
				t3 = (byte)((b3 & 192) >> 6);
				t3 += t;

				t4 = (byte)(b3 & 63);

				kodowanko[x * 4] = t1;
				kodowanko[x * 4 + 1] = t2;
				kodowanko[x * 4 + 2] = t3;
				kodowanko[x * 4 + 3] = t4;

			}

			for (int x = 0; x < pozostale * 4; x++)
			{
				wynik[x] = DoChar(kodowanko[x]);
			}

			switch (reszta)
			{
				case 0:
					break;
				case 1:
					wynik[pozostale * 4 - 1] = '=';
					break;
				case 2:
					wynik[pozostale * 4 - 1] = '=';
					wynik[pozostale * 4 - 2] = '=';
					break;
				default:
					break;
			}

			return wynik;
		}

		private static char DoChar(byte b)
		{
			char[] tabelka = new char[64] {
		'A','B','C','D','E','F','G','H','I','J','K','L','M',
		'N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
		'a','b','c','d','e','f','g','h','i','j','k','l','m',
		'n','o','p','q','r','s','t','u','v','w','x','y','z',
		'0','1','2','3','4','5','6','7','8','9','+','/'
	};

			if ((b >= 0) && (b <= 63))
			{
				return tabelka[(int)b];
			}
			else
			{
				return ' ';
			}
		}
	}
}
