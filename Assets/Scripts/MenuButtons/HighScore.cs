﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour {

    public void HighScorePressed()
    {
        SceneManager.LoadScene("HighScoreDisplay");
    }
}
