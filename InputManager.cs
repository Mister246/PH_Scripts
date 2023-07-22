using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Rhythm.opportunity)
            {
                Rhythm.NoteHit();
            }
            else
            {
                Rhythm.NoteMiss();
            }
        }
    }
}