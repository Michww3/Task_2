using System.Collections;
using System.Collections.Specialized;

var map = new Dictionary<int, double>();
var map2 = new Dictionary<int, double> { };


var valueIsExist = map.TryGetValue(1, out var value);

var sDic = new SortedDictionary<int, double>();
var  arrayValues = new int[1];
var  arrayValues2 = new int[1];

var orderedDictionary = new OrderedDictionary() { };
{
    orderedDictionary.Add(23393, 110.23);
    orderedDictionary.Add(7646496, 123210.23);
    orderedDictionary.Add(9293, 239593);
}
//

var compare = new Collection();
Console.WriteLine(compare.collection[1] == compare.collection[2]);

//}
IEnumerator<int> enumerator = compare.GetKeys();
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}
public class Collection : IComparer<int>
{
    //public OrdDicCompare(T collection)
    //{

    //}
    public OrderedDictionary collection = new OrderedDictionary()
    {
        {234234,2323.20 },
        {5959,23929 },
        {12,302.34 },
        {490238,232.19 },
        {1,2.23 },
    };

    public IEnumerator<int> GetKeys()
    {
        foreach (DictionaryEntry entry in collection)
        {
            yield return (int)entry.Key;
        }
    }
    public int Compare(int x, int y)
    {
        return x.CompareTo(y);
    }

}

