using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceRemover : MonoBehaviour
{
    public GameObject SpaceCanvas;
    private void OnTriggerEnter(Collider other)
    {
        SpaceCanvas.SetActive(false);
    }
}
