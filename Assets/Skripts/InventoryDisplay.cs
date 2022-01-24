using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplay : MonoBehaviour
{
    public void ShowOnly(string itemType) // функция фильтрации элементов по имени
    {
        for (int i = 0; i < transform.childCount; i++) // цикл по дочерним элементам компонента content
        {
            InventoryItemButton thisItem = transform.GetChild(i).GetComponent<InventoryItemButton>(); // получение доступа к компонентам
            thisItem.gameObject.SetActive(thisItem.name == itemType); // если имя компонента равно значению фильтра
        }
    }

    public void ShowAll()// функция просмотра всех элементов 
    {
        for (int i = 0; i < transform.childCount; i++) // цикл по дочерним элементам компонента content
        {
            transform.GetChild(i).gameObject.SetActive(true); // показать все элементы
        }
    }

    public void Search(InputField field) // функция поиска по имени в поисковой строке
    {
        if (field.text != "") // если строка не пустая
        {
            for (int i = 0; i < transform.childCount; i++)// цикл по дочерним элемента компонента content
            {
                InventoryItemButton thisItem = transform.GetChild(i).GetComponent<InventoryItemButton>();// получение доступа к компонентам
                thisItem.gameObject.SetActive(thisItem.name == field.text); // если введённое значение совпадает с именем элемента
            }
        }
        else ShowAll(); // иначе показать все элементы
    }
}
