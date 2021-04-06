using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacteble : MonoBehaviour
{
    // Start is called before the first frame update
    private bool _isFocus;
    private PlayerCreature _player;
    private bool _hasInterected;
    [SerializeField] private float _interactionDistance;
    public virtual float StopingDIstance
    {
        get { return _interactionDistance * 0.7f; }
    }
    public void OnFocus(PlayerCreature player) 
    {
        _isFocus = true;
        _player = player;
        
    }

    public void OnUnfocus() 
    {
        _isFocus = false;
        _hasInterected = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_isFocus && _player != null)
        {
            if (Vector3.Distance(transform.position, _player.transform.position) < _interactionDistance && !_hasInterected)
            {
                Interect();
            }
        }
    }

    private void Interect()
    {
        _hasInterected = true;
        Debug.Log("Interacted " + gameObject);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _interactionDistance / 2);
    }
}
