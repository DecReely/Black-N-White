using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceAdder : MonoBehaviour
{
    public GameObject SpaceCanvas;
    private void OnTriggerEnter(Collider other)
    {
        SpaceCanvas.SetActive(true);
    }
}
