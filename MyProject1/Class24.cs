using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
  class Class24
    {
		
		

			// Function for finding and
			// returning sum of digits
			// of a number
			static int sumDig(int n)
			{
				int a = 0;
				while (n > 0)
				{
					a = a + n % 10;
					n = n / 10;
				}

				return a;
			}
            static Boolean isValidIMEI(long n)
			{

				// Converting the number into
				// String for finding length
				String s = n.ToString();
				int len = s.Length;

				if (len != 15)
					return false;

				int sum = 0;
				for (int i = len; i >= 1; i--)
				{
					int d = (int)(n % 10);

					// Doubling every alternate
					// digit
					if (i % 2 == 0)
						d = 2 * d;

					// Finding sum of the digits
					sum += sumDig(d);
					n = n / 10;
				}

				return (sum % 10 == 0);
			}

			// Driver code
			public static void Main()
			{

				// 15 digits cannot be stored in
				// 'int' data type
				long n = 490154203237518L;

				if (isValidIMEI(n))
					Console.Write("Valid IMEI Code");
				else
					Console.Write("Invalid IMEI Code");

			}
		

		
	}
}
