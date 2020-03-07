using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Anchor_name : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField Anchorname;
    // public Text txt;
    [HideInInspector]
    public string path;
    
    void Start()
    {
       
    }

    public void CreateText()
    {
        path = Application.dataPath + "/Log.txt";
        string content = Anchorname.text;
        if (!File.Exists(path))
        {

            File.WriteAllText(path, "Anchorname.text");
        }
          content ="\n"+ Anchorname.text;

        File.AppendAllText(path, content);
 
    }
}
