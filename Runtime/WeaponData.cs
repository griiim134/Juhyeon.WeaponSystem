using UnityEngine;

namespace Weapon
{
    public enum EWeaponType
    {
        Both, Main, Sub
    };

    public enum EWeaponProp
    {
        Normal
    };

    public enum ERangeType
    {
        Melee, // 근거리
        Ranged // 원거리
    };

    [CreateAssetMenu(fileName = "WeaponData", menuName = "Scriptable Objects/WeaponData")]
    public class WeaponData : ScriptableObject
    {
        [SerializeField] private int _weaponID;
        [SerializeField] private string _weaponName;
        [SerializeField] private EWeaponType _weaponType;
        [SerializeField] private EWeaponProp _weaponProp;
        [SerializeField] private ERangeType _rangeType;
        [SerializeField] private float _range;
        [SerializeField] private int _weaponATK;
        [SerializeField] private int _weaponSPD;
        [SerializeField] [Range(0, 1)] private float _weaponCTR;
        [SerializeField] private GameObject _weaponPrefab;

        public int GetWeaponID() => _weaponID;
        public string GetWeaponName() => _weaponName;
        public EWeaponType GetWeaponType() => _weaponType;
        public EWeaponProp GetWeaponProp() => _weaponProp;
        public ERangeType GetRangeType() => _rangeType;
        public float GetRange() => _range;
        public int GetATK() => _weaponATK;
        public int GetSPD() => _weaponSPD;
        public float GetCTR() => _weaponCTR;
        public GameObject GetWeaponPrefab() => _weaponPrefab;
    }
}
