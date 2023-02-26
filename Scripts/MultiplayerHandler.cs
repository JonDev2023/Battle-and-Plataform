using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using System.Threading;
using UnityEngine;

public class MultiplayerHandler : MonoBehaviour
{

    public bool multiplayer;
    public string FileDataPath;

    void GPU(string txt)
    {
        Debug.Log(txt);
    }

    // Start is called before the first frame update
    void Start()
    {
        try {
            using var file = File.CreateText(FileDataPath);
            file.WriteLine(multiplayer.ToString());
            file.Close();
        } catch (Exception ex) {
            GPU("Sorry! Error there");
            multiplayer = false;
            Thread.Sleep(1000 * 10);
        }
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown (KeyCode.KeypadEnter)) {
            Debug.Log("2P Activated");
            multiplayer = true;
            try {
                using var file = File.CreateText(FileDataPath);
                file.WriteLine(multiplayer.ToString());
                file.Close();
            } catch (Exception ex) {
                GPU("Sorry! Error there");
                multiplayer = false;
                Thread.Sleep(1000 * 10);
            }
       }
    }
}
