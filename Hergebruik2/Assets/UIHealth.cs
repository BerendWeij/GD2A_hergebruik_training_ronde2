using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIHealth : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private PlayerHealth playerHealth;
    private Image healthBar;
    [SerializeField]
    private Transform timeBar;
    [SerializeField]
    private float startTimer;
    private float timer;

    void Awake()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
        healthBar = GetComponent<Image>();
        playerHealth.OnPlayerDamage += ChangeHealthBar;
        timer = startTimer;
        StartCoroutine(timerCo());
    }
    IEnumerator timerCo()
    {
        while (true)
        {
            timer--;
            float xscale = timer / startTimer;
            timeBar.localScale = new Vector3(xscale, timeBar.localScale.y, timeBar.localScale.z);
            yield return new WaitForSeconds(1);
        }
    }
    void ChangeHealthBar()
    {
        healthBar.fillAmount -= 0.2f;
    }
}