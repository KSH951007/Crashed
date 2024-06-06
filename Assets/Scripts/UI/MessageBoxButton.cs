using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MessageBoxButton : MonoBehaviour
{

    private TextMeshProUGUI buttonTMP;
    private Button button;
    private void Awake()
    {
        buttonTMP = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void OnDisable()
    {
        button.onClick.RemoveAllListeners();
    }
    public void InIt(string text, Action action = null)
    {
        gameObject.SetActive(true);
        buttonTMP.text = text;
        button.onClick.AddListener(action.Invoke);


    }



}
