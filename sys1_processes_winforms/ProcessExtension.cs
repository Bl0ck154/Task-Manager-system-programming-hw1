using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sys1_processes_winforms
{
	public static class ProcessExtension
	{
		public static string getProcessStartTime(this Process process)
		{
			string time = "";
			try
			{
				time = process.StartTime.ToShortTimeString();
			}
			catch (Exception ex) { }
			return time;
		}
		public static string getProcessDescription(this Process process)
		{
			string desc = "";
			try
			{
				desc = process.MainModule.FileVersionInfo.FileDescription.ToString();
			}
			catch (Exception ex) { }
			return desc;
		}
		public static string getProcessPath(this Process process)
		{
			string path = "";
			try
			{
				path = process.MainModule.FileName.ToString();
			}
			catch (Exception ex) { }
			return path;
		}
		public static Process getProcessByPath(string path)
		{
			foreach (Process item in Process.GetProcessesByName(Path.GetFileNameWithoutExtension(path)))
			{
				if (item.MainModule.FileName == path)
					return item;
			}
			return null;
		}
	}
}
