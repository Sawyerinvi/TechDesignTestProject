using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnimationController : MonoBehaviour
{
    [SerializeField] private string _animationName;
    private Animator _animator;
    private AudioSource _audioSource;
    

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        PlayAnimation();
    }
    private void PlayAnimation()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (GetComponent<Collider2D>().OverlapPoint(mousePosition))
            {
                _animator.Play(_animationName);
                _audioSource.Play();
            }
        }
    }
}
