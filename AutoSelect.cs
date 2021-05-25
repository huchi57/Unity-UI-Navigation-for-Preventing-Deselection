using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Selectable))]
public class AutoSelect : MonoBehaviour, IPointerEnterHandler {

    [SerializeField] bool autoSelect = true;
    Selectable selectable;

    private void Awake() {
        selectable = GetComponent<Selectable>();
    }

    public void OnPointerEnter(PointerEventData eventData) {
        if(autoSelect)
            selectable.Select();
    }

    public void Click() {
        print("clicked: " + Time.time);
    }

}