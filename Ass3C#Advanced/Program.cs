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
        }
    }
}
