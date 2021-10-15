using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDoList
{
    public class ToDoViewModel : BindableObject
    {
        //For testing purposes
        //public string HelloText => "Hello Binding";

        public ObservableCollection<ToDoItem> Items { get; set; }
        public ICommand AddToDoCommand => new Command(() => AddNewToDo());
        public ICommand MarkAsCompletedCommand => new Command<ToDoItem>(MarkAsCompleted);
        public event EventHandler<double> UpdateProgressBar;


        private void MarkAsCompleted(ToDoItem obj)
        {
            obj.Completed = true;
            Items.Remove(obj);
            Items.Add(obj);
            CalculateCompletedHeader();
        }

        private void CalculateCompletedHeader()
        {
            CompletedHeader = $"Completed {Items.Count(y => y.Completed)}/{Items.Count}";
            CompletedProgress = (double)Items.Count(y => y.Completed) / (double)
                Items.Count;
            updateProgressBar?.Invoke(this, CompletedProgress);
            //                          sender, value
        }

        private void AddNewToDo()
        {
            Items.Add(new ToDoItem($"To Do Item{Items.Count+1}"));
        }
        private string PageTitle { get; set; }
        private ToDoItem selectedItem;

        public event EventHandler<double> updateProgressBar;

        public string completedHeader;
        public string CompletedHeader
        {
            get { return completedHeader; }
            set
            {
                completedHeader = value;
                OnPropertyChanged();
            }
        }

        public double completedProgress;
        public double CompletedProgress
        {
            get { return completedProgress; }
            set
            {
                completedProgress = value;
                OnPropertyChanged();
            }
        }


        public ToDoItem SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                PageTitle = value?.Name;
                OnPropertyChanged("PageTitle");
                //it is nullable when using ?
            }
        }

        public ToDoViewModel()
        {

            Items = new ObservableCollection<ToDoItem>(ToDoItem.GetToDoItems());
            CalculateCompletedHeader();
        }
    }

}
