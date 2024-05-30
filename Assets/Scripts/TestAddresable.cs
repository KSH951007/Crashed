using Fusion;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class TestAddresable : MonoBehaviour
{
    public GameObject networkRunner;

    private void Awake()
    {

        TestLoad();
    }

    private void TestLoad()
    {
        Addressables.LoadAssetAsync<GameObject>("NetworkRunner").Completed +=
             (asyncoprationhandle) =>
             {
                 networkRunner = asyncoprationhandle.Result;

             };
    }
}
