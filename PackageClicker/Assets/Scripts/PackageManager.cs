using TMPro;
using UnityEngine;
using DG.Tweening;
using System.Numerics;
using System.Net;

public class PackageManager : MonoBehaviour
{
    public static PackageManager instance;

    public GameObject MainGameCanvas;

    [SerializeField] private GameObject _upgradeCanvas;
    [SerializeField] private TextMeshProUGUI _packageCountText;
    [SerializeField] private TextMeshProUGUI _packagesPerSecondText;
    [SerializeField] private GameObject _packageObj;
    public GameObject PackageTextPopup;
    [SerializeField] private GameObject _backgroundObj;

    [Space]
    public PackageUpgrade[] PackageUpgrades;
    [SerializeField] private GameObject _upgradeUIToSpawn;
    [SerializeField] private Transform _upgradeUIParent;
    public GameObject PackagesPerSecondObjToSpawn;

    public double CurrentPackageCount { get; set; }
    public double CurrentPackagesPerSecond { get; set; }

    // upgrades
    public double PackagesPerClickUpgrade { get; set; }

    private InitializeUpgrades _initializeUpgrades;
    private PackageDisplay _packageDisplay;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        _packageDisplay = GetComponent<PackageDisplay>();

        UpdatePackageUI();
        UpdatePackagesPerSecondUI();

        _upgradeCanvas.SetActive(false);
        MainGameCanvas.SetActive(true);

        _initializeUpgrades = GetComponent<InitializeUpgrades>();
        _initializeUpgrades.Initialize(PackageUpgrades, _upgradeUIToSpawn, _upgradeUIParent);
    }

    #region On Package Clicked

    public void OnPackageClicked()
    {
        IncreasePackage();

        _packageObj.transform.DOBlendableScaleBy(new UnityEngine.Vector3(0.05f, 0.05f, 0.05f), 0.05f).OnComplete(CookieScaleBack);
        _backgroundObj.transform.DOBlendableScaleBy(new UnityEngine.Vector3(0.05f, 0.05f, 0.05f), 0.05f).OnComplete(BackgroundScaleBack);

        PopupText.Create(1 + PackagesPerClickUpgrade);
    }

    public void IncreasePackage()
    {
        CurrentPackageCount += 1 + PackagesPerClickUpgrade;
        UpdatePackageUI();
    }

    private void CookieScaleBack()
    {
        _packageObj.transform.DOBlendableScaleBy(new UnityEngine.Vector3(-0.05f, -0.05f, -0.05f), 0.05f);
    }

    private void BackgroundScaleBack()
    {
        _backgroundObj.transform.DOBlendableScaleBy(new UnityEngine.Vector3(-0.05f, -0.05f, -0.05f), 0.05f);
    }

    #endregion

    #region UI Updates

    private void UpdatePackageUI()
    {
        //_packageCountText.text = CurrentPackageCount.ToString();
        _packageDisplay.UpdatePackageCount(CurrentPackageCount, _packageCountText);
    }

    private void UpdatePackagesPerSecondUI()
    {
        //_packagesPerSecondText.text = CurrentPackagesPerSecond.ToString() + "P/S";
        _packageDisplay.UpdatePackageCount(CurrentPackagesPerSecond, _packagesPerSecondText, " P/S");
    }

    #endregion

    #region Button Presses

    public void OnUpgradeButtonPress()
    {
        MainGameCanvas.SetActive(false);
        _upgradeCanvas.SetActive(true);
    }

    public void OnResumeButtonPress()
    {
        _upgradeCanvas.SetActive(false);
        MainGameCanvas.SetActive(true);
    }

    #endregion

    #region Simple Increases

    public void SimplePackageIncrease(double amount)
    {
        CurrentPackageCount += amount;
        UpdatePackageUI();
    }

    public void SimplePackagePerSecondIncrease(double amount)
    {
        CurrentPackagesPerSecond += amount;
        UpdatePackagesPerSecondUI();
    }

    #endregion

    #region Events

    public void OnUpgradeButtonClick(PackageUpgrade upgrade, UpgradeButtonReferences buttonRef)
    {
        if (CurrentPackageCount >= upgrade.CurrentUpgradeCost)
        {
            upgrade.ApplyUpgrade();

            CurrentPackageCount -= upgrade.CurrentUpgradeCost;

            UpdatePackageUI();

            upgrade.CurrentUpgradeCost = Mathf.Round((float)(upgrade.CurrentUpgradeCost * (1 + upgrade.CostIncreaseMultiplierPerPurchase)));

            buttonRef.UpgradeCostText.text = "Cost: " + upgrade.CurrentUpgradeCost;
        }
    }

    #endregion
}
