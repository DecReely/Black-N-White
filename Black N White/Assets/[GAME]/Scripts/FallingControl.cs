using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManage>().Restart();
    }
}
