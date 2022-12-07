using System.Collections;
using UnityEngine;

public class BonusHealth : MonoBehaviour
{
    public string collisionTag;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == collisionTag)
        {
            Unit unit = collision.gameObject.GetComponent<Unit>();
            unit.ReceiveHealing();
            Destroy(this.gameObject);
        }
    }

}
