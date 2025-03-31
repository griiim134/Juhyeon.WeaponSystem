using UnityEngine;

namespace Juhyeon.Weapon.System
{
    public enum EWeaponCategory
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
    public class WeaponDefinition : ScriptableObject
    {
        [SerializeField] private int _id;
        [SerializeField] private string _name;
        [SerializeField] private EWeaponCategory _category;
        [SerializeField] private EWeaponProp _prop;
        [SerializeField] private ERangeType _rangeType;
        [SerializeField] private float _range;
        [SerializeField] private GameObject _prefab;

        public int ID => _id;
        public string Name => _name;
        public EWeaponCategory Category => _category;
        public EWeaponProp Prop => _prop;
        public ERangeType RangeType => _rangeType;
        public float Range => _range;
        public GameObject Prefab => _prefab;
    }
}
