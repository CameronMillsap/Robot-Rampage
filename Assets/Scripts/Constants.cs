using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour
{
    //Scenes
    public const string SceneBattle = "Battle";
    public const string SceneMenu = "MainMenu";

    //Gun Types
    public const string Pistol = "Pistol";
    public const string Shotgun = "Shotgun";
    public const string AssaultRifle = "AssaultRifle";

    //Robot Types
    public const string RedRobot = "RedRobot";
    public const string BlueRobot = "BlueRobot";
    public const string YellowRobot = "YellowRobot";

    //Pickup Types
    public const int PickUpPistolAmmo = 1;
    public const int PickupAssaultRifleAmmo = 2;
    public const int PickupShotgunAmmo = 3;
    public const int PickupHealth = 4;
    public const int PickupArmor = 5;

    //Misc
    public const string Game = "Game";
    public const float CameraDefaultZoom = 60f;

    public static readonly int[] AllPickupTypes = new int[5]
    {
        PickUpPistolAmmo,
        PickupAssaultRifleAmmo,
        PickupShotgunAmmo,
        PickupHealth,
        PickupArmor
    };
}
