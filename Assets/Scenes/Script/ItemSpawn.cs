using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawnItem;
    public void Spawn(Transform spawnPosition)
    {
        for(int i=0; i < spawnItem.Length; i++)
        {
            Instantiate(spawnItem[i],spawnPosition);
        }
    }
}
