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

        public Weapon EquipWeapon(in Weapon weapon, in EWeaponCategory targetCategory)
        {
            Debug.Assert(targetCategory != EWeaponCategory.Both, "wrong input(category) : EquipmentCaomponent.EquipWeapon");
            Weapon heldedWeapon = HeldedWeapon(targetCategory);
            if (weapon.Category == EWeaponCategory.Both || weapon.Category == targetCategory)
            {
                _slot[ChangeToIndex(targetCategory)] = weapon;
                return heldedWeapon;
            }
            return null;
        }

        public ESetIndex GetCurrentSet() => _currentIndex;

        public Weapon HeldedWeapon(in EWeaponCategory targetCategory)
        {
            Debug.Assert(targetCategory != EWeaponCategory.Both, "wrong input(category) : EquipmentCaomponent.HeldedWeapon");
            return _slot[ChangeToIndex(targetCategory)];
        }

        public void SwapSet()
        {
            _currentIndex = (_currentIndex == ESetIndex.FirstSet ? ESetIndex.SecondSet : ESetIndex.FirstSet);
        }

        public Weapon UnequipWeapon(in EWeaponCategory targetCategory)
        {
            Debug.Assert(targetCategory != EWeaponCategory.Both, "wrong input(category) : EquipmentCaomponent.UnequipWeapon");
            Weapon heldedWeapon = HeldedWeapon(targetCategory);
            _slot[ChangeToIndex(targetCategory)] = null;
            return heldedWeapon;
        }

        private int ChangeToIndex(in EWeaponCategory category)
        {
            return category == EWeaponCategory.Main ? (int)_currentIndex : (int)_currentIndex + 1;
        }
    }
