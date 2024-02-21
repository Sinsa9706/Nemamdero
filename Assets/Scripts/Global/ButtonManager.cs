using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    private static ButtonManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void StartBtn()
    {
        SceneManager.LoadScene("GameScene");
    }
}
