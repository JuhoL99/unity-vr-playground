using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifyingGlass : MonoBehaviour
{
    private Camera textureCam;
    private Camera mainCam;

    private void Start()
    {
        textureCam = GetComponentInChildren<Camera>();
        mainCam = Camera.main;
    }
    private void Update()
    {
        textureCam.transform.rotation = mainCam.transform.rotation;
    }
}
