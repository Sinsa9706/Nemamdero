using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneManager : MonoBehaviour
{
    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        Instantiate(Resources.Load("Prefabs/StartCanvas"));
        Instantiate(Resources.Load("Prefabs/ButtonManager"));
    }
}
