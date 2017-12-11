using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{

    public GameObject[] TreeArray;
    public Canvas MainCanvas = null;

    private float fTimer;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Timer storing the Time.time value
        fTimer = Time.time;
        // checking if the timer is actually counting
        Debug.Log(fTimer);


        // spawn a tree every 2 seconds.
        if (fTimer % 2.0f == 0)
        {
            SpawnTree();
        }
    }

    // function to spawn a tree in a random location.
    void SpawnTree()
    {
        int Selector = Random.Range(0, TreeArray.Length);
        Instantiate(TreeArray[Selector], new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), 0), Quaternion.identity, MainCanvas.transform);
        
    }
}
