﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoText.Helpers.Extensions
{
	public static class Common
	{
		public static string ToStringConcat(this List<Input> input)
		{
			return string.Concat(input.Select(p => p.CharToInput));
		}
	}
}
