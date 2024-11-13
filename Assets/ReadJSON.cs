using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using UnityEngine;

public class ReadJSON : MonoBehaviour
{
    public void LoadJSON() {
        string json = File.ReadAllText(@"C:\Users\ianki\Downloads\new_tasklist.json");
        TaskData lists = JsonUtility.FromJson<TaskData>(json);
    }

}
