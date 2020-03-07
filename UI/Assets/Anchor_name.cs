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
    public string path;
    public void CreateText()
    {
          path = Application.dataPath + "/Log.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Anchor Names ");
        }
        string content = "\n"+ Anchorname.text ;

        File.AppendAllText(path, content);
    }
    void Start()
    {
        CreateText(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
