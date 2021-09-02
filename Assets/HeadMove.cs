using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HeadMove : MonoBehaviour
{
    public GameObject forwardPos;
    Transform startPos;
    private bool isHit;

    private void Start()
    {
        
        startPos = gameObject.transform;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&!isHit)
        {
            isHit = true;
            Vector2 backPos = new Vector2(Random.Range(-7, 0), 0);
            gameObject.transform.DOMove(forwardPos.transform.position, 1f).OnComplete(()=>
            gameObject.transform.DOMove(backPos,0.5f).OnComplete(()=>
            gameObject.transform.DOMove(new Vector2(0,0), 2f).OnComplete(() =>isHit = false))
            );
            Debug.Log(backPos);

        }
    }
    
}
