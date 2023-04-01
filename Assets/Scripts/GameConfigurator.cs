using Unity.VisualScripting;
using UnityEngine;


public class GameConfigurator : MonoBehaviour
{
    private DragonAbstractFactory _dragonFactory;

    internal void EasyLevel()
    {
        _dragonFactory = this.AddComponent<EasyDragonFactory>();
        SpawnDragons();
    }
    internal void MediumLevel()
    {
        _dragonFactory = this.AddComponent<MediumDragonFactory>();
        SpawnDragons();
    }
    internal void HardLevel()
    {
        _dragonFactory = this.AddComponent<HardDragonFactory>();
        SpawnDragons();
    }

    void SpawnDragons()
    {
        _dragonFactory.CreateNightmare(new Vector3(5, 0, 0));
        _dragonFactory.CreateSoulEater(new Vector3(-5,0,0));
        _dragonFactory.CreateTerrorBringer(new Vector3(15, 0, 0));
        _dragonFactory.CreateUsurper(new Vector3(-15, 0, 0));
    }
}
