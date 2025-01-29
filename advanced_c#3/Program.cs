using System.Collections;
using System.Collections.Generic;
//
namespace advanced_c_3
{
    internal class Program
    {

        static int CountKeysStartingWith(Dictionary<string, int> dict, char targetChar)
        {
            int count = 0;

            foreach (var key in dict.Keys)
            {
                if (key.StartsWith(targetChar.ToString()))
                {
                    count++;
                }
            }

            return count;
        }
        static HashSet<int> UnionOfSets(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> unionSet = new HashSet<int>(set1);

            unionSet.UnionWith(set2);

            return unionSet;
        }
        static Hashtable SwapKeysAndValues(Hashtable original)
        {
            Hashtable swapped = new Hashtable();

            foreach (DictionaryEntry entry in original)
            {
                swapped.Add(entry.Value, entry.Key); 
            }

            return swapped;
        }

        static List<int> FindMissingNumbers(int[] numbers, int N)
        {
            // Create a HashSet for the numbers in the array for O(1) lookup
            HashSet<int> numberSet = new HashSet<int>(numbers);

            // List to store the missing numbers
            List<int> missingNumbers = new List<int>();

            // Check each number from 1 to N
            for (int i = 1; i <= N; i++)
            {
                if (!numberSet.Contains(i))
                {
                    missingNumbers.Add(i); // Add missing number to the list
                }
            }

            return missingNumbers;
        }
        static void AddEmployee(SortedList<int, string> directory, int id, string name)
        {
            if (!directory.ContainsKey(id))
            {
                directory.Add(id, name);
                Console.WriteLine($"Added: {id} - {name}");
            }
            else
            {
                Console.WriteLine($"Employee with ID {id} already exists.");
            }
        }

        // Method to retrieve an employee's name by ID
        static string RetrieveEmployee(SortedList<int, string> directory, int id)
        {
            if (directory.ContainsKey(id))
            {
                return directory[id];
            }
            else
            {
                return $"Employee with ID {id} not found.";
            }
        }

        // Method to remove an employee by ID
        static void RemoveEmployee(SortedList<int, string> directory, int id)
        {
            if (directory.ContainsKey(id))
            {
                directory.Remove(id);
                Console.WriteLine($"Removed: Employee with ID {id}");
            }
            else
            {
                Console.WriteLine($"Employee with ID {id} not found.");
            }
        }

        // Method to display all employees
        static void DisplayEmployees(SortedList<int, string> directory)
        {
            foreach (var employee in directory)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }
        }
        static void AddStudent(SortedDictionary<int, string> dictionary, int id, string name)
        {
            if (!dictionary.ContainsKey(id))
            {
                dictionary.Add(id, name);
                Console.WriteLine($"Added: {id} - {name}");
            }
            else
            {
                Console.WriteLine($"Student with ID {id} already exists.");
            }
        }

        static string RetrieveStudent(SortedDictionary<int, string> dictionary, int id)
        {
            if (dictionary.ContainsKey(id))
            {
                return dictionary[id];
            }
            else
            {
                return $"Student with ID {id} not found.";
            }
        }

        static void RemoveStudent(SortedDictionary<int, string> dictionary, int id)
        {
            if (dictionary.ContainsKey(id))
            {
                dictionary.Remove(id);
                Console.WriteLine($"Removed: Student with ID {id}");
            }
            else
            {
                Console.WriteLine($"Student with ID {id} not found.");
            }
        }

        static void DisplayStudents(SortedDictionary<int, string> dictionary)
        {
            foreach (var student in dictionary)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }

        }

            static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int num in nums)
            {
                if (seenNumbers.Contains(num))
                {
                    return true; 
                }
                seenNumbers.Add(num);
            }

            return false; 
        }
        static void Main(string[] args)
        {
            #region  part1 

            // List :  A generic collection that allows dynamic resizing and provides indexed access.  Add(): O(1), Remove(): O(n), Access[]: O(1) . Best for ordered collections where elements are accessed by index and elements may change.

            // Arraylist :  A non-generic collection that can store any type of objects, dynamically resized.   Add(): O(1), Remove(): O(n), Access[]: O(1)  .  Used when elements are of unknown types and do not require type safety.

            // HashSet  :  A collection of unique elements with no specific order. Internally uses a hash table.  Add(): O(1), Contains(): O(1), Remove(): O(1)  .   Best for situations where you need to ensure uniqueness and fast lookups.

            // Hashtable :  	A collection of key-value pairs, where keys are unique. Internally uses a hash table.  Add(): O(1), ContainsKey(): O(1), Remove(): O(1)  .   Used when you need to store data as key-value pairs with fast lookup by key.

            //SortedDictionary	 :   A collection of key-value pairs, where keys are sorted. Internally uses a balanced tree.       Add(): O(log n), ContainsKey(): O(log n), Remove(): O(log n)    .          Used when you need to store data as key-value pairs, and keys need to be sorted automatically.
            
            
            #endregion
            #region part2 q1
            //int[] arr = { 1, 2, 3, 2, 1, 4, 1, 3, 2, 5 };


            //Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            //foreach (int num in arr)
            //{
            //    if (frequencyMap.ContainsKey(num))
            //        frequencyMap[num]++;
            //    else
            //        frequencyMap[num] = 1;
            //}

            //Console.WriteLine("Element Frequencies:");
            //foreach (var kvp in frequencyMap)
            //{
            //    Console.WriteLine($"Element {kvp.Key}: {kvp.Value} times");
            //}
            #endregion

            #region q2
            //    Hashtable hashtable = new Hashtable
            //{
            //    { "A", 10 },
            //    { "B", 25 },
            //    { "C", 15 },
            //    { "D", 30 },
            //    { "E", 20 }
            //};

            //    string maxKey = null;
            //    int maxValue = int.MinValue;

            //    foreach (DictionaryEntry entry in hashtable)
            //    {
            //        if ((int)entry.Value > maxValue)
            //        {
            //            maxValue = (int)entry.Value;
            //            maxKey = (string)entry.Key;
            //        }
            //    }

            //    Console.WriteLine($"Key with the highest value: {maxKey}, Value: {maxValue}");
            #endregion

           

            #region  q3
            //    Hashtable hashtable = new Hashtable
            //{
            //    { "key1", "apple" },
            //    { "key2", "banana" },
            //    { "key3", "apple" },
            //    { "key4", "orange" }
            //};

            //    Console.Write("Enter target value: ");
            //    string targetValue = Console.ReadLine();

            //    ArrayList matchingKeys = new ArrayList();

            //    foreach (DictionaryEntry entry in hashtable)
            //    {
            //        if (entry.Value.ToString() == targetValue)
            //        {
            //            matchingKeys.Add(entry.Key);
            //        }
            //    }

            //    if (matchingKeys.Count > 0)
            //    {
            //        foreach (var key in matchingKeys)
            //        {
            //            Console.WriteLine(key);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Key not found");
            //    }
            #endregion
            #region  q4
            //string[] words = { "ddii", "alaa", "aala", "didi", "daiana" };

            //Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            //foreach (string word in words)
            //{
            //    char[] charArray = word.ToCharArray();
            //    Array.Sort(charArray);
            //    string sortedWord = new string(charArray);

            //    if (!anagramGroups.ContainsKey(sortedWord))
            //    {
            //        anagramGroups[sortedWord] = new List<string>();
            //    }
            //    anagramGroups[sortedWord].Add(word);
            //}

            //Console.WriteLine("Grouped Anagrams:");
            //foreach (var group in anagramGroups.Values)
            //{
            //    Console.WriteLine($"[{string.Join(", ", group)}]");
            //}
            #endregion
            #region  q5
            int[] numbers = { 4, 3, 3, 4, 5, 6, 3 };

            bool hasDuplicates = ContainsDuplicate(numbers);

            Console.WriteLine(hasDuplicates);

            #endregion

            #region  q6
            SortedDictionary<int, string> studentDictionary = new SortedDictionary<int, string>();

            AddStudent(studentDictionary, 101, "alaa magdy");
            AddStudent(studentDictionary, 102, "daiana abdelrahman");
            AddStudent(studentDictionary, 103, "esraa magdy");

            Console.WriteLine("All Students:");
            DisplayStudents(studentDictionary);

            Console.WriteLine("\nRetrieve student with ID 102:");
            Console.WriteLine(RetrieveStudent(studentDictionary, 102));

            Console.WriteLine("\nRemoving student with ID 101");
            RemoveStudent(studentDictionary, 101);

            Console.WriteLine("\nAll Students after removal:");
            DisplayStudents(studentDictionary);
            #endregion

            #region  q7
            SortedList<int, string> employeeDirectory = new SortedList<int, string>();

            AddEmployee(employeeDirectory, 1001, "alaa magdy");
            AddEmployee(employeeDirectory, 1003, "abdelrahman magdy");
            AddEmployee(employeeDirectory, 1002, "daiana abdelrahman");

            Console.WriteLine("All Employees:");
            DisplayEmployees(employeeDirectory);

            Console.WriteLine("\nRetrieve employee with ID 1002:");
            Console.WriteLine(RetrieveEmployee(employeeDirectory, 1002));

            Console.WriteLine("\nRemoving employee with ID 1001");
            RemoveEmployee(employeeDirectory, 1001);

            Console.WriteLine("\nAll Employees after removal:");
            DisplayEmployees(employeeDirectory);

            #endregion

            #region q8
            int[] numberss = { 1, 2, 4, 6, 7, 8 };

            List<int> missingNumbers = FindMissingNumbers(numberss, 8);

            Console.WriteLine("Missing Numbers:");
            foreach (int number in missingNumbers)
            {
                Console.WriteLine(number);
            }
            #endregion

            #region   q9
            List<int> numbersss = new List<int> { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7 };

            HashSet<int> uniqueNumbers = new HashSet<int>(numbersss);

            Console.WriteLine("Unique Numbers:");
            foreach (int number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }
            #endregion

            #region  q10
            Hashtable originalHashtable = new Hashtable
        {
            { 1, "alaa" },
            { 2, "esraa" },
            { 3, "abdelrahman" },
            { 4, "daiana" }
        };

         Hashtable swappedHashtable = SwapKeysAndValues(originalHashtable);

            Console.WriteLine("Swapped Hashtable:");
            foreach (DictionaryEntry entry in swappedHashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
            #endregion


            #region  q11
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };

            HashSet<int> unionSet = UnionOfSets(set1, set2);

            Console.WriteLine("Union of the two sets:");
            foreach (int item in unionSet)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region q12
            Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "apple", 1 },
            { "animal", 2 },
            { "airport", 3 }
        };

            Console.Write("Enter target character: ");
            char targetChar = char.Parse(Console.ReadLine());
            Console.WriteLine();

            int count = CountKeysStartingWith(dict, targetChar);

            Console.WriteLine($"Output: {count}");
            #endregion


        }
    }
}
