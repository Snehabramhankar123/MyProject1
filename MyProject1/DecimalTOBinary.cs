using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
	class Binary
	{
		 public bool BinaryNumber(int binary)
		{
			bool status = true;
			while (true)
			{
				if (binary == 0)
				{
					break;
				}
				else
				{
					int tmp = binary % 10;
					if (tmp > 1)
					{
						status = false;
						break;
					}
					binary = binary / 10;
				}
			}
			return status;
		}
		public static void Main(String[] args)
		{
			Binary ab = new Binary();

			Console.WriteLine(ab.BinaryNumber(1111));
		}
	}
}


	

			
		
	




