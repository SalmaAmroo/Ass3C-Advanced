using System.Collections;

namespace Ass3C_Advanced
{
    internal class Program
    {
        #region Q1
        //public static int NonRepeatedCharcter (string str)
        //{
        // Dictionary<char, int> Count = new Dictionary<char, int>();

        //   for(int i=0;i<str.Length;i++)
        //   {
        //          if (Count.ContainsKey(str[i]))
        //              Count[str[i]]++;

        //          else
        //              Count[str[i]] = 1;
        //   }
        //   for(int i=0;i<str.Length;i++)
        //   {
        //          if (Count[str[i]] == 1)
        //          {
        //              return i;
        //          }


        //   }


        //          return -1;
        //}

        #endregion

        #region Q2
        //public static void FrequencyOfNumbers (int[] arr)
        //{

        //    Hashtable hashtable = new Hashtable ();
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (hashtable.ContainsKey(arr[i]))
        //            hashtable[arr[i]] = (int)hashtable[arr[i]] +1;
        //        else 
        //            hashtable[arr[i]] = 1;

        //    }

        //    foreach (DictionaryEntry item in hashtable)
        //    {
        //        Console.WriteLine($"{item.Key} : {item.Value}");
        //    }



        //}


        #endregion

        #region Q3
        //public static object GretterKey ( Hashtable hashtable )
        //{
        //    object MaxKey = null;
        //    int MaxValue = int.MinValue;

        //    foreach (DictionaryEntry Values in hashtable)
        //    {
        //        if ((int)Values.Value > MaxValue)
        //        {
        //            MaxValue = (int)Values.Value;
        //            MaxKey = Values.Key;
        //        }    
        //    }

        //    return MaxKey;


        //}
        #endregion

        #region Q4
        //public static void GetKeyOfTargetValue(Hashtable hashtable)
        //{
        //    Console.WriteLine("Enter Target Value : ");
        //    string? targetValue = Console.ReadLine();
        //    bool found = false;
        //    foreach ( DictionaryEntry item in hashtable)
        //    {
        //        if (item.Value.ToString() == targetValue)
        //        {
        //            Console.WriteLine(item.Key);
        //            found = true;


        //        }
        //    }
        //    if (!found)
        //        Console.WriteLine("Key Not Found");


        //}
        #endregion

        #region Q5
        //public static List<List<string>> AnagramsCharcters(string[] strings)
        //{
        //    Dictionary<string , List<string>> map = new Dictionary<string, List<string>>();

        //    foreach (string word in strings)
        //    {
        //        char[] Chars = word.ToCharArray();
        //        Array.Sort(Chars);
        //        string sortedWord = new string(Chars);

        //        if (!map.ContainsKey(sortedWord)) 
        //        {
        //            map[sortedWord] = new List<string>();
        //        }
        //        map[sortedWord].Add(word);
        //    }
        //    List <List<string>> result = new List<List<string>>();

        //    foreach(var values in map.Values)
        //    {
        //      result.Add(values);
        //    }
        //    return result;
        //}
        #endregion

       
        static void Main(string[] args)
        {

            #region CallQ1
            //string str = "Salmokka";

            //Console.WriteLine($"Index : {NonRepeatedCharcter(str)}");
            #endregion

            #region CallQ2
            //int[] arr = {1,2,1,3,4,4,6,1,2,6,6}; 
            //FrequencyOfNumbers(arr);

            #endregion

            #region CallQ3
            //Hashtable hashtable = new Hashtable()
            //{
            //    {"Salma",100 },
            //    {"Ahmed",200 },
            //    {"Mokha",50 },
            //    {"Karim",250}
            //}; 

            //Console.WriteLine($"Key : {GretterKey(hashtable)}");
            #endregion

            #region CallQ4
            //Hashtable hashtable = new Hashtable()
            //{
            //    {"Key1","apple"},
            //    {"Key2","banana"},
            //    {"Key3","apple"},
            //    {"Key4","apple"},
            //    {"Key5","banana"}
            //};
            //GetKeyOfTargetValue(hashtable);
            #endregion

            #region CallQ5
            //string[] words = 
            //{
            //    "eat","tea","tan","ate","nat","bat"
            //};
            //foreach (var group in AnagramsCharcters(words))
            //{
            //    Console.WriteLine("[" + string.Join(", ", group) + "]");
            //}

            #endregion

            #region Q6
            //SortedDictionary<int , string > StudentNames = new SortedDictionary<int , string >();

            //StudentNames.Add(101, "Salma");
            //StudentNames.Add(103, "Ahmed");
            //StudentNames.Add(102, "Karim");
            ////Adding a studend
            //Console.WriteLine("Student Information:");
            //foreach (var Names in StudentNames)
            //{
            //    Console.WriteLine($"ID:{Names.Key}, Name : {Names.Value} ");
            //}
            ////Removing a student
            //Console.WriteLine("Student Information After Removing:");
            //StudentNames.Remove(103);
            //foreach (var Names in StudentNames)
            //{
            //    Console.WriteLine($"ID:{Names.Key}, Name : {Names.Value} ");
            //}
            ////Retrieving a student
            //Console.WriteLine("Retrieving :");
            //if (StudentNames.ContainsKey(102))
            //    Console.WriteLine($"ID:102, Name : {StudentNames[102]} ");
            //else
            //    Console.WriteLine("Student Not Found");

            #endregion

            #region Q7
            //Dictionary<int,string> Employees = new Dictionary<int,string>();
            //Employees.Add(4, "Salma");
            //Employees.Add(3, "Ahmed");
            //Employees.Add(2, "Karim");
            //Employees.Add(1, "Hoda");

            //SortedList<int, string> SortedEmployees = new SortedList<int, string>(Employees);
            //Console.WriteLine("Sorted Employees by ID:");
            //foreach (var emp in SortedEmployees)
            //{
            //    Console.WriteLine($"ID:{emp.Key}, Name : {emp.Value} ");
            //}


            #endregion

            #region Q8
            //List<int> DuplicatedInteger = new List<int>()
            //{
            //    1,1,2,3,3,4,5,3,2,6,7,8,5
            //};
            //Console.WriteLine("Duplicated Integer:");
            //foreach (var num in DuplicatedInteger)
            //{
            //    Console.Write($"{num} ");
            //}
            //Console.WriteLine();
            //HashSet<int> UniqueIntegers = new HashSet<int>(DuplicatedInteger);
            //Console.WriteLine("UnDuplicated Integer:");
            //foreach (var num in UniqueIntegers)
            //{
            //    Console.Write($"{num} ");
            //}

            #endregion
        }
    }
}
