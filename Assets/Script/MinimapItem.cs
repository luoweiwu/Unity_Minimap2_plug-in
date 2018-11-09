using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapItem : MonoBehaviour {

    public string iconName;
    private GameObject minimapIconGo;
    private Transform iconTrans;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        minimapIconGo = Minimap._instance.AddIcon(iconName);
        iconTrans = minimapIconGo.transform;
    }

    private void FixedUpdate()
    {
        Vector3 offset = transform.position - player.position;
        iconTrans.localPosition = new Vector3(offset.x, offset.z, 0)*5;
    }

    void OnDestroy()
    {
        Destroy(this.minimapIconGo);    
    }

}
