using UnityEngine;
using UnityEngine.UI;


public class InventoryUI : MonoBehaviour
{
    // Referência ao sistema de inventário
    public InventorySystem inventory;

    // Referência ao painel onde os slots de inventário serão exibidos
    public Transform slotParent;

    // Prefab que representa um slot de inventário na UI
    public GameObject slotPrefab;

    // Ao iniciar, atualiza a interface do inventário
    void Start()
    {
        InitializeSlots(); // Inicializa os slots na interface
        UpdateUI(); // Atualiza a interface com os dados atuais do inventário
    }

    // Inicializa os slots, criando-os uma vez
    void InitializeSlots()
    {
        // Se não houver slots criados, cria os slots de UI para o inventário
        if (slotParent.childCount == 0)
        {
            for (int i = 0; i < 9; i++)
            {
                // Cria os slots e os posiciona na interface
                GameObject newSlot = Instantiate(slotPrefab, slotParent);
                newSlot.name = "Slot " + i;  // Define um nome único para cada slot
            }
        }
    }

    // Atualiza a interface do inventário
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

                    // Verifica se o índice do slot é válido no inventário
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
                        // Se não houver item para esse slot, limpa a interface
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
                    Debug.LogError("ItemIcon ou QuantityItemText não encontrados no ItemBackground.");
                }
            }
            else
            {
                Debug.LogError("ItemBackground não encontrado no slot.");
            }
        }
    }

}
