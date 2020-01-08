using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

   

public class MenuScript
{
    [MenuItem("Tools/Assign Material")]
    public static void AssignMaterial()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        Material material = Resources.Load<Material>("Tile");

        foreach (GameObject t in tiles)
        {
            t.GetComponent<Renderer>().material = material;
        }
    }

    [MenuItem("Tools/Assign Tile Script")]
   
    public static void AssignScript()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");

        foreach (GameObject t in tiles)
        {
            t.AddComponent<AssignTileMaterial>();
        }
    }
}
