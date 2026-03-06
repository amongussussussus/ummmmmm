using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI[] scoreText;
    [SerializeField]
    int[] scoreValue;
    public void AddScore(int i)
    {
        scoreValue[i]++;
        scoreText[i].text = scoreValue[i].ToString();
    }
}
