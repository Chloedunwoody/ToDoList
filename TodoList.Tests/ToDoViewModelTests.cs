using System;
using Xunit;

namespace TodoList.Tests
{
    public class ToDoViewModelTests
    {
        [Fact]
        public void ViewModel_polulate_items_correctly()
        {
            //arrange prepare all objs
            int expectedSize = 6;

            //act fill obj with values
            ToDoListViewModel viewModel = new ToDoListViewModel();

            //assert
            Assert.Equal(expectedSize, viewModel.Items.Count);
        }

        [Fact]
        public void Add_item_command_adds_new_item_to_list_sucessfully()
        {
            //arrange prepare all objs
            int expectedSize = 7;
            ToDoListViewModel viewModel = new ToDoListViewModel();

            //act fill obj with values
            viewModel.AddToDoCommand.Execute(null);

            //assert
            Assert.Equal(expectedSize, viewModel.Items.Count);
        }

    }
}
