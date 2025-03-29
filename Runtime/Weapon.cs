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

        public int ID => _data.ID;
        public string Name => _data.Name;
        public EWeaponCategory Category => _data.Category;
        public EWeaponProp Prop => _data.Prop;
        public ERangeType RangeType => _data.RangeType;
        public float Range => _data.Range;
        public GameObject Prefab => _data.Prefab;
    }
}
