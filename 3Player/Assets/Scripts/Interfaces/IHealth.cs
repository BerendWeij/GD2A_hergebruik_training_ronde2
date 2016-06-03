using UnityEngine;
using System.Collections;

public interface IHealth {

    void DecreaseHealth(float damage);

    void IncreaseHealth(float healing);

    void ResetHealth();
}
