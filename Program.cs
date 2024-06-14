using System.Collections;
using System.Collections.Specialized;

Dictionary<int, double> map = new Dictionary<int, double>();
Dictionary<int, double> map2 = new Dictionary<int, double> { };

SortedDictionary<int, double> sDic = new SortedDictionary<int, double>();


OrderedDictionary orderedDictionary = new OrderedDictionary();
orderedDictionary.Add(23393, 110.23);
orderedDictionary.Add(7646496, 123210.23);
orderedDictionary.Add(9293, 239593);

//

OrdDicCompare compare = new OrdDicCompare();
//int value = 10;

//foreach (DictionaryEntry entry in orderedDictionary)
//{
//    bool key = (int)entry.Key == value;
//    Console.WriteLine(key);
//}
//foreach (DictionaryEntry entry in orderedDictionary)
//{
//    Console.WriteLine(compare.Compare((int)entry.Key, value));
//}
IEnumerator<int> enumerator = compare.GetKeys();

public class OrdDicCompare : IComparer<int>
{
    public OrderedDictionary orderedDictionary3 = new OrderedDictionary
    {
        {234234,2323.20 },
        {5959,23929 },
        {12,302.34 },
        {490238,232.19 },
        {1,2.23 },
    };

    public IEnumerator<int> GetKeys()
    {
        foreach (DictionaryEntry entry in orderedDictionary3)
        {
            yield return (int)entry.Key;
        }
    }
    public int Compare(int x, int y)
    {
        return x.CompareTo(y);
    }

}

