﻿using HospitalSystem.Views;
using HospitalSystem.DataAccess.DataAccessControllers;

namespace HospitalSystem.DataControllers
{
    public class DataGetController
    {
        public int GetLoginSelection()
        {
            OptionsProvider options = new OptionsProvider();
            options.PrintStartingOptions();
            int userSelection = GetUserSelection();
            Console.Clear();
            return userSelection;
        }

        protected int GetUserSelection()
        {
            string providedData = Console.ReadLine();
            int userSelection;

            while(!Int32.TryParse(providedData, out userSelection))
            {
                Console.WriteLine("Please provide correct data :");
                providedData = Console.ReadLine();
            }

            Console.Clear();
            return userSelection;
        }
        protected int GetID(string message)
        {
            Console.WriteLine(message);
            string ID = Console.ReadLine();
            while (!Int32.TryParse(ID, out int n))
            {
                Console.WriteLine("ID must be number");
                ID = Console.ReadLine();
            }
            Console.Clear();
            return Int32.Parse(ID);
        }

        protected int GetHospitalID()
        {

            var hospitalProvider = new HospitalsDataProvider();
            int HospitalID = GetID("Provide Hospital ID where doctor Work");
            var hospitals = hospitalProvider.GetHospitals();

            while (hospitals.Any(hospital => hospital.HospitalID == HospitalID))
            {
                HospitalID = GetID($"You already have hospital with {HospitalID} ID");
            }

            return HospitalID;
        }

    }
}