using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private GameObject[] _targets;
    [SerializeField] private bool _isActivated;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pad"))
        {
            foreach (GameObject target in _targets)
            {
                if(target.TryGetComponent<IInteractable>(out IInteractable interactable))
                    interactable.Activate(_isActivated);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Pad"))
        {
            foreach (GameObject target in _targets)
            {
                if (target.TryGetComponent<IInteractable>(out IInteractable interactable))
                    interactable.Activate(_isActivated);
            }
        }
    }
}
