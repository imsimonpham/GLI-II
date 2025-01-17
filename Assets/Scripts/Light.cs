using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour, IInteractable
{
    private Material _emissviveMat;
    [SerializeField] private bool _isOn;
    [SerializeField] private float _emissionPower;
    private void Start()
    {
        _emissviveMat = GetComponent<MeshRenderer>().materials[1];
        ToggleLight();
    }

    public void Interact()
    {
        _isOn = !_isOn;
        ToggleLight();
    }

    private void ToggleLight()
    {
        if (_isOn)
            _emissviveMat.SetColor("_EmissionColor", Color.white * _emissionPower);
        else
            _emissviveMat.SetColor("_EmissionColor", Color.black);
    }

    public void Activate(bool isActivated) { }
}
