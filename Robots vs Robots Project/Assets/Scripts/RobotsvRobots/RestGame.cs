using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestGame : MonoBehaviour
{
    public void OnClickRestart ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScreen");
        RobotProductionManager.instance.Reset();
        PrefabManager.instance.ClearAllPools();
    }

    public void OnClickTitle ()
    {
        RobotProductionManager.instance.Reset();
        UnityEngine.SceneManagement.SceneManager.LoadScene("TitleScreen");
    }
}
