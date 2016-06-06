using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextValue : MonoBehaviour {

    [SerializeField]
    private Text displayText;

    [SerializeField]
    private DamageAble damageAble;

    private string standardValue;

    void Awake() {
        standardValue = displayText.text;
    }

    void OnEnable()
    {
        damageAble.ChangeHealth += DisplayNewHealth;
    }

    void OnDisable()
    {
        damageAble.ChangeHealth -= DisplayNewHealth;
    }

    void DisplayNewHealth(float _newValue) {
        displayText.text = standardValue + _newValue;
    }
}
