using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gg : MonoBehaviour
{
    public int health = 100;

    public GUIStyle GuiStyle;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      

    }



    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width*0.75f,Screen.height*0.95f,100,100), $"Здоровье: {health}/100",GuiStyle);
       
        

    }

}
