using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class MapTextureCreator : IInitializable, IDisposable
{
    [Inject] private Camera mapCamera;
    [Inject] private RawImage target;
    [Inject] private OnlineMapsRawImageTouchForwarder touchForwarder;

    private RenderTexture targetTexture;

    public void Initialize()
    {
        var size = target.rectTransform.rect;
        targetTexture = new RenderTexture((int)size.width, (int)size.height, 24);
        mapCamera.targetTexture = targetTexture;
        target.texture = targetTexture;
        touchForwarder.targetTexture = targetTexture;
    }

    public void Dispose()
    {
        mapCamera.targetTexture = null;
        GameObject.DestroyImmediate(targetTexture);
    }
}
