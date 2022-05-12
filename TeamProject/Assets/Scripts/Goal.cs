using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public int nextLevel;

    public bool ButtonGoal;
    public bool CollectGoal;
    public bool FinalGoal;
    void Start()
    {
        
    }

    
    void Update()
    {
 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && ButtonGoal == true)
        {
            SceneManager.LoadScene(nextLevel);
            GameObject.FindGameObjectWithTag("LevelTrack").GetComponent<LevelsCompleted>().buttonComplete = true;
        }

        if (collision.gameObject.tag == "Player" && CollectGoal == true)
        {
            SceneManager.LoadScene(nextLevel);
            GameObject.FindGameObjectWithTag("LevelTrack").GetComponent<LevelsCompleted>().collectComplete = true;
        }

        if (collision.gameObject.tag == "Player" && FinalGoal == true)
        {
            SceneManager.LoadScene(nextLevel);
            GameObject.FindGameObjectWithTag("LevelTrack").GetComponent<LevelsCompleted>().finalComplete = true;
        }
    }
}
