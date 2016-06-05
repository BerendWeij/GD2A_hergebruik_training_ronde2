using UnityEngine;
using System.Collections;

public class TurretHealth : MonoBehaviour, IHealth {

    [SerializeField]
    private int _turretHealth;

    public int GetTurretHealth
    {
        get { return _turretHealth; }
    }
	
    public void ChangeHealth(int damage, bool hurt)
    {
        if (hurt)
            _turretHealth -= damage;
        else
            _turretHealth += damage;
    }
}
