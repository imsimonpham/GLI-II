using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private GameObject _uiContainer;

    private void Awake()
    {
        _uiContainer.SetActive(false);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Add Health");
            Destroy(gameObject);
        }
    }*/

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _uiContainer.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Interacting with Item");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _uiContainer.SetActive(false);
    }
}
