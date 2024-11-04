using UnityEngine;
using TMPro;
using System.Globalization;

[RequireComponent(typeof(TextMeshPro))]
public class SimpleTextMeshProBehaviour : MonoBehaviour
{
    private TextMeshProUGUI textObj;

    public SimpleIntData dataObj;
    
    // Start is called before the first frame update
    private void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void UpdateWithIntData()
    {
        textObj.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}