using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
        //gameObject.transform.Translate(new Vector3(0, 20, 0) * Time.deltaTime);
        //gameObject.transform.Translate(new Vector3(0, -20, 0) * Time.deltaTime);
    }
}
