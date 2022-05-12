using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevelButton : MonoBehaviour
{
    public int nextLevel;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
