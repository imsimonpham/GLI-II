using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    private bool _isOpen;
    private Animator _anim;
    [SerializeField] private bool _isLocked;
    [SerializeField] private GameObject _doorControlPanel;

    void Start()
    {
        _anim = GetComponent<Animator>();
        if(_isLocked)
        {
            _doorControlPanel.transform.GetChild(0).gameObject.SetActive(true);
            _doorControlPanel.transform.GetChild(1).gameObject.SetActive(false);
        }else
        {
            _doorControlPanel.transform.GetChild(0).gameObject.SetActive(false);
            _doorControlPanel.transform.GetChild(1).gameObject.SetActive(true);
        }
            
    }

    public void Interact()
    {
        if (!_isLocked)
        {
            _isOpen = !_isOpen;
            _anim.SetBool("IsOpen", _isOpen);
        } else {
            Debug.Log("Door is locked");
        }
        
    }

    public void Activate()
    {
        UnlockDoor();
    }

    private void UnlockDoor()
    {
        _isLocked = false;
        _doorControlPanel.transform.GetChild(0).gameObject.SetActive(false);
        _doorControlPanel.transform.GetChild(1).gameObject.SetActive(true);
    }
}
