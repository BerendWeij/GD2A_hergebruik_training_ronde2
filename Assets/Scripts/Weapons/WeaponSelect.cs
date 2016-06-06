using UnityEngine;
using System.Collections.Generic;

public class WeaponSelect : MonoBehaviour
{
    private List<IWeapon> weapons = new List<IWeapon>();

    private int selectedWeaponIndex;

    void Start()
    {
        foreach (IWeapon weapon in GetComponents<IWeapon>())
        {
            weapons.Add(weapon);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            ChangeWeapon(1);

        else if (Input.GetKeyDown(KeyCode.Q))
            ChangeWeapon(-1);
    }

    void ChangeWeapon(int _change)
    {
        selectedWeaponIndex += _change;

        if (selectedWeaponIndex < 0)
            selectedWeaponIndex = weapons.Count - 1;

        else if (selectedWeaponIndex > weapons.Count - 1)
            selectedWeaponIndex = 0;
    }

    void OnMouseDown()
    {
        weapons[selectedWeaponIndex].Shoot();
        print("shoot");
    }
}
