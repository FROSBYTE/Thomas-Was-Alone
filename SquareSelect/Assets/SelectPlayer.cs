using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SelectPlayer : MonoBehaviour
{
    private string Layer = "Player";
    private int index = 0;
    private ChangePlayer parent;
    public UnityEvent onPlayerSelected;
    // Start is called before the first frame update
    void Start()
    {
      parent=transform.parent.GetComponent<ChangePlayer>();
        onPlayerSelected.AddListener(delegate
        {
            parent.player(index);
        });
    }

    private void OnMouseDown()
    {
        Debug.Log("gameobject clicked:"+ gameObject.name+" index:"+index);
        onPlayerSelected?.Invoke();
    }
    public void changeIndex(int value)
    {
        index = value;
    }
    
    

}
