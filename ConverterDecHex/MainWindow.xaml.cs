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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConverterDecHex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ConverterHex converterHex = new ConverterHex();

        private void DecNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            HexNumber.Text = "HEX_DEC: " + converterHex.TranslateData(DecNumber.Text) + " \n" + "HEX_HEX: " + converterHex.TranslateDataCodeANSII(DecNumber.Text);
        }
    }
}
