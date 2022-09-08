﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace UserInterfaceApp
{

    class EmployeeDetailViewModel : INotifyPropertyChanged
    {
        private Employee _employee;
        public Employee Employee
        {
            get { return _employee; }
            set { _employee = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
