using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevelFinal : MonoBehaviour
{
    public Collider2D doorBox;
    public SpriteRenderer door;
    public Color unlocked;
    public int nextLevel;
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("LevelTrack").GetComponent<LevelsCompleted>().buttonComplete == true && GameObject.FindGameObjectWithTag("LevelTrack").GetComponent<LevelsCompleted>().collectComplete == true)
        {
            doorBox.enabled = true;
            door.color = unlocked;
        }
        else
        {
            doorBox.enabled = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.Space))
        {
            Debug.Log("unlocked");
            SceneManager.LoadScene(nextLevel);
        }
    }
}
