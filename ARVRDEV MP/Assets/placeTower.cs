using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeTower : MonoBehaviour
{
    public Transform spawnpos;
    public GameObject[] spawnee;
    public Quaternion spawnRot;
    private float start = 0f;
    private float limit = 10f;
    private bool flag = true;
    RaycastHit hit;
    private Vector3 v3;
    // Update is called once per frame
    void Update()
    {
        if (start == 0)
        {
            start += Time.deltaTime;

        }
        else if (start == limit)
        {
            flag = false;
            Reset();
        }

    }

    public void Reset()
    {
        v3 = new Vector3(spawnpos.transform.position.x, spawnpos.transform.position.y, spawnpos.transform.position.z);

    }
}
