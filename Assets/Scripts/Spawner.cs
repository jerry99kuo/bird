using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab ;

    public float spwanRate = 1f ;
    public float minHeight = -1f ;
    public float maxHeight = 1f ;

    private void OnEnable() 
    {
        InvokeRepeating("Spawn" , spwanRate , spwanRate);
    }
    private void OnDisable() {
        CancelInvoke("Spawn");
    }
    private void Spawn() 
    {
        GameObject pipes = Instantiate(prefab , transform.position , Quaternion.identity) ;
        pipes.transform.position += Vector3.up * Random.Range(minHeight , maxHeight);

    }
}
