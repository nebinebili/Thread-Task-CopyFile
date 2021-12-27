using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using TaskThread.Command;
using TaskThread.Views;

namespace TaskThread.ViewModels
{
    public class MainViewModel
    {
        public List<string> Text { get; set; } = new List<string>();
        Thread thread;
        MainView mainView;

        public RelayCommand FileFromCommand { get; set; }
        public RelayCommand FileToCommand { get; set; }
        public RelayCommand CopyCommand { get; set; }
        public RelayCommand ResumeCommand { get; set; }
        public RelayCommand SuspendCommand { get; set; }

        public MainViewModel(MainView _mainView)
        {
            mainView = _mainView;

            FileFromCommand = new RelayCommand
                (
                  act => FileFromButtonClick(),
                  pre => true
                );

            FileToCommand = new RelayCommand
               (
                 act => FileToButtonClick(),
                 pre => true
               );

            CopyCommand = new RelayCommand
               (
                 act => CoppyButtonClick(),
                 pre => true
               );

            ResumeCommand = new RelayCommand
               (
                 act => thread?.Resume(),
                 pre => true
               );

            SuspendCommand = new RelayCommand
               (
                 act => thread?.Suspend(),
                 pre => true
               );
        }

        public void FileFromButtonClick()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files|*.*|Text files|*.txt";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == true)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Text.Add(line);
                    }
                   mainView.txb_from.Text = openFileDialog.FileName;
                }

            }
        }


        public void FileToButtonClick()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Default.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == true)
            {
                mainView.txb_to.Text = save.FileName;
            }
        }

        private void CopyProcess()
        {
            string toFile = "";
           mainView.Dispatcher.Invoke(new Action(() =>
            {
                toFile = mainView.txb_to.Text;
            }));

            if (!File.Exists(toFile))
            {
                using (var stream = File.Create(toFile))
                {
                    using (StreamWriter sw = new StreamWriter(stream))
                    {
                        foreach (var item in Text)
                        {
                            Thread.Sleep(1000);
                            mainView.Dispatcher.Invoke(new Action(() =>
                            {
                                mainView.progressbar.Value += 100 / Text.Count;
                            }));

                            sw.WriteLine(item);
                        }
                    }
                }
                mainView.Dispatcher.Invoke(new Action(() =>
                {
                    mainView.progressbar.Value = 100;
                }));
                MessageBox.Show("Copy Success!");
            }

        }

        public void CoppyButtonClick()
        {
            ThreadStart threadStart = new ThreadStart(CopyProcess);
            thread = new Thread(threadStart);
            thread.Start();
        }

    }
}
