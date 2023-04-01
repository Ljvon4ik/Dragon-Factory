using UnityEngine;

public abstract class DragonAbstractFactory : MonoBehaviour
{
    protected DragonsInfo _dragonsInfo;
    private void Awake()
    {
        _dragonsInfo = Resources.Load<DragonsInfo>("DragonsInfo");
    }
    public abstract void CreateNightmare(Vector3 position);
    public abstract void CreateSoulEater(Vector3 position);
    public abstract void CreateTerrorBringer(Vector3 position);
    public abstract void CreateUsurper(Vector3 position);
}
