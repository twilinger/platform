using UnityEngine;
using UnityEngine.UI;
using YG;

public class AdvButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private float _timeToNextShow = 60f;
    [SerializeField] private Health playerHealth;


    private void OnEnable() => YandexGame.RewardVideoEvent += OnRewarded;
    private void OnDisable() => YandexGame.RewardVideoEvent -= OnRewarded;

    private void Start()
    {
        _button.onClick.AddListener(ShowAdvButton);
    }
    private void ShowAdvButton()
    {
        if (YandexGame.SDKEnabled)
        {
            YandexGame.RewVideoShow(0);
        }
        else
        {
            OnRewarded(0);
        }

        DeactiveteButton();
        Invoke(nameof(ActiveteButton), _timeToNextShow);
    }

    private void ActiveteButton()
    {
        _button.enabled = true;
    }
    private void DeactiveteButton()
    {
        _button.enabled = false;
    }

    private void OnRewarded(int id)
    {
        if (id == 0)
        {
            playerHealth.Bonus();
            playerHealth.AddHealth(1);
        }
    }

}
