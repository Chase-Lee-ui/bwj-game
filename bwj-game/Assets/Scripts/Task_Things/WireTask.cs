using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireTask : MonoBehaviour
{
    public List<Wire> _leftWires = new List<Wire>();
    public List<Wire> _rightWires = new List<Wire>();

    public Wire CurrentDraggedWire;
    public Wire CurrentHoveredWire;

    public bool IsTaskCompleted = false; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckTaskCompletion());
    }

    private IEnumerator CheckTaskCompletion()
    {
        while(!IsTaskCompleted)
        {
            int successfulWires = 0;
            for (int i = 0; i < _rightWires.Count; i++)
            {
                if (_rightWires[i].IsSuccess)
                {
                    successfulWires++;
                }
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
