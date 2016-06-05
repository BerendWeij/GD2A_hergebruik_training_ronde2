using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBarListener : MonoBehaviour {

    [SerializeField]
    private PlayerHealth _playerHealth;

    [SerializeField]
    private Image _healthBarImage;


	void Start () 
    {
        _playerHealth.OnPlayerDamage += UpdateHealthBar;
	}
	
	void UpdateHealthBar()
    {
        _healthBarImage.fillAmount -= 0.25f;
    }
}
