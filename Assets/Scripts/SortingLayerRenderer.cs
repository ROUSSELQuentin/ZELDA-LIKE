using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingLayerRenderer : MonoBehaviour {

    [SerializeField] int sortingOrderBase = 5000;
    [SerializeField] float offset = 0;

    private SpriteRenderer sprRenderer;

    private void Start()
    {
        sprRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        sprRenderer.sortingOrder = (int)((sortingOrderBase - transform.position.z - offset) * 50);
    }
}
