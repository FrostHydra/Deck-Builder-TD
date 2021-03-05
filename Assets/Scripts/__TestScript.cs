using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class __TestScript : MonoBehaviour
{
    public WaveManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = this.gameObject.GetComponent<WaveManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            manager.SpawnWave(1);
        }
    }
}
