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
        public Text text;

        public EquipmentComponent slot;
        public Weapon weapon;

        private void Start()
        {
            mainEquip.onClick.AddListener(OnEquipMain);
            subEquip.onClick.AddListener(OnEquipSub);
            mainUnequip.onClick.AddListener(OnUnequipMain);
            subUnequip.onClick.AddListener(OnUnequipSub);
            swap.onClick.AddListener(slot.SwapSet);
            generate.onClick.AddListener(OnGenerate);
        }

        private void Update()
        {
            var main = slot.HeldedWeapon(EWeaponCategory.Main);
            var sub = slot.HeldedWeapon(EWeaponCategory.Sub);
            int mainId = 0, subId = 0;

            if (main)
                mainId = main.ID;
            if (sub)
                subId = sub.ID;
            text.text = $"{(slot.GetCurrentSet() == ESetIndex.FirstSet ? 1 : 2)}\nSlot : Main : {mainId}\nSub : {subId}";
        }

        public void OnEquipMain()
        {
            Debug.Log($"Equip main weapon {weapon.ID}");
            slot.EquipWeapon(weapon, EWeaponCategory.Main);
        }

        public void OnEquipSub()
        {
            Debug.Log($"Equip sub weapon {weapon.ID}");
            slot.EquipWeapon(weapon, EWeaponCategory.Sub);
        }

        public void OnUnequipMain()
        {
            var weapon = slot.UnequipWeapon(EWeaponCategory.Main);
            if (weapon)
                Debug.Log($"Unequip main weapon {weapon.ID}");
        }

        public void OnUnequipSub()
        {
            var weapon = slot.UnequipWeapon(EWeaponCategory.Sub);
            if (weapon)
                Debug.Log($"Unequip main weapon {weapon.ID}");
        }

        public void OnGenerate()
        {
            int id = Random.Range(1, 4);
            Weapon weapon = CreateWeapon(id);
            Debug.Log($"Generate weapon {weapon.ID}");
            
        }
        #endregion

        public Weapon CreateWeapon(int id, Transform parent = null)
        {
            WeaponData data = DB.GetWeaponData(id);

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
