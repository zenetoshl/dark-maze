using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectSetup : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.U2D.PixelPerfectRendering.pixelSnapSpacing =  camera.orthographicSize * 2.0f / camera.pixelHeight;
    }
}
