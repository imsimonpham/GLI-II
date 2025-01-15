using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminal : MonoBehaviour, IInteractable
{
    public GameObject[] targets;
    /*public bool isPoweredUp;*/

    public void Interact()
    {
        foreach (GameObject target in targets)
        {
            if(target.TryGetComponent<IInteractable>(out IInteractable interactable))
            {
                interactable.Activate();
            }
        }
    }

    public void Activate() { }
}
