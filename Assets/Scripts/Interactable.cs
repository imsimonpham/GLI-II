using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private GameObject _uiContainer;
    private IInteractable _interactable;

    private void Awake()
    {
        _uiContainer.SetActive(false);
        _interactable = GetComponent<IInteractable>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            _uiContainer.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Interacting with Item");
                _interactable.Interact();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            _uiContainer.SetActive(false);
    }
}
