using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    [SerializeField]
    float velocity = 1;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        transform.position = transform.position + Vector3.right * Time.deltaTime * velocity;
    }
}
