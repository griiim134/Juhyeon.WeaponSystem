using UnityEngine;

namespace Juhyeon.Weapon.System
{
    public enum ESetIndex
    {
        FirstSet = 0, SecondSet = 2
    };

    public class EquipmentComponent : MonoBehaviour, IEquipmentComponent
    {
        private Weapon[] _slot = new Weapon[4];
        private ESetIndex _currentIndex = ESetIndex.FirstSet;

        public void Equip(in Weapon weapon, in EWeaponCategory targetCategory)
        {
            Debug.Assert(targetCategory != EWeaponCategory.Both, "wrong input(category) : EquipmentCaomponent.EquipWeapon");
            if (weapon.Category == EWeaponCategory.Both || weapon.Category == targetCategory)
            {
                _slot[ChangeToIndex(targetCategory)] = weapon;
            }
        }

        public Weapon HasWeapon(in EWeaponCategory targetCategory)
        {
            Debug.Assert(targetCategory != EWeaponCategory.Both, "wrong input(category) : EquipmentCaomponent.HeldedWeapon");
            return _slot[ChangeToIndex(targetCategory)];
        }

        public void Swap()
        {
            _currentIndex = (_currentIndex == ESetIndex.FirstSet ? ESetIndex.SecondSet : ESetIndex.FirstSet);
        }

        public void Unequip(in EWeaponCategory targetCategory)
        {
            Debug.Assert(targetCategory != EWeaponCategory.Both, "wrong input(category) : EquipmentCaomponent.UnequipWeapon");
            _slot[ChangeToIndex(targetCategory)] = null;
        }

        private int ChangeToIndex(in EWeaponCategory category)
        {
            return category == EWeaponCategory.Main ? (int)_currentIndex : (int)_currentIndex + 1;
        }
    }
}
