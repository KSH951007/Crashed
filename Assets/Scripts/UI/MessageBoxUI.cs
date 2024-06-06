using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MessageBoxUI : PopupUI
{
    [SerializeField] private TextMeshProUGUI contentTMP;
    [SerializeField] private RectTransform buttonRoot;
    [SerializeField] private MessageBoxButton buttonPrefab;
    private List<MessageBoxButton> buttonList;

    private void Awake()
    {
        buttonList = new List<MessageBoxButton>(buttonRoot.childCount);
        for (int i = 0; i < buttonRoot.childCount; i++)
        {
            buttonList.Add(buttonRoot.GetChild(i).GetComponent<MessageBoxButton>());
        }

    }

    private void OnDisable()
    {
        for (int i = 0; i < buttonList.Count; i++)
        {
            buttonList[i].gameObject.SetActive(false);
        }

    }
    public void Init(string content, params ButtonInfo[] buttonInfos)
    {
        contentTMP.text = content;

        for (int i = 0; i < buttonInfos.Length; i++)
        {
            if (buttonInfos[i].isActivity)
                buttonInfos[i].action += () => { gameObject.SetActive(false); };

            MessageBoxButton button;
            if (i >= buttonRoot.childCount - 1)
            {
                button = Instantiate(buttonPrefab, buttonRoot.transform);
                button.InIt(buttonInfos[i].text, buttonInfos[i].action);
                buttonList.Add(button);
            }
            else
            {
                buttonList[i].gameObject.SetActive(true);
                buttonList[i].InIt(buttonInfos[i].text, buttonInfos[i].action);
            }

        }

    }


}
public struct ButtonInfo
{
    public string text;
    public Action action;
    public bool isActivity;

    public ButtonInfo(string newText, bool isActivity = false, Action newAction = null)
    {
        text = newText;
        this.isActivity = isActivity;
        action = newAction;
    }
}