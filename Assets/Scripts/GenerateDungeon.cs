using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateDungeon : MonoBehaviour
{
    public GameObject[] rooms;
    public int[] directions;
    public GameObject[][] dgs;
    public GameObject start;
    private Vector3 pos;
    private int signal;
    private bool isX;

    void Start()
    {
        start = GameObject.Find("start");
        dgs = new GameObject[4][];
        directions = new int[4];
        for (int i = 0; i < 4; i++)
        {
            directions[i] = Random.Range(1, 4);
            dgs[i] = new GameObject[directions[i]];
            isX = i % 2 != 0;
            signal = (i < 2) ? 1 : -1;

            for(int j = 0; j < directions[i]; j++)
            {
                dgs[i][j] = rooms[i];
                pos = (isX) ? new Vector3((1.1f + (1.1f * j)) * signal, 0 ) : new Vector3(0, (1.1f + (1.1f * j)) * signal);
                Instantiate(dgs[i][j], start.transform.position + pos, Quaternion.identity);
            }
        }
    }
    
    void Update()
    {
        
    }
}
