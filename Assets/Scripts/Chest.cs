using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
   [SerializeField] private bool _isOpen;
   private Animator _anim;

   [SerializeField] private bool _isLocked;
   
   void Start()
   {
        _anim = GetComponent<Animator>();
   }

   public void Interact()
   {
        if (!_isLocked) 
        { 
            _isOpen = !_isOpen;
            _anim.SetBool("IsOpen", _isOpen);
        }
   }

   public void Activate(bool isActivated)
   {

   }
}
