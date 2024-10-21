using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class SimpleImageBehaviour : MonoBehaviour
{
    private Image imageObj;

    public SimpleFloatData dataObj;
    
    // Start is called before the first frame update
    private void Start()
    {
        imageObj = GetComponent<Image>();
    }

    // Update is called once per frame
     public void UpdateWithFloatData()
    {
        imageObj.fillAmount = dataObj.value;
    }
}
