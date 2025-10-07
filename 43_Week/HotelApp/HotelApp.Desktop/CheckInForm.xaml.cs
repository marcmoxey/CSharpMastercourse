﻿using HotelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HotelApp.Desktop
{
    /// <summary>
    /// Interaction logic for CheckInForm.xaml
    /// </summary>
    public partial class CheckInForm : Window
    {
        private BookingFullModel _data = null;
        public CheckInForm()
        {
            InitializeComponent();
        }

        public void PopulateCheckInInfo(BookingFullModel data)
        {
            _data = data;
        }
    }
}
