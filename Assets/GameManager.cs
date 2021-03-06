﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class GameManager : MonoBehaviour {
    public Interface inter;
    public int physicsFramesSinceStart = 0;

    // Use this for initialization
    void Start() {
        if(Application.platform == RuntimePlatform.WebGLPlayer) {
            Debug.Log("In WebGL mode, using JSInterface");
            inter = GetComponent<JSInterface>();
        }
        else {
            Debug.Log("In non-WebGL mode, using HumanInterface");
            inter = GetComponent<HumanInterface>();
        }
        if(inter == null) {
            Debug.Log("No interface!");
        }
        inter.QueryEnv(this);
    }

    void Update() {
        Time.timeScale = Input.GetKey(KeyCode.P) ? 0f : (Input.GetKey(KeyCode.T) ? 0.1f : 1f);
    }

    void FixedUpdate() {
        physicsFramesSinceStart++;
    }
}
