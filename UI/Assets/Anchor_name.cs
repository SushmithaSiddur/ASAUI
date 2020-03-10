using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Linq;

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


    public void DeleteText()
    {

        string ObjectToDeleteName = gameObject.name;
        
        string ObjectToDeleteName_withNumber = ObjectToDeleteName.Replace("Delete ", "");
        ObjectToDeleteName = ObjectToDeleteName_withNumber.Remove(ObjectToDeleteName_withNumber.Length - 2);

       string[] lines = File.ReadAllLines(gameObject.GetComponent<Load_anchor_name>().path);


        List<string> listOfLines = lines.OfType<string>().ToList();
        for (int i = listOfLines.Count - 1; i >= 0; i--)
        {
      
            if (listOfLines[i].Contains(ObjectToDeleteName))
            {
                listOfLines.RemoveAt(i);
                Debug.Log("Removed");
            }
        }

        File.WriteAllLines(gameObject.GetComponent<Load_anchor_name>().path, listOfLines);

        Destroy(gameObject);
        Destroy(GameObject.Find(ObjectToDeleteName_withNumber));

    }

}
