﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gate : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        int currScene = SceneManager.GetActiveScene().buildIndex;
        LevelData.NextLevel();
        SceneManager.LoadScene(currScene + 1);
    }
}
