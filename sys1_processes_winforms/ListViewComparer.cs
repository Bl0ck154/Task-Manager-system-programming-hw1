using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sys1_processes_winforms
{
	class ListViewItemComparer : IComparer
	{
		private int col;
		private SortOrder order;
		public ListViewItemComparer()
		{
			col = 0;
		}
		public ListViewItemComparer(int column, SortOrder order)
		{
			col = column;
			this.order = order;
		}
		/*
		 * default comparer
		 * 
		public int Compare(object x, object y) 
		{
			int returnVal = -1;

			returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
									((ListViewItem)y).SubItems[col].Text);
			
			if (order == SortOrder.Descending)
				returnVal *= -1;

			return returnVal;
		}
		*/
		public int Compare(object x, object y) // only for my task list
		{
			int returnVal = -1;

			if(col == 0 || col == 3) 
			{
				int? num1, num2;
				num1 = StrToNum(((ListViewItem)x).SubItems[col].Text);
				num2 = StrToNum(((ListViewItem)y).SubItems[col].Text);
				returnVal = num1.Value.CompareTo(num2);
			}
			else
				returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
									((ListViewItem)y).SubItems[col].Text);
			
			if (order == SortOrder.Descending)
				returnVal *= -1;

			return returnVal;
		}
		int? StrToNum(string str)
		{
			string num = "";
			foreach (char c in str)
			{
				if (c >= '0' && c <= '9')
					num += c;
			}
			return num == "" ? (int?)null : Int32.Parse(num);
		}
	}
}
