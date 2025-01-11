using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("Interacting with " + gameObject.name);
    }

    public void Activate()
    {

    }
}
