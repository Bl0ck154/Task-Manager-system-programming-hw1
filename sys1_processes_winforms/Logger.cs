using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sys1_processes_winforms
{
	public static class Logger
	{
		public static bool Log(string FilePath, string message)
		{
			string formatted = "L ";
			formatted += DateTime.Now + " " + message;

			using (FileStream fs = new FileStream(FilePath, FileMode.Append))
			{
				using (StreamWriter sr = new StreamWriter(fs, Encoding.Unicode))
				{
					sr.WriteLine(formatted);
				}
			}
			return true;
		}
		public static bool Log(string message)
		{
			return Log($"{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}.log", message);
		}
	}
}
