using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [HideInInspector] public string levelName;

    public void LevelChanger()
    {
        SceneManager.LoadScene(levelName);
    }
}
