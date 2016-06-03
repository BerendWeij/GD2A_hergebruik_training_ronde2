using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour {

    [SerializeField]
    private Image healthBar;

    [SerializeField]
    private HealhPlayer playerHealth;

    void Start()
    {
        healthBar.fillAmount = 1;
    }

    void Update()
    {
        Debug.Log(healthBar.fillAmount);
        Debug.Log(playerHealth.health);
        healthBar.fillAmount = playerHealth.health;
    }
}
