using UnityEngine;
using UnityEngine.UI;

namespace Juhyeon.Weapon.System
{
    public class WeaponManager : MonoBehaviour
    {
        public WeaponDB DB;

        #region Test
        public Button mainEquip;
        public Button subEquip;
        public Button mainUnequip;
        public Button subUnequip;
        public Button swap;
        public Button generate;

        public EquipmentComponent slot;
        public Weapon weapon;
        public EquipmentUIController ui;

        private void Start()
        {
            mainEquip.onClick.AddListener(OnEquipMain);
            subEquip.onClick.AddListener(OnEquipSub);
            mainUnequip.onClick.AddListener(OnUnequipMain);
            subUnequip.onClick.AddListener(OnUnequipSub);
            swap.onClick.AddListener(OnSwap);
            generate.onClick.AddListener(OnGenerate);
        }

        private void Update()
        {
            ui.DrawSlotImage(slot.HasWeapon(EWeaponCategory.Main), slot.HasWeapon(EWeaponCategory.Sub));
        }

        public void OnEquipMain()
        {
            Debug.Log($"Equip main weapon {weapon.Definition.ID}");
            slot.Equip(weapon, EWeaponCategory.Main);
        }

        public void OnEquipSub()
        {
            Debug.Log($"Equip sub weapon {weapon.Definition.ID}");
            slot.Equip(weapon, EWeaponCategory.Sub);
        }

        public void OnUnequipMain()
        {
            slot.Unequip(null, EWeaponCategory.Main);
        }

        public void OnUnequipSub()
        {
            slot.Unequip(null, EWeaponCategory.Sub);
        }

        public void OnGenerate()
        {
            int random = Random.Range(0, 4);
            int id = 1;
            switch (random)
            {
                case 0: id = 1; break;
                case 1: id = 3; break;
                case 2: id = 9; break;
                case 3: id = 14; break;
            }
            Weapon weapon = CreateWeapon(id);
            Debug.Log($"Generate weapon {weapon.Definition.ID}");
            
        }

        public void OnSwap()
        {
            slot.Swap();
        }
        #endregion

        public Weapon CreateWeapon(int id, Transform parent = null)
        {
            WeaponDefinition data = DB.GetWeaponData(id);

            if (data == null)
            {
                return null;
            }
            GameObject newWeapon = Instantiate(data.Prefab, parent);
            Weapon weapon = newWeapon.GetComponent<Weapon>();
            if (weapon == null)
            {
                weapon = newWeapon.AddComponent<Weapon>();
            }
            weapon.SetData(data);
            return weapon;
        }
    }
}
