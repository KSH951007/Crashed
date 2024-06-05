using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Threading;
using UnityEngine.UIElements;
using System;
public class MainLauncher : MonoBehaviour
{

    private  void Start()
    {

        CheckNetworkConnected();

        AuthCheck();
    }


    private bool CheckNetworkConnected()
    {
        return NetworkInterface.GetIsNetworkAvailable();
    }

    private void AuthCheck()
    {
        AuthManager authManager = GameManager.AuthManager;

        if (authManager.Auth == null)
        {

        }



    }

   
 
}
