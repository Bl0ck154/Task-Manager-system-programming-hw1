using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sys1_processes_winforms
{
	class Task
	{
		public string Path { get; set; }
		public string Params { get; set; }
		public DateTime? StartTime { get; set; }
		public DateTime? CloseTime { get; set; }
		public override string ToString()
		{
			return $"{Path} -\"{Params}\" -start {StartTime} -close {CloseTime}";
		}
	}
}
