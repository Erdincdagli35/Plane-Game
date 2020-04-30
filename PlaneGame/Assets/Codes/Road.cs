using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Road : MonoBehaviour {

    public bool active;
    public GameObject[] objs;
	void Start () {
        float botNumber = Random.Range(0, 2);
        float topNumber = Random.Range(0, 2);
        if (botNumber == 1)
        {
            objs[1].SetActive(false);
        }
        else
        {
            objs[1].SetActive(true);
        }
        if (topNumber == 1)
        {
            objs[2].SetActive(false);
        }
        else
        {
            objs[2].SetActive(true);
        }
        if (topNumber == 1 && botNumber == 1)
        {
            objs[3].transform.localPosition = new Vector3(0, Random.Range(0.89f, -1.87f), 0);
            
        }
        objs[1].transform.localPosition = new Vector3(Random.Range(-3.48f, 4.45f), -3.27f, 0);
        objs[2].transform.localPosition = new Vector3(Random.Range(-3.48f, 4.45f), 2.38094f, 0);objs[3].SetActive(true);
        

    }
	
	// Update is called once per frame
	void Update () {
        if (active)
        {

            objs[3].SetActive(false);
            Invoke("HalfRoad",3);
            active = false;
        }
	}
    void HalfRoad()
    {   float botNumber = Random.Range(0, 2);
        float topNumber = Random.Range(0, 2);
        if (botNumber ==1)
        {
            objs[1].SetActive(false);
        }
        else
        {
            objs[1].SetActive(true);
        }
        if (topNumber == 1)
        {
            objs[2].SetActive(false);
        }
        else
        {
            objs[2].SetActive(true);
        }
        if (topNumber==1 && botNumber==1)
        {
            objs[3].transform.localPosition = new Vector3(0,Random.Range(0.89f,-1.87f),0);
           
        }
        transform.position = transform.position + new Vector3(40.19f, 0, 0);
        objs[1].transform.localPosition = new Vector3(Random.Range(-3.48f,4.45f), -3.27f,0);
        objs[2].transform.localPosition = new Vector3(Random.Range(-3.48f, 4.45f), 2.38094f, 0);
        objs[3].SetActive(true);
    }
    
}
