using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameSceneManager : MonoBehaviour
{
    public static GameSceneManager instance;
    public GameManager gameManager;

    private void Awake()
    {
        instance = this;
        Init();
    }

    private void Init()
    {
        Instantiate(Resources.Load("Prefabs/ButtonManager"));
        Instantiate(Resources.Load("Prefabs/Player"));
        Instantiate(Resources.Load("Prefabs/GameSceneCanvas"));
    }
}
