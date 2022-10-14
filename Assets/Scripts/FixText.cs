using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FixText : MonoBehaviour
{

    public TMP_Text narrativeText;

    public void RemoveR()
    {
        narrativeText.text = narrativeText.text.Replace("\r", "");
    }

}
