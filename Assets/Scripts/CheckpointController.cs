﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckpointController : MonoBehaviour {

    // Variables
    public bool checkpointReached;
    public int nextLevel;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // Increment our scene forward 1 scene from the scene we are on 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            checkpointReached = true;
        }
    }
}