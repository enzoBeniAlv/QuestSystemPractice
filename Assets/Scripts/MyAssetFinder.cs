using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class MyAssetFinder
{
    public static List<T> FindAll<T>(string folder)
        where T : ScriptableObject
    {
        var results = new List<T>();

        foreach (string guid in AssetDatabase.FindAssets(
                     $"t:{typeof(T).Name}", new[] { folder }))
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            T asset = AssetDatabase.LoadAssetAtPath<T>(path);

            if (asset != null)
                results.Add(asset);
        }

        return results;
    }
}
