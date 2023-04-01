using UnityEngine;

public class HardDragonFactory : DragonAbstractFactory
{
    public override void CreateNightmare(Vector3 position)
    {
        GameObject _nightmare = _dragonsInfo.Nightmare[2].Prefab;
        Instantiate(_nightmare, position, Quaternion.identity);
    }

    public override void CreateSoulEater(Vector3 position)
    {
        GameObject _soulEater = _dragonsInfo.SoulEater[2].Prefab;
        Instantiate(_soulEater, position, Quaternion.identity);
    }

    public override void CreateTerrorBringer(Vector3 position)
    {
        GameObject _terrorBringer = _dragonsInfo.TerrorBringer[2].Prefab;
        Instantiate(_terrorBringer, position, Quaternion.identity);
    }

    public override void CreateUsurper(Vector3 position)
    {
        GameObject _usurper = _dragonsInfo.Usurper[2].Prefab;
        Instantiate(_usurper, position, Quaternion.identity);
    }
}
