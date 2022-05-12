using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowComplete : MonoBehaviour
{
    public Image doorButton;
    public Image doorCollect;

    public Color goal;
    void Update()
    {
        

        if(GameObject.FindGameObjectWithTag("LevelTrack").GetComponent<LevelsCompleted>().buttonComplete == true)
        {
            doorButton.color = goal;
        }

        if (GameObject.FindGameObjectWithTag("LevelTrack").GetComponent<LevelsCompleted>().collectComplete == true)
        {
            doorCollect.color = goal;
        }
    }
}
