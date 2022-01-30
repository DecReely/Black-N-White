using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADRemover : MonoBehaviour
{
    public GameObject ADCanvas;
    private void OnTriggerEnter(Collider other)
    {
        ADCanvas.SetActive(false);
    }
}
