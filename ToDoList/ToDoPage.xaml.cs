using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ToDoList
{
    
    public partial class ToDoPage : ContentPage
    {
        public ToDoPage()
        {
            InitializeComponent();
            ToDoViewModel toDoViewModel = new ToDoViewModel();
            BindingContext = toDoViewModel;
            toDoViewModel.updateProgressBar += ToDoViewModel_UpdateProgressBar;
        }

        private async ToDoViewModel_UpdateProgressBar(object sender, double e)
        {
            await progressBar.ProgressTo(e, 300, Easing.Linear);
        }
    }
}
