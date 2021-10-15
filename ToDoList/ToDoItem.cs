using System;
using System.Collections.Generic;

namespace ToDoList
{
    public class ToDoItem
    {
        public string Name { get; set; }
        public bool Completed { get; set; }

        public ToDoItem(string name)
        {
            Name = name;
        }

        public static IEnumerable<ToDoItem> GetToDoItems()
        {
            return new List<ToDoItem>
            {
                new ToDoItem("Sleep"),
                new ToDoItem("Nail Appointment"),
                new ToDoItem("Hair"),
                new ToDoItem("Walk Dog"),
                new ToDoItem("Sleep"),
                new ToDoItem("Go To Gym")
            };
        }
    }
}
