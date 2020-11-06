using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]

public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public TabGroup TabGroup;

    public Image background;

    public UnityEvent onTabSelected;
    public UnityEvent onTabDeselected;

    public void OnPointerClick(PointerEventData eventData)
    {
        TabGroup.TabSelected(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        TabGroup.TabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TabGroup.TabExit(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Image>();
        TabGroup.MenuButtons(this);
    }

   
    public void Select()
    {
        if(onTabSelected != null)
        {
            onTabSelected.Invoke();
        }
    }
   
   public void Deselect()
    {
        if (onTabDeselected != null)
        {
            onTabDeselected.Invoke();
              }
    }


}
