using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{ 
    LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        // get linerender
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            //创建射线对象，从屏幕发出的射线，参数：鼠标在屏幕的位置
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //判断射线是否产生碰撞，最远距离是100
            if(Physics.Raycast(ray,out hit, 100f))
            {
                //开启射线的显示
                lineRenderer.enabled = true;
                //设置射线的结束位置，参数1就是前面提到的结束位置
                lineRenderer.SetPosition(1, hit.point);
				//消除射线碰撞的物体
				DestroyImmediate(hit.collider.gameObject);
            }
            else
            {
                //射线没有碰撞物体，就关闭射线的显示
                lineRenderer.enabled = false;
            }
        }
    }
}
