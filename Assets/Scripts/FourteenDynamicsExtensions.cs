using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
namespace FourteenDynamics.Extensions {
    public static class FDExtentions {
        /// <summary>
        /// Get a random object out of the collection, using Random.Range()
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns>Random object out of the collection</returns>
        public static T GetRandom<T>(this IList<T> collection) {
            return collection[Random.Range(0, collection.Count)];
        }

        /// <summary>
        /// Remove all objects out of the original List, which are also in "other"s
        /// </summary>
        /// <param name="other">The list that contains the elements to remove</param>
        public static void RemoveFromCollection<T>(this List<T> collection, List<T> other) {
            List<T> result = new List<T>();
            foreach(T all in collection) {
                if(!other.Contains(all) && !result.Contains(all)) {
                    result.Add(all);
                }
            }
            collection.Clear();
            foreach(T var in result) {
                collection.Add(var);
            }
        }
        /// <summary>
        /// Remove all duplicates out of the original list
        /// </summary>
        public static void RemoveDuplicates<T>(this List<T> collection) where T : class {
            for(int i = 0; i < collection.Count - 1; i++)
                for(int j = i + 1; j < collection.Count; j++)
                    if(collection[i] == collection[j])
                        collection.RemoveAt(j);
        }
        /// <summary>
        /// Prints out the list with Unity's Debug.Log()
        /// </summary>
        /// <param name="original">The list to be printed</param>
        /// <param name="first">First text before printed list</param>
        /// <param name="last">Last text after printed list</param>
        public static void Print<T>(this IList<T> original, string first = "", string last = "") => Print(original, false, first, last);
        /// <summary>
        /// Prints out the list with Unity's Debug.Log()
        /// </summary>
        /// <param name="singleLine">If the whole list should be in only one Debug.Log, or each element one Debug.Log</param>
        /// <param name="original">The list to be printed</param>
        /// <param name="first">First text before printed list</param>
        /// <param name="last">Last text after printed list</param>
        public static void Print<T>(this IList<T> original, bool singleLine = false, string first = "", string last = "") {
            string res = "";

            if(first != "") { Debug.Log(first); }
            foreach(var item in original) {
                if(singleLine) {
                    res += item + ", ";
                } else {
                    Debug.Log(item);
                }
            }
            if(singleLine) { Debug.Log(res); }
            if(last != "") { Debug.Log(last); }
        }
    }
}
