using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitBtn : MonoBehaviour
{
    private Button _ExitBtn;

    private void Awake()
    {
        _ExitBtn = GetComponent<Button>();
    }

    private void Start()
    {
        _ExitBtn.onClick.AddListener(() => ButtonManager.instance.ExitBtn());
    }
}
