namespace PracticalLinq
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Builder
    {
        public IEnumerable<int> BuildIntegerSequence()
        {
            var integers = Enumerable.Range(0, 10);
            return integers;
        }

        public IEnumerable<int> CompareSequences()
        {
            var seq1 = Enumerable.Range(0, 10);
            var seq2 = Enumerable.Range(0, 10).Select(i => i * i);

            return seq1.Intersect(seq2);
        }
    }
}
