using UnityEngine;
using System.Collections;

namespace AI.BehaviourTree
{
    // Bot controllato da un Decision Tree
    public class AIBot_BehaviourTree : MonoBehaviour
    {

        public int currentAmmo = 0;

        private Task rootTask;

        public float tickPeriod = 0.5f;

        public void Awake()
        {
            // Setup the behaviour

            Blackboard blackboard = GetComponent<Blackboard>();

            // Create the nodes 

            var selTask = new SelectorTask();
            selTask.blackboard = blackboard;

            var seqTask1 = new SequenceTask();
            seqTask1.blackboard = blackboard;

            var seqTask2 = new SequenceTask();
            seqTask2.blackboard = blackboard;

            var seqTask3 = new SequenceTask();
            seqTask3.blackboard = blackboard;

            var notTask = new NotTask();
            notTask.blackboard = blackboard;

            var hasAmmo = new HasAmmoTask();
            hasAmmo.blackboard = blackboard;

            var moveToAmmoTask = new MoveToAmmoTask();
            moveToAmmoTask.blackboard = blackboard;

            var shootTask = new ShootTask();
            shootTask.blackboard = blackboard;

            var playSFX = new PlaySfxTask();
            playSFX.blackboard = blackboard;
            playSFX.source = this.GetComponent<AudioSource>();

            var moveToPlayerTask = new MoveToPlayerTask();
            moveToPlayerTask.blackboard = blackboard;

            var pcTask = new PlayerIsCloseTask();
            pcTask.blackboard = blackboard;

            var standTask = new StayStillTask();
            standTask.blackboard = blackboard;

            var waitTask = new WaitTask();
            waitTask.blackboard = blackboard;

            var forTask = new ForTask();
            forTask.blackboard = blackboard;
            forTask.nRepeat = 5;

            rootTask = selTask;
            selTask.children.Add(seqTask1);
            selTask.children.Add(seqTask2);
            selTask.children.Add(seqTask3);

            seqTask1.children.Add(notTask);
            seqTask1.children.Add(moveToAmmoTask);

            notTask.children.Add(hasAmmo);

            seqTask2.children.Add(pcTask);
            seqTask2.children.Add(standTask);
            seqTask2.children.Add(forTask);
            seqTask2.children.Add(playSFX);

            forTask.children.Add(seqTask3);

            seqTask3.children.Add(shootTask);
            seqTask3.children.Add(waitTask);
            waitTask.period = 5;

            selTask.children.Add(moveToPlayerTask);


        }

        public void Start()
        {
            StartCoroutine(TickeAICO());
        }

        public IEnumerator TickeAICO()
        {
            while (true)
            {
                rootTask.Run();
                yield return null;
            }
        }


        public void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Ammo>())
            {
                Destroy(other.gameObject);
                this.currentAmmo += 10;
            }
        }

        public void Shoot()
        {
            if (this.currentAmmo > 0)
            {
                this.currentAmmo -= 1;
                Debug.Log("Shooting");
            }
        }
    }
}
