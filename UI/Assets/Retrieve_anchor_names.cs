using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
//using UnityEngine.

  
public class Retrieve_anchor_name : MonoBehaviour
{
    // Start is called before the first frame update
    string path = "Assets/Log.txt";
    //string path = Application.dataPath + "/Log.txt";
    public void Start()

    {
        string[] Anchorname = File.ReadAllLines(path);
     
        // AssetDatabase.ImportAsset(path);
        //TextAsset asset = Application.dataPath.
            
            //Load("Log.txt");

        //Print the text from the file
        Debug.Log(Anchorname);
    }

   
    
}
