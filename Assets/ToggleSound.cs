using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSound : MonoBehaviour
{
    [SerializeField] private bool _toggleEffects;


public void Toggle()
{
    if(_toggleEffects) SoundManager.Instance.ToggleEffects();
}



}
