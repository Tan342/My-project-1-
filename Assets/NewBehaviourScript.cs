using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] GameObject p;
    [SerializeField] ScrollRect scrollRect;
    [SerializeField] RectTransform content;

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 7; i++)
        {
            
            Transform a = Instantiate(p, transform).transform;
            if (i == 4)
            {
                ScrollTo(a);
            }
        }
        
    }


    void ScrollTo(Transform target)
    {
        Canvas.ForceUpdateCanvases();
        content.anchoredPosition = (Vector2)scrollRect.transform.InverseTransformPoint(content.position) - (Vector2)scrollRect.transform.InverseTransformPoint(target.position);
    }

}
