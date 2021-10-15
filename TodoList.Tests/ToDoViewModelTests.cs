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
            int expectedSize = 6;
            ToDoListViewModel viewModel = new ToDoListViewModel();

            //act fill obj with values
            viewModel.AddToDoCommand.Execute(null);

            //assert
            Assert.Equal(expectedSize, viewModel.Items.Count);
            Assert.Equal("ToDo Item 7",viewModel.Items.Last().Name);

        }

        [Fact]
        public void MarkAsCompletedCommand_marks_item_as_completed_and_puts_it_at_end()
        {
            //arrange prepare all objs
            ToDoListViewModel viewModel = new ToDoListViewModel();
            int expectedSize = 5;

            //act fill obj with values
            viewModel.MarkAsCompletedCommand.Execute(viewModel.Items.First());


            //assert
            Assert.Equal(expectedSize, viewModel.Items.Count);
            Assert.True(viewModel.Items.Last().Completed);
            Assert.Equal("Sleep", viewModel.Items.Last().Name);

        }

        [Fact]
        public void MarkAsCompletedCommand_marks_item_as_completed_and_changes_progress_bar_value()
        {
            //arrange prepare all objs
            ToDoListViewModel viewModel = new ToDoListViewModel();
            string expectedHeader = "Completed 1/5";
            double expectedProgress = 0.2;

            //act fill obj with values
            viewModel.MarkAsCompletedCommand.Execute(viewModel.Items.First());

            //assert
            Assert.Equal(expectedHeader, viewModel.CompletedHeader);
            Assert.Equal(expectedProgress, viewModel.ExpectedProgress);

        }


        [Fact]
        public void Selected_item_is_null_initially()
        {
            //arrange prepare all objs
            ToDoListViewModel viewModel = new ToDoListViewModel();

            //act fill obj with values
            viewModel.Items.SelectedItem.Execute(null);


            //assert
            Assert.False(expectedName, viewModel.Items.SelectedItem.Name);

        }


        [Fact]
        public void Selected_item_is_got()
        {
            //arrange prepare all objs
            ToDoListViewModel viewModel = new ToDoListViewModel();
            string expectedName = "Sleep";

            //act fill obj with values
            viewModel.Items.SelectedItem.Execute(viewModel.Items.SelectedItem.Name);


            //assert
            Assert.Equal(expectedName, viewModel.Items.SelectedItem.Name);

        }


        /// <summary>
        /// might look back at !!!!!!!!!!!!!
        /// </summary>

        [Fact]
        public void Selected_item_is_set()
        {
            //arrange prepare all objs

            //act fill obj with value
            ToDoListViewModel viewModel = new ToDoListViewModel();

            //assert
            Assert.False(viewModel.SelectedItem);

        }

    }
}
