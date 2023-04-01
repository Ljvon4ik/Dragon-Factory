using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DragonsInfo", menuName = "Gameplay/New DragonInfo")]
public class DragonsInfo : ScriptableObject
{
    [SerializeField] private List<DragonInfo> _nightmare;
    [SerializeField] private List<DragonInfo> _soulEater;
    [SerializeField] private List<DragonInfo> _terrorBringer;
    [SerializeField] private List<DragonInfo> _usurper;

    public List<DragonInfo> Nightmare => _nightmare;
    public List<DragonInfo> SoulEater => _soulEater;
    public List<DragonInfo> TerrorBringer => _terrorBringer;
    public List<DragonInfo> Usurper => _usurper;
}
