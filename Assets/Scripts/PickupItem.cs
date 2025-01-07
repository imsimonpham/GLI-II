using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour, IInteractable
{
    void Start()
    {
        Debug.Log("This is a pickup item");
    }

    public void Interact()
    {
        Debug.Log("Interacting with " + gameObject.name);
    }
}
