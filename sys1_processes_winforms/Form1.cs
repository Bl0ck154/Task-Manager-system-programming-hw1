using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sys1_processes_winforms
{
	public partial class Form1 : Form
	{
		private int sortColumn = -1; // для сортировки колонок
		System.Threading.Timer taskListTimer; // таймер обновления списка процессов
		BindingList<Task> TaskList; // для хранения задач

		public Form1()
		{
			InitializeComponent();
			CenterToScreen();

			// добавляю колонки в listview
			listView1.Columns.Add("Id", -2);
			listView1.Columns.Add("Name", -2);
			listView1.Columns.Add("Description", 500);
			listView1.Columns.Add("Memory", -2);
			listView1.Columns.Add("Start time", -2);
			listView1.FullRowSelect = true; // возможность выделить всю строку в листе
			listView1.ColumnClick += ListView1_ColumnClick; // для сортировки
			listView1.ContextMenuStrip = contextMenuStripForList;

			fill(); // заполняю listview

			this.FormClosing += Form1_FormClosing; // сворачивание в трей

			// контекстное меню иконки в трее
			ContextMenu contextMenuStrip = new ContextMenu();
			contextMenuStrip.MenuItems.Add(new MenuItem("Exit", new EventHandler(close)));
			notifyIcon1.ContextMenu = contextMenuStrip;

			// таймер обновления списка процессов
			taskListTimer = new System.Threading.Timer(new TimerCallback(updateFunc));
			taskListTimer.Change(2000, 2000);

			// таймер проверки задач
			TaskList = new BindingList<Task>();
			System.Threading.Timer taskTimer = new System.Threading.Timer(new TimerCallback(checkTaskList));
			taskTimer.Change(1000, 1000);

			// отображение созданных задач
			dataGridView1.DataSource = TaskList;
			dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (WindowState != FormWindowState.Minimized && TaskList.Count > 0)
			{
				e.Cancel = true;
				Hide();
				this.WindowState = FormWindowState.Minimized;
			}
		}

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

			// TODO при сортировке некорректно работает обновление
			listView1.Sort();
			listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, listView1.Sorting);
			offToolStripMenuItem.PerformClick();
		}
		private void updateFunc(object state)
		{
			Thread thread = new Thread(new ThreadStart(updateTest));
			thread.Start();
			//listView1.Invoke(new Action(() => { checkForUpdates(listView1); }));
			//listView1.Invoke(new Action(() => { listView1.Items.Clear(); fill(listView1); }));
			//	listView1.Invoke(new Action(() => { listView1.Clear(); fill(); }));
			//	//fill();
			//foreach (var item in getProcessesStringArray())
			//{
			//	listView1.FindItemWithText(item[0], true, 0);
			//}
		}
		void updateTest()
		{
			try
			{
				listView1.Invoke(new Action(() => { checkForUpdates(listView1); }));
			}
			catch (Exception ex) { }
		}
		void checkForUpdates(ListView listView)
		{
			ListViewItem listViewItem; // для хранения найденной строки в listView
			string filePath; // для хранения пути файла процесса
			List<string> findedIndexes = new List<string>(); // для индексов найденных строк
			int procCount, threadsCount; // кол-во процессов, кол-во потоков

			foreach (var item in getProcessesStringArray(out procCount, out threadsCount))
			{
				listViewItem = listView1.FindItemWithText(item[0]); // ищем строку по item[0] - id процесса
				
				if(listViewItem == null) // если не найден id, значит - процесс новый
				{
					// добавляем в список // не добавляется
					listView.Items.Add(new ListViewItem(item, item[1]));
					findedIndexes.Add(item[0]);
					try
					{
						filePath = Process.GetProcessById(Convert.ToInt32(item[0])).MainModule.FileName;
						listView.SmallImageList.Images.Add(item[1], Icon.ExtractAssociatedIcon(filePath));
					}
					catch (Exception ex) { continue; }
				}
				else
				{
					findedIndexes.Add(listViewItem.SubItems[0].Text);
					// проверяем колонки и обновляем в случае несовпадения данных
					// 0 - id, 1 - name, 2 - title, 3 - memory, 4 - startTime. Из них только 2 и 3 могут измениться
					for (int i = 2; i <= 3; i++)
					{
						if (listViewItem.SubItems[i].Text != item[i])
							listViewItem.SubItems[i].Text = item[i];
					}
				}
			}

			// обновление статус бара
			procCountLabel.Text = procCount.ToString();
			threadsCountLabel.Text = threadsCount.ToString();

			// проверяем какие id не были найдены и удаляем их
			foreach (ListViewItem item in listView.Items)
			{
				if (!findedIndexes.Contains(item.SubItems[0].Text))
					item.Remove();
			}
		}

		void fill()
		{
			// иконки процессов
			ImageList imageList = new ImageList();
			string filePath;
			foreach (var item in Process.GetProcesses())
			{
				try
				{
					filePath = item.MainModule.FileName;
					imageList.Images.Add(item.ProcessName, Icon.ExtractAssociatedIcon(filePath));
				}
				catch (Exception ex) { continue; }
			}
			listView1.SmallImageList = imageList;

			// заполнение списка
			int procCount, threadsCount;
			foreach (var item in getProcessesStringArray(out procCount, out threadsCount))
			{
				listView1.Items.Add(new ListViewItem(item, item[1]));
			}
			// статус бар
			procCountLabel.Text = procCount.ToString();
			threadsCountLabel.Text = threadsCount.ToString();
		}
		IEnumerable<string[]> getProcessesStringArray(out int count, out int threadsCount)
		{
			Process[] processes = Process.GetProcesses();
			count = processes.Count();
			threadsCount = processes.Sum(p => p.Threads.Count);
			return processes
				.Select(p => new[] {
					p.Id.ToString(),
					p.ProcessName,
					p.getProcessDescription(),
					$"{p.PagedMemorySize64 / 1024} KB",
					p.getProcessStartTime(),
					p.getProcessPath()
				})
					.OrderBy(p => Convert.ToInt32(p[0]));
		}

		// кнопка выбрать файл приложения
		private void buttonSelectFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Exe Files|*.exe|All Files (*.*)|*.*";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
				textBoxFilePath.Text = openFileDialog.FileName;

			dateTimePickerStart.Checked = true;
		}

		// кнопка Старт таймера 
		private void buttonStart_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxFilePath.Text) )
				return;

			if (!File.Exists(textBoxFilePath.Text)) // проверка на существование файла
				return;

			if (!dateTimePickerStart.Checked && !dateTimePickerExit.Checked) // поверка на заполненость полей времени
				return;

			// создание задачи по введенным параметрам
			Task task = new Task()
			{
				StartTime = dateTimePickerStart.Checked ? dateTimePickerStart.Value : (DateTime?)null,
				CloseTime = dateTimePickerExit.Checked ? dateTimePickerExit.Value : (DateTime?)null,
				Path = textBoxFilePath.Text,
				Params = textBoxParams.Text
			};
			TaskList.Add(task);
			Logger.Log($"Added task: {task}");

			// иконка в трее
			notifyIcon1.Visible = true;
			notifyIcon1.BalloonTipText = $"{textBoxFilePath.Text} will be " +
				 (dateTimePickerStart.Checked ? $"started at {dateTimePickerStart.Value}" :
				 $"finished at {dateTimePickerExit.Value}");
			
			notifyIcon1.ShowBalloonTip(2500);

//			timerInfoLabel.Text = $"Your program will be started after {dateTimePickerStart.Value-DateTime.Now}";
		}

		// запуск приложения, ф-я для таймера
		void checkTaskList(object obj)
		{
			// ежесекундное обновление времени в поле ввода
			bool prevState; // обновление времени ставит checkbox в положение checked, с помощью переменной возвращаю исходное положение
			if (dateTimePickerStart.Value <= DateTime.Now)
			{
				dateTimePickerStart.Invoke(new Action(() =>
				{
				// Focused проверяет чтобы обновление времени производилось только когда пользователь не сфокусирован на вводе
					if (!dateTimePickerStart.Focused)
					{
						prevState = dateTimePickerStart.Checked;
						dateTimePickerStart.Value = DateTime.Now;
						dateTimePickerStart.Checked = prevState;
					}
				}));
			}
			if (dateTimePickerExit.Value <= DateTime.Now)
			{
				dateTimePickerExit.Invoke(new Action(() =>
				{
					if (!dateTimePickerExit.Focused)
					{
						prevState = dateTimePickerExit.Checked;
						dateTimePickerExit.Value = DateTime.Now;
						dateTimePickerExit.Checked = prevState;
					}
				}));
			}

			try
			{
				foreach (Task item in TaskList.ToArray())
				{
					DateTime currentTime = DateTime.Now;
					if (item.StartTime <= currentTime)
					{
						notifyIcon1.BalloonTipText = $"Process {Process.Start(item.Path, item.Params).ProcessName} is starting...";
						notifyIcon1.ShowBalloonTip(2500);
						Logger.Log(notifyIcon1.BalloonTipText);
					}
					else if (item.CloseTime <= currentTime)
					{
						Process proc = ProcessExtension.getProcessByPath(item.Path);
						notifyIcon1.BalloonTipText = $"Process {proc.ProcessName} is closing...";
						Logger.Log(notifyIcon1.BalloonTipText);
						proc.CloseMainWindow();
						proc.Close();
						//proc.Kill();
						notifyIcon1.ShowBalloonTip(2500);
					}
					else continue;

					dataGridView1.Invoke(new Action(() => TaskList.Remove(item)));
				}
			}
			catch(Exception ex)
			{
				Logger.Log(ex.Message);
			}

	//		if (TaskList.Count <= 0)
	//			notifyIcon1.Visible = false;
		}

		// открытие главного окна по двойному клику иконки в трее
		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Show();
			this.WindowState = FormWindowState.Normal;
			notifyIcon1.Visible = TaskList.Count > 0 ? true : false;
		}
		
		// ф-я закрытия приложения для контекстного меню иконки в трее
		void close(object sender, EventArgs e)
		{
			Close();
		}

		// кнопка ручного обновления
		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			listView1.Items.Clear();
			fill();
			Cursor.Current = Cursors.Default;
		}

		// завершение выбранного процесса по времени
		private void completionByTimeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count <= 0)
				return;

			// 5 - скрытая колонка пути файла процесса
			if (string.IsNullOrWhiteSpace(listView1.SelectedItems[0].SubItems[5].Text))
			{
				// если пусто, значит процесс защищен
				MessageBox.Show("Secure process!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			textBoxFilePath.Text = listView1.SelectedItems[0].SubItems[5].Text;
			tabControl1.SelectedIndex = 1; // переключить вкладку
			dateTimePickerExit.Checked = true;
		}

		// выбор времени обновления в статус баре
		private void offToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = (sender as ToolStripItem).Text;
			updatePerControl.Text = $"Update: {text}";
			if (text == "Off")
				taskListTimer.Change(Timeout.Infinite, Timeout.Infinite);
			else
			{
				int time = Int32.Parse(text.Remove(text.Length - 1));
				taskListTimer.Change(time * 1000, time * 1000);
			}
		}
	}
}
