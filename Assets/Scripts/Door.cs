using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    private bool _isOpen;
    [SerializeField] private Animator _anim;

    public void Interact()
    {
        _isOpen = !_isOpen;
        _anim.SetBool("IsOpen", _isOpen);
    }
}
