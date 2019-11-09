using UnityEngine;


public class Ground : MonoBehaviour
{
    #region  屬性
    // 宣告變數 (定義欄位 field)
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // private 私人(隱藏)，public 公開(顯示)
    // int 整數
    [Header("地板移動速度"), Range(1, 5)]
    public int speed = 1;
    [Header("地板位移元件")]
    public Transform _Ground;
    #endregion


    #region  事件
    private void Start()
    {
        print(_Ground.position);
    }
    private void Update()
    {
        GroundMove();
    }

    #endregion


    #region  方法
    //方法/函式 ,Method/function 語法
    //void 無回傳類型

    /// <summary>
    /// 地板的移動方法
    /// </summary>
    void GroundMove()
    {
        //transform.position += Vector3.left * speed*Time.deltaTime;
        //將地板往左移動(以世界座標)
        //_Ground.Translate(x,y,z);
        //_Ground.Translate(Vector3.方向*Time.deltaTime,座標方式)
        //每偵時間Time.deltaTime
        _Ground.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
    }
    #endregion
}
