using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace ToDoList.Model
{
    
    public class DataStorge
    {
        private ObservableCollection<Task> Task;

        public DataStorge()
        {
            Task = new ObservableCollection<Task>();
        }

        public void Add(string nombre)
        {
            Task.Add(new Task { Name = nombre });
        }


        public ObservableCollection<Task> Tasks
        {
            get { return Tasks; }

        }


    }

    
}
