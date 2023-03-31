using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
   [SerializeField] WeaponData weaponData;

    private void OnMouseDown()
    {
        UIManager.Instance.UpdateUI(weaponData);
        UIManager.Instance.HighLightWeapon(this);
    }
}
