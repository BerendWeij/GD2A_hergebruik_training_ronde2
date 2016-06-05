using UnityEngine;
using System.Collections;

public class FindTarget : MonoBehaviour {

    //Delegates
    public delegate void TurretEventHandler();
    public TurretEventHandler OnEnemyFind;
    //Delegates

    //LayerMask
    [SerializeField] private LayerMask _targetLayer;
    //LayerMask

    //GameObject
    private GameObject closestEnemy;
    //GameObject


    //Float
    [SerializeField] private float _targetRange;
    //Float

    //Bool
    [SerializeField]
    bool _showTargetRange;
    //Bool

    void Start()
    {
        InvokeRepeating("FindEnemy", 2f, 2f);
    }

    void FindEnemy()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, _targetRange, _targetLayer);


        float shortestDistance = float.MaxValue;

        for (int i = 0; i < hitEnemies.Length; i++)
        {
            float distance = Vector2.Distance(transform.position, hitEnemies[i].transform.position);

            if (distance < shortestDistance)
            {
                closestEnemy = hitEnemies[i].gameObject;
                shortestDistance = distance;
            }
        }

        if (closestEnemy != null)
        {
            if (OnEnemyFind != null)
                OnEnemyFind();
        }

    }

    void OnDrawGizmosSelected()
    {
        if (_showTargetRange)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.gameObject.transform.position, _targetRange);
        }
       
    }
}
