using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    [SerializeField] private Image healthImage;

	void Start () {
        Humanoid.OnHealthChangeEvent += ChangeHealthBar;
	}

    void ChangeHealthBar(float input)
    {
        healthImage.fillAmount = input / 100;
    }
}
