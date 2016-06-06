using UnityEngine;
using System.Collections;

public class player : living
{
    [SerializeField]
    private GameObject bullet;
    private gun1 gun1;
    private gun2 gun2;
    private gun3 gun3;
    private gun4 gun4;

    private Iweapon equip;

    [SerializeField]
    private Transform hpBar;

    private float maxHp;
    private Vector3 targetPoint;
    [SerializeField]
    private float _maxSpeed;
    [SerializeField]
    private float _speed;
    private Rigidbody _rb;
    // Use this for initialization
    void Start()
    {
        gun1 = GetComponent<gun1>();
        gun2 = GetComponent<gun2>();
        gun3 = GetComponent<gun3>();
        gun4 = GetComponent<gun4>();
        maxHp = health;
        _rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update ()
    {
        float newXHp = (health / maxHp);
        hpBar.localScale = new Vector3(newXHp, 1, 1);
        //print(targetPoint);
        keyboardInput();
        //transform.LookAt(Camera.main.ScreenPointToRay(Input.mousePosition));
        if (Input.GetMouseButtonDown(0))
        {
            int randomShoot = Mathf.RoundToInt(Random.Range(1, 4));
            switch(randomShoot)
            {
                case 1:
                    equip = gun1;
                    break;
                case 2:
                    equip = gun2;
                    break;
                case 3:
                    equip = gun3;
                    break;
                case 4:
                    equip = gun4;
                    break;
                default:
                    print("ERROR");
                    break;
            }
            equip.shoot(targetPoint);
            
            
        }

    }
    protected override void death()
    {
        base.death();
        float newXHp = (health / maxHp);
        hpBar.localScale = new Vector3(newXHp, 1, 1);
    }
    void keyboardInput()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Move(new Vector3(1, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Move(new Vector3(-1, 0, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Move(new Vector3(0, 0, 1)); ;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Move(new Vector3(0, 0, -1)); ;
        }
    }
    public void Move(Vector3 vectorValue)
    {
        if (_rb.velocity.magnitude > _maxSpeed)
        {
            _rb.velocity = _rb.velocity.normalized * _maxSpeed;
            _speed = _maxSpeed;
        }

        _rb.velocity = vectorValue * _speed;
    }
    // speed is the rate at which the object will rotate
    public float speed;

    void FixedUpdate()
    {
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        float hitdist = 0.0f;
        if (playerPlane.Raycast(ray, out hitdist))
        {
            targetPoint = ray.GetPoint(hitdist);
            
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
        }
    }
}
