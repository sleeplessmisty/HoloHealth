using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject Cube;
    [SerializeField] int numberOfItems;
    [SerializeField] Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfItems; i++)
        {
            Vector3 position = new Vector3(Random.Range(-5f, 10f), Random.Range(0f, 2f), Random.Range(0f, 10f));
            Instantiate(Cube, position, Quaternion.identity, parent);
        }
    }
}
