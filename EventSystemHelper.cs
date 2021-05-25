using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(EventSystem))]
public class EventSystemHelper : MonoBehaviour {

    static EventSystem ES;
    static GameObject cacheObject;

    private void Awake() {
        ES = GetComponent<EventSystem>();
    }

    private void Update() {

        // Set cache object
        if (ES.currentSelectedGameObject != null && ES.currentSelectedGameObject != cacheObject) {
            cacheObject = ES.currentSelectedGameObject;
        }

        // Automatically select cache object if nothing is selected
        else if (cacheObject != null && ES.currentSelectedGameObject == null) {
            ES.SetSelectedGameObject(cacheObject);
        }

    }

    // Call from outside to override selected object
    public static void SetSelectedObject(GameObject go) {
        if(ES)
            cacheObject = go;
    }

}
