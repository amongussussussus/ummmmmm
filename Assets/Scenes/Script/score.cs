using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    //This file contains functions that change and manage inventory item value.
    //Each item is distinguisable by their index value in the array.
    [SerializeField]
    TextMeshProUGUI[] scoreText;
    [SerializeField]
    int[] scoreValue;
    public void AddScore(int i)
    {
        //When this function is called, increase the value of the item with index value i by 1.
        scoreValue[i]++;
        scoreText[i].text = scoreValue[i].ToString();
    }
}
