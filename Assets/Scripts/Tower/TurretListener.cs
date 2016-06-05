using UnityEngine;
using System.Collections;

public class TurretListener : MonoBehaviour {

    [SerializeField]
    private FindTarget _findTarget;

    [SerializeField]
    private GameObject _nozzleObject;

    [SerializeField]
    private GameObject _bulletObject;


    void Awake()
    {
        _findTarget.OnEnemyFind += Start;
    }

    void Start()
    {
        InvokeRepeating("ShootBullet", 1, 1);
    }


    void ShootBullet()
    {
        Instantiate(_bulletObject, _nozzleObject.transform.position, Quaternion.identity);
    }
}
