using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.name == "BOXO")
        {
            SceneManager.LoadScene(4);
        }
    }
}
