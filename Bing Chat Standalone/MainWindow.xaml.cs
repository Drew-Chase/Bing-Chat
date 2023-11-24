// LFInteractive LLC. 2021-2024
﻿using System.Text;
using System.Windows;

namespace Bing_Chat_Standalone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            browser.Source = new System.Uri("https://www.bing.com/chat");
        }
    }
}