
using UnityEngine;

public class Player : MonoBehaviour
{
#region  屬性
[Header("跳躍力道"),Range(10,100)]
public float JumpForce=10;
[Header("是否死亡"),Tooltip("是否死亡視為true，否為false")]
public bool isDead;

#endregion

#region  事件
 private void Update() 
 {
     if (Input.GetMouseButtonDown(0))
       
    {
    
    }
     
 }

#endregion

#region  方法
#endregion

}
