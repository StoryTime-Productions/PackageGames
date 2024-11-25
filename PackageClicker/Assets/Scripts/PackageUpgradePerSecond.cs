using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Package Upgrade/Packages Per Second", fileName = "Packages Per Second")]
public class PackageUpgradePerSecond : PackageUpgrade
{
    public override void ApplyUpgrade()
    {
        GameObject go = Instantiate(PackageManager.instance.PackagesPerSecondObjToSpawn, Vector3.zero, Quaternion.identity);
        go.GetComponent<PackagePerSecondTimer>().PackagePerSecond = UpgradeAmount;

        PackageManager.instance.SimplePackagePerSecondIncrease(UpgradeAmount);
    }
}
