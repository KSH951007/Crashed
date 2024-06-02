using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class MainLauncher : MonoBehaviour
{

    private void Start()
    {
        AuthCheck();
    }


    private void AuthCheck()
    {
        AuthManager authManager = GameManager.AuthManager;

        if (authManager.Auth == null)
        {

        }



        else
        {

            Debug.Log("nullX");
        }
    }
}
