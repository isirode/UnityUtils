using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    public Logger logger;

    public UIDocument document;
    private VisualElement root;
    private VisualElement button;

    void Start()
    {
        RequireComponent.AssignIfNotSet(this, ref document);
        RequireComponent.RequireThrow(this, document);

        RequireComponent.RequireThrow(this, logger);

        root = document.rootVisualElement;

        button = root.QR<VisualElement>("my-button");

        button.RegisterCallback<PointerUpEvent>(DoSomething);
    }

    private void DoSomething(PointerUpEvent evt)
    {
        logger.DoLog(nameof(DoSomething));
    }
}
