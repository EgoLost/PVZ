using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settext : MonoBehaviour
{
    [SerializeField]
    private LocalizedText text;
    [SerializeField]
    private LocalizedDropdown dropdown;

    public void LocalizedText()
    {
        text.Localize("Settings");
    }

    public void LocalizeDropdown()
    {
        var options = new List<string>() {"Very Low", "Low", "Medium", "High", "Very High", "Ultra"};
        dropdown.Localize(options);
    }
}
