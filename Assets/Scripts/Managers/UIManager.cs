using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class UIManager : MonoBehaviour
{
    public enum CanvasType { Scene, World, Popup, Size }

    [SerializeField] private Canvas[] canvasPrefabs;
    private Canvas[] canvas;
    [SerializeField] private AssetReference sceneCanvasRef;


    private void Awake()
    {
        CreateUICanvas();
    }

    private void CreateUICanvas()
    {
        if (canvas == null)
        {
            canvas = new Canvas[(int)CanvasType.Size];
        }
        if (canvas[(int)CanvasType.Scene] == null)
        {
            canvas[(int)CanvasType.Scene] =  Instantiate(canvasPrefabs[(int)CanvasType.Scene]);

        }

    }
}
