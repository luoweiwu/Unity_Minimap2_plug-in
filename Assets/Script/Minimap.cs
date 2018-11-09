using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour {

    //单例模式
    public static Minimap _instance;
    public GameObject iconPrefab;

    void Awake()
    {
        _instance = this;
    }

    public GameObject AddIcon(string iconname)
    {
        GameObject go = NGUITools.AddChild(this.gameObject,iconPrefab);
        //设置图标的名字，更新图标的显示
        go.GetComponent<UISprite>().spriteName=iconname;

        //把创建出来的图标返回出来
        return go;
    }
}
