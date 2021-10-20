using System;
namespace Italbytz.Infrastructure.Exam.OperatingSystems.PageReplacement
{
    public class Fifo : BackwardDistanceStrategy
    {
        public Fifo(int[] requests, int memorySize) : base(requests, memorySize)
        {
        }
    }
}
