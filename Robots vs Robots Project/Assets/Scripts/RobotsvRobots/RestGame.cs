using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestGame : MonoBehaviour
{
    public void OnClickRestart ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScreen");
    }
}
