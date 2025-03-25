using UnityEngine;
using UnityEngine.UI;


public class InventoryUI : MonoBehaviour
{
    // Refer�ncia ao sistema de invent�rio
    public InventorySystem inventory;

    // Refer�ncia ao painel onde os slots de invent�rio ser�o exibidos
    public Transform slotParent;

    // Prefab que representa um slot de invent�rio na UI
    public GameObject slotPrefab;

    // Ao iniciar, atualiza a interface do invent�rio
    void Start()
    {
        InitializeSlots(); // Inicializa os slots na interface
        UpdateUI(); // Atualiza a interface com os dados atuais do invent�rio
    }

    // Inicializa os slots, criando-os uma vez
    void InitializeSlots()
    {
        // Se n�o houver slots criados, cria os slots de UI para o invent�rio
        if (slotParent.childCount == 0)
        {
            for (int i = 0; i < 9; i++)
            {
                // Cria os slots e os posiciona na interface
                GameObject newSlot = Instantiate(slotPrefab, slotParent);
                newSlot.name = "Slot " + i;  // Define um nome �nico para cada slot
            }
        }
    }

    // Atualiza a interface do invent�rio
    public void UpdateUI()
    {
        // Para cada slot na interface, atualize a imagem e a quantidade
        for (int i = 0; i < slotParent.childCount; i++)
        {
            Transform slot = slotParent.GetChild(i);
            Transform itemBackground = slot.transform.Find("ItemBackground");

            if (itemBackground != null)
            {
                Transform itemIconTransform = itemBackground.transform.Find("ItemIcon");
                Transform quantityTextTransform = itemBackground.transform.Find("QuantityItemText");

                if (itemIconTransform != null && quantityTextTransform != null)
                {
                    Image icon = itemIconTransform.GetComponent<Image>();
                    Text quantityText = quantityTextTransform.GetComponent<Text>();

                    // Verifica se o �ndice do slot � v�lido no invent�rio
                    if (i < inventory.slots.Count)
                    {
                        InventorySlot inventorySlot = inventory.slots[i];

                        // Atualiza a imagem do item no slot
                        if (icon != null)
                        {
                            icon.sprite = inventorySlot.item?.itemIcon;
                        }

                        // Atualiza o texto da quantidade do item no slot
                        if (quantityText != null)
                        {
                            quantityText.text = inventorySlot.quantityItem > 0 ? inventorySlot.quantityItem.ToString() : "";
                        }
                    }
                    else
                    {
                        // Se n�o houver item para esse slot, limpa a interface
                        if (icon != null)
                        {
                            icon.sprite = null;
                        }
                        if (quantityText != null)
                        {
                            quantityText.text = "";
                        }
                    }
                }
                else
                {
                    Debug.LogError("ItemIcon ou QuantityItemText n�o encontrados no ItemBackground.");
                }
            }
            else
            {
                Debug.LogError("ItemBackground n�o encontrado no slot.");
            }
        }
    }

}
