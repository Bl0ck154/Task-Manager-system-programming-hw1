using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sys1_processes_winforms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			listView1.Columns.Add("Id", -2);
			listView1.Columns.Add("Name", -2);
			listView1.Columns.Add("Title", -1);
			listView1.Columns.Add("Memory", -2);
			listView1.Columns.Add("Start time", -2);
			listView1.Columns.Add("Path", -2);
			listView1.FullRowSelect = true;
			listView1.ColumnClick += ListView1_ColumnClick;		

			fill();

			//TimerCallback timerCallback = new TimerCallback(updateFunc);
			//System.Threading.Timer timer = new System.Threading.Timer(timerCallback);
			//timer.Change(1000, 1000);
		}

		private int sortColumn = -1;

		private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column != sortColumn)
			{
				sortColumn = e.Column;
				listView1.Sorting = SortOrder.Ascending;
			}
			else
			{
				listView1.Sorting = listView1.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
			}
			
			listView1.Sort();
			listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, listView1.Sorting);

		}

		//private void updateFunc(object state)
		//{
		//	listView1.Invoke(new Action(() => { listView1.Clear(); fill(); }));
		//	//fill();
		//	//foreach (var item in getProcessesStringArray())
		//	//{
		//	//	listView1.FindItemWithText(item[0], true, 0);
		//	//}
		//}

		void fill()
		{
			ImageList imageList = new ImageList();
			listView1.SmallImageList = imageList;
			string filePath;
			foreach (var item in Process.GetProcesses())
			{
				try { filePath = item.MainModule.FileName; }
				catch (Exception e) { continue; }
				imageList.Images.Add(item.ProcessName, Icon.ExtractAssociatedIcon(filePath));
			}
		
			foreach (var item in getProcessesStringArray())
			{
				listView1.Items.Add(new ListViewItem(item, item[1]));
			}
		}
		IEnumerable<string[]> getProcessesStringArray()
		{
			return Process.GetProcesses()
				.Select(p => new[] {
					p.Id.ToString(),
					p.ProcessName,
					p.MainWindowTitle,
					$"{p.PagedMemorySize64 / 1024 / 1024} MB",
					processStartTime(p),
					p.StartInfo.FileName
				})
					.OrderBy(p => Convert.ToInt32(p[0]));
		}
		string processStartTime(Process process)
		{
			string time = "";
			try
			{
				time = process.StartTime.ToShortTimeString();
			}
			catch(Exception ex)
			{

			}
			return time;
		}
	}
}
