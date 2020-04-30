using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

    public void restartGame()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
