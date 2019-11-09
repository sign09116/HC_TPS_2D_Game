using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 6, b = 2, c = 1, d = 5;
    public int score = 50;
    public int num1 = 10, num2 = 50;
    public bool boolA = true, boolB = true;

    // Start is called before the first frame update
    void Start()
    {
        #region 數學運算子
        //數學運算子
        // print(a + b);
        // print(a * b);
        // print(a / b);
        // print(a - b);
        //餘數  
        // print(a % b);
        //先輸出在執行遞增
        // print(c++);
        //先遞增在執行輸出 (其餘同理)  
        // print(++d);
        //指定運算 左=右邊運算得結果
        //score= score+10;
        //score += 10;//(結果同上)
        //print(6 / 2 * (2 + 1));
        // print(num1 > num2);
        // print(num1 >= num2);
        // print(num1 < num2);
        // print(num1 <= num2);
        // print(num1 == num2);
        // print(num1 != num2);
        #endregion
    }
    #region 邏輯運算子
    //並且 &&
    //或者 ||
    //相反 !
    // print(boolAboolB);
    //print(boolA||boolB);



    #endregion
    // Update is called once per frame
    void Update()
    {

    }
}
