 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciateMesh : MonoBehaviour
{
    public Transform pos;
    public GameObject[] objectToInitiate;
    public int element_number = 20;
    private Vector3 posVector3;
    private int count;
    public float lenghtTunnel = 16f;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(count);

        for (count = 0; count < element_number; count++)
        {
            InstantiateObject(count);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //MoveInstance();
    }

    private void InstantiateObject(int i)
    {

        int n = Random.Range(0, objectToInitiate.Length);
        GameObject g = Instantiate(objectToInitiate[n], new Vector3(transform.position.x, transform.position.y, transform.position.z + (lenghtTunnel* i*4)), objectToInitiate[n].transform.rotation);
        g.transform.parent = gameObject.transform;
        //g.transform.localScale = scale;
    }

    public void MoveInstance(int i)
    {
        transform.Translate(0, 0, Time.deltaTime);
    }

}