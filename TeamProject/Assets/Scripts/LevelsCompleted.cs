using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsCompleted : MonoBehaviour
{
    public bool buttonComplete;
    public bool collectComplete;
    public bool finalComplete;

    public static LevelsCompleted original;
    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (original == null)
        {
            original = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    void Update()
    {

    }
}

