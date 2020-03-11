﻿using System.Collections;
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
        path = Application.dataPath + "/Log.txt";
    }

    private void Update()
    {
        var lines = File.ReadAllLines(path).Where(arg => !string.IsNullOrWhiteSpace(arg));
        File.WriteAllLines(path, lines);
    }

    public void CreateText()
    {

        string content = Anchorname.text;
        if (!File.Exists(path))
        {

            File.WriteAllText(path, "Anchorname.text");
        }
        content = "\n" + Anchorname.text;

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

        //StartCoroutine(ReloadAnchorNames());

        // InvokeRepeating("ReloadAnchorNames", 2.0f, 0f);

        ClearAnchorLocationsPage();
        ReloadAnchorNames();


    }

    public void  ReloadAnchorNames()
    {
        Debug.Log(1);
        //yield return new WaitForSeconds(1f);
        Debug.Log(2);
        Debug.Log(GameObject.Find("Locations Page"));
        GameObject.Find("Locations Page").GetComponent<Load_anchor_name>().loadAnchors();

    }

    public void ClearAnchorLocationsPage()
    {
        Debug.Log("something");

        GameObject[] uiElement = GameObject.FindGameObjectsWithTag("ClearUI");
        foreach (GameObject ui in uiElement)
        {
            Debug.Log(ui);
            Destroy(ui);
        }

    }

   
}
