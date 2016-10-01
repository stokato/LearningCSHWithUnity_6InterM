using UnityEngine;
using System.Collections;
using NSZombie;

public class Monsters : MonoBehaviour {

    public MonsterInfo monsterInfo = new MonsterInfo();

	// Use this for initialization
	void Start () {
        MonsterInfo m = monsterInfo;

        Debug.Log(m.health);
        Debug.Log(m.armor);
        Debug.Log(m.attack);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TakeDamage(int damage)
    {
        monsterInfo.health -= damage;
    }
}
