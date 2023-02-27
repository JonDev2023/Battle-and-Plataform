using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiplayerHandler : MonoBehaviour
{
    public bool multiplayer;
    public GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        player2.SetActive(false);
    }

    // Multiplayer is called when the enter on keypad is pressed
    void Multiplayer()
    {
        player2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown (KeyCode.KeypadEnter)) {
            multiplayer = true;
            Multiplayer();
       }
    }
}
