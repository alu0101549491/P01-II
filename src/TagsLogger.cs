using UnityEngine;

public class TagsLogger : MonoBehaviour
{
    private string[] tagsToSearch = 
    { 
        "Capsule", 
        "Rectangular Prism", 
        "Sphere", 
        "Car", 
        "MainCamera", 
        "Player" 
    };

    void Start()
    {
        foreach (string tag in tagsToSearch)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);

            foreach (GameObject obj in objects)
            {
                Debug.Log("(Tag: " + tag + ") at position " + obj.transform.position);
            }
        }
    }
}
