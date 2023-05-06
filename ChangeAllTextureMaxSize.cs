using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class ChangeAllTextureMaxSize
{
    [MenuItem("Tools/Change All Texture MaxSize")]
    public static void ChangeMaxSize()
    {
        // Numeric value to rewrite MaxSize (e.g., 512)
        int newMaxSize = 512;

        // Get all textures in the project
        string[] guids = AssetDatabase.FindAssets("t:Texture");
        List<Texture> textures = new List<Texture>();

        foreach (string guid in guids)
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(guid);
            Texture texture = AssetDatabase.LoadAssetAtPath<Texture>(assetPath);
            textures.Add(texture);
        }

        // Changes the MaxSize of the acquired texture
        foreach (Texture texture in textures)
        {
            TextureImporter textureImporter = AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(texture)) as TextureImporter;

            if (textureImporter != null)
            {
                textureImporter.maxTextureSize = newMaxSize;
                AssetDatabase.ImportAsset(AssetDatabase.GetAssetPath(texture));
            }
        }
        Debug.Log("All Texture MaxSize Changed to: " + newMaxSize);
    }
}
