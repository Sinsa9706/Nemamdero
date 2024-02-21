using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance;

    private void Awake()
    {
        
    }

    void Start()
    {

    }

    void Update()
    {
        SceneManager.LoadScene("GameScene");
    }
}
