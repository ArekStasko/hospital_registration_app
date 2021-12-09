﻿using System;
using HospitalRegistrationApp.Views;

namespace HospitalRegistrationApp.DataControllers
{
    public class DataGetController
    {
        protected int GetUserSelection()
        {
            string providedData = Console.ReadLine();
            int userSelection;

            while(!Int32.TryParse(providedData, out userSelection))
            {
                Console.WriteLine("Please provide correct data :");
                providedData = Console.ReadLine();
            }

            return userSelection;
        }

        public int GetLoginSelection()
        {
            OptionsProvider options = new OptionsProvider();
            options.PrintStartingOptions();
            int userSelection = GetUserSelection();
            Console.Clear();
            return userSelection;
        }
    }
}