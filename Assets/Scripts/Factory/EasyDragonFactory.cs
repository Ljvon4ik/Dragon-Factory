using UnityEngine;

public class EasyDragonFactory : DragonAbstractFactory
{
    public override void CreateNightmare(Vector3 position)
    {
        GameObject _nightmare = _dragonsInfo.Nightmare[0].Prefab;
        Instantiate(_nightmare, position, Quaternion.identity);
    }

    public override void CreateSoulEater(Vector3 position)
    {
        GameObject _soulEater = _dragonsInfo.SoulEater[0].Prefab;
        Instantiate(_soulEater, position, Quaternion.identity);
    }

    public override void CreateTerrorBringer(Vector3 position)
    {
        GameObject _terrorBringer = _dragonsInfo.TerrorBringer[0].Prefab;
        Instantiate(_terrorBringer, position, Quaternion.identity);
    }

    public override void CreateUsurper(Vector3 position)
    {
        GameObject _usurper = _dragonsInfo.Usurper[0].Prefab;
        Instantiate(_usurper, position, Quaternion.identity);
    }
}
