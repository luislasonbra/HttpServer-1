﻿using System;

namespace DotLiquidCore.NamingConventions
{
	public class CSharpNamingConvention : INamingConvention
	{
		public StringComparer StringComparer
		{
			get { return StringComparer.Ordinal; }
		}

		public string GetMemberName(string name)
		{
			return name;
		}
	}
}