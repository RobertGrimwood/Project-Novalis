using System;

namespace ProjectNovalis
{

    class Program
    {
        static string opening;
        static string lowerOpening;
        static string[] jobTitle = new string[512];
        static string[] companyName = new string[512];
        static string[] jobLocation = new string[512];
        static string[] salaryPay = new string[512];
        static string[] notes = new string[512];
        static string[] applyDate = new string[512];
        static int jobCount;
        static string path = @"C:\\Temp\ProjectNovalis";
        static int u;
        static int D;
        

        static void Main()
        {
            //Version 0.3.3 by Robert Grimwood

            jobCount = 0;

            while (2 > 1)
            {

                Console.WriteLine("What would you like to do?:" + Environment.NewLine +
                    "Create new job" + Environment.NewLine +
                    "View previous jobs" + Environment.NewLine +
                    "Get help" + Environment.NewLine + 
                    "Save data" + Environment.NewLine +
                    "Load Data" + Environment.NewLine +
                    "Exit" + Environment.NewLine);
                opening = Console.ReadLine();
                lowerOpening = opening.ToLower();

                if (lowerOpening == "create new job")
                {
                    NewJobs();
                    Console.WriteLine("You've applied for: " + jobCount + " jobs"); 
                }

                if (lowerOpening == "view previous jobs")
                {
                    ViewJobs(); 
                    

                }

                if (lowerOpening == "get help")
                {
                    Help();
                    
                }

                if (lowerOpening == "save data")
                {
                    SaveData();
                    
                }

                if (lowerOpening == "load data")
                {
                    LoadData();
                    Console.WriteLine("Feature is to be implemented. Sorry.");
                }
                if (lowerOpening == "exit")
                {
                    Environment.Exit(0);
                }
            }

        }


        static void NewJobs()
        {
            
            Console.WriteLine("This is where you input job info.");
            Console.WriteLine("Input the Job title:");
            jobTitle[jobCount] = Console.ReadLine();
            Console.WriteLine("Input the company name:");
            companyName[jobCount] = Console.ReadLine();
            Console.WriteLine("Input the job location:");
            jobLocation[jobCount] = Console.ReadLine();
            Console.WriteLine("Input the salary:");
            salaryPay[jobCount] = Console.ReadLine();
            Console.WriteLine("Input the date in MMDDYYYY format:");
            applyDate[jobCount] = Console.ReadLine();
            Console.WriteLine("Input any notes about the job application:");
            notes[jobCount] = Console.ReadLine();
            jobCount++;
           Console.WriteLine( Environment.NewLine);
            
        }

        
        static void ViewJobs()
        {
            u = 0;
            Console.WriteLine("This is where you get job info.");
            while (u < jobCount)
            {
                Console.WriteLine("Job No.: " + (D = u +1) + Environment.NewLine +
                    jobTitle[u] + Environment.NewLine +
                    companyName[u] + Environment.NewLine +
                    jobLocation[u] + Environment.NewLine +
                    salaryPay[u] + Environment.NewLine +
                    applyDate[u] + Environment.NewLine +
                    notes[u] + Environment.NewLine + Environment.NewLine );

               u++;
                
            }
            
        }


        static void SaveData()
        {
            
            System.IO.File.WriteAllLines(path , jobTitle);
            System.IO.File.WriteAllLines("companyName", companyName);
            System.IO.File.WriteAllLines("jobLocation", jobLocation);
            System.IO.File.WriteAllLines("salaryPay", salaryPay);
            System.IO.File.WriteAllLines("applyDate", applyDate);
            System.IO.File.WriteAllLines("notes", notes);
            Console.WriteLine("Data has been saved.");

        }

        static void LoadData()
        {
            System.IO.File.ReadAllLines(path);
        }

        static void Help()
        {
            Console.WriteLine("This is Version 0.3.4. The Author is Robert Grimwood.");
            Console.WriteLine("The main options are: " + Environment.NewLine +
                "Create new job" + Environment.NewLine +
                "View previous jobs" + Environment.NewLine +
                "Save Data" + Environment.NewLine +
                "Load Data" + Environment.NewLine +
                "The 'Load Date' feature is not complete yet. Please be paitient.");
        }
        
      

    }

}
