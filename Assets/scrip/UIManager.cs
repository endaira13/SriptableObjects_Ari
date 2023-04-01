using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
  [SerializeField] private Text SolText;
  [SerializeField] private Text LunaText;
  [SerializeField] private Text TierraText;
  [SerializeField] private Text AguaText;
  [SerializeField] private Text IdiomaText;

  private static UIManager instance;

  public static UIManager Instance
  {
    get 
    {
        if(instance == null)
        {
            instance = FindObjectOfType<UIManager>();
        }
        return instance;
    }
  }

  public void UpdateUI(WeaponData weaponData)
  {
    SolText.text = weaponData.weaponSol;
    LunaText.text = weaponData.weaponLuna;
    TierraText.text = weaponData.weaponTierra;
    AguaText.text = weaponData.weaponAgua;
    IdiomaText.text = weaponData.weaponIdioma;
  }

  public void HighLightWeapon(Weapon weaponToHighLight)
  {
     Weapon[] weapons = FindObjectsOfType<Weapon>();

     foreach(Weapon weapon in weapons)
     {
         weapon.GetComponent<SpriteRenderer>().color = Color.grey;
     }
     weaponToHighLight.GetComponent<SpriteRenderer>().color = Color.white;
  }
}
