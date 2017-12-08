﻿using System;
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
using System.Text.RegularExpressions;

namespace MailClient
{
    /// <summary>
    /// NewUser.xaml 的交互逻辑
    /// </summary>
    public partial class NewUser : Window
    {
        static string MailRegex = @"(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$)";

        public UserInfo UserInfo { get; set; }

        public NewUser()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(UserEmail.Text, MailRegex))
            {
                UserEmail.Background = Brushes.White;
            }
            else
            {
                UserEmail.Background = Brushes.LightCoral;
            }
        }
    }
}