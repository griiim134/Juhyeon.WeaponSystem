using UnityEngine;
using UnityEngine.UI;

namespace Juhyeon.Weapon.System
{
    public class EquipmentUIController : MonoBehaviour
    {
        [SerializeField] private Image _mainWeaponImage;
        [SerializeField] private Image _subWeaponImage;

        public void DrawSlotImage(in Weapon mainWeapon, in Weapon subWeapon)
        {
            _mainWeaponImage.sprite = mainWeapon.Definition.Icon;
            _subWeaponImage.sprite = subWeapon.Definition.Icon;
        }
    }
}
