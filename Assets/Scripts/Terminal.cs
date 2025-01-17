using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminal : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject[] _targets;
    [SerializeField] private bool _isActivated;

    public void Interact()
    {
        foreach (GameObject target in _targets)
        {
            if(target.TryGetComponent<IInteractable>(out IInteractable interactable))
            {
                _isActivated = true;
                interactable.Activate(_isActivated);
            }
        }
    }

    public void Activate(bool isActivated) { }
}
