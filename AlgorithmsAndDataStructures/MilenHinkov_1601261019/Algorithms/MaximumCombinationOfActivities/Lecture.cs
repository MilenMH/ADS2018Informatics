using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms.MaximumCombinationOfActivities
{

    /// <summary>
    /// Lecture class is representation of vertex 
    /// </summary>
    public class Lecture : IEquatable<Lecture>
    {
        public Lecture(DateTime startHour, DateTime endHour, bool isMathLecture)
        {
            this.StartHour = startHour;
            this.EndHour = endHour;
            this.Weight = (EndHour - StartHour).TotalHours;
            this.IsMathLecture = isMathLecture;
            this.Neighbors = new List<Lecture>();
        }

        public DateTime StartHour { get; set; }

        public DateTime EndHour { get; set; }

        public double Weight { get; set; }

        public bool IsMathLecture { get; set; }

        public List<Lecture> Neighbors { get; set; }

        public bool Equals(Lecture other)
        {
            return this.StartHour == other.StartHour 
                && this.EndHour == other.EndHour 
                && this.Weight == other.Weight 
                && this.IsMathLecture == other.IsMathLecture;
        }

        public override string ToString()
        {
            return "Start Hour : " + this.StartHour.Hour + ", End Hour : " + this.EndHour.Hour + 
                ", Current Time : " + this.Weight + " Subject : " + (IsMathLecture ? " Math " : "Informatics");
        }
    }
}
