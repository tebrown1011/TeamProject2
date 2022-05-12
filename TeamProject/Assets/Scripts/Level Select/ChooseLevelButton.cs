using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevelButton : MonoBehaviour
{
    public int nextLevel;
    public Collider2D doorCol;
    public Collider2D playerCol;

    private void Update()
    {
        if(doorCol.IsTouching(playerCol) && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
