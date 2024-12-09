﻿using System.Configuration;
using _2HabitTracker_Advanced.Models;
using System.Globalization;
using System.Data.SQLite;
namespace _2HabitTracker_Advanced;

internal class Program
{
    private static readonly string? connectionString = ConfigurationManager.ConnectionStrings["DefaultCnn"].ConnectionString;
    private static string tableName = "Specified_HabitTracker";

    static void Main(string[] args)
    {
        int approvedConn = RunNonQueryOnDatabase(@$"CREATE TABLE IF NOT EXISTS {tableName} (
                                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                            HabitName TEXT NOT NULL,
                                                            DateAndTime TEXT,
                                                            Quantity REAL,
                                                            Unit TEXT NOT NULL
                                                            )");

        if (approvedConn != 0)
        {
            Console.WriteLine($"System was unable to create specified database. Check program configuration and try again!\n\n");
            Console.ReadKey();
            return;
        }

        ShowMenu();
    }

    static void ShowMenu()
    {
        Console.Clear();

        bool closeApp = false;
        while (closeApp == false)
        {
            Console.WriteLine("\n\nWELCOME TO HABIT TRACKER - ADVANCED");
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("\n0. Close Application");
            Console.WriteLine("1. View All Records");
            Console.WriteLine("2. Add New Record");
            Console.WriteLine("3. Delete A Record");
            Console.WriteLine("4. Update a Record");
            Console.WriteLine("------------------------------\n");

            var userChoice = Console.ReadKey();
            Console.WriteLine("\n");

            switch (userChoice.KeyChar)
            {
                case '0':
                    Console.WriteLine("Have a good day! Application will be closed.");
                    closeApp = true;
                    break;
                case '1':
                    //ViewAllData();
                    break;
                case '2':
                    //InsertNewRecord();
                    break;
                case '3':
                    //UpdateRecord();
                    break;
                case '4':
                    //DeleteRecord();
                    break;
                default:
                    Console.WriteLine("\nInvalid input! Try Again.");
                    break;
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }

    // Database SubOperations section.
    public static int RunNonQueryOnDatabase(string commandText)
    {
        using var connection = new SQLiteConnection(connectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = commandText;
        int result = command.ExecuteNonQuery();

        connection.Close();

        return result;
    }

    private static int CheckDatabaseForRecord(string date) 
        /* Check if a record with the given date exists in the database
        * Return 1 if the record exists, 0 if it does not */
    {
        return 0;
    }
}
