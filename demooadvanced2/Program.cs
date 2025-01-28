////dataset >>often refers to DataSet, a class in the System.Data namespace. It is a disconnected, in-memory representation of data.
//using System;
//using System.Data;
//using System.Data.SqlClient;

//class Program
//{
//    static void Main()
//    {
//        string connectionString = "your_connection_string_here";
//        string query = "SELECT * FROM Students";

//        // Create a connection
//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            // Create a DataAdapter
//            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

//            // Create a DataSet to hold the data
//            DataSet ds = new DataSet();

//            // Fill the DataSet
//            adapter.Fill(ds, "Students");

//            // Access the DataTable from the DataSet
//            DataTable studentTable = ds.Tables["Students"];

//            // Iterate through the rows and display data
//            foreach (DataRow row in studentTable.Rows)
//            {
//                Console.WriteLine($"ID: {row["StudentID"]}, Name: {row["Name"]}");
//            }
//        }
//    }
//}
// <<<collections >>>>  are data structures used to store, manage, and manipulate groups of objects.
//They are part of the System.Collections, System.Collections.Generic
//// and related namespaces, offering a variety of ways to handle data efficiently.
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Create a list of integers
//        List<int> numbers = new List<int>();

//        // Add elements to the list
//        numbers.Add(10);
//        numbers.Add(20);
//        numbers.Add(30);

//        // Add multiple elements using AddRange
//        numbers.AddRange(new int[] { 40, 50, 60 });

//        // Display the elements in the list
//        Console.WriteLine("List Elements:");
//        foreach (int number in numbers)
//        {
//            Console.WriteLine(number);
//        }

//        // Access elements by index
//        Console.WriteLine($"\nFirst Element: {numbers[0]}");
//        Console.WriteLine($"Third Element: {numbers[2]}");

//        // Remove an element
//        numbers.Remove(20);
//        Console.WriteLine("\nAfter Removing 20:");
//        foreach (int number in numbers)
//        {
//            Console.WriteLine(number);
//        }

//        // Check if an element exists
//        bool contains30 = numbers.Contains(30);
//        Console.WriteLine($"\nList contains 30: {contains30}");

//        // Get the count of elements in the list
//        Console.WriteLine($"\nTotal Elements: {numbers.Count}");
//    }
//}
// A Generic List >>>> is part of the System.Collections.Generic
// namespace and is implemented as the List<T> class. It allows you to create a strongly-typed
// list that can hold objects of a specified type. Generic lists improve type safety, reduce boxing/unboxing,
// and are more efficient compared to non-generic collections.
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Create a list of strings
//        List<string> fruits = new List<string>();

//        // Add items to the list
//        fruits.Add("Apple");
//        fruits.Add("Banana");
//        fruits.Add("Cherry");

//        // Add multiple items at once
//        fruits.AddRange(new List<string> { "Dragonfruit", "Elderberry" });

//        // Display all items
//        Console.WriteLine("Fruits:");
//        foreach (string fruit in fruits)
//        {
//            Console.WriteLine(fruit);
//        }

//        // Access an item by index
//        Console.WriteLine($"\nFirst Fruit: {fruits[0]}");

//        // Remove an item
//        fruits.Remove("Banana");

//        // Check if an item exists
//        bool hasCherry = fruits.Contains("Cherry");
//        Console.WriteLine($"\nContains Cherry: {hasCherry}");

//        // Get the number of items in the list
//        Console.WriteLine($"\nTotal Fruits: {fruits.Count}");

//        // Sort the list alphabetically
//        fruits.Sort();
//        Console.WriteLine("\nSorted Fruits:");
//        foreach (string fruit in fruits)
//        {
//            Console.WriteLine(fruit);
//        }
//    }
//}
