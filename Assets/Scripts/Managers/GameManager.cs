using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private static AuthManager authManager;


    public static AuthManager AuthManager { get => authManager; }
    public static GameManager Instance { get { return instance; } }


    private void Awake()
    {
        if (instance != null)
        {
            instance = null;
            DestroyImmediate(gameObject);
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        CreateManagers();

    }

    private void CreateManagers()
    {
        if (authManager == null)
        {
            GameObject authObject = new GameObject("AuthManager");
            authObject.transform.parent = transform;
            authManager = authObject.AddComponent<AuthManager>();
        }
    }

}
