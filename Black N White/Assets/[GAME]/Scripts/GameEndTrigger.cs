using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndTrigger : MonoBehaviour
{
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("GameCompleted");
    }
}
