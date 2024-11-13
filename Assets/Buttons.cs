using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Microsoft.MixedReality.GraphicsTools.Editor;
using System.ComponentModel;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject canvas;
    [SerializeField] private Button soloButton;
    [SerializeField] private Button sharedButton;
    [SerializeField] private TextMeshPro listActual;
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        soloButton = canvas.transform.Find("toggleIndiv").gameObject.GetComponent<Button>();
        sharedButton = canvas.transform.Find("toggleShared").gameObject.GetComponent<Button>();
        listActual = canvas.transform.Find("listActual").gameObject.GetComponent<TextMeshPro>();

        soloButton.onClick.AddListener(soloClicked);
        sharedButton.onClick.AddListener(sharedClicked);
    }

    public void soloClicked() {

    }

    public void sharedClicked() {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
