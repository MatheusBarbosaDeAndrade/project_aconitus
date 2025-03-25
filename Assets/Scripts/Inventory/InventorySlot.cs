using UnityEngine;


// CLASSE QUE REPRESENTA APENAS 1 SLOT
[System.Serializable]
public class InventorySlot
{
    //PEGA O ITEM DO SCRIPTABLE OBJECT E A QUANTIDADE DELE PARA ACUMULAR SE NECESSÁRIO.
    public ItemData item;
    public int quantityItem;

    public InventorySlot(ItemData newItem, int newQuantityItem)
    {
        item = newItem;
        quantityItem = newQuantityItem;
    }
}
