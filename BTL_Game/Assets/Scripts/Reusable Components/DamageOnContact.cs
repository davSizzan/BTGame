using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
    [SerializeField] private string otherString;
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(otherString))
        {
            GenericHealth temp = collision.gameObject.GetComponent<GenericHealth>();
            if (temp)
            {
                temp.Damage(damage);
            }
            Destroy(this.gameObject);
        }
    }
}
