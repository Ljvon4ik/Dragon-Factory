using UnityEngine;
using UnityEngine.UI;

public class GUI : MonoBehaviour
{
    [SerializeField]
    Button _easy;
    [SerializeField]
    Button _medium;
    [SerializeField]
    Button _hard;
    GameConfigurator _gameConfigurator;

    private void Start()
    {
        _gameConfigurator = GetComponent<GameConfigurator>();
        _easy.onClick.AddListener(CreateEasyLevel);
        _medium.onClick.AddListener(CreateMediumLevel);
        _hard.onClick.AddListener(CreateHardLevel);
    }

    void CreateEasyLevel()
    {
        _gameConfigurator.EasyLevel();
        OffInteractableButtons();
    }

    void CreateMediumLevel()
    {
        _gameConfigurator.MediumLevel();
        OffInteractableButtons();
    }

    void CreateHardLevel()
    {
        _gameConfigurator.HardLevel();
        OffInteractableButtons();
    }

    void OffInteractableButtons()
    {
        _easy.interactable = false;
        _medium.interactable = false;
        _hard.interactable = false;
    }
}
