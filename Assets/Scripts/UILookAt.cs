using System;
using UnityEngine;

public class UILookAt : MonoBehaviour
{
   /*[SerializeField] private Camera _cam;*/
   private void LateUpdate()
   {
      transform.LookAt(Camera.main.transform);
   }
}
