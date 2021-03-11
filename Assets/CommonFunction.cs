using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonFunction : MonoBehaviour
{
    /// <summary>
    /// GetComponent in parent,children,self
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="gameObject"></param>
    /// <example>
    /// MonobitView monovitView = CommonFunction.GetComponentInTree<MonobitView>( this.gameObject );
    /// </example>
    /// <returns>T</returns>

    public static  T GetComponentInTree<T>(GameObject gameObject) where T : Component
    {

        T val = default(T);
        // すべての親オブジェクトに対して MonobitView コンポーネントを検索する
        val = gameObject.GetComponentInParent<T>();
        if (val != null)
        {
            return val;
        }
        // 親オブジェクトに存在しない場合、すべての子オブジェクトに対してコンポーネントを検索する
        else
        {
            val = gameObject.GetComponentInChildren<T>();
            if (val != null)
            {
                return val;
            }
            else
            {
                return gameObject.GetComponent<T>();
            }
        }
    }

    public static T GetComponentInObject<T>(string objectName)
    {
        T c = default(T);
        GameObject gameObject = GameObject.Find(objectName);
        if (gameObject == null)
        {
            Debug.LogError(objectName + " is not found");
        }
        else
        {
            c = gameObject.GetComponent<T>();
            if (c == null)
            {
                Debug.LogError(nameof(T) + " is not found");
            }
        }
        return c;
    }
}

}
