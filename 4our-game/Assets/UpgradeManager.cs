using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager Instance;
    internal int damage;
    [SerializeField] private PlayerUpgrade playerStats;
    [SerializeField] private Button damageButton;
    [SerializeField] private Button healthButton;
    [SerializeField] private Button speedButton;

    public int baseDamage = 10;
    public int damageBonus = 0;

    public int TotalBulletDamage => baseDamage + damageBonus;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    void Start()
    {
        damageButton.onClick.AddListener(() => playerStats.UpgradeDamage());
        healthButton.onClick.AddListener(() => playerStats.UpgradeHealth());
        speedButton.onClick.AddListener(() => playerStats.UpgradeMovementSpeed());
    }


}
