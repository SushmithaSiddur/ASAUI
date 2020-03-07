using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

using UnityEditor;

using UnityEngine.UI;

public class Load_anchor_name : MonoBehaviour
{
    // Start is called before the first frame update
    string path = "Assets/Log.txt";
    void Start()
    {
        //string[] Anchorname = File.ReadAllLines(path);

        //Debug.Log(Anchorname);

        StreamReader reader = new StreamReader(path);
        string text;
        do
        {
            text = reader.ReadLine();
            //Console.WriteLine(text);
            print(text);
        } while (text != null);

        //Debug.Log(reader.ReadToEnd());
        // reader.Close();
        // OnGUI();

        GameObject newGO = new GameObject("myTextGO");
        newGO.transform.SetParent(this.transform);

        Text myText = newGO.AddComponent<Text>();
       

        myText.text = "Ta-dah!"+ reader.ReadLine();
        Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        myText.font = ArialFont;


    }
    /**public void OnGUI()
    {
        StreamReader reader = new StreamReader(path);
        GUI.contentColor = Color.red;
        GUI.Label(new Rect(1000, 50, 400, 400), reader.ReadToEnd());
    }**/

    void Update()
    {
        
    }
}
