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

        public bool IsValid => _data != null;
        public bool IsNotValid => !IsValid;
        public WeaponDefinition Definition => _data;
    }
}
