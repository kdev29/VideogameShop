﻿
using System;
using System.Collections.Generic;
using System.Text;
using VideogameShop.Library.Services;
using VideogameShopLibrary.CVS_Models;
using VideogameShopLibrary.Services;

namespace VideogameShopLibrary
{

    class Program
    {

        static void Main(string[] args)
        {
            //check for card validation functionality
            RetrieveDbData retrieveP_Characteristics = new RetrieveDbData();
            RetrieveDbData.ProductCharacteristics productCharacteristics = new RetrieveDbData.ProductCharacteristics();
            productCharacteristics = retrieveP_Characteristics.displayProductCharacteristics();

            foreach (var item in productCharacteristics.Condition)
            {
                Console.WriteLine(item);
            }




            //    string input;
            //    while (true)
            //    {
            //        Console.WriteLine("Type Import to upload data or Retrieve to display data from database");
            //        input = Console.ReadLine().Trim();

            //        if (input.ToLower() == "import" || input.ToLower() == "retrieve")
            //            break;
            //    }


            //    if (input.ToLower() == "import")
            //    {
            //        while (true)
            //        {
            //            Console.WriteLine("Type JSON to save data to a JSON file or SQL to save data to the database");
            //            input = Console.ReadLine().Trim();
            //            if (input.ToLower() == "json" || input.ToLower() == "sql")
            //                break;
            //        }


            //        if (input.ToLower() == "json")
            //        {
            //            Console.WriteLine("json input");
            //            try
            //            {
            //                //string builder necessary to parse csv to JSON format

            //                StringBuilder JInventoryrecords = new StringBuilder();
            //                StringBuilder JSalesrecords = new StringBuilder();

            //                //transforming into json

            //                var JInventorySb = new InventoryManagementService(JInventoryrecords);
            //                JInventorySb.ProcessProductsFromCsv(Config.PathToInvetoryFile);

            //                var JSalesSb = new InventoryManagementService(JSalesrecords);
            //                JSalesSb.ProcesOrdersFromCsv(Config.PathToSalesFile);


            //                //making file out of json string

            //                var JInventoryFile = new CsvToJsonConverter();
            //                JInventoryFile.ProcessCsvFile(JInventoryrecords, Config.PathToData + "JInventoryFile.json");
            //                var JSalesFile = new CsvToJsonConverter();
            //                JSalesFile.ProcessCsvFile(JSalesrecords, Config.PathToData + "JSalesFile.json");
            //            }
            //            catch (Exception ex)
            //            {
            //                var Err = new CreateLogFiles();
            //                Err.ErrorLog(Config.PathToData + "err.log", ex.Message);
            //                Console.WriteLine("Fatal error : " + ex.Message + ", please find a complete error at ErrorLog file");
            //                throw;
            //            }
            //            Console.WriteLine("Updated database succesfully");
            //        }
            //        else if (input.ToLower() == "sql")
            //        {
            //            try
            //            {
            //                var dropData = new InventoryManagementService();
            //                dropData.DropAllData();

            //                var CsvProductCharRecords = new InventoryManagementService();
            //                CsvProductCharRecords.SaveProductChar(Config.PathToInvetoryFile);

            //                var CsvInvetoryRecords = new InventoryManagementService();
            //                CsvInvetoryRecords.SaveCsvInventory(Config.PathToInvetoryFile);

            //                var CsvSalesRecords = new InventoryManagementService();
            //                CsvSalesRecords.SaveCsvOrders(Config.PathToSalesFile);


            //            }
            //            catch (Exception ex)
            //            {
            //                var Err = new CreateLogFiles();
            //                Err.ErrorLog(Config.PathToData + "err.log", ex.Message);
            //                Console.WriteLine("Fatal error : " + ex.Message + ", please find a complete error at ErrorLog file");
            //                throw;
            //            }
            //            Console.WriteLine("Updated database succesfully");
            //        }

            //    }
            //    else if (input == "retrieve")
            //    {
            //        StringBuilder records = new StringBuilder();
            //        Console.WriteLine(DisplayDbData.displayAllData(records).ToString());
            //    }

        }


    }
    
}