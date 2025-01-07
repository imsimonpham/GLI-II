using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
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
