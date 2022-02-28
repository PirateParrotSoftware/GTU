using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

public class Map : IInitializable
{
    [Inject] private OnlineMaps map;
    
    public async void Initialize()
    {
        await Init();
    }

    private async UniTask Init()
    {
        while (Input.location.status != LocationServiceStatus.Running)
            await UniTask.Yield();

        map.SetPosition(Input.location.lastData.longitude, Input.location.lastData.latitude);
    }
}
