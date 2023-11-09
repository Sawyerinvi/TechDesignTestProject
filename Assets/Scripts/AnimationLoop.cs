using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationLoop : MonoBehaviour
{
    [SerializeField] private AnimationNames _animationNames;
    private string[] _names = { "Idle", "Walk", "Attack", "Hurt", "Die" };
    private Animator _animator;
    
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _animator.Play(_names[(int)_animationNames]);
    }
}
public enum AnimationNames
{
    Idle = 0,
    Walk = 1,
    Attack = 2,
    Hurt = 3,
    Die = 4

}
