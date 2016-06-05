using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour, IHealth {

    public delegate void PlayerHealthEventHandler();
    public PlayerHealthEventHandler OnPlayerDamage;

    [SerializeField]
    int _playerHealth;

    public int GetPlayerHealth
    {
        get { return _playerHealth; }
    }

    public void ChangeHealth(int damage, bool hurt)
    {
        if (hurt)
        {
            _playerHealth -= damage;
            SendSignal();
        }
            
        else
            _playerHealth += damage;

        
    }

    void SendSignal()
    {
        if (OnPlayerDamage != null)
        {
            OnPlayerDamage();
        }
    }


}
