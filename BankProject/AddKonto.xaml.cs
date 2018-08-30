﻿using BankProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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

namespace BankProject
{
    /// <summary>
    /// Interaction logic for AddKonto.xaml
    /// </summary>
    public partial class AddKonto : Window
    {
        public AddKonto()
        {
            InitializeComponent();
        }

        private void kontobtn_opret_Click(object sender, RoutedEventArgs e)
        {
            if (txt_kundecpr.Text != "" && txt_saldo.Text != "" && txt_rente.Text != "" && txt_konto.Text != "" && txt_dato.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Udfyld alle felter!!");
            }
        }

        private void btnkonto_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void header_addkonto_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
    }
}
