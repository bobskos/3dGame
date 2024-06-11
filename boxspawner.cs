using UnityEngine;
public class boxspawner : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(myPrefab, new Vector3(0, 5, 0), Quaternion.identity);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightShift))
        {
            Instantiate(myPrefab, new Vector3(0, 5, 0), Quaternion.identity);
        }
    }
}