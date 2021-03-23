using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody),typeof(Collider),typeof(Animator))]
[RequireComponent(typeof(NavMeshAgent))]
public abstract class LivingCreature : MonoBehaviour
{
    public Rigidbody CreatureRB { get; private set; }
    public Collider CreatureCollider { get; private set; }
    public NavMeshAgent CreatureNMA { get; private set; }
    public Animator CreatureAnimator { get; private set; }

    [SerializeField] private LivingCreatureActionController  _actionController;

    public LivingCreatureActionController ActionController { get; protected set; }

    public ServiceManager ServiceManager { get; private set; }

    protected virtual void Start()
    {
        CreatureRB = GetComponent<Rigidbody>();
        CreatureCollider = GetComponent<Collider>();
        CreatureNMA = GetComponent<NavMeshAgent>();
        CreatureAnimator = GetComponent<Animator>();
        ServiceManager = ServiceManager.Instance;
    }

    void Update()
    {
        
    }
}
