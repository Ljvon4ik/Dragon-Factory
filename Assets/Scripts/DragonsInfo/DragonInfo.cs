using System;
using UnityEngine;

[Serializable]
public class DragonInfo
{
    [SerializeField] private GameObject _prefab;
    public GameObject Prefab => _prefab;
}