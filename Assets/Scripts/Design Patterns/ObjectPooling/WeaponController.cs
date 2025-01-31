using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    private const int POOL_SIZE = 10;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePointTransform;
    private float bulletSpeed = 3f;

    private Queue<GameObject> bulletPool;
    private void Start()
    {
        bulletPool = new Queue<GameObject>();

        for (int i =0; i < POOL_SIZE; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab, Vector3.zero, Quaternion.identity);
            bullet.SetActive(false);
            bulletPool.Enqueue(bullet);
        }
    }

    private GameObject GetBulletFromPool()
    {
       if (bulletPool.Count > 0)
        {
            GameObject bullet = bulletPool.Dequeue();
            bullet.SetActive(true);
            return bullet;
        }
       return null;
    }

    private void ReturnBulletToPool(GameObject bullet)
    {
        bullet.SetActive(false);
        bulletPool.Enqueue(bullet);
    }

    private IEnumerator DisableBulletAfterDelay(GameObject bullet, float delay)
    {
        yield return new WaitForSeconds(delay);
        ReturnBulletToPool(bullet);
    }
    private void Update()
    {
        HandleShooting();
    }
    private void HandleShooting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector3 shootDirection = (mouseWorldPosition - transform.position).normalized;
            GameObject bullet = GetBulletFromPool();
            if (bullet != null)
            {
                bullet.transform.position = firePointTransform.position;
                bullet.SetActive(true);

                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.velocity = shootDirection * bulletSpeed;

                StartCoroutine(DisableBulletAfterDelay(bullet, 2f));
            }
        }
    }
}
