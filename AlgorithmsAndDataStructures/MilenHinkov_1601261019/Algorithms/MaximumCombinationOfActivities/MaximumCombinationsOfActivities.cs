using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsAndDataStructures.Algorithms.MaximumCombinationOfActivities
{
    public class MaximumCombinationsOfActivities
    {
        private List<Lecture> OrderedByStartHourLectures { get; set; }

        private List<Lecture> EveryPossibleGraph { get; set; }

        private double TotalHours { get; set; }

        private List<Lecture> ResultMaxLecturePath { get; set; }

        public List<Lecture> BruteForceSolution(List<Lecture> lectures)
        {
            if (lectures.Count == 0)
            {
                return new List<Lecture>();
            }
            this.OrderedByStartHourLectures = lectures.OrderBy(l => l.StartHour).ToList();
            this.EveryPossibleGraph = new List<Lecture>();

            var count = this.OrderedByStartHourLectures.Count;
            for (int i = 0; i < count; i++)
            {
                this.EveryPossibleGraph.Add(this.OrderedByStartHourLectures[i]);
            }

            for (int i = 0; i < count; i++)
            {
                var lectureForDistribution = OrderedByStartHourLectures[i];
                for (int j = 0; j < count; j++)
                {
                    if (lectureForDistribution.IsMathLecture != this.EveryPossibleGraph[j].IsMathLecture
                        && this.EveryPossibleGraph[j].EndHour <= lectureForDistribution.StartHour)
                    {
                        this.EveryPossibleGraph[j].Neighbors.Add(lectureForDistribution);
                    }
                }
            }

            this.ResultMaxLecturePath = new List<Lecture>();

            foreach (var lecture in this.EveryPossibleGraph)
            {
                this.DFSWithRecursion(lecture);
            }

            this.ResultMaxLecturePath.Reverse();
            return this.ResultMaxLecturePath;
        }

        public void DFSWithRecursion(Lecture vertex)
        {
            var visited = new HashSet<Lecture>();
            var newMax = this.Traverse(vertex, visited, "  ", vertex.Weight);
        }

        private bool Traverse(Lecture v, HashSet<Lecture> visited, string offset, double weight)
        {
            var newMax = false;
            if (weight > this.TotalHours)
            {
                this.TotalHours = weight;
                this.ResultMaxLecturePath = new List<Lecture>();
                this.ResultMaxLecturePath.Add(v);
                newMax = true;
            }
            visited.Add(v);
            foreach (var neighbour in v.Neighbors)
            {
                newMax = this.Traverse(neighbour, visited, offset + "  ", neighbour.Weight + weight);
                if (newMax)
                {
                    this.ResultMaxLecturePath.Add(v);
                }
                return newMax;
            }

            return newMax;
        }
    }
}
