using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.UI
{
	public static class StringExtenctions
	{
		public static string ExtractOnlyText(this string text)
		{
			string result = string.Empty;
			foreach(var character in text)
			{
				if (char.IsDigit(character))
				{
					continue;
				}
				result += character;
			}

			return result;
		}
	}
}
