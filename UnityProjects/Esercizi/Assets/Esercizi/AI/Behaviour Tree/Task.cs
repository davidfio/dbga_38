using System.Collections.Generic;

namespace AI.BehaviourTree
{
    public abstract class Task
    {
        public List<Task> children = new List<Task>();
        public Blackboard blackboard;

        public abstract bool Run();

    }
}