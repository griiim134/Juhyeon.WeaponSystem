using UnityEngine;

namespace Juhyeon.Weapon.System
{

    public class Weapon : MonoBehaviour
    {
        [SerializeField] private WeaponDefinition _data = null;

        public void SetData(in WeaponDefinition data)
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

        public bool IsValid => _data != null;
        public bool IsNotValid => !IsValid;
        public WeaponDefinition Definition => _data;
    }
}
