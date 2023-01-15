# Drawing Lines 2D

This project contains various utility tools for Unity.

## Main features

### Require components utils

It allow to throw a precise error when a component is not set inside a class, in the Start method for instance.

One of the method allow to assign it aswell.


### UI Toolkit

The library provide a set of extensions to require an element inside of a UI Document, and to throw an explicit error if it is not present.

Since, as you may know, the extension provided by Unity will return null if the VisualElement is not present in the document.

```csharp
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
```

## Running the project

To run the project, open the example main scene, you can then remove components to see if an exception is thrown, for instance.

## Importing the project

You can add this package as a git url : 
- "https://github.com/isirode/UnityUtils.git?path=/Assets/Isirode/UnityUtils#VERSION".

Replace "VERSION" by the version you want, such as "https://github.com/isirode/UnityUtils.git?path=/Assets/Isirode/UnityUtils#0.0.1", for instance.

The project will be added to your "Packages" folder, the scenes will be read-only, if you want to open them, just copy them in your Assets folder and they will be usable.

### Dependencies

It require :
* UI Toolkit (from Unity)

## Know issues

Nothing yet here.

## Partipating

Open the [DEVELOPER.md](./DEVELOPER.md) section.

## License

It is provided with the GNU LESSER GENERAL PUBLIC LICENSE.

UnityUtils is a library containing various utility tools for Unity.
Copyright (C) 2023  Isirode

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.
