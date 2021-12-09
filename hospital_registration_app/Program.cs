﻿using System;
using HospitalRegistrationApp.DataControllers;
using HospitalRegistrationApp.DataControllers.AdminControllers;
using HospitalRegistrationApp.DataControllers.PatientControllers;
using HospitalRegistrationApp.DataControllers.DoctorControllers;

namespace HospitalRegistrationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGetController getDataController = new DataGetController();
            int selectedOption = getDataController.GetLoginSelection();

            // For now doctor and patient Controllers is empty

            if (selectedOption == 1)
            {
                PatientController patientController = new PatientController();
                patientController.PatientTestInfo();
            }
            else if (selectedOption == 2)
            {
                DoctorController doctorController = new DoctorController();
                doctorController.DoctorTestInfo();
            }
            else if (selectedOption == 3)
            {
                AdminController adminController = new AdminController();
                adminController.GetAdminOptions();
            }
            else
            {
                Console.WriteLine("You selected wrong option number");
            }
        }
    }
}