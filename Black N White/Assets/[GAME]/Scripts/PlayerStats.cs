using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public const float MaxBoostAmount = 100;
    public float boostAmount;
    public float boostIncreaseAmount = 10;
    public float boostDecreaseAmount = 1;

    public Material whiteMaterial;
    public Material blackMaterial;

    public enum colorState
    {
        black,
        white
    }

    public colorState color = colorState.white;

}
