using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    private float destroyTimer = 3f; 
    // Start is called before the first frame update
    void Start()
    {
         Destroy(gameObject,destroyTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()// هي عبارة عن دالة تستخدم في استشعار نقرة الماوس ومن ممكن وضع شرط بعدد نقرات مرادة لتدمير العنصر
    {
        TargetObjScript.score+=2;// زيادة على قيمة متغير سكور بواحد
        
        Destroy(gameObject);// تدمير العنصر عليه سكربت 
        if (TargetObjScript.score>=14)//هنا شرط اذا كانت قيمة سكور اكبر من 10 ينفذ الكودالموجود بداخل 
        {
            TargetObjScript.win = true;// تصبح قيمة متغير الذي قمنا بتعرفه في كلاس اخر وهو حالته ياخد اما صح او خطا
            print("you win");
        }

     }
}
