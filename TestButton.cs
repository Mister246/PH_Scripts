using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TestButton : MonoBehaviour
{
    static public Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(delegate { MusicManagement.PlayMusic("120 BPM"); } );
    }

    static public void ChangeColorRandomly()
    {
        button.GetComponent<Image>().color = new Color(Random.Range(0, 0.255f), Random.Range(0, 0.255f), Random.Range(0, 0.255f)); 
    }
}