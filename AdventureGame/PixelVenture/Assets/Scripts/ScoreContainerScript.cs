using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreContainerScript : MonoBehaviour
{
    public SimpleIntData scoreData;

    public void AddPoint(int amount)
    {
        scoreData.UpdateValue(amount);
    }
}
