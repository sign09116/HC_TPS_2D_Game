using UnityEngine;

public class Ground : MonoBehaviour
{
#region  屬性
// 宣告變數 (定義欄位 field)
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // private 私人(隱藏)，public 公開(顯示)
    // int 整數
    [Header("地板移動速度"),Range(1,5)]
    public int speed = 1;
#endregion
    
    
#region  事件
private void Update() {
transform.position += Vector3.left * speed*Time.deltaTime;
}
#endregion


#region  方法
#endregion
}
