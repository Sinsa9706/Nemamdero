using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    private Button _StartBtn;

    private void Awake()
    {
        _StartBtn = GetComponent<Button>();
    }

    private void Start()
    {
        _StartBtn.onClick.AddListener(() => ButtonManager.instance.StartBtn());
    }
}
