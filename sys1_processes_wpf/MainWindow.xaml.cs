using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sys1_processes_wpf
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		private IEnumerable<object> processes { get; set; }
		public MainWindow()
		{
			InitializeComponent();
			TimerCallback timerCallback = new TimerCallback(ko);
			Timer timer = new Timer(timerCallback);
			timer.Change(1000, 1000);
			dataGrid.DataContext = this;
		}

		private void ko(object state)
		{
			Processes = Process.GetProcesses()
				.Select(p => new {
					p.Id,
					p.ProcessName,
					p.MainWindowTitle,
					Memory = $"{p.PagedMemorySize64 / 1024 / 1024} MB",
					StartTime = !string.IsNullOrWhiteSpace(p.MainWindowTitle) ? p.StartTime.ToShortTimeString() : ""
				})
					.OrderBy(p => p.Id);
			dataGrid.ItemsSource = Processes;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public IEnumerable<object> Processes
		{
			get { return processes; }
			set { processes = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Processes")); }
		}


	}
}
