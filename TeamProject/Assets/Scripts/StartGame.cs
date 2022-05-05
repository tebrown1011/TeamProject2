using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Update is called once per frame
    public void changeLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonLevel()
    {
        SceneManager.LoadScene(3);
    }

    public void CollectLevel()
    {
        SceneManager.LoadScene(2);
    }
}
