using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIHealth : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private PlayerHealth playerHealth;
    private Image healthBar;

    void Awake()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
        healthBar = GetComponent<Image>();
        playerHealth.OnPlayerDamage += ChangeHealthBar;
    }

    void ChangeHealthBar()
    {
        healthBar.fillAmount -= 0.2f;
    }
}