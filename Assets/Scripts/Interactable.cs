using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private GameObject _uiContainer;
    private IInteractable _interactable;
    private bool _isInteractable;

    private void Awake()
    {
        _uiContainer.SetActive(false);
        _interactable = GetComponent<IInteractable>();
        _isInteractable = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _uiContainer.SetActive(true);
            _isInteractable = true;
        }      
    }

    private void Update()
    {
        if (_isInteractable && Input.GetKeyDown(KeyCode.E))
        {
            _interactable.Interact();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _uiContainer.SetActive(false);
            _uiContainer.SetActive(true);
        }
    }
}
