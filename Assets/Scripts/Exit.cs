using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour
{

    public void exit()
    {
        Application.Quit();
    }
    public void Lvl1()
    {
        SceneManager.LoadScene("Lvl1");
    }
}
