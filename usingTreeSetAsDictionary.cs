using System;
using C5;


// Red-Black tree https://en.wikipedia.org/wiki/Red%E2%80%93black_tree


// custom comparer to get functionality of dictionary (key -> value mapping)

//KeyValuePairComparer<KeyType, ValueType>
//Key and value can be of any type, most resonable is propably <int, object> - for effectivity, <string, object> - for convenience 

KeyValuePairComparer<string, string> comparer = new KeyValuePairComparer<string, string>(System.Collections.Generic.Comparer<string>.Default);



// dictionary 
TreeSet<C5.KeyValuePair<string, string>> dict = new TreeSet<C5.KeyValuePair<string, string>>(comparer);


// add value to dictionary
C5.KeyValuePair<string, string> obj1 = new C5.KeyValuePair<string, string>("key1", "value1");
C5.KeyValuePair<string, string> obj2 = new C5.KeyValuePair<string, string>("key2", "value2");

//1st option
dict.Add(obj1);
//2nd option; this option will return value as in example below;
dict.FindOrAdd(ref obj2); 



// check value in dictionary

// find1  -  object neccessery to find object; it will be replaced; second value has no use during finding object - it will be used for storing extracted value
C5.KeyValuePair<string, string> find1 = new C5.KeyValuePair<string, string>("aa", null);

// check
bool found = dict.Find(ref find1);

if(found)
{
    Console.WriteLine( String.Format("Key:{0}, Value{1}", find1.Key, find1.Value) );
}

