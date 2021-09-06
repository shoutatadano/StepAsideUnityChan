using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Wall : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "CarTag")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "TrafficConeTag")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "CoinTag")
        {
            Destroy(other.gameObject);
        }
       
    }

}
