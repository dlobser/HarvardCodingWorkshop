using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowPlantOnCollision : MonoBehaviour
{

    public GameObject plant;
    public string soil = "ground";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == soil)
        {
            GameObject p = Instantiate(plant, this.transform.position, Quaternion.identity);
            p.GetComponent<Animator>().SetTrigger("play");
            Destroy(this.gameObject);
        }
    }
}
