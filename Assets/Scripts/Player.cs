using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public int armor;
    public GameUI gameUI;
    private GunEquipper gunEquipper;
    private Ammo ammo;
    // Start is called before the first frame update
    void Start()
    {
        ammo = GetComponent<Ammo>();
        gunEquipper = GetComponent<GunEquipper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount) 
    {
        int healthDamage = amount;
        if (armor > 0) ;
        {
            int effectiveArmor = armor * 2;
            effectiveArmor -= healthDamage;

            if (effectiveArmor > 0)
            {
                armor = effectiveArmor / 2;
                gameUI.SetArmorText(armor);
                return;
            }
            else
            {
                armor = 0;
                gameUI.SetArmorText(armor);
            }

            health -= healthDamage;
            gameUI.SetHealthText(health);

            if (health <= 0)
            {
                Debug.Log("GameOver");
            }
        }
    }

    private void pickupHealth()
    {
        health += 50;
        if (health > 200)
        {
            health = 200;
        }

        gameUI.SetPickupText("Health Picked Up +50 HP");
        gameUI.SetHealthText(health);
    }

    private void pickupArmor()
    {
        armor += 15;
        gameUI.SetPickupText("Armor Picked Up +15 Armor");
        gameUI.SetArmorText(armor);
    }

    private void pickupAssaultRifleAmmo()
    {
        ammo.AddAmmo(Constants.AssaultRifle, 50);
        gameUI.SetPickupText("Assault Rifle Ammo Picked Up +50 Ammo");
        if(gunEquipper.GetActiveWeapon().tag == Constants.AssaultRifle)
        {
            gameUI.SetAmmoText(ammo.GetAmmo(Constants.AssaultRifle));
        }
    }

    private void pickupPistolAmmo()
    {
        ammo.AddAmmo(Constants.Pistol, 20);
        gameUI.SetPickupText("Pistol Ammo Picked Up +20 Ammo");
        if (gunEquipper.GetActiveWeapon().tag == Constants.Pistol)
        {
            gameUI.SetAmmoText(ammo.GetAmmo(Constants.Pistol));
        }
    }

    private void pickupShotgunAmmo()
    {
        ammo.AddAmmo(Constants.Shotgun, 10);
        gameUI.SetPickupText("Shotgun Ammo Picked Up +10 Ammo");
        if (gunEquipper.GetActiveWeapon().tag == Constants.Shotgun)
        {
            gameUI.SetAmmoText(ammo.GetAmmo(Constants.Shotgun));
        }
    }

    public void PickUpItem(int pickupType)
    {
        switch (pickupType)
        {
            case Constants.PickupArmor:
                pickupArmor();
                break;
            case Constants.PickupHealth:
                pickupHealth();
                break;
            case Constants.PickupAssaultRifleAmmo:
                pickupAssaultRifleAmmo();
                break;
            case Constants.PickUpPistolAmmo:
                pickupPistolAmmo();
                break;
            case Constants.PickupShotgunAmmo:
                pickupShotgunAmmo();
                break;
            default:
                Debug.LogError("Bad pickup type passed" + pickupType);
                break;
        }
    }
}
