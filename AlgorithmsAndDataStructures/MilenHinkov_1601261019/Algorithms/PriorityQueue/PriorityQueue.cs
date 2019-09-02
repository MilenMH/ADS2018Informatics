using System;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Algorithms.PriorityQueue
{
    public class PriorityQueue<T>
    {
        private Dictionary<string, LinkedList<T>> MainTrunk;

        private LinkedList<string> GroupsInTheCorrectOrder;

        public PriorityQueue()
        {
            this.MainTrunk = new Dictionary<string, LinkedList<T>>();
            this.GroupsInTheCorrectOrder = new LinkedList<string>();
        }

        public void Add(string group, T element)
        {
            if (!this.MainTrunk.ContainsKey(group))
            {
                this.MainTrunk.Add(group, new LinkedList<T>());
                this.GroupsInTheCorrectOrder.AddLast(group);
            }
            MainTrunk[group].AddLast(new LinkedListNode<T>(element));

        }

        public T Poll()
        {
            if (GroupsInTheCorrectOrder.Count == 0)
            {
                return default(T);
            }
            var firstGroup = this.GroupsInTheCorrectOrder.First.Value;
            var listOfElements = this.MainTrunk[firstGroup];
            if (listOfElements.Count == 0)
            {
                this.GroupsInTheCorrectOrder.RemoveFirst();
                this.MainTrunk.Remove(firstGroup);
                return Poll();
            }
            var returnElement = listOfElements.First.Value;
            this.MainTrunk[firstGroup].RemoveFirst();
            return returnElement;
        }
    }
}
