﻿// <copyright file="MainWindow.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HappyTourManager
{
    using System;
    using System.Collections.Generic;
    using System.IO;
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
    //using HappyTourManager.VM;
    //using Helper;
    using DATA;
    using DATA.Repositories;
    using DATA.Interfaces;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// a főmenü page-t indítja
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
            //Menu page1 = new Menu(this.mainFrame);
            //this.mainFrame.Content = page1;
            PlaceRepository repo = new PlaceRepository();
            
            repo.Create(new Place()
            {
                Country = "Hungary",
                City = "Sopron"
            });
            IQueryable<Place> list = repo.GetAll();
            foreach (Place item in list)
            {
                Console.WriteLine(item.PlaceID + " "+ item.Country + " " + item.City);
            }

            Console.Read();
        }
    }
}
