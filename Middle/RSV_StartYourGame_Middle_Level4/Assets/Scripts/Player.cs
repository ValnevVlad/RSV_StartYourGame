using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour {

    static private string attackTriggerName = "Attack";
    static private string isMovingBoleanName = "isMoving";

    static private string axisHorizontal = "Horizontal";

    static private LayerMask mobMask {
        get {
            return LayerMask.GetMask("Mobs");
        }
    }

    static private float minHorizontalSpeed = 0.1f;
    static private float minActionCooldown = 1.2f;

    [SerializeField] private float actionCooldown = 1.2f;
    [SerializeField] private Transform aimTransform;
    [SerializeField] private float jumpPower = 350f;
    [SerializeField] private float speed = 2f;


    private Collider2D selfCollider;
    private Rigidbody2D selfRigidbody;
    private Transform selfTransform;

    private Animator selfAnimator;
    private float timeToAction = 0f;
    private List<Collider2D> groundColliders = new List<Collider2D>();


    private void Awake() {
        selfAnimator = GetComponent<Animator>();
        selfRigidbody = GetComponent<Rigidbody2D>();
        selfCollider = GetComponent<Collider2D>();
        selfTransform = GetComponent<Transform>();
    }

    [Serializable] private class Staff {
        [SerializeField] private float physicalDamage = 200;
        [SerializeField] private float fireDamage = 715;
        private const float voidDamage = 0.015f;

        public void Use(IDamagable aim) {
            if (aim != null) {
                aim.ApplyDamage(physicalDamage, fireDamage, voidDamage);
            }
        }
    }

    [SerializeField] private Staff weapon;

    private bool isOnGround {
        get {
            return groundColliders.Count > 0;
        }
    }

    private void OnCollisionStay2D(Collision2D coll) {
        if (!groundColliders.Contains(coll.collider)) {
            foreach (var p in coll.contacts) {
                if (p.point.y < selfCollider.bounds.min.y) {
                    groundColliders.Add(coll.collider);
                    break;
                }
            }
                
        } 
    }

    void OnCollisionExit2D(Collision2D coll) {
        if (groundColliders.Contains(coll.collider)) {
            groundColliders.Remove(coll.collider);
        }
    }



    private void Attack() {
        selfAnimator.SetTrigger(attackTriggerName);
        weapon.Use(Physics2D.BoxCast(new Vector2(aimTransform.position.x, aimTransform.position.y), new Vector2(3, 2), 0, Vector3.zero, Mathf.Infinity, mobMask).collider?.gameObject?.GetComponent<IDamagable>());
        timeToAction = Mathf.Max(minActionCooldown, actionCooldown);
    }

    private void Jump() {
        //напиши код дл€ прыжка
    }

    private void Move(float horizontalSpeed) {
        //напиши код дл€ горизонтального перемещени€ главного геро€ (влево/вправо)
    }

    private void Update() {
        // дл€ настройки анимации используй параметры анимации типа boolean дл€ движени€ и типа trigger дл€ атаки в методе Attack
        if (timeToAction <= 0) {
            // Ќапиши код дл€ обработки клавиш отвечающих за перемещение влево/вправо, прыжок (клавиша W) и атаку (клавиша Space)
            // Ќе забудь добавить код управл€ющий анимаци€ми
        }  

        timeToAction -= Time.deltaTime;
    }

}
