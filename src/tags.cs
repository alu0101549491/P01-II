using UnityEngine;

public class tags : MonoBehaviour
{
    void Start()
    {
        PrintTaggedObjects(gameObject.transform);
    }

    void PrintTaggedObjects(Transform parent)
    {
        foreach (Transform child in parent)
        {
            if (child.gameObject.tag != "Untagged")
            {
                Debug.Log("(Tag: " + child.gameObject.tag + ") at position " + child.gameObject.transform.position);
            }
            PrintTaggedObjects(child);
        }
    }

    void Update()
    {
        
    }
}