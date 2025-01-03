using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Add Health");
            Destroy(gameObject);
        }
    }
}
