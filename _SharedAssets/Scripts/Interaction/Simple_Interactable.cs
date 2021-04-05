using UnityEngine;

namespace ON{

public class Simple_Interactable : MonoBehaviour
{
    public virtual void OnRaycastHit(){
        print(this.gameObject.name + " was hit");
    }
}


}