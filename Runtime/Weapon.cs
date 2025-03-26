using UnityEngine;

namespace Weapon
{

    public class Weapon : MonoBehaviour
    {
        [SerializeField] private WeaponData _data;

        public void SetData(in WeaponData data)
        {
            _data = data;
        }

        public int GetWeaponID() => _data.GetWeaponID();
        public string GetWeaponName() => _data.GetWeaponName();
        public EWeaponType GetWeaponType() => _data.GetWeaponType();
        public EWeaponProp GetWeaponProp() => _data.GetWeaponProp();
        public ERangeType GetRangeType() => _data.GetRangeType();
        public float GetRange() => _data.GetRange();
        public int GetATK() => _data.GetATK();
        public int GetSPD() => _data.GetSPD();
        public float GetCTR() => _data.GetCTR();
        public GameObject GetPrefab() => _data.GetWeaponPrefab();
    }
}
