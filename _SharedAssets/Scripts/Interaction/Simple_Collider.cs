using UnityEngine;

namespace ON{

public class Simple_Collider : MonoBehaviour
{

    private void Update()
    {
        print("anything");
    }

    void OnCollisionEnter(Collision collision)
    {
        print("boom!");
        print(collision.gameObject.name);
        Destroy(collision.gameObject);
    }
}


}