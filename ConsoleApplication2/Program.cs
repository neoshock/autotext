﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication2
{


	class Program
	{
		[DllImport("user32.dll")]
		public static extern int ToUnicode(
			uint virtualKeyCode,
			uint scanCode,
			byte[] keyboardState,
			[Out, MarshalAs(UnmanagedType.LPWStr, SizeConst = 64)]
			StringBuilder receivingBuffer,
			int bufferSize, uint flags);


		static string GetCharsFromKeys(Keys keys, bool shift, bool altGr)
		{
			var buf = new StringBuilder(256);
			var keyboardState = new byte[256];
			if (shift)
				keyboardState[(int)Keys.ShiftKey] = 0xff;
			if (altGr)
			{
				keyboardState[(int)Keys.ControlKey] = 0xff;
				keyboardState[(int)Keys.Menu] = 0xff;
			}

			ToUnicode((uint)keys, 0, keyboardState, buf, 256, 0);
			return buf.ToString();
		}



		static void Main(string[] args)
		{
			Console.WriteLine(GetCharsFromKeys(Keys.E, false, false));    // prints e
			Console.WriteLine(GetCharsFromKeys(Keys.E, true, false));     // prints E

			// Assuming British keyboard layout:
			Console.WriteLine(GetCharsFromKeys(Keys.E, false, true));     // prints é
			Console.WriteLine(GetCharsFromKeys(Keys.E, true, true));      // prints É

			Console.Read();
		}
	}
}
