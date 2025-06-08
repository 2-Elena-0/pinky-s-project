using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    public MapScript mp;
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button btn = root.Q<Button>("btn");

        btn.clicked += () => { mp.IsTowerBuilding = true; };
    }
}
