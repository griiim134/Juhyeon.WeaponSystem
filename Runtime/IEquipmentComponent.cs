namespace Juhyeon.Weapon.System
{
    public interface IEquipmentComponent
    {
        /// <summary>
        /// 세트를 변경합니다.
        /// </summary>
        void Swap();

        /// <summary>
        /// 무기를 지정한 카테고리에 맞추어 장착합니다.
        /// 이때, 카테고리는 Main과 Sub만 유효합니다.
        /// </summary>
        /// <param name="weapon">장착할 무기를 지정합니다.</param>
        /// <param name="targetCategory">어느 카테고리에 장착할지 지정합니다.</param>
        /// <returns>원래 장착되어 있던 무기를 반환합니다. 장착되어 있지 않았다면 null을 반환합니다.</returns>
        Weapon Equip(in Weapon weapon, in EWeaponCategory targetCategory);

        /// <summary>
        /// 지정한 카테고리에 해당하는 무기를 장착 해제합니다.
        /// 이때, 카테고리는 Main과 Sub만 유효합니다.
        /// </summary>
        /// <param name="targetCategory">어느 카테고리에 장착 해제할지 지정합니다.</param>
        /// <returns>원래 장착되어 있던 무기를 반환합니다. 장착되어 있지 않았다면 null을 반환합니다.</returns>
        Weapon Unequip(in EWeaponCategory targetCategory);


        /// <summary>
        /// 지정한 카테고리에 장착된 무기가 무엇인지 알려줍니다.
        /// 이때, 카테고리는 Main과 Sub만 유효합니다.
        /// </summary>
        /// <param name="targetCategory">어느 카테고리의 무기인지 지정합니다.</param>
        /// <returns>장착되어 있는 무기를 반환합니다. 장착되어 있지 않다면 null을 반환합니다.</returns>
        Weapon HeldedWeapon(in EWeaponCategory targetCategory);
    }
}
