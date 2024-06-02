using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public enum CanvasType { Scene, World, Popup, Size }

    private Canvas[] canvas;



    private void Awake()
    {

    }

    private void CreateUICanvas()
    {
        if (canvas == null)
        {
            canvas = new Canvas[(int)CanvasType.Size];
        }
        if (canvas[(int)CanvasType.Scene] == null)
        {
            //canvas[(int)CanvasType.Scene]
        }

    }
}
