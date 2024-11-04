using UnityEngine;

//[CreateAssetMenu(menuName = "Single Variables/SimpleIntData")]
public class SimpleIntData : MonoBehaviour
{
    public float value;

    public void UpdateValue(int amount)
    {
        value += amount;
    }

    public void SetValue(int amount)
    {
        value = amount;
    }
}