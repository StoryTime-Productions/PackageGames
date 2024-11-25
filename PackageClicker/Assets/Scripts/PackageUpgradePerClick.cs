using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Package Upgrade/Packages Per Click", fileName = "Package Per Click")]
public class PackageUpgradePerClick : PackageUpgrade
{
    public override void ApplyUpgrade()
    {
        PackageManager.instance.PackagesPerClickUpgrade += UpgradeAmount;
    }
}
