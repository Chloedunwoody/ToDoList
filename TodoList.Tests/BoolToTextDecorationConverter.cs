using System;
using Xunit;
using ToDoList;

namespace TodoList.Tests
{
    public class BoolToTextDecorationConverter
    {
        [Fact]
        public void Convert_returns_strikethrough_when_item_is_completed()
        {
            //arrange prepare all objs
            var converter = new ToDoList.BoolToTextDecorationConverter();

            //act fill obj with values
            var result = converter.Convert(true, null, null, null, null);

            //assert
            Assert.Equal(TextDecorations.Strikethrough, (TextDecorations)result);
        }


        [Fact]
        public void Convert_returns_none_when_item_is_not_completeed()
        {
            //arrange prepare all objs
            var converter = new ToDoList.BoolToTextDecorationConverter();

            //act fill obj with values
            var result = converter.Convert(false, null, null, null, null);

            //assert
            Assert.Equal(TextDecorations.None, (TextDecorations)result);
        }


    }
}
