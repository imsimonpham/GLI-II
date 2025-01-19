using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLoot : MonoBehaviour
{
    [SerializeField] private List<GameObject> lootItems = new List<GameObject>();

    [SerializeField] [Range(1, 19)] private int minNumber = 1;
    [SerializeField] [Range(2, 20)] private int maxNumber = 5;

    [SerializeField] private Transform _spawnPoint;

    private bool _isCollected = false;
    private bool _isSpawned = false;

    private void Update()
    {
        if(_isSpawned && !_isCollected)
        {
            _isSpawned = false;
            Debug.Log("Spawn Loot");
        }
    }
}
