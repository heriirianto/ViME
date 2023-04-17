using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SwitchScenes : MonoBehaviour
{

    public void PindahScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
