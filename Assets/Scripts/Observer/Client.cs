using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
    {
        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Look at the console window to watch the countdown and the events getting triggered.");
        }
    }
